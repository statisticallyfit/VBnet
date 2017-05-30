Imports System.Data.Entity
Imports System.Text
Imports System.Threading.Tasks
Imports UnitTestProject1.User_Stories.Add

Namespace DataLayer
   Public Class CustomerContext
	   Inherits DbContext

		Public Property Customers As DbSet(Of Customer)
   End Class
End Namespace
