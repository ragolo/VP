namespace LoremIpsum.Helpers
{
    using System.Linq;
    using OpenQA.Selenium.Support.UI;
    using OpenQA.Selenium;


    /// <summary>
    /// Class selenium get methods
    /// </summary>
    public class SeleniumGetMethods
    {

        /// <summary>
        /// Gets the text.
        /// </summary>
        /// <param name="element">The element.</param>
        /// <param name="elementType">Type of the element.</param>
        /// <returns></returns>
        public static string GetText(string element, PropertiesCollection.PropertyType elementType)
        {
            switch (elementType)
            {
                case PropertiesCollection.PropertyType.Id:
                    return PropertiesCollection.Driver.FindElement(By.Id(element)).Text;
                case PropertiesCollection.PropertyType.Name:
                    return PropertiesCollection.Driver.FindElement(By.Name(element)).Text;
                case PropertiesCollection.PropertyType.XPath:
                    return PropertiesCollection.Driver.FindElement(By.XPath(element)).GetAttribute("innerText");
                case PropertiesCollection.PropertyType.CssSelector:
                    return PropertiesCollection.Driver.FindElement(By.CssSelector(element)).Text;
                default:
                    return string.Empty;
            }
        }

        /// <summary>
        /// Gets the elements by count.
        /// </summary>
        /// <param name="element">The element.</param>
        /// <param name="elementType">Type of the element.</param>
        /// <returns></returns>
        public static int GetElementsByCount(string element, PropertiesCollection.PropertyType elementType)
        {
            switch (elementType)
            {
                case PropertiesCollection.PropertyType.Id:
                    return PropertiesCollection.Driver.FindElements(By.Id(element)).Count;
                case PropertiesCollection.PropertyType.Name:
                    return PropertiesCollection.Driver.FindElements(By.Name(element)).Count;
                case PropertiesCollection.PropertyType.XPath:
                    return PropertiesCollection.Driver.FindElements(By.XPath(element)).Count;
                case PropertiesCollection.PropertyType.CssSelector:
                    return PropertiesCollection.Driver.FindElements(By.CssSelector(element)).Count;
                default:
                    return 0;
            }
        }

        /// <summary>
        /// Gets the text from DDL.
        /// </summary>
        /// <param name="element">The element.</param>
        /// <param name="elementType">Type of the element.</param>
        /// <returns></returns>
        public static string GetTextFromDDL(string element, PropertiesCollection.PropertyType elementType)
        {
            switch (elementType)
            {
                case PropertiesCollection.PropertyType.Id:
                    return new SelectElement(PropertiesCollection.Driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
                case PropertiesCollection.PropertyType.Name:
                    return new SelectElement(PropertiesCollection.Driver.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;
                default:
                    return string.Empty;
            }
        }

    }
}
