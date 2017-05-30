Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports TechTalk.SpecFlow
Imports WatiN.Core

Namespace SpecFlowDemo.AcceptanceTests.Steps
    <Binding()>
 Public Class LogOn
        <Given("I am logged into the site as an administrator")>
        Public Sub GivenIAmLoggedIntoTheSiteAsAnAdministrator()
            WebBrowser.Current.GoTo("http://localhost:3737/Account/LogOn")

            WebBrowser.Current.TextField(Find.ByName("UserName")).TypeText("admin")
            WebBrowser.Current.TextField(Find.ByName("Password")).TypeText("pass123")
            WebBrowser.Current.Button(Find.ByValue("Log On")).Click()

            Assert.IsTrue(WebBrowser.Current.Link(Find.ByText("Log Off")).Exists)
        End Sub
    End Class
End Namespace