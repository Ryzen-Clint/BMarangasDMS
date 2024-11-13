Public Class Clerk02frm
    Private Sub logoutfrm_Click(sender As Object, e As EventArgs) Handles logoutfrm.Click
        LoginForm.Show()
        Me.Close()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        LoginForm.Show()
        Me.Close()
    End Sub
End Class