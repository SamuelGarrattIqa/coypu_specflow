using Coypu;
using FluentAssertions;
using FluentAssertions.Execution;
using FluentAssertions.Primitives;

namespace UiTest.Lib.Extensions
{
  public class ElementScopeAssertions : ReferenceTypeAssertions<ElementScope, ElementScopeAssertions>
  {
    public ElementScopeAssertions(ElementScope instance)
    {
      Subject = instance;
    }

    protected override string Identifier => "ElementScope";

    public AndConstraint<ElementScopeAssertions> Exist(string because = "", params object[] becauseArgs)
    {
      Execute.Assertion
        .BecauseOf(because, becauseArgs)
        .ForCondition(Subject.Exists())
        .FailWith($"Element {Subject.Name} not found. Reason: {because}"); // TODO: Get this to work

      return new AndConstraint<ElementScopeAssertions>(this);
    }

    public AndConstraint<ElementScopeAssertions> HaveInnerText(string content, string because = "", params object[] becauseArgs)
    {
      Execute.Assertion
        .BecauseOf(because, becauseArgs)
        .ForCondition(Subject.InnerHTML.Contains(content))
        .FailWith($"Expected content '{content}' to be in element with HTML '{Subject.InnerHTML}' but was not. Reason: {because}");
      return new AndConstraint<ElementScopeAssertions>(this);
    }
  }
}
