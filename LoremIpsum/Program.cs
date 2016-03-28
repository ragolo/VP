namespace LoremIpsum
{
    using NUnit.Framework;
    using OpenQA.Selenium.Chrome;
    using System;
    using Helpers;

    /// <summary>
    /// Class program
    /// </summary>
    public class Program
    {

        /// <summary>
        /// Mains the specified arguments.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {

        }

        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.Driver = new ChromeDriver();

            //It's timeout that i need to all element
            //Advise me write to .config
            //TimeSpan t = new TimeSpan(10);
            //driver.Manage().Timeouts().ImplicitlyWait(t);

            //the wait is for the elements

            PropertiesCollection.Driver.Navigate().GoToUrl("http://www.lipsum.com/");
            Console.WriteLine("Open the browser");
        }

        [Test]
        public void ExecuteTest()
        {
            string firstparagraph = SeleniumGetMethods.GetText("p", PropertiesCollection.PropertyType.CssSelector);
            string title = SeleniumGetMethods.GetText("/descendant::h2/span", PropertiesCollection.PropertyType.XPath);

            StringAssert.AreEqualIgnoringCase("What is Lorem Ipsum?", title);
            StringAssert.Contains("Lorem Ipsum is simply dummy text of the printing and typesetting industry", firstparagraph);
        }

        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.Driver.Quit();
            Console.WriteLine("Close the window");
        }
    }
}
