Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FoodBankDataSet4.peoplesTable' table. You can move, or remove it, as needed.
        Me.PeoplesTableTableAdapter.Fill(Me.FoodBankDataSet4.peoplesTable)

        Dim user As String = Form1.txtName.Text

        Label6.Text = user

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles AddnewBt.Click


        addVolunteer.WriteToVisitors()
        Me.PeoplesTableTableAdapter.Fill(Me.FoodBankDataSet4.peoplesTable)



        WriteToFile.Saveit()
        VisitorNametxt.Clear()
        VisitorLastxt.Clear()
        VisitorAddresstxt.Clear()
        VisitorChildrenstxt.Clear()
        VisitorHouseQtytxt.Clear()
        VisitorNametxt.Focus()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Form1.Visible = True
        Form1.txtName.Clear()
        Form1.txtID.Clear()
        Form1.txtName.Focus()
    End Sub
End Class