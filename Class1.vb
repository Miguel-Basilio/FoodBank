Public Class addVolunteer
    Inherits Form2
    Dim Connection As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\FoodBank.mdb")
    Sub WriteToDB()



        Connection.Open()

        Dim command As New OleDb.OleDbCommand("Insert into Volunteers ([ID],[VolunteerName],[VolunteerAddress],[VolunteerPhoneNumber]) values
('" & Form2.txtID.Text & "','" & Form2.txtName.Text & "', '" & Form2.txtAddress.Text & "', " & Form2.txtPhoneNumber.Text & ")", Connection)

        command.ExecuteNonQuery()
        Connection.Close()
        MsgBox("Volunteer Successfully added to database", MsgBoxStyle.Information)

        Me.Hide()
        Form1.Visible = True
    End Sub




    Sub WriteToVisitors()


        Connection.Open()

        Dim command As New OleDb.OleDbCommand("Insert into peoplesTable ([FirstName],[LastName],[Address],[Children],[HouseholdQty]) values
('" & Form3.VisitorNametxt.Text & "','" & Form3.VisitorLastxt.Text & "', '" & Form3.VisitorAddresstxt.Text & "', '" & Form3.VisitorChildrenstxt.Text & "', " & Form3.VisitorHouseQtytxt.Text & ")", Connection)

        command.ExecuteNonQuery()
        Connection.Close()

        MsgBox("Volunteer Successfully added to database", MsgBoxStyle.Information)


    End Sub


End Class
