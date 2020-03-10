using Coypu;
using Coypu.Drivers.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UiTest.Lib
{
  /// <summary>
  /// Holds information to be shared across a SpecFlow scenario.
  /// This does the same as ScenarioContext but shows usage clearer rather than using a list
  /// </summary>
  public class ScenarioCommon : IDisposable
  {
    public BrowserSession Browser { get; set; }

    public void Dispose()
    {
      if (Browser != null) Browser.Dispose();
    }

    public void Setup(TestContext testContext)
    {
      var sessionConfiguration = new SessionConfiguration
      {
        Driver = typeof(SeleniumWebDriver)
      };
      string browser = testContext.Properties["browser"] as string;
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
      Browser = new BrowserSession(sessionConfiguration);
    }
  }
}
