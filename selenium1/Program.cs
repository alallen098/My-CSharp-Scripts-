using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace selenium1
{
    class Tst
    {
        static void Main(string[] args)
        {
            TestChrome();
        }

        static void TestChrome()
        {
            IWebDriver drv = new ChromeDriver();
            drv.Navigate().GoToUrl("http://google.com");
            IWebElement query = drv.FindElement(By.Name("q"));
            query.SendKeys("abc");
            query.Submit();
            drv.Quit();


        }
    }
}
