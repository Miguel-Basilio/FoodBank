Public Class Form2





    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles GoBckLabel.Click
        Me.Hide()
        Form1.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles EnrollBtn.Click
        addVolunteer.WriteToDB()
        Me.Hide()
        Form1.Visible = True

    End Sub

End Class