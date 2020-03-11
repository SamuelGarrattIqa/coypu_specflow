using BoDi;
using Coypu;
using Coypu.Drivers.Selenium;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UiTest.Lib;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using TechTalk.SpecFlow;

namespace Hooks
{
  [Binding]
  public class SetUp
  {    
    private readonly ScenarioContext scenarioContext;

    private ScenarioCommon scenarioCommon;

    private TestContext testContext;

    public SetUp(ScenarioContext scenarioContext, ScenarioCommon scenarioCommon, TestContext testContext)
    {
          this.scenarioCommon = scenarioCommon;
          this.scenarioContext = scenarioContext;
          this.testContext = testContext;
    }

    [BeforeScenario]
    public void BeforeUI()
    {
      scenarioCommon.Setup(testContext);          
    }    

    [AfterScenario]
    public void AfterUI()
    {
      /*
      if (scenarioCommon.HasBrowser != null)
      {        
        if (testContext.CurrentTestOutcome != UnitTestOutcome.Passed)
        {
          var seperator = GetInformation.separator;
          var path = $"{GetInformation.projectDirectory}{seperator}TestResults{seperator}{testContext.TestName}.png";
          scenarioCommon.Browser.SaveScreenshot(path);
          testContext.AddResultFile(path);
          ReportStatus("False");
        }
        else
        {
          ReportStatus("True");
        }
      }
      */
    }

    private void ReportStatus(string status)
    {
      if (scenarioCommon.DemoMode == true)
      {
        var cookies = scenarioCommon.Browser.Driver.Cookies;
        cookies.AddCookie(new OpenQA.Selenium.Cookie("zaleniumTestPassed", status));
      }
    }
  }
}
