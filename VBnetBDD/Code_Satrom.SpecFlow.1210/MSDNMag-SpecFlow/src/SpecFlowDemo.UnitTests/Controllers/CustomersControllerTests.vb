Imports System.Web.Mvc
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports SpecFlowDemo.Core.Models
Imports SpecFlowDemo.Site.Controllers

Namespace SpecFlowDemo.UnitTests.Controllers
	<TestClass> _
	Public Class CustomersControllerTests
		<TestMethod> _
		Public Sub GetCreateShouldReturnCustomerView()
			Dim customersController = New CustomersController()
			Dim result = TryCast(customersController.Create(), ViewResult)

			Assert.AreEqual("Create", result.ViewName)
			Assert.IsInstanceOfType(result.ViewData.Model, GetType(Customer))
		End Sub

		<TestMethod> _
		Public Sub PostCreateShouldSaveCustomerAndReturnDetailsView()
			Dim customersController = New CustomersController()
			Dim customer = New Customer With {.Name = "Hugo Reyes", .Email = "hreyes@dharmainitiative.com", .Phone = "720-123-5477"}

			Dim result = TryCast(customersController.Create(customer), ViewResult)

			Assert.IsNotNull(result)
			Assert.AreEqual("Details", result.ViewName)
			Assert.IsInstanceOfType(result.ViewData.Model, GetType(Customer))

			customer = TryCast(result.ViewData.Model, Customer)
			Assert.IsNotNull(customer)
			Assert.IsTrue(customer.Id > 0)
		End Sub
	End Class
End Namespace
