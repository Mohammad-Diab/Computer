Public Class Login
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub OK_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If UsernameTextBox.Text = "The Legend Mohammad" And PasswordTextBox.Text = "The Legend Mohammad" Then
            Me.Close()
        Else
            If UsernameTextBox.Text = "" AndAlso PasswordTextBox.Text = "" Then
                MsgBox("أدخل اسم امستخدم وكلمة المرور ثم اضغط على 'ادخل'", MsgBoxStyle.Information)
            ElseIf UsernameTextBox.Text = "" Then
                MsgBox("أدخل اسم امستخدم ثم اضغط على 'ادخل'", MsgBoxStyle.Information)
            ElseIf PasswordTextBox.Text = "" Then
                MsgBox("أدخل كلمة المرور ثم اضغط على 'ادخل'", MsgBoxStyle.Information)
            ElseIf UsernameTextBox.Text = "The Legend Mohammad" Then
                MsgBox("كلمة المرور خاطئة", MsgBoxStyle.Critical)
                PasswordTextBox.Clear()
            ElseIf PasswordTextBox.Text = "The Legend Mohammad" Then
                MsgBox("اسم المستخدم خاطئ", MsgBoxStyle.Critical)
                UsernameTextBox.Clear()
            Else
                MsgBox("اسم المستخدم وكلمة المرور غير صحيحين", MsgBoxStyle.Critical)
                UsernameTextBox.Clear()
                PasswordTextBox.Clear()
            End If
        End If
    End Sub

    Private Sub Cancel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        End
    End Sub

End Class