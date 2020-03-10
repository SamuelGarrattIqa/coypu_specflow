using System.Threading;
using Coypu;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using UiTest.Lib;

namespace SpecFlowUiTests.StepDefinitions
{

    [Binding]
    public class Verify
    {
        private readonly ScenarioContext scenarioContext;

        private ScenarioCommon ScenarioCommon;

        private TestContext testContext;

        public Verify(ScenarioContext scenarioContext, ScenarioCommon scenarioCommon, TestContext testContext)
        {
            ScenarioCommon = scenarioCommon;
            this.scenarioContext = scenarioContext;
            this.testContext = testContext;
        }

        [Then("a result is returned")]
        public void ThenAResultIsReturned()
        {
            ScenarioCommon.Browser.FindXPath("//div[@id='content-area']//a", new Options { Match = Match.First }).Click();
            Thread.Sleep(500);
        }
    }
}