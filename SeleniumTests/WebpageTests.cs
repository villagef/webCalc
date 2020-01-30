using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace SeleniumTests
{

    public class Tests
    {
        private string urlAddress = "http://localhost:49584";

        private ChromeDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Url = urlAddress;
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }

        [Test]
        public void TestMetricsDistanceSimple()
        {
            var webpage = new CalcWebpageModel(driver);
            var metricsWebpage = webpage.GoToMetricsWebpage();
            metricsWebpage.KmField = 4.ToString();
            metricsWebpage.ClickDistanceSubmit();

            Assert.AreEqual(2.48.ToString(), metricsWebpage.MilesField);
        }

        [Test]
        public void TestMathCalculatorSimpleAddition()
        {
            var webpage = new CalcWebpageModel(driver);
            webpage.InsertFirstNumber(4.ToString());
            webpage.InsertSecondNumber(4.ToString());
            webpage.SelectOperationByText("Addition");
            webpage.Submit();
            
            Assert.AreEqual(webpage.GetResult(), 8.ToString());
        }

        [Test]
        public void TestMathCalculatorSafetyOfForms()
        {
            var webpage = new CalcWebpageModel(driver);
            webpage.InsertFirstNumber("im string");

            webpage.InsertSecondNumber("i am string too");


            Assert.AreEqual(webpage.FirstNumberField, string.Empty);

            Assert.AreEqual(webpage.SecondNumberField, string.Empty);
        }
    }
}