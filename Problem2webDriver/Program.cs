using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;

namespace Problem2webDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://www.google.com";
            driver.Manage().Window.Maximize();

            ICollection<IWebElement> links = driver.FindElements(By.TagName("a"));

            Console.WriteLine("Links found: ");
            foreach (var link in links)
                Console.WriteLine(link.Text);
        }
    }
}
