using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTests
{
    public class CalcWebpageModel
    {
        private ChromeDriver driver;

        public string FirstNumberField
        {
            get
            {
                var element = driver.FindElementById("NumberA");
                return element.GetAttribute("value");
            }
            set
            {
                driver.FindElementById("NumberA").SendKeys(value.ToString());
            }
        }

        public string SecondNumberField
        {
            get
            {
                var element = driver.FindElementById("NumberB");
                return element.GetAttribute("value");
            }
            set
            {
                driver.FindElementById("NumberB").SendKeys(value.ToString());
            }
        }

        public CalcWebpageModel(ChromeDriver driver)
        {
            this.driver = driver;
        }

        public MetricsWebpage GoToMetricsWebpage()
        {
            driver.FindElementById("GoToMetrics").Click();

            return new MetricsWebpage(driver);
        }

        public void InsertFirstNumber(string number)
        {
            FirstNumberField = number;
        }

        public void InsertSecondNumber(string number)
        {
            SecondNumberField = number;
        }

        public void SelectOperationByText(string operationName)
        {
            var dropdown = driver.FindElementById("OperationType");
            var select = new SelectElement(dropdown);

            select.SelectByText(operationName);
        }

        public void Submit()
        {
            var submit = driver.FindElementById("submit");
            submit.Click();
        }

        public string GetResult()
        {
            var result = driver.FindElementById("Result");
            return result.GetAttribute("value");
        }
    }
}
