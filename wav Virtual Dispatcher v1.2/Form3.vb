Imports System.ComponentModel

Public Class Form3mll

    Private Sub textboxX_leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AirlinetextBox4.Leave, CallsignTextBox6.Leave, FlightTextBox5.Leave, arrTextBox2.Leave, depTextBox1.Leave, TakeoffTextBox7.Leave, LandTextBox8.Leave, taxioutTextBox9.Leave, taxiinTextBox10.Leave, opeTextBox3.Leave, dteTextBox11.Leave, ettTextBox12.Leave, AIRTPORTextBox3.Leave, RouteTextBox2.Leave


        Dim tb As TextBox = sender
        tb.BackColor = Color.White
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form4.Show()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        End

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles fbc.Click
        Form5.Show()
        Me.Close()


    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11vatsim.Click
        Form6.Show()

    End Sub

    Private Sub ettTextBox12_Click(sender As Object, e As EventArgs) Handles ettTextBox12.Click

    End Sub

    Private Sub File1_Click(sender As Object, e As EventArgs) Handles exit1.Click
        End

    End Sub

    Private Sub CallsignTextBox6_TextChanged(sender As Object, e As EventArgs) Handles CallsignTextBox6.TextChanged


    End Sub

    Private Sub Save4_MouseEnter(sender As Object, e As EventArgs) Handles Save4.MouseEnter

    End Sub

    Private Sub Save4_Click(sender As Object, e As EventArgs) Handles Save4.Click
        SaveFileDialog1.ShowDialog()
        SaveFileDialog1.Title = "save text"
        SaveFileDialog1.InitialDirectory = "Documents"


        Dim location As String

        location = SaveFileDialog1.FileName

        'My.Computer.FileSystem.WriteAllText(location & ".txt", "" & RouteTextBox1.Text, True)

        Dim writer As New System.IO.StreamWriter(location & ".txt")
        writer.WriteLine(AirlinetextBox4.Text)
        writer.WriteLine(FlightTextBox5.Text)
        writer.WriteLine(CallsignTextBox6.Text)
        writer.WriteLine(RouteTextBox1.Text)
        writer.Close()
    End Sub

    Private Sub Open3_Click(sender As Object, e As EventArgs) Handles Open3.Click

        OpenFileDialog1.InitialDirectory = "Documents"
        OpenFileDialog1.Title = "open text files"
        OpenFileDialog1.ShowDialog()

        Dim openlocation As String

        openlocation = OpenFileDialog1.FileName

        Dim reader As New System.IO.StreamReader(openlocation)
        Dim str1, str2, str3, str4 As String
        str1 = reader.ReadLine()
        str2 = reader.ReadLine()
        str3 = reader.ReadLine()
        str4 = reader.ReadLine()
        reader.Close()
        AirlinetextBox4.Text = str1
        FlightTextBox5.Text = str2
        CallsignTextBox6.Text = str3
        RouteTextBox1.Text = str4







    End Sub

    Private Sub project_Click(sender As Object, e As EventArgs) Handles project.Click
        SaveFileDialog2.ShowDialog()
        SaveFileDialog2.Title = "save text"
        SaveFileDialog2.InitialDirectory = "Documents"



        Dim location As String

        location = SaveFileDialog1.FileName

        My.Computer.FileSystem.WriteAllText(location & ".pln", "" & RouteTextBox1.Text, True)
    End Sub

    Private Sub pmdg_Click(sender As Object, e As EventArgs) Handles pmdg.Click
        SaveFileDialog3.ShowDialog()
        SaveFileDialog3.Title = "save text"
        SaveFileDialog3.InitialDirectory = "Documents"
        Dim location As String

        location = SaveFileDialog1.FileName

        My.Computer.FileSystem.WriteAllText(location & ".txt", "" & RouteTextBox1.Text, True)
    End Sub

    Private Sub Buttonp3d_Click(sender As Object, e As EventArgs) Handles Buttonp3d.Click
        SaveFileDialog8.ShowDialog()
        SaveFileDialog8.Title = "save text"
        SaveFileDialog8.InitialDirectory = "Documents"
        Dim location As String

        location = SaveFileDialog1.FileName

        My.Computer.FileSystem.WriteAllText(location & ".txt", "" & RouteTextBox1.Text, True)
    End Sub

    Private Sub Button787_Click(sender As Object, e As EventArgs) Handles Button787.Click
        SaveFileDialog9.ShowDialog()
        SaveFileDialog4.Title = "save text"
        SaveFileDialog4.InitialDirectory = "Documents"
        Dim location As String

        location = SaveFileDialog1.FileName

        My.Computer.FileSystem.WriteAllText(location & ".txt", "" & RouteTextBox1.Text, True)
    End Sub

    Private Sub Button9787_Click(sender As Object, e As EventArgs) Handles Button9787.Click
        SaveFileDialog9.ShowDialog()
        SaveFileDialog9.Title = "save text"
        SaveFileDialog9.InitialDirectory = "Documents"
        Dim location As String

        location = SaveFileDialog1.FileName

        My.Computer.FileSystem.WriteAllText(location & ".txt", "" & RouteTextBox1.Text, True)

    End Sub

    Private Sub Buttonairbus_Click(sender As Object, e As EventArgs) Handles Buttonairbus.Click
        SaveFileDialog7.ShowDialog()
        SaveFileDialog7.Title = "save text"
        SaveFileDialog7.InitialDirectory = "Documents"
        Dim location As String

        location = SaveFileDialog1.FileName

        My.Computer.FileSystem.WriteAllText(location & ".txt", "" & RouteTextBox1.Text, True)

    End Sub

    Private Sub Button8airbus_Click(sender As Object, e As EventArgs) Handles Button8airbus.Click
        SaveFileDialog10.ShowDialog()
        SaveFileDialog10.Title = "save text"
        SaveFileDialog10.InitialDirectory = "Documents"
        Dim location As String

        location = SaveFileDialog1.FileName

        My.Computer.FileSystem.WriteAllText(location & ".txt", "" & RouteTextBox1.Text, True)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("wav-Virtual-Dispatcher-v1.0


        CONTACT US Wavuserhelpdesk@hotmail.com or go to
        www.willairwayvirtual34.com/It Help desk")

    End Sub

    Private Sub New2_Click(sender As Object, e As EventArgs) Handles New2.Click
        AirlinetextBox4.Clear()
    End Sub

    Private Sub Print5_Click(sender As Object, e As EventArgs) Handles Print5.Click
        PrintDialog1.Document = PrintDocument1
        PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
        PrintDialog1.AllowSomePages = True

        If PrintDialog1.ShowDialog = DialogResult.OK Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
            PrintDocument1.Print()


        End If
    End Sub
End Class