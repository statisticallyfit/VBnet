Imports System.Text
Imports System.Web.Mvc
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports SpecFlowDemo.Site
Imports SpecFlowDemo.Site.Controllers

Namespace SpecFlowDemo.UnitTests.Controllers
	<TestClass> _
	Public Class HomeControllerTest
		<TestMethod> _
		Public Sub Index()
			' Arrange
			Dim controller As New HomeController()

			' Act
			Dim result As ViewResult = TryCast(controller.Index(), ViewResult)

			' Assert
			Dim viewData As ViewDataDictionary = result.ViewData
			Assert.AreEqual("Welcome to ASP.NET MVC!", viewData("Message"))
		End Sub

		<TestMethod> _
		Public Sub About()
			' Arrange
			Dim controller As New HomeController()

			' Act
			Dim result As ViewResult = TryCast(controller.About(), ViewResult)

			' Assert
			Assert.IsNotNull(result)
		End Sub
	End Class
End Namespace
