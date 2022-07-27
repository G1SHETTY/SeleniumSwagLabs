using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;



namespace SeleniumSwagLabs
{
    public class UtilityClass : ConfigClass
    {
        public void LaunchBrowser(string browser)
        {
            switch (browser)
            {
                case "CHROME":
                    driver = new ChromeDriver();
                    break;

                case "FIREFOX":
                    driver = new FirefoxDriver();
                    break;

                default: throw new ArgumentException("Error");
            }
        }

        public void browserMaximize()
        {
            driver.Manage().Window.Maximize();
        }
        public void browserMinimize()
        {
            driver.Manage().Window.Minimize();
        }
        public void browserBackNavigation()
        {
            driver.Navigate().Back();
        }
        public void browserRefresh()
        {
            driver.Navigate().Refresh();
        }
        public void browserForwardNavigation()
        {
            driver.Navigate().Forward();
        }

        public void PageLoad()
        {
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(PAGE_LOAD_TIMEOUT);
        }

        public void ImplicitWait()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(IMPLICIT_WAIT);
        }

        public void LaunchApp(string url)
        {
            driver.Url = url;
        }

        public void CloseBrowser()
        {
            driver.Quit();
        }

        public string ValidatePageTitle()
        {
            return driver.Title;
        }

        public void CaptureScreenshot()
        {

            ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;

            Screenshot screenshot = screenshotDriver.GetScreenshot();

            screenshot.SaveAsFile(Screenshotpath + "/screenshot.png", ScreenshotImageFormat.Png);


        }
    }
}
