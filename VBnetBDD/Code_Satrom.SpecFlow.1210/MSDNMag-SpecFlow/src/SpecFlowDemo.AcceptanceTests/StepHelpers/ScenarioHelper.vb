Imports TechTalk.SpecFlow
Imports WatiN.Core

Namespace SpecFlowDemo.AcceptanceTests.StepHelpers
    <Binding()>
 Public Class ScenarioHelper
        <AfterScenario()>
        Public Shared Sub Close()
            Dim link = WebBrowser.Current.Link(Find.ByText("Log Off"))

            If link.Exists Then
                link.Click()
            End If

            If ScenarioContext.Current.ContainsKey("browser") Then
                WebBrowser.Current.Close()
            End If
        End Sub
    End Class
End Namespace