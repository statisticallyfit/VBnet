' -----------------------------------------------------------------------
' <copyright file="MastercamVBNETHook1.vb" company="">
' TODO: Update copyright text.
' </copyright>
' -----------------------------------------------------------------------

Imports Mastercam.App
Imports Mastercam.App.Types

Namespace MastercamVBNETHook1

    ''' <summary>
    ''' This is the class that represents our NetHook App. It's set up by deriving from the NetHook3App class OR
    ''' by creating a class that implements the INetHook3App interface. For the sake of simplicity, we'll start
    ''' with the derivation method. When Mastercam goes to run a NetHook app it will look for a class in your
    ''' .dll of the NetHook3App class type, so deriving from it makes it the class that Mastercam will load and run.
    ''' </summary>
    ''' <remarks></remarks>
    Public Class NETHookMain
        Inherits NetHook3App

#Region "System Public Methods"

        ''' <summary>
        ''' This method is the first one run by Mastercam when it loads your NetHook app. It's designed to handle all
        ''' of the initialization stuff your app may need. If you decide you don't need any initialization it's
        ''' perfectly fine to not override this method and just delete the following method declaration. 
        ''' </summary>
        ''' <param name="param">Parameter is not used</param>
        ''' <returns>A <c>MCamReturn</c> return type.</returns>
        ''' <remarks></remarks>
        Public Overrides Function Init(ByVal param As Integer) As MCamReturn
            Return MCamReturn.NoErrors
        End Function

        ''' <summary>
        ''' This method is designed to be the main entry point for your NetHook app. This is where your app should do
        ''' all of the things it's supposed to do and then return an MCamReturn value representing the outcome of your
        '''  NetHook application. 
        ''' </summary>
        ''' <param name="param">Parameter is not used</param>
        ''' <returns>A <c>MCamReturn</c> return type.</returns>
        ''' <remarks></remarks>
        Public Overrides Function Run(ByVal param As Integer) As MCamReturn
            Return MCamReturn.NoErrors
        End Function

        ''' <summary>
        ''' This is the method called when your application has ended it's execution loop and is getting ready to
        ''' close. This method is where you would want to put any cleanup code or special closing functionality.
        ''' Just like the Init method, this is also optional and can be omitted if you don't need to do anything on closing. 
        ''' </summary>
        ''' <param name="param">Parameter is not used</param>
        ''' <returns>A <c>MCamReturn</c> return type.</returns>
        ''' <remarks></remarks>
        Public Overrides Function Close(ByVal param As Integer) As MCamReturn
            Return MCamReturn.NoErrors
        End Function

        ''' <summary>
        ''' This method is used to handle notification messages from the main Mastercam app to your NetHook
        ''' application. This could allow you to include special handling of certain notification messages, such as
        ''' graphical repaints or file changes. Just like the Close and Init methods, this is entirely optional
        ''' and probably should only be used if you're very comfortable with the Mastercam messaging system and
        ''' want to do some very advanced application programming.
        ''' </summary>
        ''' <param name="event_code">The <c>MCamEvent</c> type that was raised.</param>
        ''' <returns>A <c>MCamReturn</c> return type.</returns>
        ''' <remarks></remarks>
        Public Overrides Function Notify(ByVal event_code As MCamEvent) As MCamReturn
            Return MCamReturn.NoErrors
        End Function

#End Region

#Region "User Public Methods"

        '''-------------------------------------------------------------------------------------------------
        ''' <summary> User created function defined in the FT file that can be associated with a toolbar button </summary>
        ''' <param name="param">    Parameter is not used. </param>
        ''' <returns>A <c>MCamReturn</c> return type.</returns>
        '''  <remarks>Rename this function to match your function defined in your FT file or delete if not using anything other than the system Run method.</remarks>
        '''-------------------------------------------------------------------------------------------------
        Public Function MyCustomFunction(ByVal param As Integer) As MCamReturn
            Return MCamReturn.NoErrors
        End Function

#End Region

    End Class
End Namespace