Public Class LoginForm1

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If UsernameTextBox.Text = "The Legend Mohammad" And PasswordTextBox.Text = "The Legend Mohammad" Then
            Me.Close()
        Else
            If UsernameTextBox.Text = "" Or PasswordTextBox.Text = "" Then
                MsgBox("Enter Username and Password then Click OK")
            Else
                MsgBox("Wrong Username or password")
            End If
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        End
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        End
    End Sub

    Private Sub ExitToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem2.Click
        End
    End Sub
End Class
