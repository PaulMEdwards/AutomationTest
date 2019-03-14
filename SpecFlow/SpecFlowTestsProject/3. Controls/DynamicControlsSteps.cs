using System;
using TechTalk.SpecFlow;

namespace SpecFlowTestsProject._3._Controls
{
    [Binding]
    public class DynamicSteps
    {
        [Given(@"I visit the Dynamic Controls example page")]
        public void GivenIVisitTheDynamicControlsExamplePage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click the checkbox Remove button")]
        public void WhenIClickTheCheckboxRemoveButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click the checkbox Add button")]
        public void WhenIClickTheCheckboxAddButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click the text input Enable button")]
        public void WhenIClickTheTextInputEnableButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click the text input Disable button")]
        public void WhenIClickTheTextInputDisableButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Observe loading animation shown then hidden")]
        public void ThenObserveLoadingAnimationShownThenHidden()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Confirm checkbox removal")]
        public void ThenConfirmCheckboxRemoval()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Confirm checkbox added")]
        public void ThenConfirmCheckboxAdded()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Confirm text input enabled")]
        public void ThenConfirmTextInputEnabled()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Confirm text input disabled")]
        public void ThenConfirmTextInputDisabled()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
