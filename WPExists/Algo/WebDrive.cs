using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WPExists.Action;

namespace WPExists.Algo
{
    public class WebDrive
    {
        public static ChromeDriverService service = ChromeDriverService.CreateDefaultService(
            System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\WebDriver\");

        public static async System.Threading.Tasks.Task StartQuery(List<string> numbers, WPExists wPExists)
        {
            try
            {
                wPExists.CurrentProxyIP = "PROXY DISABLED";
                if (numbers != null && numbers.Count > 0)
                {
                    var tasks = System.Threading.Tasks.Task.Factory.StartNew(arg => DoQuery(numbers, wPExists),
                            TaskContinuationOptions.LongRunning | TaskContinuationOptions.RunContinuationsAsynchronously);
                    System.Threading.Tasks.Task.WaitAll(tasks);
                }

                wPExists.ProcessCompleted = true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        public static void DoQuery(List<string> _nums, WPExists wPExists)
        {
            List<WAResponse> wAResponses = new List<WAResponse>();

            ChromeOptions options = new ChromeOptions();
            //options.AddArgument("headless");
            //options.AddArgument("--silent");
            options.AddArgument("disable-popup-blocking");
            service.HideCommandPromptWindow = true;
            IWebDriver driver = new ChromeDriver(service, options);

            driver.Navigate().GoToUrl("about:blank");

            foreach (string line in _nums)
            {
                driver.FindElement(By.CssSelector("Body")).SendKeys(System.Windows.Forms.Keys.Control + "t");
                driver.SwitchTo().Window(driver.WindowHandles.Last());
                string url = SettingConfig.API_BASE_URL + line;
                driver.Navigate().GoToUrl(url);
                string result = driver.PageSource.Replace("<html><head></head><body><pre style=\"word-wrap: break-word; white-space: pre-wrap;\">", "").Replace("</pre></body></html>", "");
                wPExists.WAResponse = new WAResponse() { Number = line, Exists = result };
            }
            driver.Close();
        }
    }
}
