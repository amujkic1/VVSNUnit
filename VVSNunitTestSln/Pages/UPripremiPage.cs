using OpenQA.Selenium;

public class UPripremiPage
{
	private IWebDriver driver;

	// Constructor
	public UPripremiPage(IWebDriver driver)
	{
		this.driver = driver;
	}

	// Web Elements
	private By sortDropdown = By.LinkText("Godina izdanja (Novije)");

	// Page Methods
	public void ClickSortDropdown()
	{
		driver.FindElement(sortDropdown).Click();
	}

	public void ClickSortByNazivAZ()
	{
		driver.FindElement(By.LinkText("Naziv (A-Z)")).Click();
	}

	public void ClickSortByNazivZA()
	{
		driver.FindElement(By.LinkText("Naziv (Z-A)")).Click();
	}

	public void ClickSortByGodinaIzdanjaNovije()
	{
		driver.FindElement(By.LinkText("Godina izdanja (Novije)")).Click();
	}

	public void ClickSortByGodinaIzdanjaStarije()
	{
		driver.FindElement(By.LinkText("Godina izdanja (Starije)")).Click();
	}

	public void ClickSortByCijenaNajniza()
	{
		driver.FindElement(By.LinkText("Cijena (Najniža)")).Click();
	}

	public void ClickSortByCijenaNajvisa()
	{
		driver.FindElement(By.LinkText("Cijena (Najviša)")).Click();
	}
}
