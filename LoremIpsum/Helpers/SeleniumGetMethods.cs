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
