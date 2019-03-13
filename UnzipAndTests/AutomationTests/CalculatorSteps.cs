using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using Shouldly;
using System.Reflection;

namespace AutomationTests
{
    [Binding]
    public class CalculatorSteps
    {
        private readonly IWebDriver _driver;
        public CalculatorSteps()
        {
            _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            _driver.Url = "C:/Project/Session/Session/HTML/Index.html";
        }

        [Given(@"(.*) is first number")]
        public void GivenIsFirstNumber(string x)
        {
            _driver.FindElement(By.Id("Num1")).SendKeys(x);
        }
        
        [Given(@"(.*) is second number")]
        public void GivenIsSecondNumber(string y)
        {
            _driver.FindElement(By.Id("Num2")).SendKeys(y);
        }
        
        [When(@"asked for addition")]
        public void WhenAskedForAddition()
        {
            _driver.FindElement(By.Id("bAdd")).Click();
        }
        
        [Then(@"result should be (.*)")]
        public void ThenResultShouldBe(string expected)
        {
            _driver.FindElement(By.Id("lResult")).Text.ShouldBe(expected);
        }
    }
}
