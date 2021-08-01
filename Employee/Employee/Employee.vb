Imports System.Data.SqlClient
Public Class Employee
    Dim con As New SqlConnection("Data Source=DESKTOP-AORF3FN;Initial Catalog=EMS;Integrated Security=True")

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Me.Hide()
    End Sub

    Private Sub ViewBTN_Click(sender As Object, e As EventArgs) Handles ViewBTN.Click
        con.Open()
        Dim cmd As SqlCommand
        cmd = New SqlCommand("select * from Employee where EmpID='" & EmpIDTB.Text & "'", con)
        Dim myDataReader As SqlDataReader
        myDataReader = cmd.ExecuteReader
        myDataReader.Read()
        EmpNameTB.Text = myDataReader("EmpName")
        EmpAddTB.Text = myDataReader("EmpAddress")
        GendCb.Text = myDataReader("EmpGender")
        PosCb.Text = myDataReader("EmpPosition")
        EmpPhoneTb.Text = myDataReader("EmpPhone")
        EmpEduCb.Text = myDataReader("EmpEdu")
        EmpSalTB.Text = myDataReader("EmpSalary")
        EmpDOB.Text = myDataReader("EmpDOB")

        myDataReader.Close()
        MsgBox("Successfully Read")
        con.Close()

        con.Open()
        Dim mysql = "select * from Employee where EmpID='" & EmpIDTB.Text & "'"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(mysql, con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim DataSet As DataSet
        DataSet = New DataSet
        adapter.Fill(DataSet)
        DataGridView1.DataSource = DataSet.Tables(0)
        con.Close()
    End Sub

    Private Sub AddBTN_Click(sender As Object, e As EventArgs) Handles AddBTN.Click
        con.Open()
        Dim cmd As SqlCommand
        cmd = New SqlCommand("insert into Employee values('" & EmpIDTB.Text & "','" & EmpNameTB.Text & "','" & EmpAddTB.Text & "','" & GendCb.Text & "','" & PosCb.Text & "','" & EmpPhoneTb.Text & "','" & EmpEduCb.Text & "','" & EmpDOB.Text & "','" & EmpSalTB.Text & "')", con)
        cmd.ExecuteNonQuery()
        MsgBox("Successfully Added")
        con.Close()
        GridObj()
        clr()
    End Sub
    Public Sub GridObj()
        con.Open()
        Dim mysql = "select * from Employee"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(mysql, con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim DataSet As DataSet
        DataSet = New DataSet
        adapter.Fill(DataSet)
        DataGridView1.DataSource = DataSet.Tables(0)
        con.Close()
    End Sub

    Private Sub EditeBTN_Click(sender As Object, e As EventArgs) Handles EditeBTN.Click
        con.Open()
        Dim cmd As SqlCommand
        cmd = New SqlCommand("update Employee set EmpName='" & EmpNameTB.Text & "',EmpAddress='" & EmpAddTB.Text & "',EmpGender='" & GendCb.Text & "',EmpPosition='" & PosCb.Text & "',EmpPhone='" & EmpPhoneTb.Text & "',EmpEdu='" & EmpEduCb.Text & "',EmpDOB='" & EmpDOB.Text & "',EmpSalary='" & EmpSalTB.Text & "'", con)
        cmd.ExecuteNonQuery()
        MsgBox("Successfully Updated")
        con.Close()
        GridObj()
        clr()
    End Sub

    Public Sub clr()
        EmpIDTB.Text = ""
        EmpNameTB.Text = ""
        EmpAddTB.Text = ""
        GendCb.Text = ""
        PosCb.Text = ""
        EmpPhoneTb.Text = ""
        EmpEduCb.Text = ""
        EmpSalTB.Text = ""
        EmpDOB.Text = ""
    End Sub

    Private Sub ClrBTN_Click(sender As Object, e As EventArgs) Handles ClrBTN.Click
        clr()
    End Sub

    Private Sub DeleteBTN_Click(sender As Object, e As EventArgs) Handles DeleteBTN.Click
        con.Open()
        Dim cmd As SqlCommand
        cmd = New SqlCommand("Delete from Employee where EmpID='" & EmpIDTB.Text & "'", con)
        cmd.ExecuteNonQuery()
        MsgBox("Successfully Deleted")
        con.Close()
        GridObj()
        clr()
    End Sub
End Class