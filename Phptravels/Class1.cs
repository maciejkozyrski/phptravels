using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Phptravels
{
    public class Class1
    {
        IWebDriver driver = new ChromeDriver();

        string url = "https://www.phptravels.net/";

        //public By tabHotels = By.XPath("//a[@href='#hotels']");
        //public By tabFlights = By.XPath("//a[@href='#flights']");
        //public By tabTours = By.XPath("//a[@href='#tours']");
        //public By tabCars = By.XPath("//a[@href='#cars']");

        //IWebElement searchHotels = driver.FindElement(By.Xpath("//*[text()='Search by Hotel or City Name']"));


        //public static IWebDriver GetChromeDriver()
        //{
        //    var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        //    return new ChromeDriver(outPutDirectory);
        //}


        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            //driver = GetChromeDriver();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
        }


        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }


        [Test]
        public void Test1WyszukanieOneWay()
        {
            //driver.FindElement(tabHotels).Click();
            //driver.FindElement(searchHotels).Click();
            //searchHotels.SendKeys("Warsaw");


            //driver.FindElement(tabFlights).Click();
            //driver.FindElement(tabTours).Click();
            //driver.FindElement(tabCars).Click();



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
    }
}