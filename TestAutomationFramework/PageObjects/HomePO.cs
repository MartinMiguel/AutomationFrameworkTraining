using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TestAutomationFramework.Hooks;

namespace TestAutomationFramework.Pages
{
    public class HomePO : DriverHelper
    {
        IWebElement LnkLogin => Driver.FindElement(By.Id("loginLink"));

        public void NavigateToHome() => Driver.Navigate().GoToUrl("http://eaapp.somee.com/");
        public void ClickLoginLink() => LnkLogin.Click();
    }
}
