using System.Linq;

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
        public void ExecuteTestCase1()
        {
            string firstparagraph = SeleniumGetMethods.GetText("p", PropertiesCollection.PropertyType.CssSelector);
            string title = SeleniumGetMethods.GetText("/descendant::h2/span", PropertiesCollection.PropertyType.XPath);

            StringAssert.AreEqualIgnoringCase("What is Lorem Ipsum?", title);
            StringAssert.Contains("Lorem Ipsum is simply dummy text of the printing and typesetting industry", firstparagraph);
        }

        [Test]
        public void ExexcuteTestCase2()
        {
            const string selectelement = "amount";
            const int numberparams = 3;

            SeleniumSetMethods.ClearElement(selectelement, PropertiesCollection.PropertyType.Id);
            SeleniumSetMethods.EnterText(selectelement, numberparams.ToString(), PropertiesCollection.PropertyType.Id);

            SeleniumSetMethods.Click("paras", PropertiesCollection.PropertyType.Id);
            SeleniumSetMethods.Click("input[type='submit']#generate", PropertiesCollection.PropertyType.CssSelector);

            var counterparas = SeleniumGetMethods.GetElementsByCount("p", PropertiesCollection.PropertyType.CssSelector);

            Assert.AreEqual(numberparams, counterparas, "The numbers of paragraphs are not equals");

            var resultgenerated = SeleniumGetMethods.GetText("generated", PropertiesCollection.PropertyType.Id);
            var firstresultgenerated = resultgenerated.Split(',').FirstOrDefault();

            StringAssert.Contains(numberparams.ToString(), firstresultgenerated);
        }


        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.Driver.Quit();
            Console.WriteLine("Close the window");
        }
    }
}
