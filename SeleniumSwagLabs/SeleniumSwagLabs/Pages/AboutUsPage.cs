using OpenQA.Selenium;

namespace SeleniumSwagLabs
{
	public class AboutUsPage : UtilityClass
	{
		private IWebDriver driver;
		private By Resources      = By.XPath("//*[@id='headerMainNav']/div/nav/ul/li[1]/ul[2]/li[4]/div[1]/div");
		private By Pricing        = By.XPath("//*[@id='headerMainNav']/div/nav/ul/li[1]/ul[2]/li[3]/div/div");
		private By Solutions      = By.XPath("//*[@id='headerMainNav']/div/nav/ul/li[1]/ul[2]/li[1]/div[1]/div/a");
		private By Platform       = By.XPath("//*[@id='headerMainNav']/div/nav/ul/li[1]/ul[2]/li[2]/div[1]/div/a");
		private By Company        = By.XPath("//*[@id='headerMainNav']/div/nav/ul/li[1]/ul[2]/li[5]/div[1]/div/a");
		private By Security       = By.XPath("//*[@id='headerMainNav']/div/nav/ul/li[1]/ul[2]/li[5]/div[2]/div/div/div/ul/li/div/ul/li/div/ul/li[6]/div/ul/li/a/span");
		private By News           = By.XPath("//*[@id='headerMainNav']/div/nav/ul/li[1]/ul[2]/li[5]/div[2]/div/div/div/ul/li/div/ul/li/div/ul/li[7]/div/ul/li/a/span");
		

		public AboutUsPage(IWebDriver driver)
		{
			this.driver = driver;
		}
		public void ResourcesLink()
		{
			driver.FindElement(Resources).Click();
		}
		public void PricingLink()
		{
			driver.FindElement(Pricing).Click();
		}
		public void SolutionsLink()
		{
			driver.FindElement(Solutions).Click();
		}
		public void PlatformLink()
		{
			driver.FindElement(Platform).Click();
		}
		public void CompanyLink()
		{
			driver.FindElement(Company).Click();
		}

		public void SecurityLink()
		{
			driver.FindElement(Security).Click();
		}

		public void NewsLink()
		{
			driver.FindElement(News).Click();
		}

	}
}
