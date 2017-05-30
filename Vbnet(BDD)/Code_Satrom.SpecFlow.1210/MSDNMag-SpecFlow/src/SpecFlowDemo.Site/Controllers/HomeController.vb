Imports System.Web.Mvc

Namespace SpecFlowDemo.Site.Controllers
    <HandleError()>
 Public Class HomeController
        Inherits Controller
        Public Function Index() As ActionResult
            ViewData("Message") = "Welcome to ASP.NET MVC!"

            Return View()
        End Function

        Public Function About() As ActionResult
            Return View()
        End Function
    End Class
End Namespace
