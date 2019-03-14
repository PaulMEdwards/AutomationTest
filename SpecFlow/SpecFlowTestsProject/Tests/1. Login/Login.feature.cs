﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SpecFlowTestsProject.Tests._1_Login
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Login Form", Description="\tIn order to login to the application\r\n\tAs a user\r\n\tI want to be able to login us" +
        "ing assigned credentials\r\n\tAnd must not be able to login with invalid credential" +
        "s", SourceFile="Tests\\1. Login\\Login.feature", SourceLine=0)]
    public partial class LoginFormFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Login.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Login Form", "\tIn order to login to the application\r\n\tAs a user\r\n\tI want to be able to login us" +
                    "ing assigned credentials\r\n\tAnd must not be able to login with invalid credential" +
                    "s", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void LoginWithValidCredentials(string username, string password, string resultMessage, string status, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "login",
                    "Valid"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Login with valid credentials", null, @__tags);
#line 8
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
 testRunner.Given("I visit the login form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 10
 testRunner.And(string.Format("I input \"{0}\" as username and \"{1}\" as password", username, password), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
 testRunner.When("I click the Login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
 testRunner.Then(string.Format("user should be logged in with \"{0}\" and \"{1}\"", resultMessage, status), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 13
 testRunner.And("the Secure Area page should load without error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
 testRunner.And("the user can logout and return to the login form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Login with valid credentials, tomsmith", new string[] {
                "login",
                "Valid"}, SourceLine=16)]
        public virtual void LoginWithValidCredentials_Tomsmith()
        {
#line 8
this.LoginWithValidCredentials("tomsmith", "SuperSecretPassword!", "You logged into a secure area!", "success", ((string[])(null)));
#line hidden
        }
        
        public virtual void AttemptLoginWithInvalidCredentials(string username, string password, string resultMessage, string status, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "login",
                    "invalid"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Attempt login with invalid credentials", null, @__tags);
#line 20
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 21
 testRunner.Given("I visit the login form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 22
 testRunner.And(string.Format("I input \"{0}\" as username and \"{1}\" as password", username, password), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 23
 testRunner.When("I click the Login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 24
 testRunner.Then(string.Format("the user should see the \"{0}\" and \"{1}\"", resultMessage, status), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 25
 testRunner.And("the Secure Area page should NOT load", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Attempt login with invalid credentials, Variant 0", new string[] {
                "login",
                "invalid"}, SourceLine=27)]
        public virtual void AttemptLoginWithInvalidCredentials_Variant0()
        {
#line 20
this.AttemptLoginWithInvalidCredentials("garbage", "SuperSecretPassword!", "Your username is invalid!", "error", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Attempt login with invalid credentials, Variant 1", new string[] {
                "login",
                "invalid"}, SourceLine=27)]
        public virtual void AttemptLoginWithInvalidCredentials_Variant1()
        {
#line 20
this.AttemptLoginWithInvalidCredentials("Null", "SuperSecretPassword!", "Your username is invalid!", "error", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Attempt login with invalid credentials, Variant 2", new string[] {
                "login",
                "invalid"}, SourceLine=27)]
        public virtual void AttemptLoginWithInvalidCredentials_Variant2()
        {
#line 20
this.AttemptLoginWithInvalidCredentials("tomsmith", "garbage", "Your password is invalid!", "error", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Attempt login with invalid credentials, Variant 3", new string[] {
                "login",
                "invalid"}, SourceLine=27)]
        public virtual void AttemptLoginWithInvalidCredentials_Variant3()
        {
#line 20
this.AttemptLoginWithInvalidCredentials("tomsmith", "Null", "Your password is invalid!", "error", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion
