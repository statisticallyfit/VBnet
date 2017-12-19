Imports TechTalk.SpecFlow

Namespace SpecFlowDemo.AcceptanceTests.Steps
    <Binding()>
 Public Class SiteNavigation
        <Given("I am on the site home page")>
        Public Sub GivenIAmOnTheSiteHomePage()
            WebBrowser.Current.GoTo("http://localhost:3737")
        End Sub
    End Class
End Namespace