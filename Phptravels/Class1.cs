using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Support.PageObjects;

public class Class1
{
    IWebDriver driver = new ChromeDriver();
    string url = "https://www.phptravels.net/";

  
    //selectors
    public By tabHotels = By.XPath("//a[@href='#hotels']");
    public By tabFlights = By.XPath("//a[@href='#flights']");
    public By tabTours = By.XPath("//a[@href='#tours']");
    public By tabCars = By.XPath("//a[@href='#cars']");
    public By wholePage = By.XPath("//*[@class='select2-drop-mask']");
    public By searchHotel = By.XPath("//*[text()='Search by Hotel or City Name']");


    [SetUp]
    public void SetUp()
    {
        driver.Navigate().GoToUrl(url);
        driver.Manage().Window.Maximize();
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
        driver.FindElement(tabHotels).Click();
        driver.FindElement(searchHotel).Click();
        driver.FindElement(wholePage).Click();
        driver.FindElement(tabFlights).Click();
        driver.FindElement(tabTours).Click();
        driver.FindElement(tabCars).Click();
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