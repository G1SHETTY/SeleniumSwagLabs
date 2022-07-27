using OpenQA.Selenium;

namespace SeleniumSwagLabs
{
    public class LoginPage : UtilityClass
    {
        private IWebDriver driver;
        private By Username = By.Id("user-name");
        private By Password = By.Id("password");
        private By Login    = By.Id("login-button");
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void UsernameField(string uname)
        {
            driver.FindElement(Username).SendKeys(uname);
        }
        public void PasswordField(string pwrd)
        {
            driver.FindElement(Password).SendKeys(pwrd);
        }
        public void LoginButton()
        {
            driver.FindElement(Login).Click();
        }
    }
}
