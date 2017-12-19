Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports TechTalk.SpecFlow
Imports WatiN.Core
Imports Table = TechTalk.SpecFlow.Table

Namespace SpecFlowDemo.AcceptanceTests.Steps
    <Binding()>
 Public Class Register
        <[When]("I enter a random username")>
        Public Sub WhenIEnteraRandomUsername()
            Dim usernameField = WebBrowser.Current.TextField(Find.ByName("UserName"))

            If Not usernameField.Exists Then
                Assert.Fail(String.Format("Could not find {0} field on the page", usernameField))
            End If

            Dim randomUsername = Guid.NewGuid().ToString()

            usernameField.TypeText(randomUsername)
        End Sub

        <[When]("I complete the form with the following information:")>
        Public Sub WhenICompleteTheFormWithTheFollowingInformation(ByVal table As Table)
            For Each tableRow In table.Rows
                Dim field = WebBrowser.Current.TextField(Find.ByName(tableRow("Field")))

                If Not field.Exists Then
                    Assert.Fail(String.Format("Could not find {0} field on the page", field))
                End If

                field.TypeText(tableRow("Value"))
            Next tableRow
        End Sub

        <[Then]("I should see a link with the text ""(.*)"" on the page")>
        Public Sub ThenIShouldSeeTextOnThePage(ByVal linkText As String)
            Assert.IsTrue(WebBrowser.Current.Link(Find.ByText(linkText)).Exists, String.Format("The following link text was not found on the page: {0}", linkText))
        End Sub
    End Class
End Namespace
