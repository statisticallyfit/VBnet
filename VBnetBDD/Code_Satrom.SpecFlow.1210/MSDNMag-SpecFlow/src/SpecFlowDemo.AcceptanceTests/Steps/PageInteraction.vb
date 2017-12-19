Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports TechTalk.SpecFlow
Imports WatiN.Core

Namespace SpecFlowDemo.AcceptanceTests.Steps
    <Binding()>
 Public Class PageInteraction
        <[When]("I click the ""(.*)"" link")>
        Public Sub WhenIClickALinkNamed(ByVal linkName As String)
            Dim link = WebBrowser.Current.Link(Find.ByText(linkName))

            If Not link.Exists Then
                Assert.Fail(String.Format("Could not find {0} link on the page", linkName))
            End If

            link.Click()
        End Sub

        <[When]("I click the ""(.*)"" button")>
        Public Sub WhenIClickAButtonWithValue(ByVal buttonValue As String)
            Dim button = WebBrowser.Current.Button(Find.ByValue(buttonValue))

            If Not button.Exists Then
                Assert.Fail(String.Format("Could not find {0} button on the page", buttonValue))
            End If

            button.Click()
        End Sub
    End Class
End Namespace