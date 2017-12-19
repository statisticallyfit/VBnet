' ------------------------------------------------------------------------------
'  <auto-generated>
'      This code was generated by SpecFlow (http://www.specflow.org/).
'      SpecFlow Version:1.3.5.2
'      Runtime Version:4.0.30319.1
' 
'      Changes to this file may cause incorrect behavior and will be lost if
'      the code is regenerated.
'  </auto-generated>
' ------------------------------------------------------------------------------
#Region "Designer generated code"
Imports TechTalk.SpecFlow

Namespace SpecFlowDemo.AcceptanceTests.Features


    <System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.3.5.2"),
    System.Runtime.CompilerServices.CompilerGeneratedAttribute(),
    Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()>
    Partial Public Class CreateANewCustomerFeature

        Private Shared testRunner As TechTalk.SpecFlow.ITestRunner

        <Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()>
        Public Shared Sub FeatureSetup(ByVal testContext As Microsoft.VisualStudio.TestTools.UnitTesting.TestContext)
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner()
            Dim featureInfo As New TechTalk.SpecFlow.FeatureInfo(
                New System.Globalization.CultureInfo("en-US"),
                "Create a new customer",
                "In order to manage customers in my system" & vbCrLf &
                "As a site administrator" & vbCrLf &
                "I want to be " & "able to create, view and manage customer records",
                (CType(Nothing, String())))
            testRunner.OnFeatureStart(featureInfo)
        End Sub

        <Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()>
        Public Shared Sub FeatureTearDown()
            testRunner.OnFeatureEnd()
            testRunner = Nothing
        End Sub

        Public Overridable Sub ScenarioSetup(ByVal scenarioInfo As TechTalk.SpecFlow.ScenarioInfo)
            testRunner.OnScenarioStart(scenarioInfo)
        End Sub

        <Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()>
        Public Overridable Sub ScenarioTearDown()
            testRunner.OnScenarioEnd()
        End Sub

        <Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute(),
        Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Create a basic customer record"),
        Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Create a new customer")>
        Public Overridable Sub CreateABasicCustomerRecord()
            Dim scenarioInfo As New TechTalk.SpecFlow.ScenarioInfo("Create a basic customer record",
                                                                   (CType(Nothing, String())))

            Me.ScenarioSetup(scenarioInfo)

            testRunner.Given("I am logged into the site as an administrator")

            testRunner.When("I click the ""Create New Customer"" link")

            Dim table1 As New TechTalk.SpecFlow.Table(New String() {"Field", "Value"})
            table1.AddRow(New String() {"Name", "Hugo Reyes"})
            table1.AddRow(New String() {"Email", "hreyes@dharmainitiative.com"})
            table1.AddRow(New String() {"Phone", "720-123-5477"})

            testRunner.And("I enter the following information", (CStr(Nothing)), table1)

            testRunner.And("I click the ""Create"" button")

            Dim table2 As New TechTalk.SpecFlow.Table(New String() {"Value"})
            table2.AddRow(New String() {"Hugo Reyes"})
            table2.AddRow(New String() {"hreyes@dharmainitiative.com"})
            table2.AddRow(New String() {"720-123-5477"})

            testRunner.Then("I should see the following details on the screen:", (CStr(Nothing)), table2)

            testRunner.CollectScenarioErrors()
        End Sub
    End Class
End Namespace
#End Region