Imports System.Data.OleDb
Public Class Form2
    Public Property stringtext1 As String
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim conn As OleDbConnection = New OleDbConnection

    ' pl1 = panel4 height
    Dim pl1 As Integer = 30
    ' pl2 = panel3 height
    Dim pl2 As Integer = 30
    ' pl3 = panel1 height
    Dim pl3 As Integer = 30
    ' pl4 = panel2 height
    Dim pl4 As Integer = 30
    ' pl5 = panel6 height
    Dim pl5 As Integer = 30
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button72.Click
        Form3.Show()
        Me.Close()


    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        ' 250 = panel height
        If pl1 > 90 Then

            Timer1.Stop()

        Else
            Me.Panel4.Size = New Size(Me.Panel4.Size.Width, pl1)
            pl1 += 17
        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        ' 250 = panel height
        If pl2 > 90 Then

            Timer2.Stop()

        Else
            Me.Panel3.Size = New Size(Me.Panel3.Size.Width, pl2)
            pl2 += 17
        End If

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick

        ' 250 = panel height
        If pl3 > 90 Then

            Timer3.Stop()

        Else
            Me.Panel2.Size = New Size(Me.Panel2.Size.Width, pl3)
            pl3 += 17
        End If

    End Sub
    Private Sub Timer4_tick(sender As Object, e As EventArgs) Handles Timer4.Tick

        ' 250 = panel height
        If pl4 > 90 Then

            Timer4.Stop()

        Else
            Me.Panel1.Size = New Size(Me.Panel1.Size.Width, pl4)
            pl4 += 17
        End If
    End Sub
    Private Sub Timer5_tick(sender As Object, e As EventArgs) Handles Timer5.Tick

        ' 250 = panel height
        If pl5 > 120 Then

            Timer5.Stop()

        Else
            Me.Panel6.Size = New Size(Me.Panel6.Size.Width, pl5)
            pl5 += 17
        End If

    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        Form4.Show()
        Me.Close()

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub flightinfo_MouseMove(sender As Object, e As MouseEventArgs) Handles flightinfo.MouseMove
        Me.Panel1.Size = New Size(Me.Panel1.Size.Width, pl4)
        Me.Panel2.Size = New Size(Me.Panel2.Size.Width, pl3)
        Me.Panel3.Size = New Size(Me.Panel1.Size.Width, pl2)
        ' Me.Panel4.Size = New Size(Me.Panel2.Size.Width, pl1)
        Me.Panel6.Size = New Size(Me.Panel1.Size.Width, pl5)
        Timer1.Start()
    End Sub

    Private Sub flightinfo_MouseLeave(sender As Object, e As EventArgs) Handles flightinfo.MouseLeave
        Timer1.Stop()
        pl1 = 30
    End Sub

    Private Sub aircrafttype_MouseMove(sender As Object, e As MouseEventArgs) Handles AircraftType.MouseMove

        Me.Panel1.Size = New Size(Me.Panel1.Size.Width, pl4)
        Me.Panel2.Size = New Size(Me.Panel2.Size.Width, pl3)
        ' Me.Panel3.Size = New Size(Me.Panel1.Size.Width, pl2)
        Me.Panel4.Size = New Size(Me.Panel2.Size.Width, pl1)
        Me.Panel6.Size = New Size(Me.Panel1.Size.Width, pl5)
        Timer2.Start()
    End Sub

    Private Sub aircrafttype_MouseLeave(sender As Object, e As EventArgs) Handles AircraftType.MouseLeave
        Timer2.Stop()
        pl2 = 30
    End Sub
    Private Sub payload_MouseMove(sender As Object, e As MouseEventArgs) Handles PAYLOAD.MouseMove
        Me.Panel1.Size = New Size(Me.Panel1.Size.Width, pl4)
        ' Me.Panel2.Size = New Size(Me.Panel2.Size.Width, pl3)
        Me.Panel3.Size = New Size(Me.Panel1.Size.Width, pl2)
        Me.Panel4.Size = New Size(Me.Panel2.Size.Width, pl1)
        Me.Panel6.Size = New Size(Me.Panel1.Size.Width, pl5)
        Timer3.Start()
    End Sub

    Private Sub payload_MouseLeave(sender As Object, e As EventArgs) Handles PAYLOAD.MouseLeave
        Timer3.Stop()
        pl3 = 30
    End Sub

    Private Sub route_MouseMove(sender As Object, e As MouseEventArgs) Handles Route.MouseMove
        Me.Panel1.Size = New Size(Me.Panel1.Size.Width, pl4)
        Me.Panel2.Size = New Size(Me.Panel2.Size.Width, pl3)
        Me.Panel3.Size = New Size(Me.Panel1.Size.Width, pl2)
        ' Me.Panel4.Size = New Size(Me.Panel2.Size.Width, pl1)
        Me.Panel6.Size = New Size(Me.Panel1.Size.Width, pl5)
        Timer4.Start()
    End Sub

    Private Sub route_MouseLeave(sender As Object, e As EventArgs) Handles Route.MouseLeave
        Timer4.Stop()
        pl4 = 30
    End Sub

    Private Sub alternates_MouseMove(sender As Object, e As MouseEventArgs) Handles alternates.MouseMove
        Me.Panel1.Size = New Size(Me.Panel1.Size.Width, pl4)
        Me.Panel2.Size = New Size(Me.Panel2.Size.Width, pl3)
        Me.Panel3.Size = New Size(Me.Panel1.Size.Width, pl2)
        Me.Panel4.Size = New Size(Me.Panel2.Size.Width, pl1)
        '  Me.Panel6.Size = New Size(Me.Panel1.Size.Width, pl5)
        Timer5.Start()
    End Sub

    Private Sub alternates_MouseLeave(sender As Object, e As EventArgs) Handles alternates.MouseLeave
        Timer5.Stop()
        pl5 = 30
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        conn.Close()
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        'Change the following to your access database location
        dataFile = "C:\VisStudioProj\wav web\willairwayvirtual34\willairwayvirtual34\app_data\willairwayvirtualDBv1.accdb"
        connString = provider & dataFile
        conn.ConnectionString = connString
        conn.Open()

        Dim savenew As String = "INSERT INTO [wavvirtdispatch]  (airline,flight,callsign,dep,arr,takeoff,land,taxiout,taxiin,ope,dte,ett,aicrt,type,climb,cruise,maxtakeoff,maxlanding,adults,children,infants,baggage,cargo,zerofuel,maxzerofuel,fuel,route,altairport,altairroute) values('" &
      AirlinetextBox4.Text & "','" &
      FlightTextBox5.Text & "','" &
      CallsignTextBox6.Text & "','" &
      depTextBox1.Text & "','" &
      arrTextBox2.Text & "','" &
      TakeoffTextBox7.Text & "','" &
      LandTextBox8.Text & "','" &
      taxioutTextBox9.Text & "','" &
     taxiinTextBox10.Text & "','" &
     opeTextBox3.Text & "','" &
     dteTextBox11.Text & "','" &
     ettTextBox12.Text & "','" &
     aicrtTextBox4.Text & "','" &
     typeTextBox13.Text & "','" &
    climbTextBox14.Text & "','" &
     cruiseTextBox15.Text & "','" &
     takeTextBox16.Text & "','" &
   lanTextBox17.Text & "','" &
  adultsTextBox18.Text & "','" &
   childrenTextBox19.Text & "','" &
  infantsTextBox20.Text & "','" &
  baggageTextBox21.Text & "','" &
   cargoTextBox22.Text & "','" &
  zeroTextBox23.Text & "','" &
maxTextBox24.Text & "','" &
  FuelTextBox25.Text & "','" &
   RouteTextBox1.Text & "','" &
    AIRTPORTextBox3.Text & "','" &
      RouteTextBox2.Text & "');"
        Dim cmd As New OleDbCommand

        With cmd
            .CommandText = savenew
            .Connection = conn
            .ExecuteNonQuery()
        End With
        MessageBox.Show("Please Wait.  Please go to the Briefing Center to get the flight plan")

        conn.Close()

    End Sub

    Private Sub Label19_Leave(sender As Object, e As EventArgs)

    End Sub

    Private Sub save1_Click(sender As Object, e As EventArgs) Handles save1.Click
        SaveFileDialog1.ShowDialog()

        Dim location As String

        location = SaveFileDialog1.FileName

        My.Computer.FileSystem.WriteAllText(location & ".txt", "" & RouteTextBox1.Text, True)
        MessageBox.Show("aill routes have been exported")
    End Sub


End Class