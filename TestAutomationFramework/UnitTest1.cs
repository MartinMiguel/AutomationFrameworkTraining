using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TestAutomationFramework.Pages;

namespace TestAutomationFramework
{
    public class Tests : DriverHelper
    {

        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Setup");

            Driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com");
            Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Tomato");
            //Driver.FindElement(By.XPath("//input[@name='ctl00$ContentPlaceHolder1$ChildMeal1']/following-sibling::div[text()='Celery']")).Click();

            CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Almond");
            Driver.Close();
            Console.WriteLine("Test");
            Assert.Pass();
        }

        [Test]
        public void LoginTest()
        {
            Driver.Navigate().GoToUrl("http://eaapp.somee.com/");

            HomePage homePO = new HomePage();
            LoginPage loginPO = new LoginPage();

            homePO.ClickLogin();
            loginPO.EnterUserNameAndPassword("admin", "password");
            loginPO.ClickLogin();
            Assert.That(homePO.IsLogOffExist(), Is.True, "Log off button did not displayed");
        }
    }
}