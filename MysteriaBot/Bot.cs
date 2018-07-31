using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace MysteriaBot
{
    public class Bot
    {
        public static IWebDriver driver;
        public static System.Timers.Timer timer = new System.Timers.Timer();

        public static void StartWeb()
        {
            /* Gets all processes of chrome before driver starts */
            IEnumerable<int> pidsBefore = Process.GetProcessesByName("chrome").Select(p => p.Id);

            var timespan = TimeSpan.FromMinutes(4);
            var driverService = ChromeDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;
            using (driver = new ChromeDriver(driverService, new ChromeOptions()))
            {
                /* Gets all processes of chrome after driver starts */
                IEnumerable<int> pidsAfter = Process.GetProcessesByName("chrome").Select(p => p.Id);
                /* Checks what processes were running after and compares to pidsAfter */
                IEnumerable<int> newChromePids = pidsAfter.Except(pidsBefore);

                driver.Navigate().GoToUrl("http://www.mysteralegacy.com/play-ml/");
                Debug.WriteLine(driver.Title);
                Thread.Sleep(3600000);

                foreach (int pid in newChromePids)
                {
                    Process.GetProcessById(pid).Kill();
                }

                var web = driver.FindElement(By.Id("jv"));
                web.SendKeys("{UP}");

                Thread.Sleep(90000000);

                driver.Quit();
            }
        }   
    }
}
