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
    //private readonly IObjectContainer _objectContainer;
    //private BrowserSession _browser;

    //private readonly TestContext _testContext;

    public SetUp()
    {
      //_objectContainer = objectContainer;
      //_testContext = testContext;      
    }

    [BeforeScenario("UI")]
    public void BeforeUI()
    {
      /*
      var sessionConfiguration = new SessionConfiguration
      {
        Driver = typeof(SeleniumWebDriver)
      };
      string browser = _testContext.Properties["browser"] as string;
      if (string.IsNullOrWhiteSpace(browser))
      {
          browser = "chrome";
      }
      sessionConfiguration.Browser = browser switch
      {
        "safari" => Coypu.Drivers.Browser.Safari,

        "chrome" => Coypu.Drivers.Browser.Chrome,

        _ => Coypu.Drivers.Browser.Chrome,
      };
      sessionConfiguration.Timeout = TimeSpan.FromSeconds(15);
      sessionConfiguration.RetryInterval = TimeSpan.FromSeconds(1);      
      _browser = new BrowserSession(sessionConfiguration);
      _objectContainer.RegisterInstanceAs(_browser);
      _browser.MaximiseWindow();      
      //ScenarioCommon.Browser = _browser;
      */
    }    

    [AfterScenario("UI")]
    public void AfterUI()
    {
      /*
      if (_testContext.CurrentTestOutcome != UnitTestOutcome.Passed)
      {
        var seperator = GetInformation.separator;
        var path = $"{GetInformation.projectDirectory}{seperator}TestResults{seperator}{_testContext.TestName}.png";
        _browser.SaveScreenshot(path);
        _testContext.AddResultFile(path);
      }
      _browser.Dispose();
      ScenarioCommon.Browser = null;
      */
    }
  }
}
