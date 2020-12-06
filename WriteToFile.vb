Public Class WriteToFile

    Inherits Form3

    Sub Saveit()
        Dim VisitorName As String = Form3.VisitorNametxt.Text
        Dim VisitorLAstName As String = Form3.VisitorLastxt.Text
        Dim VisitorAddress As String = Form3.VisitorAddresstxt.Text
        Dim VisitorChildren As Decimal = Form3.VisitorChildrenstxt.Text
        Dim VisitorHousholdQty As Decimal = Form3.VisitorHouseQtytxt.Text


        Dim location As String = "C:\Users\angel\Desktop\Visitors.txt"

        Try
            Dim FileWrite As IO.StreamWriter = IO.File.AppendText(location)
            FileWrite.WriteLine("Name " & VisitorName)
            FileWrite.WriteLine("Last name: " & VisitorLAstName)
            FileWrite.WriteLine("Address: " & VisitorAddress)
            FileWrite.WriteLine("Children: " & VisitorChildren)
            FileWrite.WriteLine("Quantity of persons on houshold: " & VisitorHousholdQty)
            FileWrite.WriteLine("--------------------------")
            FileWrite.Close()
            MessageBox.Show("Recorded")
        Catch ex As Exception
            MessageBox.Show("Error")
        End Try

    End Sub




End Class
