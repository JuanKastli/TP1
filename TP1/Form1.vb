Public Class Form1

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not e.KeyChar = "/" And Not e.KeyChar = " " And Not e.KeyChar = "." And Not e.KeyChar = "-" And Not e.KeyChar = "." And Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            Exit Sub
        End If
        Dim pos As Integer = TextBox1.SelectionStart
        If e.KeyChar = "/" And pos <> 2 And pos <> 5 Then
            e.Handled = False
        End If

        If Char.IsNumber(e.KeyChar) And (pos = 2 Or pos = 5) Then
            e.Handled = True
            Exit Sub
        End If

        If e.KeyChar = "." Then
            SendKeys.Send("/")
            e.Handled = True
        End If
        If e.KeyChar = " " Then
            SendKeys.Send("/")
            e.Handled = True
        End If
        If e.KeyChar = "-" Then
            SendKeys.Send("/")
            e.Handled = True
        End If
        If e.KeyChar = "_" Then
            SendKeys.Send("/")
            e.Handled = True
        End If
    End Sub
End Class
