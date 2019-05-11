using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phptravels
{
    public class Class1
    {
        //123
    }
}

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomatyInżynierka
{
    public class Tests
    {
        public static void Main(string[] args) { }

        IWebDriver driver = new ChromeDriver();

        string url = "https://www.phptravels.net/public/234234/";

        [SetUp]
        public void SetUp()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
            //spr czy strona się załadowała
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void Test1WyszukanieOneWay()
        {
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