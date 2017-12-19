Imports System.Text
Imports System.Threading.Tasks
Imports DataLayer
Imports UnitTestProject1.User_Stories.Add

Namespace Repositories
Public Class CustomerRepository
  Private _context As New CustomerContext

  Public Sub Add(ByVal customer As Customer)
	_context.Customers.Add(customer)
  End Sub

  Public Function Save() As Integer
	Return _context.SaveChanges
  End Function

  Public Function FindById(ByVal id As Integer) As Customer
	Return _context.Customers.Find(id)
  End Function
End Class
End Namespace
