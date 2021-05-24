using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace Demo.SeleniumTests
{
    [TestClass]
    public class DotNetSiteTests
    {
        [TestMethod]
        public void TestGetStarted()
        {
            using (var driver = new ChromeDriver("."))
            {   
                const string TenDigitPhoneNumber = "9090909090";
                
                driver.Manage().Window.Maximize();

                driver.Navigate().GoToUrl("https://selfregistration.cowin.gov.in/");

                var mobileNumberInputField = driver.FindElement(By.Id("mat-input-0"));
                mobileNumberInputField.SendKeys(TenDigitPhoneNumber);

                driver.FindElement(By.CssSelector("ion-button")).Click();

                var otpInputFieldSelector = "mat-input-1";
                
                Thread.Sleep(5000);
                driver.FindElement(By.Id(otpInputFieldSelector)).Click();

                Thread.Sleep(1000000);
            }
        }
    }
}