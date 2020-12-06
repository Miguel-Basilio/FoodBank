Imports System.Data.OleDb
Imports System.Data

Public Class Form1

    Dim Connection As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\FoodBank.mdb")

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Hide()
        Form2.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles LogInButton.Click, txtName.Click

        If txtID.TextLength = Nothing Or txtID.Text = Nothing Then
            MessageBox.Show("Enter ID")
        Else
            If Connection.State = ConnectionState.Closed Then
                Connection.Open()
            End If

            Dim cmd As New OleDbCommand("Select count(*) from Volunteers where ID=? and VolunteerName=?", Connection)
            cmd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = txtID.Text
            cmd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = txtName.Text

            Dim count = Convert.ToInt32(cmd.ExecuteScalar())

            If (count > 0) Then
                MsgBox("Login Succeed", MsgBoxStyle.Information)
                Me.Hide()
                Form3.Visible = True
            Else
                MsgBox("Account not Found check Credentials", MsgBoxStyle.Critical)
            End If



        End If
    End Sub
End Class
