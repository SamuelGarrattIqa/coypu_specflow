using Coypu;

namespace UiTest.Lib.PageObjects
{
  public abstract class BasePage
  {
    public BrowserSession Browser;

    public BasePage(BrowserSession browser)
    {
      Browser = browser;
    }

    /// <summary>
    /// Find an element on the page with this id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    protected ElementScope FindId(string id)
    {
      return Browser.FindId(id);
    }

    /// <summary>
    /// Find a field using the provided identifier
    /// </summary>
    /// <param name="identifier"></param>
    /// <returns></returns>
    protected ElementScope Field(string identifier)
    {
      return Browser.FindField(identifier);
    }
  }
}
