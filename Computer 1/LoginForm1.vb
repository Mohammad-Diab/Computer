Public Class LoginForm1
    Dim go As Boolean = False
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub OK_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If UsernameTextBox.Text = "The Legend Mohammad" And PasswordTextBox.Text = "The Legend Mohammad" Then
            go = True
            Me.Close()
        Else
            If UsernameTextBox.Text = "" Or PasswordTextBox.Text = "" Then
                MsgBox("Enter Username and Password, then Click OK", MsgBoxStyle.Critical, "Computer")
            Else
                MsgBox("Wrong Username or password", MsgBoxStyle.Critical, "Computer")
            End If
        End If
    End Sub

    Private Sub Cancel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        End
    End Sub

    Private Sub LoginForm1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If (Not go) Then
            End
        End If
    End Sub
End Class
