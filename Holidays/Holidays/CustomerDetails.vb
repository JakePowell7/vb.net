Imports System.IO
Public Class CustomerDetails

    Private Function Wipe()
        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtEmail.Text = ""
    End Function

    Private Sub CustomerDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtID.Enabled = False

        If Not System.IO.File.Exists("customerdetails.txt") Then
            System.IO.File.WriteAllText("customerdetails.txt", vbNewLine & " ")
        End If

        Dim LinesRead As String() = File.ReadAllLines(Dir("customerdetails.txt"))
        txtID.Text = Val(Mid(LinesRead.Last, 1, 3)) + 1

    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click

        If txtFirstName.Text = "" Then
            MessageBox.Show("Please enter your first name.")
            Wipe() : Exit Sub
        ElseIf txtFirstName.TextLength > 10 Then
            MessageBox.Show("Please make sure your name is equal or less than 10 characters.")
            Wipe() : Exit Sub
        ElseIf txtLastName.Text = "" Then
            MessageBox.Show("Please enter your last name.")
            Wipe() : Exit Sub
        ElseIf txtLastName.TextLength > 15 Then
            MessageBox.Show("Please make sure your name is equal or less than 15 characters.")
            Wipe() : Exit Sub
        ElseIf txtEmail.Text = "" Then
            MessageBox.Show("Please enter your Email address.")
            Wipe() : Exit Sub
        ElseIf txtEmail.TextLength > 25 Then
            MessageBox.Show("Please make sure your Email is equal or less than 25 characters.")
            Wipe() : Exit Sub
        Else
            Dim LinesRead As String() = File.ReadAllLines(Dir("customerdetails.txt"))
            Dim ID As Integer
            ID = Val(Mid(LinesRead.Last, 1, 7))

            Dim CustomerData As New System.IO.StreamWriter(Dir("customerdetails.txt"), True)
            Dim FirstName As String = LSet(txtFirstName.Text, 10)
            Dim LastName As String = LSet(txtLastName.Text, 15)
            Dim Email As String = LSet(txtEmail.Text, 25)
            ID = LSet(Str(ID), 7)
            CustomerData.WriteLine(vbNewLine & ID & FirstName & LastName & Email & dtpDateOfBirth.Text)
            CustomerData.Close()
            Wipe()
            txtID.Text = Val(Mid(LinesRead.Last, 1, 3)) + 1

        End If

    End Sub
End Class