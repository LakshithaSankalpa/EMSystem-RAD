Imports System.Data.SqlClient
Public Class Details
    Dim con As New SqlConnection("Data Source=DESKTOP-AORF3FN;Initial Catalog=EMS;Integrated Security=True")

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click
        Me.Hide()
    End Sub

    Private Sub ViewBTN_Click(sender As Object, e As EventArgs) Handles ViewBTN.Click
        con.Open()
        Dim cmd As SqlCommand
        cmd = New SqlCommand("select * from Employee where EmpID='" & EmpIDTB.Text & "'", con)
        Dim myDataReader As SqlDataReader
        myDataReader = cmd.ExecuteReader
        myDataReader.Read()
        EmpNamelbl.Text = myDataReader("EmpName")
        EmpAddlbl.Text = myDataReader("EmpAddress")
        EmpGender.Text = myDataReader("EmpGender")
        EmpPoselbl.Text = myDataReader("EmpPosition")
        EmpPhone.Text = myDataReader("EmpPhone")
        EmpEdulbl.Text = myDataReader("EmpEdu")
        EmpDoblbl.Text = myDataReader("EmpDOB")

        myDataReader.Close()
        MsgBox("Successfully View")
        con.Close()
    End Sub

    Public Sub clr()
        EmpNamelbl.Text = "EmpName"
        EmpAddlbl.Text = "EmpAddress"
        EmpGender.Text = "EmpGender"
        EmpPoselbl.Text = "EmpPosition"
        EmpPhone.Text = "EmpPhone"
        EmpEdulbl.Text = "EmpEdu"
        EmpDoblbl.Text = "EmpDOB"
        EmpIDTB.ResetText()
    End Sub

    Private Sub clrBTN_Click(sender As Object, e As EventArgs) Handles clrBTN.Click
        clr()
    End Sub
End Class