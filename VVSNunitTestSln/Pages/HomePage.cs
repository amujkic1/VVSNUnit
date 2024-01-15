using OpenQA.Selenium;

public class HomePage
{
	private IWebDriver driver;

	// Constructor
	public HomePage(IWebDriver driver)
	{
		this.driver = driver;
	}

	// Page URL
	private string HomePageUrl = "https://www.buybook.ba/";

	// Web Elements
	private By authorsLink = By.LinkText("Autori");
	private By upripremiLink = By.LinkText("U pripremi");

	// Page Methods
	public void NavigateToHomePage()
	{
		driver.Navigate().GoToUrl(HomePageUrl);
	}

	public void ClickAuthorsLink()
	{
		driver.FindElement(authorsLink).Click();
	}

	public void ClickAuthorAtIndex(int index)
	{
		// Click on the nth author using the specified index
		By authorSelector = By.CssSelector($".authorNames:nth-child({index}) .m-0");
		driver.FindElement(authorSelector).Click();
	}

	public void ClickUPripremiLink()
	{
		driver.FindElement(upripremiLink).Click();
	}
}
