using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace TestAutomationFramework.Hooks
{
    [Binding]
    public class Base : DriverHelper
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            ChromeOptions option = new ChromeOptions();
            option.AddArguments("start-maximized");
            option.AddArguments("disable-gpu");
            DriverHelper.Driver = new ChromeDriver(option);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            DriverHelper.Driver.Quit();
        }
    }
}
