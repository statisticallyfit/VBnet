Imports System.Web.Mvc
Imports SpecFlowDemo.Core.Models
Imports SpecFlowDemo.Core.Repositories
Imports SpecFlowDemo.Infrastructure.Repositories

Namespace SpecFlowDemo.Site.Controllers
	Public Class CustomersController
		Inherits Controller
		Private _repository As ICustomerRepository

		Public Sub New()
			_repository = New CustomerRepository()
		End Sub

		Public Function Create() As ActionResult
			Return View("Create", New Customer())
		End Function

        <AcceptVerbs(HttpVerbs.Post)>
        Public Function Create(ByVal customer As Customer) As ActionResult
            _repository.Create(customer)

            Return View("Details", customer)
        End Function
	End Class
End Namespace
