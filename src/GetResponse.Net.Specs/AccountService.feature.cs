﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.18051
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace GetResponse.Net.Specs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class AccountServiceFeature : Xunit.IUseFixture<AccountServiceFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "AccountService.feature"
#line hidden
        
        public AccountServiceFeature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "AccountService", "In order to manage the account\r\nAs an API developer\r\nI want to access the account" +
                    " functionality", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void SetFixture(AccountServiceFeature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "AccountService")]
        [Xunit.TraitAttribute("Description", "Get account info")]
        public virtual void GetAccountInfo()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get account info", new string[] {
                        "mytag"});
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("a account service return value \'{\"jsonrpc\":\"2.0\",\"id\":\"1\",\"result\":{\"from_email\":" +
                    "\"support@example.com\",\"created_on\":\"2013-07-31 15:17:59\",\"from_name\":\"Example Us" +
                    "er\",\"login\":\"support@example.com\"}}\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.And("an account service", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
 testRunner.When("I call GetInfo", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.Then("the account service result should be the account service return value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "AccountService")]
        [Xunit.TraitAttribute("Description", "Get account from fields")]
        public virtual void GetAccountFromFields()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get account from fields", ((string[])(null)));
#line 13
this.ScenarioSetup(scenarioInfo);
#line 14
 testRunner.Given(@"a account service return value '{""jsonrpc"":""2.0"",""id"":""1"",""result"":{""nvsd"":{""email"":""admin2@example.com"",""created_on"":""2013-08-18 19:59:42"",""name"":""Example User2""},""nSRA"":{""email"":""support@example.com"",""created_on"":""2013-07-31 15:17:59"",""name"":""Example User""}}}'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 15
 testRunner.And("an account service", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
 testRunner.When("I call GetFromFields", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 17
 testRunner.Then("the account service result should be the account service return value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "AccountService")]
        [Xunit.TraitAttribute("Description", "Get account from field")]
        public virtual void GetAccountFromField()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get account from field", ((string[])(null)));
#line 19
this.ScenarioSetup(scenarioInfo);
#line 20
 testRunner.Given("a account service return value \'{\"jsonrpc\":\"2.0\",\"id\":\"1\",\"result\":{\"nvsd\":{\"emai" +
                    "l\":\"admin2@example.com\",\"created_on\":\"2013-08-18 19:59:42\",\"name\":\"Example User2" +
                    "\"}}}\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 21
 testRunner.And("an account service", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
 testRunner.When("I call GetFromField with a value of \'nvsd\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 23
 testRunner.Then("the account service result should be the account service return value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "AccountService")]
        [Xunit.TraitAttribute("Description", "Add account from field")]
        public virtual void AddAccountFromField()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add account from field", ((string[])(null)));
#line 25
this.ScenarioSetup(scenarioInfo);
#line 26
 testRunner.Given("a account service return value \'{\"jsonrpc\":\"2.0\",\"id\":\"1\",\"result\":{\"FROM_FIELD_I" +
                    "D\":\"abc123\",\"added\":1}}\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 27
 testRunner.And("an account service", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Email"});
            table1.AddRow(new string[] {
                        "Add Name",
                        "addname@example.com"});
#line 28
 testRunner.And("the following From data", ((string)(null)), table1, "And ");
#line 31
 testRunner.When("I call AddFromField", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 32
 testRunner.Then("the account service result should be the account service return value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "AccountService")]
        [Xunit.TraitAttribute("Description", "Add account from field with invalid email")]
        public virtual void AddAccountFromFieldWithInvalidEmail()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add account from field with invalid email", ((string[])(null)));
#line 34
this.ScenarioSetup(scenarioInfo);
#line 35
 testRunner.Given("a account service return value \'{\"jsonrpc\":\"2.0\",\"error\":{\"message\":\"Invalid emai" +
                    "l syntax\",\"code\":-1},\"id\":\"1\"}\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 36
 testRunner.And("an account service", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Email"});
            table2.AddRow(new string[] {
                        "Add Name",
                        "addnamecom"});
#line 37
 testRunner.And("the following From data", ((string)(null)), table2, "And ");
#line 40
 testRunner.When("I call AddFromField", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 41
 testRunner.Then("the account service result should be the account service return value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "AccountService")]
        [Xunit.TraitAttribute("Description", "Get account domains")]
        public virtual void GetAccountDomains()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get account domains", ((string[])(null)));
#line 43
this.ScenarioSetup(scenarioInfo);
#line 44
 testRunner.Given("a account service return value \'{\"jsonrpc\":\"2.0\",\"id\":\"1\",\"result\":{\"abcd\":{\"crea" +
                    "ted_on\":\"2009-01-01 00:00:00\",\"domain\":\"emailaddress.com\"},\"efgh\":{\"created_on\":" +
                    "\"2009-01-02 00:00:00\",\"domain\":\"otheremailaddress.com\"}}}\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 45
 testRunner.And("an account service", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 46
 testRunner.When("I call GetDomains", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 47
 testRunner.Then("the account service result should be the account service return value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "AccountService")]
        [Xunit.TraitAttribute("Description", "Get account domain")]
        public virtual void GetAccountDomain()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get account domain", ((string[])(null)));
#line 49
this.ScenarioSetup(scenarioInfo);
#line 50
 testRunner.Given("a account service return value \'{\"jsonrpc\":\"2.0\",\"id\":\"1\",\"result\":{\"abcd\":{\"crea" +
                    "ted_on\":\"2009-01-01 00:00:00\",\"domain\":\"emailaddress.com\"},\"efgh\":{\"created_on\":" +
                    "\"2009-01-02 00:00:00\",\"domain\":\"otheremailaddress.com\"}}}\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 51
 testRunner.And("an account service", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
 testRunner.And("a domain id of \'abcd\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
 testRunner.When("I call GetDomain with the domain id", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 54
 testRunner.Then("the account service result should be the account service return value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "AccountService")]
        [Xunit.TraitAttribute("Description", "Get account customs")]
        public virtual void GetAccountCustoms()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get account customs", ((string[])(null)));
#line 56
this.ScenarioSetup(scenarioInfo);
#line 57
 testRunner.Given(@"a account service return value '{""jsonrpc"":""2.0"",""id"":""1"",""result"":{""abcd"":{""name"":""age"",""content_type"":""number"",""input_type"":""text"",""is_hidden"":""no""},""efgh"":{""name"":""comment"",""content_type"":""string"",""input_type"":""textarea"",""is_hidden"":""yes""},""ijkl"":{""name"":""likes_food"",""content_type"":""string"",""input_type"":""multi_select"",""is_hidden"":""no"",""contents"":[""meat"",""fruits""]}}}'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 58
 testRunner.And("an account service", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 59
 testRunner.When("I call GetCustoms", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 60
 testRunner.Then("the account service result should be the account service return value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "AccountService")]
        [Xunit.TraitAttribute("Description", "Add account custom")]
        public virtual void AddAccountCustom()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add account custom", ((string[])(null)));
#line 62
this.ScenarioSetup(scenarioInfo);
#line 63
 testRunner.Given("a account service return value \'{\"jsonrpc\":\"2.0\",\"id\":\"1\",\"result\":{\"added\":1,\"CU" +
                    "STOM_ID\":\"p8n4\"}}\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 64
 testRunner.And("an account service", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "ContentType",
                        "InputType",
                        "IsHidden",
                        "Contents"});
            table3.AddRow(new string[] {
                        "custom_name",
                        "string",
                        "text",
                        "false",
                        ""});
#line 65
 testRunner.And("the following customs data", ((string)(null)), table3, "And ");
#line 68
 testRunner.When("I call AddCustom", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 69
 testRunner.Then("the account service result should be the account service return value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "AccountService")]
        [Xunit.TraitAttribute("Description", "Add account custom name already taken")]
        public virtual void AddAccountCustomNameAlreadyTaken()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add account custom name already taken", ((string[])(null)));
#line 71
this.ScenarioSetup(scenarioInfo);
#line 72
 testRunner.Given("a account service return value \'{\"jsonrpc\":\"2.0\",\"error\":{\"message\":\"Name already" +
                    " taken\",\"code\":-1},\"id\":\"1\"}\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 73
 testRunner.And("an account service", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "ContentType",
                        "InputType",
                        "IsHidden",
                        "Contents"});
            table4.AddRow(new string[] {
                        "custom_name",
                        "string",
                        "text",
                        "false",
                        ""});
#line 74
 testRunner.And("the following customs data", ((string)(null)), table4, "And ");
#line 77
 testRunner.When("I call AddCustom", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 78
 testRunner.Then("the account service result should be the account service return value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "AccountService")]
        [Xunit.TraitAttribute("Description", "Add account custom missing contents")]
        public virtual void AddAccountCustomMissingContents()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add account custom missing contents", ((string[])(null)));
#line 80
this.ScenarioSetup(scenarioInfo);
#line 81
 testRunner.Given("a account service return value \'{\"jsonrpc\":\"2.0\",\"error\":{\"message\":\"Missing cont" +
                    "ents\",\"code\":-1},\"id\":\"1\"}\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 82
 testRunner.And("an account service", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "ContentType",
                        "InputType",
                        "IsHidden",
                        "Contents"});
            table5.AddRow(new string[] {
                        "test_radio",
                        "string",
                        "radio",
                        "true",
                        ""});
#line 83
 testRunner.And("the following customs data", ((string)(null)), table5, "And ");
#line 86
 testRunner.When("I call AddCustom", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 87
 testRunner.Then("the account service result should be the account service return value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "AccountService")]
        [Xunit.TraitAttribute("Description", "Set account custom content")]
        public virtual void SetAccountCustomContent()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Set account custom content", ((string[])(null)));
#line 89
this.ScenarioSetup(scenarioInfo);
#line 90
 testRunner.Given("a account service return value \'{\"jsonrpc\":\"2.0\",\"id\":\"1\",\"result\":{\"added\":2,\"de" +
                    "leted\":1}}\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 91
 testRunner.And("an account service", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 92
 testRunner.And("custom Id of \'p8n4\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 93
 testRunner.And("custom contents of \'value 1\', \'value 2\' and \'value 3\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 94
 testRunner.When("I call SetCustomContent", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 95
 testRunner.Then("the account service result should be the account service return value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "AccountService")]
        [Xunit.TraitAttribute("Description", "Set account custom content not selectable input type")]
        public virtual void SetAccountCustomContentNotSelectableInputType()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Set account custom content not selectable input type", ((string[])(null)));
#line 97
this.ScenarioSetup(scenarioInfo);
#line 98
 testRunner.Given("a account service return value \'{\"jsonrpc\":\"2.0\",\"error\":{\"message\":\"Not selectab" +
                    "le input type\",\"code\":-1},\"id\":\"1\"}\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 99
 testRunner.And("an account service", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 100
 testRunner.And("custom Id of \'p8n4\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 101
 testRunner.And("custom contents of \'value 1\', \'value 2\' and \'value 3\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 102
 testRunner.When("I call SetCustomContent", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 103
 testRunner.Then("the account service result should be the account service return value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "AccountService")]
        [Xunit.TraitAttribute("Description", "Set account custom content missing custom")]
        public virtual void SetAccountCustomContentMissingCustom()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Set account custom content missing custom", ((string[])(null)));
#line 105
this.ScenarioSetup(scenarioInfo);
#line 106
 testRunner.Given("a account service return value \'{\"jsonrpc\":\"2.0\",\"error\":{\"message\":\"Missing cust" +
                    "om\",\"code\":-1},\"id\":\"1\"}\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 107
 testRunner.And("an account service", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 108
 testRunner.And("custom Id of \'p8n5\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 109
 testRunner.And("custom contents of \'value 1\', \'value 2\' and \'value 3\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 110
 testRunner.When("I call SetCustomContent", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 111
 testRunner.Then("the account service result should be the account service return value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "AccountService")]
        [Xunit.TraitAttribute("Description", "Delete account custom")]
        public virtual void DeleteAccountCustom()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Delete account custom", ((string[])(null)));
#line 113
this.ScenarioSetup(scenarioInfo);
#line 114
 testRunner.Given("a account service return value \'{\"jsonrpc\":\"2.0\",\"id\":\"1\",\"result\":{\"deleted\":1}}" +
                    "\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 115
 testRunner.And("an account service", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 116
 testRunner.And("custom Id of \'p8n4\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 117
 testRunner.When("I call DeleteCustom", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 118
 testRunner.Then("the account service result should be the account service return value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "AccountService")]
        [Xunit.TraitAttribute("Description", "Delete account custom missing custom")]
        public virtual void DeleteAccountCustomMissingCustom()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Delete account custom missing custom", ((string[])(null)));
#line 121
this.ScenarioSetup(scenarioInfo);
#line 122
 testRunner.Given("a account service return value \'{\"jsonrpc\":\"2.0\",\"error\":{\"message\":\"Missing cust" +
                    "om\",\"code\":-1},\"id\":\"1\"}\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 123
 testRunner.And("an account service", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 124
 testRunner.And("custom Id of \'p8n5\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 125
 testRunner.When("I call DeleteCustom", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 126
 testRunner.Then("the account service result should be the account service return value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                AccountServiceFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                AccountServiceFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion