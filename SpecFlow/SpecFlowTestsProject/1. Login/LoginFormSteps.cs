using System;
using TechTalk.SpecFlow;

namespace SpecFlowTestsProject.AUT
{
    [Binding]
    public class LoginFormSteps
    {
        [Given(@"I visit the login form")]
        public void GivenIVisitTheLoginForm()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I input ""(.*)"" as username and ""(.*)"" as password")]
        public void GivenIInputAsUsernameAndAsPassword(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click the Login button")]
        public void WhenIClickTheLoginButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"user should be logged in with ""(.*)"" and ""(.*)""")]
        public void ThenUserShouldBeLoggedInWithAnd(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the Secure Area page should load without error")]
        public void ThenTheSecureAreaPageShouldLoadWithoutError()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the user can logout and return to the login form")]
        public void ThenTheUserCanLogoutAndReturnToTheLoginForm()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the user should see the ""(.*)"" and ""(.*)""")]
        public void ThenTheUserShouldSeeTheAnd(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the Secure Area page should NOT load")]
        public void ThenTheSecureAreaPageShouldNOTLoad()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
