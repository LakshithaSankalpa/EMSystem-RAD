Imports System.Data.SqlClient
Public Class Salary
    Dim con As New SqlConnection("Data Source=DESKTOP-AORF3FN;Initial Catalog=EMS;Integrated Security=True")

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con.Open()
        Dim cmd As SqlCommand
        cmd = New SqlCommand("select * from Employee where EmpID='" & TextBox1.Text & "'", con)
        Dim myDataReader As SqlDataReader
        myDataReader = cmd.ExecuteReader
        myDataReader.Read()
        Label16.Text = myDataReader("EmpName")
        Label11.Text = myDataReader("EmpPosition")
        TextBox3.Text = myDataReader("EmpSalary")

        myDataReader.Close()
        MsgBox("Successfully Read")
        con.Close()

        con.Open()
        Dim mysql = "select EmpID,EmpName,EmpPosition,EmpSalary from Employee where EmpID='" & TextBox1.Text & "'"
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

    Public Sub clr()
        TextBox1.ResetText()
        Label16.ResetText()
        Label11.ResetText()
        TextBox3.ResetText()
        DataGridView1.ClearSelection()

    End Sub

    Private Sub ClearBTN_Click(sender As Object, e As EventArgs) Handles ClearBTN.Click
        clr()
    End Sub
End Class