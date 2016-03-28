namespace LoremIpsum.Helpers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using OpenQA.Selenium;

    public class PropertiesCollection
    {
        public enum PropertyType
        {
            Id,
            Name,
            LinkText,
            CssName,
            ClassName,
            XPath,
            CssSelector
        }

        public static IWebDriver Driver { get; set; }
    }
}
