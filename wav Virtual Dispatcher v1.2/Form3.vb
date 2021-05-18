Imports System.ComponentModel
Imports System.Data.OleDb
Imports System.Drawing.Printing

Public Class Form3mll
    Public Property stringtext1 As String
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim conn As OleDbConnection = New OleDbConnection

    ' pl1 = fligPanel1 height
    Dim pl1 As Integer = 30
    ' pl2 = panel2 height
    Dim pl2 As Integer = 30
    ' pl3 = panel3 height
    Dim pl3 As Integer = 30
    ' pl4 = panel4 height
    Dim pl4 As Integer = 30
    ' pl5 = panel5 height
    Dim pl5 As Integer = 30





    Private Sub textboxX_leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AirlinetextBox4.Leave, CallsignTextBox6.Leave, FlightTextBox5.Leave, arrTextBox2.Leave, depTextBox1.Leave, TakeoffTextBox7.Leave, LandTextBox8.Leave, taxioutTextBox9.Leave, taxiinTextBox10.Leave, opeTextBox3.Leave, dteTextBox11.Leave, ettTextBox12.Leave, AIRTPORTextBox3.Leave, regiTextBox1.Leave, aicrtTextBox1.Leave, RouteTextBox2.Leave


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
        SaveFileDialog2.ShowDialog()
        SaveFileDialog2.Title = "save text"
        SaveFileDialog2.InitialDirectory = "\Documents"
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

        OpenFileDialog1.Filter = "Flight plan(*.flt.*.pln )|"
        OpenFileDialog1.InitialDirectory = "\Documents"
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

    Private Sub project_Click(sender As Object, e As EventArgs)



        Dim location As String

        location = SaveFileDialog1.FileName

        My.Computer.FileSystem.WriteAllText(location & ".pln", "" & RouteTextBox1.Text, True)
    End Sub

    Private Sub pmdg_Click(sender As Object, e As EventArgs) Handles pmdg.Click
        SaveFileDialog31.ShowDialog()
        SaveFileDialog31.Title = "save text"
        SaveFileDialog31.InitialDirectory = "\C:Program Files (x86)\Microsoft Games\Microsoft Flight Simulator X\PMDG\FLIGHTPLANS"
        Dim location As String

        location = SaveFileDialog1.FileName

        My.Computer.FileSystem.WriteAllText(location & ".txt", "" & RouteTextBox1.Text, True)



    End Sub

    Private Sub Buttonp3d_Click(sender As Object, e As EventArgs) Handles Buttonp3d.Click
        SaveFileDialog32.ShowDialog()
        SaveFileDialog32.Title = "save text"
        SaveFileDialog32.InitialDirectory = "\C:\Program Files\lockheedmartin\prepar3d v3\pmdg\FLIGHTPLANS\777"
        Dim location As String

        location = SaveFileDialog1.FileName

        My.Computer.FileSystem.WriteAllText(location & ".txt", "" & RouteTextBox1.Text, True)

    End Sub

    Private Sub Button787_Click(sender As Object, e As EventArgs) Handles Button787.Click

        SaveFileDialog3.ShowDialog()
        SaveFileDialog3.Title = "save text"
        SaveFileDialog3.InitialDirectory = "\C:\Program Files (x86)\Microsoft Games\Microsoft Flight Simulator X\QualityWings\QW787\FlightPlans"
        Dim location As String
        location = SaveFileDialog1.FileName

        My.Computer.FileSystem.WriteAllText(location & ".txt", "" & RouteTextBox1.Text, True)


    End Sub

    Private Sub Button9787_Click(sender As Object, e As EventArgs) Handles Button9787.Click
        SaveFileDialog54.ShowDialog()
        SaveFileDialog54.Title = "save text"
        SaveFileDialog54.InitialDirectory = "\C:\Program Files (x86)\lockheedmartin\prepar3d v3\QualityWings\QW787\FlightPlans"
        Dim location As String
        location = SaveFileDialog1.FileName

        My.Computer.FileSystem.WriteAllText(location & ".txt", "" & RouteTextBox1.Text, True)



    End Sub

    Private Sub Buttonairbus_Click(sender As Object, e As EventArgs) Handles Buttonairbus.Click
        SaveFileDialog55.ShowDialog()
        SaveFileDialog55.Title = "save text"
        SaveFileDialog55.InitialDirectory = "C:\Users\Lorcan\Documents\Aerosoft\AerosoftAirbusExtended\FlightPlans"
        Dim location As String
        location = SaveFileDialog1.FileName

        My.Computer.FileSystem.WriteAllText(location & ".txt", "" & RouteTextBox1.Text, True)

    End Sub

    Private Sub Button8airbus_Click(sender As Object, e As EventArgs) Handles Button8airbus.Click
        SaveFileDialog55.ShowDialog()
        SaveFileDialog55.Title = "save text"
        SaveFileDialog55.InitialDirectory = "C:\Users\Lorcan\Documents\Aerosoft\AerosoftAirbusExtended\FlightPlans"
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
        FlightTextBox5.Clear()
        CallsignTextBox6.Clear()
        depTextBox1.Clear()
        arrTextBox2.Clear()
        TakeoffTextBox7.Clear()
        LandTextBox8.Clear()
        taxioutTextBox9.Clear()
        taxiinTextBox10.Clear()
        opeTextBox3.Clear()
        dteTextBox11.Clear()
        ettTextBox12.Clear()
        regiTextBox1.Clear()
        arrTextBox2.Clear()
        typeTextBox13.Clear()
        climbTextBox14.Clear()
        cruiseTextBox15.Clear()
        takeTextBox16.Clear()
        lanTextBox17.Clear()
        adultsTextBox18.Clear()
        childrenTextBox19.Clear()
        infantsTextBox20.Clear()
        baggageTextBox21.Clear()
        cargoTextBox22.Clear()
        zeroTextBox23.Clear()
        maxTextBox24.Clear()
        FuelTextBox25.Clear()
        RouteTextBox1.Clear()
        AIRTPORTextBox3.Clear()
        RouteTextBox2.Clear()




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

    Private Sub mfs20020_Click(sender As Object, e As EventArgs) Handles mfs20020.Click
        SaveFileDialog2020.ShowDialog()
        SaveFileDialog2020.Title = "save text"
        SaveFileDialog2020.InitialDirectory = "\C:\Users\Lorcan\app_data\Local\Packages\Microsoft.FlightSimulator_8wekyb3d8bbwe\LocalState"
        Dim location As String

        location = SaveFileDialog1.FileName

        My.Computer.FileSystem.WriteAllText(location & ".txt", "" & RouteTextBox1.Text, True)

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        conn.Close()
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        'Change the following to your access database location
        dataFile = "C:\VisStudioProj\wav web\willairwayvirtual34\willairwayvirtual34\app_data\willairwayvirtualDBv1.accdb"
        connString = provider & dataFile
        conn.ConnectionString = connString
        conn.Open()

        Dim savenew As String = "INSERT INTO [wavvirtdispatch]  (airline,flight,callsign,dep,arr,takeoff,land,taxiout,taxiin,registration,ope,dte,ett,aicrt,type,climb,cruise,maxtakeoff,maxlanding,adults,children,infants,baggage,cargo,zerofuel,maxzerofuel,fuel,route,altairport,altairroute) values('" &
      AirlinetextBox4.Text & "','" &
      FlightTextBox5.Text & "','" &
      CallsignTextBox6.Text & "','" &
      depTextBox1.Text & "','" &
      arrTextBox2.Text & "','" &
      TakeoffTextBox7.Text & "','" &
      LandTextBox8.Text & "','" &
      taxioutTextBox9.Text & "','" &
     taxiinTextBox10.Text & "','" &
      regiTextBox1.Text & "','" &
        opeTextBox3.Text & "','" &
     dteTextBox11.Text & "','" &
     ettTextBox12.Text & "','" &
     aicrtTextBox1.Text & "','" &
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






    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        ' 250 = panel height
        If pl1 > 90 Then

            Timer1.Stop()

        Else
            Me.fligPanel1.Size = New Size(Me.fligPanel1.Size.Width, pl1)
            pl1 += 17
        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        ' 250 = panel height
        If pl2 > 90 Then

            Timer2.Stop()

        Else
            Me.aircrPanel2.Size = New Size(Me.aircrPanel2.Size.Width, pl2)
            pl2 += 17
        End If

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick

        ' 250 = panel height
        If pl3 > 90 Then

            Timer3.Stop()

        Else
            Me.PAYPanel3.Size = New Size(Me.PAYPanel3.Size.Width, pl3)
            pl3 += 17
        End If

    End Sub
    Private Sub Timer4_tick(sender As Object, e As EventArgs) Handles Timer4.Tick

        ' 250 = panel height
        If pl4 > 90 Then

            Timer4.Stop()

        Else
            Me.RoPanel4.Size = New Size(Me.RoPanel4.Size.Width, pl4)
            pl4 += 17
        End If
    End Sub
    Private Sub Timer5_tick(sender As Object, e As EventArgs) Handles Timer5.Tick

        ' 250 = panel height
        If pl5 > 120 Then

            Timer5.Stop()

        Else
            Me.altePanel5.Size = New Size(Me.altePanel5.Size.Width, pl5)
            pl5 += 17
        End If

    End Sub




    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub flightinfo_MouseMove(sender As Object, e As MouseEventArgs) Handles flightinfo.MouseMove
        'Me.fligPanel1.Size = New Size(Me.fligPanel1.Size.Width, pl1)
        Me.aircrPanel2.Size = New Size(Me.aircrPanel2.Size.Width, pl2)
        Me.PAYPanel3.Size = New Size(Me.PAYPanel3.Size.Width, pl3)
        Me.RoPanel4.Size = New Size(Me.RoPanel4.Size.Width, pl4)
        Me.altePanel5.Size = New Size(Me.altePanel5.Size.Width, pl5)

        Timer1.Start()
    End Sub

    Private Sub flightinfo_MouseLeave(sender As Object, e As EventArgs) Handles flightinfo.MouseLeave
        Timer1.Stop()
        pl1 = 30
    End Sub

    Private Sub aircrafttype_MouseMove(sender As Object, e As MouseEventArgs) Handles AircraftType.MouseMove

        Me.fligPanel1.Size = New Size(Me.fligPanel1.Size.Width, pl1)
        ' Me.aircrPanel2.Size = New Size(Me.aircrPanel2.Size.Width, pl2)
        Me.PAYPanel3.Size = New Size(Me.PAYPanel3.Size.Width, pl3)
        Me.RoPanel4.Size = New Size(Me.RoPanel4.Size.Width, pl4)
        Me.altePanel5.Size = New Size(Me.altePanel5.Size.Width, pl5)

        Timer2.Start()
    End Sub

    Private Sub aircrafttype_MouseLeave(sender As Object, e As EventArgs) Handles AircraftType.MouseLeave
        Timer2.Stop()
        pl2 = 30
    End Sub
    Private Sub payload_MouseMove(sender As Object, e As MouseEventArgs) Handles PAYLOAD.MouseMove
        Me.fligPanel1.Size = New Size(Me.fligPanel1.Size.Width, pl1)
        Me.aircrPanel2.Size = New Size(Me.aircrPanel2.Size.Width, pl2)
        ' Me.PAYPanel3.Size = New Size(Me.PAYPanel3.Size.Width, pl3)
        Me.RoPanel4.Size = New Size(Me.RoPanel4.Size.Width, pl4)
        Me.altePanel5.Size = New Size(Me.altePanel5.Size.Width, pl5)

        Timer3.Start()
    End Sub

    Private Sub payload_MouseLeave(sender As Object, e As EventArgs) Handles PAYLOAD.MouseLeave
        Timer3.Stop()
        pl3 = 30
    End Sub

    Private Sub route_MouseMove(sender As Object, e As MouseEventArgs) Handles Route.MouseMove
        Me.fligPanel1.Size = New Size(Me.fligPanel1.Size.Width, pl1)
        Me.aircrPanel2.Size = New Size(Me.aircrPanel2.Size.Width, pl2)
        Me.PAYPanel3.Size = New Size(Me.PAYPanel3.Size.Width, pl3)
        ' Me.RoPanel4.Size = New Size(Me.RoPanel4.Size.Width, pl4)
        Me.altePanel5.Size = New Size(Me.altePanel5.Size.Width, pl5)

        Timer4.Start()
    End Sub

    Private Sub route_MouseLeave(sender As Object, e As EventArgs) Handles Route.MouseLeave
        Timer4.Stop()
        pl4 = 30
    End Sub

    Private Sub alternates_MouseMove(sender As Object, e As MouseEventArgs) Handles alternates.MouseMove
        Me.fligPanel1.Size = New Size(Me.fligPanel1.Size.Width, pl1)
        Me.aircrPanel2.Size = New Size(Me.aircrPanel2.Size.Width, pl2)
        Me.PAYPanel3.Size = New Size(Me.PAYPanel3.Size.Width, pl3)
        Me.RoPanel4.Size = New Size(Me.RoPanel4.Size.Width, pl4)
        ' Me.altePanel5.Size = New Size(Me.altePanel5.Size.Width, pl5)

        Timer5.Start()
    End Sub

    Private Sub alternates_MouseLeave(sender As Object, e As EventArgs) Handles alternates.MouseLeave
        Timer5.Stop()
        pl5 = 30
    End Sub

    Private Sub export_MouseMove(sender As Object, e As MouseEventArgs)
        Me.fligPanel1.Size = New Size(Me.fligPanel1.Size.Width, pl1)
        Me.aircrPanel2.Size = New Size(Me.aircrPanel2.Size.Width, pl2)
        Me.PAYPanel3.Size = New Size(Me.PAYPanel3.Size.Width, pl3)
        Me.RoPanel4.Size = New Size(Me.RoPanel4.Size.Width, pl4)
        Me.altePanel5.Size = New Size(Me.altePanel5.Size.Width, pl5)

    End Sub

    Private Sub export_MouseLeave(sender As Object, e As EventArgs)

    End Sub

    Private Sub alternates_Click(sender As Object, e As EventArgs) Handles alternates.Click

    End Sub

    Private Sub AircraftType_Click(sender As Object, e As EventArgs) Handles AircraftType.Click

    End Sub

    Private Sub flight_Click(sender As Object, e As EventArgs) Handles flight.Click

    End Sub

    Private Sub Takeoff_Click(sender As Object, e As EventArgs) Handles Takeoff.Click

    End Sub

    Private Sub ExpotToProjectFLYToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage

        e.Graphics.DrawString(RouteTextBox1.Text, RouteTextBox1.Font, Brushes.Blue, 100, 100)
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        SaveFileDialog4.ShowDialog()
        SaveFileDialog4.Title = "save text"
        SaveFileDialog4.InitialDirectory = "C:\Users\Lorcan\Documents\AivlaSoft\EFB\UserData\Routes"



        Dim location As String

        location = SaveFileDialog1.FileName
        My.Computer.FileSystem.WriteAllText(location & ".efb routes", "" & RouteTextBox1.Text, True)

    End Sub
End Class