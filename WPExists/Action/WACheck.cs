using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WPExists.Algo;

namespace WPExists.Action
{
    public class WACheck
    {
        private readonly List<string> proxyList = SettingConfig.ProxyIPCollection;
        private List<string> mobileNumberList;
        public readonly WPExists wPExists;

        public CancellationTokenSource tokenSource = new CancellationTokenSource();

        public WACheck(WPExists wPExists)
        {
            this.wPExists = wPExists;
        }
        public async void StartCheck()
        {
            try
            {
                mobileNumberList = wPExists.InputList;

                int numberCount = mobileNumberList.Count;
                int batchSize = SettingConfig.REQUEST_BATCH_SIZE;
                int slotCount = (int)Math.Ceiling(numberCount / (double)batchSize);

                int currentProxy = 0;
                for (int x = 0; x < slotCount; x++)
                {
                    int startIndex = x * batchSize;
                    int count = slotCount == 1 ? numberCount : ((slotCount - x) == 1 ? numberCount % batchSize == 0 ? batchSize : numberCount % batchSize : (numberCount < batchSize ? numberCount : batchSize));

                    List<string> current = mobileNumberList.GetRange(startIndex, count);


                    if (SettingConfig.OPERATION_ASYNC)
                    {
                        await Async.HttpClintProxyAsync(current, wPExists);
                    }
                    else if(SettingConfig.OPERATION_TASK)
                    {
                        await Algo.Task.DoTaskQuery(current, wPExists, tokenSource);
                    }
                    else if(SettingConfig.OPERATION_HASHSET)
                    {
                        await Algo.HashSet.DoHashSetQuery(current, wPExists, tokenSource);
                    }
                    else if(SettingConfig.OPERATION_CHROMEDRIVER)
                    {
                        await Algo.WebDrive.StartQuery(current, wPExists);
                    }
                    else if (SettingConfig.OPERATION_WEBSOCKET)
                    {
                        await Algo.WebSocket.StartQuery(current, wPExists);
                    }
                    currentProxy++;
                }

                wPExists.ProcessCompleted = true;
            }
            catch (Exception ex)
            {
                wPExists.SetError = ex.Message + Environment.NewLine + ex.InnerException;
            }
        }
    }
}
