﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.18052
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace HangFire.Tests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class ClientFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Client.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Client", "\r\n  As a Developer, I want to define and create jobs.", ProgrammingLanguage.CSharp, new string[] {
                        "redis"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((TechTalk.SpecFlow.FeatureContext.Current != null) 
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "Client")))
            {
                HangFire.Tests.ClientFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
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
        
        public virtual void FeatureBackground()
        {
#line 6
#line hidden
#line 7
    testRunner.Given("the following job type:", "public class TestJob : BackgroundJob\r\n{\r\n    public int ArticleId { get; set; }\r\n" +
                    "    public string Author { get; set; }\r\n\r\n    public override void Perform()\r\n  " +
                    "  {\r\n    }\r\n}          ", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("the `Perform.Async<TJob>()` method should enqueue a job of the given type")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Client")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void ThePerform_AsyncTJobMethodShouldEnqueueAJobOfTheGivenType()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("the `Perform.Async<TJob>()` method should enqueue a job of the given type", ((string[])(null)));
#line 23
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 24
     testRunner.When("I call the `Perform.Async<TestJob>()`", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 25
     testRunner.Then("the argumentless \'TestJob\' should be added to the default queue", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("the `Perform.Async<TJob>(object args)` method should enqueue job with the given a" +
            "rguments")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Client")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void ThePerform_AsyncTJobObjectArgsMethodShouldEnqueueJobWithTheGivenArguments()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("the `Perform.Async<TJob>(object args)` method should enqueue job with the given a" +
                    "rguments", ((string[])(null)));
#line 27
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 28
     testRunner.When("I call the `Perform.Async<TestJob>(new { ArticleId = 3, Author = \"odinserj\" })`", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Value"});
            table1.AddRow(new string[] {
                        "ArticleId",
                        "3"});
            table1.AddRow(new string[] {
                        "Author",
                        "odinserj"});
#line 29
     testRunner.Then("the \'TestJob\' should be added to the default queue with the following arguments:", ((string)(null)), table1, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("When one or more of the job arguments can not be converted using the custom TypeC" +
            "onverter, an exception should be raised")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Client")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void WhenOneOrMoreOfTheJobArgumentsCanNotBeConvertedUsingTheCustomTypeConverterAnExceptionShouldBeRaised()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When one or more of the job arguments can not be converted using the custom TypeC" +
                    "onverter, an exception should be raised", ((string[])(null)));
#line 34
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line hidden
#line 35
    testRunner.Given("the custom types:", @"[TypeConverter(typeof(CustomTypeConverter))
public class CustomType {}

public class CustomTypeConverter : TypeConverter
{
    public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
    {
        throw new NotSupportedException();
    }
}", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 48
     testRunner.When("I call the `Perform.Async<TestJob>(new { Author = new CustomType() })`", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 49
     testRunner.Then("a \'System.InvalidOperationException\' should be thrown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("the `Perform.Async(Type type)` method should enqueue a job of the given type")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Client")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void ThePerform_AsyncTypeTypeMethodShouldEnqueueAJobOfTheGivenType()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("the `Perform.Async(Type type)` method should enqueue a job of the given type", ((string[])(null)));
#line 51
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 52
     testRunner.When("I call the `Perform.Async(typeof(TestJob))`", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 53
     testRunner.Then("the argumentless \'TestJob\' should be added to the default queue", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Passing the null type argument to the `Perform.Async(Type type)` method should ca" +
            "use exception")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Client")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void PassingTheNullTypeArgumentToThePerform_AsyncTypeTypeMethodShouldCauseException()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Passing the null type argument to the `Perform.Async(Type type)` method should ca" +
                    "use exception", ((string[])(null)));
#line 55
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 56
     testRunner.When("I call the `Perform.Async(null)`", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 57
     testRunner.Then("a \'System.ArgumentNullException\' should be thrown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("the `Perform.Async(Type type, object args)` method should enqueue job of the give" +
            "n type")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Client")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void ThePerform_AsyncTypeTypeObjectArgsMethodShouldEnqueueJobOfTheGivenType()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("the `Perform.Async(Type type, object args)` method should enqueue job of the give" +
                    "n type", ((string[])(null)));
#line 59
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 60
     testRunner.When("I call the `Perform.Async(typeof(TestJob), new { ArticleId = 3 })`", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Value"});
            table2.AddRow(new string[] {
                        "ArticleId",
                        "3"});
#line 61
     testRunner.Then("the \'TestJob\' should be added to the default queue with the following arguments:", ((string)(null)), table2, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Passing the null type argument to the `Perform.Async(Type type, object args)` met" +
            "hod should cause exception")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Client")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void PassingTheNullTypeArgumentToThePerform_AsyncTypeTypeObjectArgsMethodShouldCauseException()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Passing the null type argument to the `Perform.Async(Type type, object args)` met" +
                    "hod should cause exception", ((string[])(null)));
#line 65
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 66
     testRunner.When("I call the `Perform.Async(null, new { ArticleId = 3 })`", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 67
     testRunner.Then("a \'System.ArgumentNullException\' should be thrown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("the `Perform.Async<TJob>()` method should enqueue a job to its actual queue")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Client")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void ThePerform_AsyncTJobMethodShouldEnqueueAJobToItsActualQueue()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("the `Perform.Async<TJob>()` method should enqueue a job to its actual queue", ((string[])(null)));
#line 72
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line hidden
#line 73
    testRunner.Given("the following job type:", "[Queue(\"critical\")]\r\npublic class CriticalQueueJob : BackgroundJob\r\n{\r\n    public" +
                    " override void Perform()\r\n    {\r\n    }\r\n}", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 83
     testRunner.When("I call the `Perform.Async<CriticalQueueJob>()`", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 84
     testRunner.Then("the argumentless \'CriticalQueueJob\' should be added to the \'critical\' queue", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("the queue name should contain only lowercase letters, digits and underscores")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Client")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void TheQueueNameShouldContainOnlyLowercaseLettersDigitsAndUnderscores()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("the queue name should contain only lowercase letters, digits and underscores", ((string[])(null)));
#line 86
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line hidden
#line 87
    testRunner.Given("the following job type:", "[Queue(\" $InvalidQueue\")]\r\npublic class InvalidQueueJob : BackgroundJob\r\n{\r\n    p" +
                    "ublic override void Perform()\r\n    {\r\n    }\r\n}", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 97
     testRunner.When("I call the `Perform.Async<InvalidQueueJob>()`", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 98
     testRunner.Then("a \'System.InvalidOperationException\' should be thrown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("if the QueueAttribute contains an empty or null string, then the actual queue sho" +
            "uld be the default queue")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Client")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void IfTheQueueAttributeContainsAnEmptyOrNullStringThenTheActualQueueShouldBeTheDefaultQueue()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("if the QueueAttribute contains an empty or null string, then the actual queue sho" +
                    "uld be the default queue", ((string[])(null)));
#line 100
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line hidden
#line 101
    testRunner.Given("the following job type:", "[Queue(\"\")]\r\npublic class EmptyQueueJob : BackgroundJob\r\n{\r\n    public override v" +
                    "oid Perform()\r\n    {\r\n    }\r\n}", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 111
     testRunner.When("I call the `Perform.Async<EmptyQueueJob>()`", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 112
     testRunner.Then("the argumentless \'EmptyQueueJob\' should be added to the default queue", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("the `Perform.In<TestJob>(TimeSpan delay)` method should schedule a job of the giv" +
            "en type")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Client")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void ThePerform_InTestJobTimeSpanDelayMethodShouldScheduleAJobOfTheGivenType()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("the `Perform.In<TestJob>(TimeSpan delay)` method should schedule a job of the giv" +
                    "en type", ((string[])(null)));
#line 117
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 118
     testRunner.When("I call the `Perform.In<TestJob>(TimeSpan.FromDays(1))`", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 119
     testRunner.Then("the argumentless \'TestJob\' should be scheduled for tomorrow", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("the `Perform.In<TestJob>(TimeSpan delay, object args)` method should schedule a j" +
            "ob of the given type")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Client")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void ThePerform_InTestJobTimeSpanDelayObjectArgsMethodShouldScheduleAJobOfTheGivenType()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("the `Perform.In<TestJob>(TimeSpan delay, object args)` method should schedule a j" +
                    "ob of the given type", ((string[])(null)));
#line 121
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 122
     testRunner.When("I call the `Perform.In<TestJob>(TimeSpan.FromDays(1), new { ArticleId = 3 })`", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Value"});
            table3.AddRow(new string[] {
                        "ArticleId",
                        "3"});
#line 123
     testRunner.Then("the \'TestJob\' should be scheduled for tomorrow with the following arguments:", ((string)(null)), table3, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("the `Perform.In(TimeSpan delay, Type type)` method should schedule a job of the g" +
            "iven type")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Client")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void ThePerform_InTimeSpanDelayTypeTypeMethodShouldScheduleAJobOfTheGivenType()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("the `Perform.In(TimeSpan delay, Type type)` method should schedule a job of the g" +
                    "iven type", ((string[])(null)));
#line 127
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 128
     testRunner.When("I call the `Perform.In(TimeSpan.FromDays(1), typeof(TestJob))`", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 129
     testRunner.Then("the argumentless \'TestJob\' should be scheduled for tomorrow", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("The `Perform.In(TimeSpan delay, Type type, object args)` method should schedule a" +
            " job of the given type")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Client")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void ThePerform_InTimeSpanDelayTypeTypeObjectArgsMethodShouldScheduleAJobOfTheGivenType()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The `Perform.In(TimeSpan delay, Type type, object args)` method should schedule a" +
                    " job of the given type", ((string[])(null)));
#line 131
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 132
     testRunner.When("I call the `Perform.In(TimeSpan.FromDays(1), typeof(TestJob), new { ArticleId = 3" +
                    " })`", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Value"});
            table4.AddRow(new string[] {
                        "ArticleId",
                        "3"});
#line 133
     testRunner.Then("the \'TestJob\' should be scheduled for tomorrow with the following arguments:", ((string)(null)), table4, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
