using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using VVSDrugiDioProjekta.Source.Pages;

[TestFixture]
public class SortiranjeKnjigaUPripremiTest
{
	private IWebDriver driver;
	private HomePage homePage;
	private UPripremiPage upripremiPage;

	[SetUp]
	public void SetUp()
	{
		driver = new ChromeDriver();
		//driver = WebDriverSingleton.GetInstance();
		homePage = new HomePage(driver);
		upripremiPage = new UPripremiPage(driver);
	}

	[TearDown]
	protected void TearDown()
	{
		driver.Quit();
	}

	[Test]
	public void sortiranjeKnjigaUPripremi()
	{
		homePage.NavigateToHomePage();
		homePage.ClickUPripremiLink();

		upripremiPage.ClickSortByNazivAZ();
		upripremiPage.ClickSortByNazivZA();
		upripremiPage.ClickSortByGodinaIzdanjaNovije();
		upripremiPage.ClickSortByGodinaIzdanjaStarije();
		upripremiPage.ClickSortByCijenaNajniza();
		upripremiPage.ClickSortByCijenaNajvisa();
	}
}
