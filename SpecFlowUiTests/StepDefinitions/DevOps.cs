using System;

using TechTalk.SpecFlow;
using UiTest.Lib;
using FluentAssertions;
using System.Threading;
using Coypu;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SpecFlowUiTests.StepDefinitions
{

    [Binding]
    public class DevOps
    {
        private readonly ScenarioContext scenarioContext;

        private ScenarioCommon ScenarioCommon;

        private TestContext testContext;

        public DevOps(ScenarioContext scenarioContext, ScenarioCommon scenarioCommon, TestContext testContext)
        {
            ScenarioCommon = scenarioCommon;
            this.scenarioContext = scenarioContext;
            this.testContext = testContext;
        }

        [Given("I am on the IntegrationQA blog page")]
        public void GivenIAmOnIQAPage()
        {
            ScenarioCommon.Browser.Visit("https://integrationqa.com/blog/");
            //ScenarioCommon.Browser.Visit("http://localhost:4999");
        }

        [When("I search for '(.*)'")]
        public void WhenISearchFor(string filter)
        {            
            ScenarioCommon.Browser.FillIn("s").With(filter);
            ScenarioCommon.Browser.ClickButton("searchsubmit");            
        }
    }
}
