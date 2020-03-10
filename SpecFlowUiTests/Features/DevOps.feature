Feature: Dev Ops

  IntegrationQA should know about Dev Ops so they can help companies to bridge the gap between
  development and operations

  @UI
  Scenario: Find Dev Ops blog
    Given I am on the IntegrationQA blog page
    When I search for 'Dev Ops'
    Then a result is returned

  Scenario: Find automated testing
    Given I am on the IntegrationQA blog page
    When I search for 'Automated Testing'
    Then a result is returned