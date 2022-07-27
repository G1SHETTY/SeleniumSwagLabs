using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SeleniumSwagLabs
{
    [Binding]
    public class AboutPageStepDefinitions : ApplicationHooks
    {
      
        [Given(@"Chrome is opened and SwagLabs app is opened")]
        public void GivenChromeIsOpenedAndSwagLabsAppIsOpened()
        {
            browserMaximize();
            Thread.Sleep(1000);
        }

        [When(@"user enter username ""([^""]*)"" and password ""([^""]*)"" and click on login")]
        public void WhenUserEnterUsernameAndPasswordAndClickOnLogin(string uname, string pwrd)
        {
            lp.UsernameField(uname);
            lp.PasswordField(pwrd);
            lp.LoginButton();
            Thread.Sleep(5000);
        }

        [When(@"user Clicks on MenuButton")]
        public void WhenUserClicksOnMenuButton()
        {
            hp.MenuButton();
            Thread.Sleep(2000);
        }

        [When(@"user clicks on About Link")]
        public void WhenUserClicksOnAboutLink()
        {
            hp.AboutUsPage();
            Thread.Sleep(3000);
        }

        [Then(@"it should display the AboutPage")]
        public void ThenItShouldDisplayTheAboutPage()
        {
            string expectedResult = "Cross Browser Testing, Selenium Testing, Mobile Testing | Sauce Labs";
            string actualResult = ValidatePageTitle();
            Assert.That(actualResult, Is.EqualTo(expectedResult));
            CaptureScreenshot();
            Console.Write(actualResult);
            Thread.Sleep(1000);
            
        }



        [Then(@"It Should Display All The Option In Alligned Manner In AboutPage")]
        public void ThenItShouldDisplayAllTheOptionInAllignedMannerInAboutPage()
        {

            browserMinimize();
            string expectedResult = "Cross Browser Testing, Selenium Testing, Mobile Testing | Sauce Labs";
            string actualResult = ValidatePageTitle();
            Assert.That(actualResult, Is.EqualTo(expectedResult));
            CaptureScreenshot();
            Console.Write(actualResult);
            Thread.Sleep(1000);
           
        }

        

        [When(@"user Clicks on company link")]
        public void WhenUserClicksOnCompanyLink()
        {
            ap.CompanyLink();
            Thread.Sleep(1000);
            
        }

        [Then(@"it should display all the options in company link")]
        public void ThenItShouldDisplayAllTheOptionsInCompanyLink()
        {
            string expectedResult = "Cross Browser Testing, Selenium Testing, Mobile Testing | Sauce Labs";
            string actualResult = ValidatePageTitle();
            Assert.That(actualResult, Is.EqualTo(expectedResult));
            CaptureScreenshot();
            Console.Write(actualResult);
            Thread.Sleep(1000);
            
        }

        [When(@"user Clicks on news link")]
        public void WhenUserClicksOnNewsLink()
        {
            ap.NewsLink();
            Thread.Sleep(1000);
        }

        [Then(@"it should be able to access")]
        public void ThenItShouldBeAbleToAccess()
        {
            string expectedResult = "News | Sauce Labs";
            string actualResult = ValidatePageTitle();
            Assert.That(actualResult, Is.EqualTo(expectedResult));
            CaptureScreenshot();
            Console.Write(actualResult);
            Thread.Sleep(1000);
           
        }

        [When(@"user clicks on security")]
        public void WhenUserClicksOnSecurity()
        {
            ap.SecurityLink();
            Thread.Sleep(1000);
        }

        [Then(@"it should be display security page")]
        public void ThenItShouldBeDisplaySecurityPage()
        {
            string expectedResult = "Security | Sauce Labs";
            string actualResult = ValidatePageTitle();
            Assert.That(actualResult, Is.EqualTo(expectedResult));
            CaptureScreenshot();
            Console.Write(actualResult);
            Thread.Sleep(1000);
           
        }

        [When(@"user Clicks on Resource link")]
        public void WhenUserClicksOnResourceLink()
        {
            ap.ResourcesLink();
            Thread.Sleep(1000);
        }

        [Then(@"it should be display all the options of resource")]
        public void ThenItShouldBeDisplayAllTheOptionsOfResource()
        {
            string expectedResult = "Cross Browser Testing, Selenium Testing, Mobile Testing | Sauce Labs";
            string actualResult = ValidatePageTitle();
            Assert.That(actualResult, Is.EqualTo(expectedResult));
            CaptureScreenshot();
            Console.Write(actualResult);
            Thread.Sleep(1000);
           
        }

        [When(@"user Clicks on platform link")]
        public void WhenUserClicksOnPlatformLink()
        {
            ap.PlatformLink();
            Thread.Sleep(1000);
        }

        [Then(@"it should be  able to access platform")]
        public void ThenItShouldBeAbleToAccessPlatform()
        {
            string expectedResult = "Cross Browser Testing, Selenium Testing, Mobile Testing | Sauce Labs";
            string actualResult = ValidatePageTitle();
            Assert.That(actualResult, Is.EqualTo(expectedResult));
            CaptureScreenshot();
            Console.Write(actualResult);
            Thread.Sleep(1000);
           
        }

        [When(@"user Clicks on solutions link")]
        public void WhenUserClicksOnSolutionsLink()
        {
            ap.SolutionsLink();
            Thread.Sleep(1000);
        }

        [Then(@"it should be  able to access solution")]
        public void ThenItShouldBeAbleToAccessSolution()
        {
            string expectedResult = "Cross Browser Testing, Selenium Testing, Mobile Testing | Sauce Labs";
            string actualResult = ValidatePageTitle();
            Assert.That(actualResult, Is.EqualTo(expectedResult));
            CaptureScreenshot();
            Console.Write(actualResult);
            Thread.Sleep(1000);
            
        }

        [When(@"user Clicks on pricing link")]
        public void WhenUserClicksOnPricingLink()
        {
           
            ap.PricingLink();
            Thread.Sleep(1000);
        }

        [Then(@"it should be  able to access pricing")]
        public void ThenItShouldBeAbleToAccessPricing()
        {
            string expectedResult = "Pricing | Sauce Labs";
            string actualResult = ValidatePageTitle();
            Assert.That(actualResult, Is.EqualTo(expectedResult));
            CaptureScreenshot();
            Console.Write(actualResult);
            Thread.Sleep(1000);
            
        }
        [When(@"user Clicks on back navigation arrow")]
        public void WhenUserClicksOnBackNavigationArrow()
        {
            browserBackNavigation();
            Thread.Sleep(1000);
        }

        [Then(@"it should display the home page")]
        public void ThenItShouldDisplayTheHomePage()
        {
            string expectedResult = "Swag Labs";
            string actualResult = ValidatePageTitle();
            Assert.That(actualResult, Is.EqualTo(expectedResult));
            CaptureScreenshot();
            Console.Write(actualResult);
            Thread.Sleep(1000);
            
        }

        [When(@"user clicks on refresh button and forward arrow")]
        public void WhenUserClicksOnRefreshButtonAndForwardArrow()
        {
            browserRefresh();
            browserForwardNavigation();
            Thread.Sleep(1000);
        }
        [Then(@"it should display the About cross testing page")]
        public void ThenItShouldDisplayTheAboutCrossTestingPage()
        {
            string expectedResult = "Cross Browser Testing, Selenium Testing, Mobile Testing | Sauce Labs";
            string actualResult = ValidatePageTitle();
            Assert.That(actualResult, Is.EqualTo(expectedResult));
            CaptureScreenshot();
            Console.Write(actualResult);
            Thread.Sleep(1000);
           
        }
    }
}
