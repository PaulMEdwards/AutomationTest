using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace SpecFlowTestsProject.AUT {
    public class Common {
        public IWebDriver webDriver = null;
        public IWait<IWebDriver> defaultWait;
        public int defaultPollingIntervalMilliseconds = 100;
        public int defaultTimeoutSeconds = 30;
        public enum browsers { Chrome, Firefox, Edge, IE, Safari }
        public browsers browser = browsers.Chrome;
        
        [BeforeScenario]
        public void Initialize() {
            switch (browser) {
                case browsers.Chrome:
                    ChromeOptions chromeOptions = new ChromeOptions();
                    chromeOptions.AddArgument("start-maximized");

                    //chromeOptions.AddUserProfilePreference("geolocation.default_content_setting", 1);
                    //chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.geolocation", 1);
                    //chromeOptions.AddUserProfilePreference("profile.default_content_settings.geolocation", 1);
                    
                    webDriver = new ChromeDriver(chromeOptions);
                    break;
                case browsers.Firefox:
                    FirefoxOptions firefoxOptions = new FirefoxOptions();
                    firefoxOptions.SetPreference("geo.enabled", true);
                    firefoxOptions.SetPreference("geo.provider.use_corelocation", true);
                    firefoxOptions.SetPreference("geo.prompt.testing", false);
                    firefoxOptions.SetPreference("geo.prompt.testing.allow", true);
                    webDriver = new FirefoxDriver(firefoxOptions);
                    break;
                case browsers.Edge:
                    webDriver = new EdgeDriver();
                    break;
                case browsers.IE:
                    webDriver = new InternetExplorerDriver(new InternetExplorerOptions() { IgnoreZoomLevel = true });
                    break;
                case browsers.Safari:
                    //TODO: Implementation Pending... PME 20190315
                default:
                    throw new NotSupportedException("Specified Browser is not supported.");
            }

            defaultWait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(defaultTimeoutSeconds)) {
                PollingInterval = TimeSpan.FromMilliseconds(defaultPollingIntervalMilliseconds)
            };
        }
        
        [AfterScenario]
        public void TearDown() {
            webDriver.Close();
            webDriver.Quit();
            webDriver.Dispose();
            webDriver = null;
        }

        public void Navigate(string url) {
            webDriver.Navigate().GoToUrl(url);
        }


        public IWebElement FindHeaderWithText(string text, string headerTag = "h2") {
            IWebElement h = null;
            try {
                h = webDriver.FindElement(By.XPath(string.Format("//{0}[contains(text(),'{1}')]", headerTag, text)));
            } catch { }
            return h;
        }

        public void VerifyPageReached(string headerText, string headerTag = "h2") {
            FindHeaderWithText(headerText, headerTag).Displayed.Should().BeTrue();
        }

        public void ConfirmMessageAndStatus(string resultMessage, string status) {
            IWebElement f = webDriver.FindElement(By.Id("flash"));
            f.Displayed.Should().BeTrue();
            f.Text.Should().Contain(resultMessage);
            f.GetAttribute("class").Should().Contain(status);
        }
    }
}
