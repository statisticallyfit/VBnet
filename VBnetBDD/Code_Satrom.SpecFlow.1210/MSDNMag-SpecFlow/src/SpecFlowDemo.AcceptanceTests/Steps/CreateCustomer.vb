Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports TechTalk.SpecFlow
Imports WatiN.Core
Imports Table = TechTalk.SpecFlow.Table

Namespace SpecFlowDemo.AcceptanceTests.Steps
    <Binding()>
 Public Class CreateCustomer
        <[When]("I enter the following information")>
        Public Sub WhenIEnterTheFollowingInformation(ByVal table As Table)
            For Each tableRow In table.Rows
                Dim field = WebBrowser.Current.TextField(Find.ByName(tableRow("Field")))

                If Not field.Exists Then
                    Assert.Fail(String.Format("Could not find {0} field on the page", field))
                End If

                field.TypeText(tableRow("Value"))
            Next tableRow
        End Sub

        <[Then]("I should see the following details on the screen:")>
        Public Sub ThenIShouldSeeTheFollowingDetailsOnTheScreen(ByVal table As Table)
            For Each tableRow In table.Rows
                Dim value = tableRow("Value")

                Assert.IsTrue(WebBrowser.Current.ContainsText(value), String.Format("Could not find text '{0}' on the page", value))
            Next tableRow
        End Sub
    End Class
End Namespace
