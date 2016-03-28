namespace LoremIpsum
{
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using System;

    /// <summary>
    /// Class program
    /// </summary>
    public class Program
    {
        readonly IWebDriver _driver = new ChromeDriver();

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
            //It's timeout that i need to all element
            //Advise me write to .config
            //TimeSpan t = new TimeSpan(10);
            //driver.Manage().Timeouts().ImplicitlyWait(t);

            //the wait is for the elements

            _driver.Navigate().GoToUrl("http://www.lipsum.com/");
            Console.WriteLine("Open the browser");
        }

        [Test]
        public void ExecuteTest()
        {
            IWebElement elementParagraphsFirst = _driver.FindElement(By.CssSelector("p"));
            IWebElement elementTitle = elementParagraphsFirst.FindElement(By.XPath("/descendant::h2/span"));

            StringAssert.AreEqualIgnoringCase("What is Lorem Ipsum?", elementTitle.GetAttribute("innerText"));
            StringAssert.Contains("Lorem Ipsum is simply dummy text of the printing and typesetting industry", elementParagraphsFirst.Text);
        }

        [TearDown]
        public void CleanUp()
        {
            _driver.Quit();
            Console.WriteLine("Close the window");
        }



    }
}
