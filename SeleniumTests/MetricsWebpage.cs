using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTests
{
    public class MetricsWebpage
    {
        private ChromeDriver driver;

        private readonly string KmSelector = "Distance_Km";

        private readonly string MilesSelector = "Distance_Miles";

        public void ClickDistanceSubmit()
        {
            driver.FindElementById("distanceSubmit").Click();
        }

        public string MilesField
        {
            get
            {
                return driver.FindElementById(MilesSelector).GetAttribute("value");
            }
            set
            {
                driver.FindElementById(MilesSelector).SendKeys(value.ToString());
            }
        }

        public string KmField
        {
            get
            {
                return driver.FindElementById(KmSelector).GetAttribute("value");
            }
            set
            {
                driver.FindElementById(KmSelector).SendKeys(value.ToString());
            }
        }
        public MetricsWebpage(ChromeDriver driver)
        {
            this.driver = driver;
            
        }

    }
}
