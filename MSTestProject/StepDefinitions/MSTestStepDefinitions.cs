using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace MSTestProject.StepDefinitions
{
    [Binding]
    public class MSTestStepDefinitions
    {
        IWebDriver driver = new ChromeDriver();

        [Given(@"Complete the flow in MS Test")]
        public void GivenCompleteTheFlowInMSTest()
        {
            Random random = new Random();
            int randomNumber = random.Next(10, 100); 



            string mail = randomNumber + "test@mailsac.com";

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Navigate().GoToUrl("https://demowebshop.tricentis.com/");
            driver.FindElement(By.XPath("//*[text()='Register']")).Click();
            driver.FindElement(By.XPath("//*[@value='M']")).Click();
            driver.FindElement(By.XPath("//*[@id=\"FirstName\"]")).SendKeys("Gaurav");
            driver.FindElement(By.XPath("//*[@id=\"LastName\"]")).SendKeys("Singh");
            driver.FindElement(By.XPath("//*[@id=\"Email\"]")).SendKeys(mail);
            driver.FindElement(By.XPath("//*[@id=\"Password\"]")).SendKeys("Qwerty!@#123");
            driver.FindElement(By.XPath("//*[@id=\"ConfirmPassword\"]")).SendKeys("Qwerty!@#123");
            driver.FindElement(By.XPath("//*[@id='register-button']")).Click();
            driver.FindElement(By.XPath("//input[@value=\"Continue\"]")).Click();
            driver.FindElement(By.XPath("//*[text()='Log out']")).Click();
            driver.FindElement(By.XPath("//*[text()='Log in']")).Click();

            driver.FindElement(By.XPath("//*[@id=\"Email\"]")).SendKeys(mail);
            driver.FindElement(By.XPath("//*[@id=\"Password\"]")).SendKeys("Qwerty!@#123");
            driver.FindElement(By.XPath("//input[@value=\"Log in\"]")).Click();

            driver.Quit();
        }
    }
}
