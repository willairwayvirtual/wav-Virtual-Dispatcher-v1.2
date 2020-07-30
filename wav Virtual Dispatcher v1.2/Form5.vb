Public Class Form5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3mll.Show()
        Me.Close()

    End Sub

    Private Sub Search_Click(sender As Object, e As EventArgs) Handles Search.Click
        CrystalReportViewer1.ReportSource = Application.StartupPath + "/CrystalReport1.rpt"
        CrystalReportViewer1.SelectionFormula = "{WavVirtDispatch.flight}= '" & TextBoxkeyword.Text.ToString() & "'"
        CrystalReportViewer1.Refresh()
        CrystalReportViewer1.RefreshReport()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form6.Show()

    End Sub
End Class