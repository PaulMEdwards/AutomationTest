using System;
using TechTalk.SpecFlow;

namespace SpecFlowTestsProject.Tests._2._Alerts
{
    [Binding]
    public class AlertsSteps
    {
        [Given(@"I visit the JavaScript example alerts page")]
        public void GivenIVisitTheJavaScriptExampleAlertsPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click the Alert example button")]
        public void WhenIClickTheAlertExampleButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click the Confirm example button")]
        public void WhenIClickTheConfirmExampleButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click the Prompt example button")]
        public void WhenIClickThePromptExampleButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I confirm Alert appears with ""(.*)"" text and ""(.*)"" input")]
        public void ThenIConfirmAlertAppearsWithTextAndInput(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I act upon alert by clicking ""(.*)"" button")]
        public void ThenIActUponAlertByClickingButton(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I confirm Result message ""(.*)""")]
        public void ThenIConfirmResultMessage(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I act upon alert by inputting text ""(.*)""")]
        public void ThenIActUponAlertByInputtingText(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
