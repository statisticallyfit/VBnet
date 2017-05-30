Imports System
Imports System.Collections.Queue
Imports Windows.Forms

' Define a new queue
Dim q As New Queue()

' Queue up some items
q.Enqueue("Chopin")
q.Enqueue("Mozart")
q.Enqueue("Beethoven")
' Is an item in the queue?
MsgBox("Beethoven in queue: " & CStr(q.Contains("Beethoven")))
' Peek at the first item
MsgBox("First item in queue is: " & q.Peek.ToString)
' Send queue to an array and display all items
Dim s() As Object = q.ToArray()
Dim i As Integer
For i = 0 To UBound(s)
    Debug.WriteLine(CStr(s(i)))
Next
' Clear queue
q.Clear(  )
