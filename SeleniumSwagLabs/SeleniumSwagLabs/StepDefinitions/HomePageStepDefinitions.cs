using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SeleniumSwagLabs
{
    [Binding]
    public class HomePageMenuButtonStepDefinitions : ApplicationHooks
    {

        [Given(@"Chrome is open and SwagLabs app is opened")]
        public void GivenChromeIsOpenAndSwagLabsAppIsOpened()
        {
            browserMaximize();
            Thread.Sleep(1000);
        }

        [When(@"user enters username ""([^""]*)"" and password ""([^""]*)"" and click on Login")]
        public void WhenUserEntersUsernameAndPasswordAndClickOnLogin(string uname, string pwrd)
        {
            lp.UsernameField(uname);
            lp.PasswordField(pwrd);
            lp.LoginButton();
            Thread.Sleep(5000);
        }

        [When(@"User clicks on Menu button")]
        public void WhenUserClicksOnMenuButton()
        {
            hp.MenuButton();
            Thread.Sleep(5000);
        }

        [Then(@"it should display all the options in Menu")]
        public void ThenItShouldDisplayAllTheOptionsInMenu()
        {
            string expectedResult = "Swag Labs";
            string actualResult = ValidatePageTitle();
            Assert.That(actualResult, Is.EqualTo(expectedResult));
            CaptureScreenshot();
            Console.Write(actualResult);
            Thread.Sleep(1000);
        }

        [When(@"User clicks on All Items link")]
        public void WhenUserClicksOnAllItemsLink()
        {
            hp.AllItemsLink();
            Thread.Sleep(1000);
        }

        [Then(@"it should display All Items")]
        public void ThenItShouldDisplayAllItems()
        {
            string expectedResult = "Swag Labs";
            string actualResult = ValidatePageTitle();
            Assert.That(actualResult, Is.EqualTo(expectedResult));
            CaptureScreenshot();
            Console.Write(actualResult);
            Thread.Sleep(1000);
        }

        [When(@"User clicks on Logout link")]
        public void WhenUserClicksOnLogoutLink()
        {
            hp.LogOutLink();
            Thread.Sleep(1000);
        }

        [Then(@"it should be Logout from the application")]
        public void ThenItShouldBeLogoutFromTheApplication()
        {
            string expectedResult = "Swag Labs";
            string actualResult = ValidatePageTitle();
            Assert.That(actualResult, Is.EqualTo(expectedResult));
            CaptureScreenshot();
            Console.Write(actualResult);
            Thread.Sleep(1000);
        }

        [When(@"User clicks on Reset App State link")]
        public void WhenUserClicksOnResetAppStateLink()
        {

            hp.ResetAppStateLink();
            Thread.Sleep(1000);
        }

        [Then(@"it should reset the app state")]
        public void ThenItShouldResetTheAppState()
        {
            string expectedResult = "Swag Labs";
            string actualResult = ValidatePageTitle();
            Assert.That(actualResult, Is.EqualTo(expectedResult));
            CaptureScreenshot();
            Console.Write(actualResult);
            Thread.Sleep(1000);
        }

        [When(@"user clicks on Twitter link")]
        public void WhenUserClicksOnTwitterLink()
        {
            hp.LinkedInLink();
            Thread.Sleep(4000);
        }

        [Then(@"it should display the Twitter page")]
        public void ThenItShouldDisplayTheTwitterPage()
        {
            string expectedResult = "Swag Labs";
            string actualResult = ValidatePageTitle();
            Assert.That(actualResult, Is.EqualTo(expectedResult));
            CaptureScreenshot();
            Console.Write(actualResult);
            Thread.Sleep(1000);
        }
        [When(@"user clicks on Facebook link")]
        public void WhenUserClicksOnFacebookLink()
        {
            hp.FacebookLink();
            Thread.Sleep(4000);
        }

       [Then(@"it should display the Facebook page")]
       public void ThenItShouldDisplayTheFacebookPage()
        {
            string expectedResult = "Swag Labs";
            string actualResult = ValidatePageTitle();
            Assert.That(actualResult, Is.EqualTo(expectedResult));
            CaptureScreenshot();
            Console.Write(actualResult);
            Thread.Sleep(1000);
        }

       [When(@"user clicks on LinkedIn link")]
       public void WhenUserClicksOnLinkedInLink()
       {
            hp.LinkedInLink();
            Thread.Sleep(4000);
        }

      [Then(@"it should display the LinkedIn page")]
      public void ThenItShouldDisplayTheLinkedInPage()
       {
            string expectedResult = "Swag Labs";
            string actualResult = ValidatePageTitle();
            Assert.That(actualResult, Is.EqualTo(expectedResult));
            CaptureScreenshot();
            Console.Write(actualResult);
            Thread.Sleep(1000);
        }

     [When(@"clicks on Close menu button")]
     public void WhenClicksOnCloseMenuButton()
      {
            hp.CloseMenuButton();
            Thread.Sleep(1000);
    }

     [Then(@"it should close the Menu")]
     public void ThenItShouldCloseTheMenu()
     {
            string expectedResult = "Swag Labs";
            string actualResult = ValidatePageTitle();
            Assert.That(actualResult, Is.EqualTo(expectedResult));
            CaptureScreenshot();
            Console.Write(actualResult);
            Thread.Sleep(1000);
        }

     }
 }

