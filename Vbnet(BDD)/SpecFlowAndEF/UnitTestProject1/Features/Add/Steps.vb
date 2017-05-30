Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Repositories
Imports TechTalk.SpecFlow

Namespace UnitTestProject1.User_Stories.Add
  <Binding>
  Public Class Steps
	Private _newCustomer As Customer
	Private _repository As CustomerRepository

        <TechTalk.SpecFlow.Given("a user has entered information about a customer")>
        Public Sub GivenAUserHasEnteredInformationAboutACustomer()
            ' added manually
            _newCustomer = New Customer
        End Sub

        <TechTalk.SpecFlow.Given("she has provided a first name and a last name as required")>
        Public Sub GivenSheHasProvidedAFirstNameAndALastNameAsRequired()
            ' added manually
            _newCustomer.FirstName = "Julie"
            _newCustomer.LastName = "Lerman"
        End Sub

        'no more elaboration needed
        <TechTalk.SpecFlow.When("she completes entering more information")>
        Public Sub WhenSheCompletesEnteringMoreInformation()
        End Sub

        <TechTalk.SpecFlow.Then("that customer should be stored in the system")>
        Public Sub ThenThatCustomerShouldBeStoredInTheSystem()
            _repository = New CustomerRepository
            _repository.Add(_newCustomer)
            _repository.Save()
            Assert.IsNotNull(_newCustomer.Id > 0)
        End Sub

        <TechTalk.SpecFlow.Given("she has not provided both the firstname and lastname")>
        Public Sub GivenSheHasNotProvidedBothTheFirstnameAndLastname()
            'ScenarioContext.Current.Pending()
        End Sub

        <TechTalk.SpecFlow.Then("that user will get a message")>
        Public Sub ThenThatUserWillGetAMessage()
            'ScenarioContext.Current.Pending()
        End Sub

        <TechTalk.SpecFlow.Then("the customer will not be stored into the system")>
        Public Sub ThenTheCustomerWillNotBeStoredIntoTheSystem()
            'ScenarioContext.Current.Pending()
        End Sub
  End Class
End Namespace
