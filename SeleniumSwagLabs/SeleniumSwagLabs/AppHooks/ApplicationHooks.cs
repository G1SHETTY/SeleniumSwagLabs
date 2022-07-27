using TechTalk.SpecFlow;

namespace SeleniumSwagLabs
{
    public class ApplicationHooks : UtilityClass
    {
        public HomePage hp;
        public AboutUsPage ap;
        public LoginPage lp;

         [BeforeScenario]
        public void BeforeScenario()
        {
               LaunchBrowser("CHROME");
               LaunchApp(url);


            hp = new HomePage(driver);
            ap = new AboutUsPage(driver);
            lp = new LoginPage(driver);
            Thread.Sleep(5000);

        }

        [AfterScenario]
        public void AfterScenario()
        {
            Thread.Sleep(1000);
            CloseBrowser();
        }
    }
}

