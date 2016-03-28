namespace LoremIpsum.Helpers
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;

    public class SeleniumSetMethods
    {

        /// <summary>
        /// Enters the text.
        /// </summary>
        /// <param name="driver">The driver.</param>
        /// <param name="element">The element.</param>
        /// <param name="value">The value.</param>
        /// <param name="elementType">Type of the element.</param>
        public static void EnterText(IWebDriver driver, string element, string value, string elementType)
        {
            if (elementType.Equals("Id"))
            {
                driver.FindElement(By.Id(element)).SendKeys(value);
            }

            if (elementType.Equals("Name"))
            {
                driver.FindElement(By.Name(element)).SendKeys(value);
            }
        }

        /// <summary>
        /// Clicks the specified driver.
        /// </summary>
        /// <param name="driver">The driver.</param>
        /// <param name="element">The element.</param>
        /// <param name="elementType">Type of the element.</param>
        public static void Click(IWebDriver driver, string element, PropertiesCollection.PropertyType elementType)
        {
            switch (elementType)
            {
                case PropertiesCollection.PropertyType.Id:
                    driver.FindElement(By.Id(element)).Click();
                    break;
                case PropertiesCollection.PropertyType.Name:
                    driver.FindElement(By.Name(element)).Click();
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Selects the drop down.
        /// </summary>
        /// <param name="driver">The driver.</param>
        /// <param name="element">The element.</param>
        /// <param name="value">The value.</param>
        /// <param name="elementType">Type of the element.</param>
        public static void SelectDropDown(IWebDriver driver, string element, string value, PropertiesCollection.PropertyType elementType)
        {
            switch (elementType)
            {
                case PropertiesCollection.PropertyType.Id:
                    new SelectElement(driver.FindElement(By.Id(element))).SelectByText(value);
                    break;
                case PropertiesCollection.PropertyType.Name:
                    new SelectElement(driver.FindElement(By.Name(element))).SelectByText(value);
                    break;
            }
        }
    }
}
