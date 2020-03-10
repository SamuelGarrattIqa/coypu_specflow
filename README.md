# NAIT UI automation suite.

This designed as an base for creating a UI test using SpecFlow and Coypu.

This project uses C# to drive UI and automation tests to verify that NAIT is working as expected.
[SpecFlow](https://specflow.org/) is used to describe the tests using Gherkin syntax.

# Initial Setup

Visual Studio will need to be installed. You can install it from [here](https://visualstudio.microsoft.com/downloads/)

## Build solution

Open the solution file (.sln) in this folder and within Visual Studio build the solution.

# Dependencies

* [Coypu](https://github.com/featurist/coypu)
* [SpecFlow](https://specflow.org/)
* [MsTest](https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-mstest)

# Running tests via command line

`dotnet test -s test.runsettings`

where the runsettings file matches the location of a file which would vary according to environment. 
For example, for a dev environment the file would be `dev.runsettings`.

# Running via Visual Studio

* Select the runsettings file desired by selecting `Test->Select Settings file` from the menu bar (This may be within a global settings sub menu.)
* View all tests `Test->Test Explorer`
* Run tests by right clicking on an individual scenario or feature and selecting `Run`

# Visual Studio extension

Download [SpecFlow Visual Studio extension](https://marketplace.visualstudio.com/items?itemName=TechTalkSpecFlowTeam.SpecFlowForVisualStudio) 
and double click on it to install it. 

# Run test

## Namespace has PROJECTNAME/FOLDERNAMES

> filter is Namespace.FeatureName.ScenarioName

## Individual test
dotnet test --filter "SpecFlowUiTests.Features.DevOpsFeature.FindDevOpsBlog"

## Individual Features
dotnet test --filter "SpecFlowUiTests.Features.DevOpsFeature"

# Foldername
dotnet test --filter "SpecFlowUiTests.Features.SubFolder"