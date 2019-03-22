using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using FluentAssertions;
using System.Globalization;
using System.Threading;

namespace SpecFlowTestsProject.AUT {
    [Binding]
    public class AllSteps : Common {
        #region LoginSteps
        [Given(@"I visit the login form")]
        public void GivenIVisitTheLoginForm() {
            string url = "https://the-internet.herokuapp.com/login";
            Navigate(url);

            VerifyPageReached("Login Page");
        }

        [Given(@"I input ""(.*)"" as username and ""(.*)"" as password")]
        public void GivenIInputAsUsernameAndAsPassword(string user, string pass) {
            IWebElement userName = webDriver.FindElement(By.Id("username"));
            IWebElement password = webDriver.FindElement(By.Id("password"));

            userName.SendKeys(user);
            password.SendKeys(pass);
        }

        [When(@"I click the Login button")]
        public void WhenIClickTheLoginButton() {
            IWebElement l = webDriver.FindElement(By.XPath("//button[@type='submit']/i[contains(text(),'Login')]/.."));

            l.Displayed.Should().BeTrue();
            l.Enabled.Should().BeTrue();
            l.Click();
        }

        [Then(@"the user should see ""(.*)"" indicating ""(.*)""")]
        public void ThenTheUserShouldSeeIndicating(string resultMessage, string status) {
            ConfirmMessageAndStatus(resultMessage, status);
        }

        [Then(@"the Secure Area page should load without error")]
        public void ThenTheSecureAreaPageShouldLoadWithoutError() {
            ConfirmLoggedIn(true);
        }

        [Then(@"the user can logout and return to the login form")]
        public void ThenTheUserCanLogoutAndReturnToTheLoginForm() {
            IWebElement l = webDriver.FindElement(By.LinkText("Logout"));

            l.Displayed.Should().BeTrue();
            l.Enabled.Should().BeTrue();
            l.Click();
        }

        [Then(@"the Secure Area page should NOT load")]
        public void ThenTheSecureAreaPageShouldNOTLoad() {
            ConfirmLoggedIn(false);
        }
        #endregion LoginSteps

        #region AlertSteps
        [Given(@"I visit the JavaScript example alerts page")]
        public void GivenIVisitTheAlertsPage() {
            string url = "https://the-internet.herokuapp.com/javascript_alerts";
            Navigate(url);

            VerifyPageReached("JavaScript Alerts", "h3");
        }

        [When(@"I click the ""(.*)"" example button")]
        public void WhenIClickThePromptExampleButton(string buttonLabel) {
            TextInfo ti = new CultureInfo("en-US", false).TextInfo;
            buttonLabel = ti.ToTitleCase(buttonLabel);

            //Input parameter validation
            switch (buttonLabel) {
                case "Alert":
                case "Confirm":
                case "Prompt":
                    break;
                default:
                    throw new ArgumentException(string.Format("JavaScript Alert Prompt button text '{0}' is not supported... Supported argument is either:\nAlert\nConfirm\nPrompt", buttonLabel));
            }

            IWebElement b = webDriver.FindElement(By.XPath("//button[text()='Click for JS " + buttonLabel + "']"));

            b.Should().NotBeNull();
            b.Displayed.Should().BeTrue();
            b.Enabled.Should().BeTrue();

            b.Click();
        }

        [Then(@"I confirm Alert appears with ""(.*)"" text")]
        public void ThenIConfirmAlertAppearsWithText(string dialogText) {
            IAlert a = webDriver.SwitchTo().Alert();

            a.Should().NotBeNull();
            a.Text.Should().Be(dialogText);
        }

        [Then(@"I act upon alert by clicking ""(.*)"" button")]
        public void ThenIActUponAlertByClickingButton(string buttonAction) {
            switch (buttonAction.ToLower()) {
                case "ok":
                    webDriver.SwitchTo().Alert().Accept();
                    break;
                case "cancel":
                    webDriver.SwitchTo().Alert().Dismiss();
                    break;
                default:
                    throw new ArgumentException(string.Format("Button action '{0}' is not valid.", buttonAction));
            }
        }

        [Then(@"I confirm Result message ""(.*)""")]
        public void ThenIConfirmResultMessage(string resultMessage) {
            IWebElement m = webDriver.FindElement(By.Id("result"));

            m.Should().NotBeNull();
            m.Text.Should().Contain(resultMessage);
        }

        [Then(@"I act upon alert by inputting text ""(.*)""")]
        public void ThenIActUponAlertByInputtingText(string textToInput) {
            webDriver.SwitchTo().Alert().SendKeys(textToInput);
        }
        #endregion AlertSteps

        #region DynamicControlsSteps
        [Given(@"I visit the Dynamic Controls example page")]
        public void GivenIVisitTheDynamicControlsPage() {
            string url = "https://the-internet.herokuapp.com/dynamic_controls";
            Navigate(url);
        }

        [When(@"I click the checkbox Remove button")]
        public void WhenIClickTheCheckboxRemoveButton() {
            ScenarioContext.Current.Pending();
        }

        [When(@"I click the checkbox Add button")]
        public void WhenIClickTheCheckboxAddButton() {
            ScenarioContext.Current.Pending();
        }

        [When(@"I click the text input Enable button")]
        public void WhenIClickTheTextInputEnableButton() {
            ScenarioContext.Current.Pending();
        }

        [When(@"I click the text input Disable button")]
        public void WhenIClickTheTextInputDisableButton() {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Observe loading animation shown then hidden")]
        public void ThenObserveLoadingAnimationShownThenHidden() {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Confirm checkbox removal")]
        public void ThenConfirmCheckboxRemoval() {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Confirm checkbox added")]
        public void ThenConfirmCheckboxAdded() {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Confirm text input enabled")]
        public void ThenConfirmTextInputEnabled() {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Confirm text input disabled")]
        public void ThenConfirmTextInputDisabled() {
            ScenarioContext.Current.Pending();
        }
        #endregion DynamicControlsSteps

        #region GeolocationSteps
        [Given(@"I visit the Geolocation page")]
        public void GivenIVisitTheGeolocationPage() {
            string url = "https://the-internet.herokuapp.com/geolocation";
            Navigate(url);

            VerifyPageReached("Geolocation", "h3");
        }

        [When(@"I click the Where am I\? button")]
        public void WhenIClickTheWhereAmIButton() {
            IWebElement b = webDriver.FindElement(By.XPath("//button[text()='Where am I?']"));

            b.Should().NotBeNull();
            b.Displayed.Should().BeTrue();
            b.Enabled.Should().BeTrue();

            b.Click();
        }

        [Then(@"User's Lat/Long coordinates are displayed and viewable on Google Maps")]
        public void ThenUserSLatLongCoordinatesAreDisplayed() {
            IWebElement latValue = WaitForElementToAppear(By.Id("lat-value"));
            IWebElement longValue = WaitForElementToAppear(By.Id("long-value"));

            latValue.Should().NotBeNull();
            longValue.Should().NotBeNull();

            latValue.Displayed.Should().BeTrue();
            longValue.Displayed.Should().BeTrue();

            IWebElement mapLink = webDriver.FindElement(By.XPath("//a[text()='See it on Google']"));

            const string baseUrl = "http://maps.google.com/?q=";
            string url = mapLink.GetAttribute("href");

            url.Should().BeEquivalentTo(baseUrl + latValue.Text + "," + longValue.Text);

            mapLink.Click();
        }
        #endregion GeolocationSteps


        private void ConfirmLoggedIn(bool expectedCondition = true) {
            IWebElement e = null;
            if (expectedCondition) {
                e = FindHeaderWithText("Secure Area");
                e.Displayed.Should().Be(true);
            } else {
                e = FindHeaderWithText("Secure Area");
                e.Should().BeNull("We should not be able to reach the secure area, yet we have.");
            }
        }

        public IWebElement WaitForElementToAppear(By ByIdentifier, int timeoutInSeconds = 30) {
            IWebElement e = null;
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(timeoutInSeconds));

            Func<IWebDriver, bool> waitForElement = new Func<IWebDriver, bool>((IWebDriver wD) => {
                e = wD.FindElement(ByIdentifier);
                return e.Displayed;
            });

            wait.Until(waitForElement);

            return e;
        }
    }
}
