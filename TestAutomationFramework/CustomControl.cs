﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestAutomationFramework
{
    public class CustomControl : DriverHelper
    {
        public static void ComboBox(string controlName, string value)
        {
            IWebElement ComboControl = Driver.FindElement(By.XPath($"//input[@id='{controlName}-awed']"));
            ComboControl.Clear();
            ComboControl.SendKeys(value);
            Driver.FindElement(By.XPath($"//div[@id='{controlName}-dropmenu']//li[text()='{value}']")).Click();
        }
    }
}