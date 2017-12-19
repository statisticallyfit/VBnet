Imports TechTalk.SpecFlow
Imports WatiN.Core

Namespace SpecFlowDemo.AcceptanceTests
	Public NotInheritable Class WebBrowser
		Private Sub New()
		End Sub
		Public Shared ReadOnly Property Current() As IE
			Get
				If Not ScenarioContext.Current.ContainsKey("browser") Then
					ScenarioContext.Current("browser") = New IE()
				End If
				Return TryCast(ScenarioContext.Current("browser"), IE)
			End Get
		End Property
	End Class
End Namespace
