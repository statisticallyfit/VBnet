Imports SpecFlowDemo.Core.Models
Imports SpecFlowDemo.Core.Repositories

Namespace SpecFlowDemo.Infrastructure.Repositories
	Public Class CustomerRepository
        Implements ICustomerRepository

		Public Sub Create(ByVal customer As Customer) Implements ICustomerRepository.Create
			customer.Id = New Random().Next(1, 2500)
		End Sub
	End Class
End Namespace
