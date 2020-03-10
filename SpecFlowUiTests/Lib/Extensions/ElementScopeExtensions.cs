using Coypu;

namespace UiTest.Lib.Extensions
{
  public static class ElementScopeExtensions
  {
    public static ElementScopeAssertions Should(this ElementScope instance)
    {
      return new ElementScopeAssertions(instance);
    }
  }
}
