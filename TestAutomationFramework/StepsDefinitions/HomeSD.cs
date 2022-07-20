using NUnit.Framework;
using TechTalk.SpecFlow;
using TestAutomationFramework.Hooks;
using TestAutomationFramework.Pages;

namespace TestAutomationFramework.Steps
{
    [Binding]
    public class HomeSD
    {
        readonly HomePO homePO = new HomePO();

        [Given(@"I navigate to application")]
        public void GivenINavigateToApplication()
        {
            homePO.NavigateToHome();
        }

        [Given(@"I click login link")]
        public void GivenIClickLogin()
        {
            homePO.ClickLoginLink();
        }
    }
}
