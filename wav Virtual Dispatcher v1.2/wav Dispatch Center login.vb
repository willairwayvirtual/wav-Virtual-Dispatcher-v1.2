Imports System.Data.OleDb
Public Class Form2
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection
    Dim conn As OleDbConnection = New OleDbConnection

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        myConnection.Close()
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        'Change the following to your access database location
        dataFile = "C:\VisStudioProj\wav web\willairwayvirtual34\willairwayvirtual34\app_data\willairwayvirtualDBv1.accdb"
        connString = provider & dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()
        'the query:
        Dim cmd As OleDbCommand = New OleDbCommand("Select * FROM [tblaccessinfo] WHERE [Uname] = '" & txtUsername.Text & "' AND [Pword] = '" & txtPassword.Text & "'", myConnection)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        ' the following variable is hold true if user is found, and false if user is not found 
        Dim userFound As Boolean = False
        ' the following variables will hold the user first and last name if found.
        Dim FirstName As String = ""
        Dim LastName As String = ""
        Dim Status As String = ""
        Dim totalHours As String = ""
        Dim lastflight As String = ""

        'if found:
        While dr.Read
            userFound = True
            FirstName = dr("FName").ToString
            LastName = dr("LName").ToString
            Status = dr("status").ToString
            totalHours = dr("TotalHours").ToString
            lastflight = dr("lastflight").ToString


        End While

        'checking the result
        If userFound = True Then

            Dim obj As New Form3mll

            obj.Show()


            obj.Show()
            Me.Close()
        Else
            MsgBox("YOU DONT EXIST", MsgBoxStyle.OkOnly, "YOU DONT EXIST")
        End If
        myConnection.Close()
    End Sub

End Class