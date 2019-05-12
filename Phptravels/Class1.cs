using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

public class Class1
{
    IWebDriver driver = new ChromeDriver();
    string url = "https://www.phptravels.net/";

  
    //selectors
    public By hotelsTab = By.XPath("//a[@href='#hotels']");
    public By flightsTab = By.XPath("//a[@href='#flights']");
    public By toursTab = By.XPath("//a[@href='#tours']");
    public By carsTab = By.XPath("//a[@href='#cars']");

    public By hotelText = By.XPath("//*[text()='Search by Hotel or City Name']");
    public By hotelInput = By.CssSelector(".select2-focused");
    public By hotelLi = By.CssSelector(".select2-result > ul > li");
    

    [SetUp]
    public void SetUp()
    {
        driver.Navigate().GoToUrl(url);
        driver.Manage().Window.Maximize();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
    }


    [TearDown]
    public void TearDown()
    {
        driver.Close();
        driver.Quit();
    }


    [Test]
    public void TC1()
    {
        driver.FindElement(hotelsTab).Click();
        driver.FindElement(hotelText).Click();
        driver.FindElement(hotelInput).SendKeys("Warsaw");
        driver.FindElement(hotelLi).Click();

        driver.FindElement(flightsTab).Click();
        driver.FindElement(toursTab).Click();
        driver.FindElement(carsTab).Click();
    }
         

        // #klik opcja ONE WAY

        //klik okno IST szukania
        //wprowadzenie nazwy lotniska
        //wybor z listy jednej nazwy

        //klik okno DXB szukania
        //wprowadzenie nazwy lotniska
        //wybor z listy jednej nazwy

        //klik data departure
        //wybor z kalendarza

        //klik data return
        //powinna być niedostępna OK

        //klik iloscc pasazerow

        //klik ilosc dorosli
        //wybor z listy
        //klik ilosc dzieci
        //wybor z listy
        //klik ilosc dorosli
        //wybor z listy
        //klik ilosc niemowląt
        //wybor z listy
        //klik button done

        // klik wybor klasy
        //wybor klasy

        //klik button search

        //ładowanie się strony, czeka do momentu pojawienia sie napisu ' ALL LISTED PRICES ARE BASED ON REALTIME'



        // #klik opcja Round Trip



        //ChromeWebElement flightsSearch = driver.FindElement(By.XPath("//*[@id="select2-drop"]/div/input"));
}