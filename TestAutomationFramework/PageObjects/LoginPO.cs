using OpenQA.Selenium;

namespace TestAutomationFramework.Pages
{
    public class LoginPO : DriverHelper
    {
        IWebElement btnLogin => Driver.FindElement(By.XPath("//input[contains(@class, 'btn')]"));

        IWebElement txtPassword => Driver.FindElement(By.Name("Password"));

        IWebElement txtUserName => Driver.FindElement(By.Name("UserName"));

        public void EnterUserNameAndPassword(string userName, string password)
        {
            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(password);
        }

        public void ClickLogin()
        {
            btnLogin.Click();
        }
    }
}
