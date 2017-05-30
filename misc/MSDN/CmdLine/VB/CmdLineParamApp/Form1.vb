''' <summary>
''' Sample Application to read Command Line Parameters 
''' </summary>
''' <remarks></remarks>
Public Class Form1

    ''' <summary>
    ''' Command Line Parameter 1 
    ''' </summary>
    ''' <remarks></remarks>
    Private param1 As String

    ''' <summary>
    ''' Command Line Parameter 2
    ''' </summary>
    ''' <remarks></remarks>
    Private param2 As String

    ''' <summary>
    ''' Defualt Constructor
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    ''' <summary>
    ''' Form Load Event Handler
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        '-----------------------------------------------------------------------------------------
        ' Environment.GetCommandLineArgs()
        ' -  An array of string where each element contains a command-line argument. 
        ' -  The first element is the executable file name
        ' -  and the following zero or more elements contain the remaining command-line arguments.
        '-----------------------------------------------------------------------------------------

        ' Retrieve & Store the Command Line Parameters 
        Dim cmdLineParams As String() = Environment.GetCommandLineArgs()

        ' Check for command Line Parameter (if any)  
        If cmdLineParams.Length > 2 Then

            Me.param1 = cmdLineParams(1)
            Me.param2 = cmdLineParams(2)

            ' Check Input Parameter for null/empty/white-space characters 
            If String.IsNullOrWhiteSpace(param1) Then
                MessageBox.Show("Parameter 1 Invalid", "Command Line Parameter", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            If String.IsNullOrWhiteSpace(param2) Then
                MessageBox.Show("Parameter 2 Invalid", "Command Line Parameter", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Else

            MessageBox.Show("Optional Input Parameters", "Command Line Parameter", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

End Class
