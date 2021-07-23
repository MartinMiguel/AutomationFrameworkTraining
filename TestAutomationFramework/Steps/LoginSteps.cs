using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using TestAutomationFramework.Pages;

namespace TestAutomationFramework.Steps
{
    [Binding]
    public class LoginSteps : DriverHelper
    {
        HomePage homePO = new HomePage();
        LoginPage loginPO = new LoginPage();

        [Given(@"I navigate to application")]
        public void GivenINavigateToApplication()
        {
            Driver.Navigate().GoToUrl("http://eaapp.somee.com/");
        }

        [Given(@"I click the login link")]
        public void GivenIClickTheLoginLink()
        {
            homePO.ClickLogin();
        }


        [When(@"I enter username and password")]
        public void WhenIEnterUsernameAndPassword(Table table)
        {
            loginPO.EnterUserNameAndPassword("admin", "password");
        }

        [When(@"I click login")]
        public void WhenIClickLogin()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I should see user logged in the application")]
        public void ThenIShouldSeeUserLoggedInTheApplication()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
