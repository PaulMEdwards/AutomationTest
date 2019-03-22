using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using FluentAssertions;
using System.Globalization;
using System.Threading;
using System.Collections.ObjectModel;

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
            FindAndClickButton(By.XPath("//button[@type='submit']/i[contains(text(),'Login')]/.."));
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
            FindAndClickButton(By.LinkText("Logout"));
        }

        [Then(@"the Secure Area page should NOT load")]
        public void ThenTheSecureAreaPageShouldNOTLoad() {
            ConfirmLoggedIn(false);
        }

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

            FindAndClickButton("Click for JS "+buttonLabel);
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

            VerifyPageReached("Dynamic Controls", "h4");
        }

        [Given(@"I toggle the checkbox")]
        public void GivenICheckTheBox() {
            IWebElement c = WaitForElementToAppear(By.XPath("//input[@type='checkbox']"));

            bool state = c.Selected;
            c.SendKeys(" ");    //Most reliable way to toggle checkbox

            c.Selected.Should().Be(!state);
        }

        [Then(@"I input ""(.*)"" text")]
        public void ThenIInputText(string text) {
            IWebElement t = webDriver.FindElement(By.XPath("//input[@type='text']"));

            t.SendKeys(text);

            string v = t.GetAttribute("value");
            v.Should().Be(text);
        }

        [When(@"I click the ""(.*)"" button")]
        public void WhenIClickTheButton(string buttonText) {
            FindAndClickButton(buttonText);
            Thread.Sleep(500);
        }

        [Then(@"Observe loading animation shown then hidden")]
        public void ThenObserveLoadingAnimationShownThenHidden() {
            IWebElement l = WaitForElementToAppear(By.Id("loading"), 5);

            ReadOnlyCollection<IWebElement> ls = webDriver.FindElements(By.Id("loading"));
            int loadingElementsDisplayed = 0;

            //Check for multiple loading graphics displayed
            int i = 0;
            for (i = 0; i < ls.Count; i++) {
                if (ls[i].Displayed)
                    loadingElementsDisplayed++;
                if (loadingElementsDisplayed > 1)
                    throw new ApplicationException("Bug: More than 1 loading graphic is displayed simultaneously!");
            }
            if (i > 0)
                i--;    //Roll iterator back by 1 to counter final for loop ++

            //Wait for loading image to become hidden
            int j = 0;
            do {
                Thread.Sleep(250);
                j++;
            } while(j < 12 && ls[i].Displayed); //12 here is appx. 3 seconds total

            //Confirm loading image has been hidden
            ls[i].Displayed.Should().BeFalse();
        }

        [Then(@"Confirm checkbox removal")]
        public void ThenConfirmCheckboxRemoval() {
            ConfirmCheckbox(false);
        }
        [Then(@"Confirm checkbox added")]
        public void ThenConfirmCheckboxAdded() {
            ConfirmCheckbox(true);
        }
        public void ConfirmCheckbox(bool state) {
            IWebElement f = WaitForElementToAppear(By.Id("checkbox-example"));
            IWebElement c = WaitForElementToAppear(By.XPath("//input[@type='checkbox']"), 3);
            ReadOnlyCollection<IWebElement> d = f.FindElements(By.XPath(".//div[contains(text(),'A checkbox')]"));

            if (state) {
                c.Should().NotBeNull();
                d.Count.Should().Be(1); //Test for exactly 1 checkbox DIV(s)
            } else {
                c.Should().BeNull();
                d.Count.Should().Be(0); //Test for lingering checkbox DIV(s)
            }
        }

        [Then(@"Confirm text input enabled")]
        public void ThenConfirmTextInputEnabled() {
            ThenConfirmTextInput(true);
        }
        [Then(@"Confirm text input disabled")]
        public void ThenConfirmTextInputDisabled() {
            ThenConfirmTextInput(false);
        }
        [Then(@"Confirm text input ""(.*)""")]
        public void ThenConfirmTextInput(string state) {
            bool? stateBool = null;

            switch (state.ToLower()) {
                case "1":
                case "on":
                case "enable":
                case "enabled":
                    stateBool = true;
                    break;
                case "0":
                case "off":
                case "disable":
                case "disabled":
                    stateBool = false;
                    break;
            }

            if (stateBool == null)
                throw new ArgumentException(string.Format("Desired state of text input field '{0}' is not supported!", state));

            ThenConfirmTextInput((bool)stateBool);
        }
        public void ThenConfirmTextInput(bool state) {
            IWebElement t = null;
            int i = 0;
            do {
                Thread.Sleep(1000); //Needs delay for state change
                t = webDriver.FindElement(By.XPath("//input[@type='text']"));
                i++;
            } while (i <= 3 && t.Enabled != state);

            t.Enabled.Should().Be(state);
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
            FindAndClickButton("Where am I?");
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

        
        public IWebElement WaitForElementToAppear(By ByIdentifier, int timeoutInSeconds = 30) {
            IWebElement e = null;
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(timeoutInSeconds));

            Func<IWebDriver, bool> waitForElement = new Func<IWebDriver, bool>((IWebDriver wD) => {
                e = wD.FindElement(ByIdentifier);
                return e.Displayed;
            });

            try {
                wait.Until(waitForElement);
            } catch { }

            return e;
        }

        public IWebElement FindAndClickButton(string buttonText) {
            return FindAndClickButton(By.XPath("//button[text()='"+buttonText+"']"));
        }
        public IWebElement FindAndClickButton(By ByIdentifier) {
            IWebElement b = WaitForElementToAppear(ByIdentifier);
            
            b.Should().NotBeNull();
            b.Displayed.Should().BeTrue();
            b.Enabled.Should().BeTrue();

            b.Click();

            return b;
        }
    }
}
