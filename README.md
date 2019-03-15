# SpecflowDemo
Demo-Specflow-Selenium-Shouldly-Pickle

Nuget required from Nuget.org

Using MSTEST

 MSTest.TestFramework
 MSTest.TestAdapter
 specflow
 specflow.MSTEST
 SpecFlow.Tools.MsBuild.Generation
 Shouldly
 
 Generate trx -
 Use VS2014 MSBUILD Command prompt
"%ProgramFiles(x86)%\Microsoft Visual Studio 14.0\Common7\IDE\mstest.exe" /testcontainer:CalculatorServiceTests.dll /resultsfile:TestResult.trx

in VS2017 use vstest.exe CalculatorServiceTests.dll /Logger:trx
VSTEST.exe 
 
 Document Generation - 
 Download pickle UI
 give feature folder path
 Give trx file path
 Select test result format MSTEST
 generate
 
 NUnit
Nuget required from Nuget.org
 NUnitTestAdapter
 NUnit3TestAdapter
 specflow
 specflow.Nunit
 Shouldly
 
 




Automation Test Nuget required from Nuget.org
 NUnitTestAdapter
 NUnit3TestAdapter
 specflow
 specflow.Nunit
 Shouldly
 Selenium.WebDriver
 Selenium.Chrome.WebDriver
