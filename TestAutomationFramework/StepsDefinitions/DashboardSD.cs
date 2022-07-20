using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TestAutomationFramework.PageObjects;

namespace TestAutomationFramework.StepsDefinitions
{
    [Binding]
    public class DashboardSD
    {
        readonly DashboardPO homePO = new DashboardPO();

        [Then(@"I should see user logged in the application")]
        public void ThenIShouldSeeUserLoggedInTheApplication()
        {
            Assert.That(homePO.IsLogOffExist(), Is.True, "Log off button did not displayed");
        }

    }
}
