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
namespace SpecFlowTestsProject._2_Alerts
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Alerts", Description="\tIn order to test JavaScript alerts\r\n\tAs an Automated Test\r\n\tI will exercise seve" +
        "ral examples", SourceFile="2. Alerts\\Alerts.feature", SourceLine=0)]
    public partial class AlertsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Alerts.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Alerts", "\tIn order to test JavaScript alerts\r\n\tAs an Automated Test\r\n\tI will exercise seve" +
                    "ral examples", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        [TechTalk.SpecRun.ScenarioAttribute("Basic Alert", new string[] {
                "Alert",
                "Basic"}, SourceLine=6)]
        public virtual void BasicAlert()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Basic Alert", null, new string[] {
                        "Alert",
                        "Basic"});
#line 7
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
 testRunner.Given("I visit the JavaScript example alerts page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.When("I click the \"Alert\" example button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
 testRunner.Then("I confirm Alert appears with \"I am a JS Alert\" text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 11
 testRunner.And("I act upon alert by clicking \"OK\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
 testRunner.And("I confirm Result message \"You successfuly clicked an alert\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Confirm OK", new string[] {
                "Alert",
                "Confirm",
                "OK"}, SourceLine=15)]
        public virtual void ConfirmOK()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Confirm OK", null, new string[] {
                        "Alert",
                        "Confirm",
                        "OK"});
#line 16
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 17
 testRunner.Given("I visit the JavaScript example alerts page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 18
 testRunner.When("I click the \"Confirm\" example button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 19
 testRunner.Then("I confirm Alert appears with \"I am a JS Confirm\" text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 20
 testRunner.And("I act upon alert by clicking \"OK\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
 testRunner.And("I confirm Result message \"You clicked: Ok\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Confirm Cancel", new string[] {
                "Alert",
                "Confirm",
                "Cancel"}, SourceLine=23)]
        public virtual void ConfirmCancel()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Confirm Cancel", null, new string[] {
                        "Alert",
                        "Confirm",
                        "Cancel"});
#line 24
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 25
 testRunner.Given("I visit the JavaScript example alerts page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 26
 testRunner.When("I click the \"Confirm\" example button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 27
 testRunner.Then("I confirm Alert appears with \"I am a JS Confirm\" text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 28
 testRunner.And("I act upon alert by clicking \"Cancel\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
 testRunner.And("I confirm Result message \"You clicked: Cancel\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        public virtual void Prompt(string text, string button, string message, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Alert",
                    "Prompt"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Prompt", null, @__tags);
#line 33
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 34
 testRunner.Given("I visit the JavaScript example alerts page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 35
 testRunner.When("I click the \"Prompt\" example button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 36
 testRunner.Then("I confirm Alert appears with \"I am a JS prompt\" text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 37
 testRunner.And(string.Format("I act upon alert by inputting text \"{0}\"", text), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
 testRunner.And(string.Format("I act upon alert by clicking \"{0}\" button", button), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
 testRunner.And(string.Format("I confirm Result message \"{0}\"", message), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Prompt, \"\"", new string[] {
                "Alert",
                "Prompt"}, SourceLine=41)]
        public virtual void Prompt_()
        {
#line 33
this.Prompt("\"\"", "OK", "You entered:", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Prompt, TestMonkey", new string[] {
                "Alert",
                "Prompt"}, SourceLine=41)]
        public virtual void Prompt_TestMonkey()
        {
#line 33
this.Prompt("TestMonkey", "Cancel", "You entered: null", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Prompt, Infinite Monkeys on Infinite Keyboards", new string[] {
                "Alert",
                "Prompt"}, SourceLine=41)]
        public virtual void Prompt_InfiniteMonkeysOnInfiniteKeyboards()
        {
#line 33
this.Prompt("Infinite Monkeys on Infinite Keyboards", "OK", "You entered: Infinite Monkeys on Infinite Keyboards", ((string[])(null)));
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