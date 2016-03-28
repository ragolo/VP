namespace LoremIpsum.Helpers
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;

    /// <summary>
    /// Class selenium set methods
    /// </summary>
    public class SeleniumSetMethods
    {

        /// <summary>
        /// Enters the text.
        /// </summary>
        /// <param name="element">The element.</param>
        /// <param name="value">The value.</param>
        /// <param name="elementType">Type of the element.</param>
        public static void EnterText(string element, string value, PropertiesCollection.PropertyType elementType)
        {
            switch (elementType)
            {
                case PropertiesCollection.PropertyType.Id:
                    PropertiesCollection.Driver.FindElement(By.Id(element)).SendKeys(value);
                    break;
                case PropertiesCollection.PropertyType.Name:
                    PropertiesCollection.Driver.FindElement(By.Name(element)).SendKeys(value);
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Clicks the specified element.
        /// </summary>
        /// <param name="element">The element.</param>
        /// <param name="elementType">Type of the element.</param>
        public static void Click(string element, PropertiesCollection.PropertyType elementType)
        {
            switch (elementType)
            {
                case PropertiesCollection.PropertyType.Id:
                    PropertiesCollection.Driver.FindElement(By.Id(element)).Click();
                    break;
                case PropertiesCollection.PropertyType.Name:
                    PropertiesCollection.Driver.FindElement(By.Name(element)).Click();
                    break;
                case PropertiesCollection.PropertyType.CssSelector:
                    PropertiesCollection.Driver.FindElement(By.CssSelector(element)).Click();
                    break;
                default:
                    break;
            }
        }

        public static void ClearElement(string element, PropertiesCollection.PropertyType elementType)
        {
            switch (elementType)
            {
                case PropertiesCollection.PropertyType.Id:
                    PropertiesCollection.Driver.FindElement(By.Id(element)).Clear();
                    break;
                case PropertiesCollection.PropertyType.Name:
                    PropertiesCollection.Driver.FindElement(By.Name(element)).Clear();
                    break;
                case PropertiesCollection.PropertyType.CssSelector:
                    PropertiesCollection.Driver.FindElement(By.CssSelector(element)).Clear();
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Selects the drop down.
        /// </summary>
        /// <param name="element">The element.</param>
        /// <param name="value">The value.</param>
        /// <param name="elementType">Type of the element.</param>
        public static void SelectDropDown(string element, string value, PropertiesCollection.PropertyType elementType)
        {
            switch (elementType)
            {
                case PropertiesCollection.PropertyType.Id:
                    new SelectElement(PropertiesCollection.Driver.FindElement(By.Id(element))).SelectByText(value);
                    break;
                case PropertiesCollection.PropertyType.Name:
                    new SelectElement(PropertiesCollection.Driver.FindElement(By.Name(element))).SelectByText(value);
                    break;
            }
        }
    }
}
