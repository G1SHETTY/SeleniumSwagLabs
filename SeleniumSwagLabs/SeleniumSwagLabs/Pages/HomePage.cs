using OpenQA.Selenium;

namespace SeleniumSwagLabs
{
    public class HomePage : UtilityClass
    {
        private IWebDriver driver;
        private By button        =  By.Id("react-burger-menu-btn");
        private By CloseMenu     = By.XPath("//*[@id='react-burger-cross-btn']");
        private By AllItems      = By.XPath("//*[@id='inventory_sidebar_link']");
        private By AboutUs       = By.XPath("//a[@id='about_sidebar_link']");
        private By LogOut        = By.XPath("//*[@id='logout_sidebar_link']");
        private By ResetAppstate = By.XPath("//*[@id='reset_sidebar_link']");
        private By Twiiter       = By.XPath("//*[@id='page_wrapper']/footer/ul/li[1]/a");
        private By Facebook      = By.XPath("//*[@id='page_wrapper']/footer/ul/li[2]/a");
        private By LinkedIn      = By.XPath("//*[@id='page_wrapper']/footer/ul/li[3]/a");
        
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void MenuButton()
		{
            driver.FindElement(button).Click();
        }
        public void CloseMenuButton()
        {
            driver.FindElement(CloseMenu).Click();
        }
        public void AllItemsLink()
        {
            driver.FindElement(AllItems).Click();
        }
        public void TwiiterLink()
        {
            driver.FindElement(Twiiter).Click();
        }
        public void FacebookLink()
        {
            driver.FindElement(Facebook).Click();
        }
        public void LinkedInLink()
        {
            driver.FindElement(LinkedIn).Click();
        }
        public void AboutUsPage()
        {
            driver.FindElement(AboutUs).Click();
        }
        public void ResetAppStateLink()
        {
            driver.FindElement(ResetAppstate).Click();
        }
        public void LogOutLink()
        {
            driver.FindElement(LogOut).Click();
        }
    }
}
