Imports System.ComponentModel

Public Class Form3mll
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
        Dim location As String

        location = SaveFileDialog1.FileName

        My.Computer.FileSystem.WriteAllText(location & ".txt", "" & RouteTextBox1.Text, True)
    End Sub



End Class