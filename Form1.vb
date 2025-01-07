Imports LuaInterface

Public Class Form1

    Public luascripting As New Lua()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim luaScript As String = TextBox1.Text

        Console.WriteLine("Code: " & luaScript)
        luascripting.DoString(luaScript)
    End Sub
End Class