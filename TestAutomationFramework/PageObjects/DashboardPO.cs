using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace TestAutomationFramework.PageObjects
{
    public class DashboardPO : DriverHelper
    {
        public bool IsLogOffExist() => LnkLogOff.Displayed;
        IWebElement LnkLogOff => Driver.FindElement(By.LinkText("Log off"));
    }
}
