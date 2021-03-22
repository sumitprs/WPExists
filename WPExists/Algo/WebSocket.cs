using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WPExists.Action;

namespace WPExists.Algo
{
    public class WebSocket
    {
        public static async System.Threading.Tasks.Task StartQuery(List<string> numbers, WPExists wPExists)
        {
            try
            {
                HttpClient client = new HttpClient();

                var tasks = numbers.Select(async url =>
                {
                    while (true) await ReadString(client, url, wPExists);
                });
                System.Threading.Tasks.Task.WhenAll(tasks).Wait();

                wPExists.ProcessCompleted = true;
                wPExists.StopRequested = true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        private static async Task<string> ReadString(HttpClient client, string url, WPExists wPExists)
        {
            var response = await client.GetAsync(SettingConfig.API_BASE_URL + url);
            string data = await response.Content.ReadAsStringAsync();
            Thread th = new Thread(delegate ()
            {
                //Console.WriteLine($"Fetched data from url={url}. Length={data.Length}");
                wPExists.WAResponse = new WAResponse() { Number = url, Exists = data };
            })
            { IsBackground = true }; th.Start();
            return data;
        }
    }
}
