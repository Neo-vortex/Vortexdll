Imports MessagePack
<MessagePackObject>
Public Class Vorlib
    <Key(0)>
    Public Overridable Property Files As New List(Of Byte())
    <Key(1)>
    Public Overridable Property Comment As String
    <Key(2)>
    Public Overridable Property Names As New List(Of String)
    <Key(3)>
    Public Overridable Property Formats As New List(Of String)

    Public Sub New()
    End Sub
End Class
