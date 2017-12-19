Imports TechTalk.SpecFlow
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports Microsoft.VisualStudio.TestTools.UnitTesting

Namespace UnitTestProject1.User_Stories.Add
    '<Binding>
    Public Class Steps
        <TechTalk.SpecFlow.Given("the user has inputted a score")> _
        Public Sub GivenTheUserHasInputtedAScore()
            Dim newScoreAsPercentage As Integer
            newScoreAsPercentage = 95
        End Sub

        <TechTalk.SpecFlow.Then("show user the average")> _
        Public Sub ThenShowUserTheAverage()
            Console.WriteLine("Current average: ")
        End Sub

        <TechTalk.SpecFlow.Then("return letter-grade feedback to user")> _
        Public Sub ThenReturnLetter_GradeFeedbackToUser()
            ScenarioContext.Current.Pending()
        End Sub

        <TechTalk.SpecFlow.Given("the user has given input")> _
        Public Sub GivenTheUserHasGivenInput()
            ScenarioContext.Current.Pending()
        End Sub

        <TechTalk.SpecFlow.Given("the input is not a score")> _
        Public Sub GivenTheInputIsNotAScore()
            ScenarioContext.Current.Pending()
        End Sub

        <TechTalk.SpecFlow.Then("throw exception")> _
        Public Sub ThenThrowException()
            ScenarioContext.Current.Pending()
        End Sub
    End Class
End Namespace
