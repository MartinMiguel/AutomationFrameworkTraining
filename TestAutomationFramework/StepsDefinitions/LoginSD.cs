using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using TestAutomationFramework.Pages;

namespace TestAutomationFramework.Steps
{
    [Binding]
    public class LoginSD
    {
        readonly LoginPO loginPO = new LoginPO();

        [When(@"I provide ""([^""]*)"" and ""([^""]*)""")]
        public void WhenIProvideAnd(string userName, string password)
        {
            loginPO.EnterUserNameAndPassword(userName, password);
        }

        [When(@"I click login button")]
        public void WhenIClickLoginButton()
        {
            loginPO.ClickLogin();
        }

    }
}
