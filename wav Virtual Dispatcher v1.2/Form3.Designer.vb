<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3mll
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3mll))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.wavMenu = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.flightinfo = New System.Windows.Forms.Button()
        Me.AircraftType = New System.Windows.Forms.Button()
        Me.PAYLOAD = New System.Windows.Forms.Button()
        Me.Route = New System.Windows.Forms.Button()
        Me.alternates = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.save1 = New System.Windows.Forms.Button()
        Me.wavMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1567, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(156, 27)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "browser"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1372, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(189, 27)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "go to the Flight Briefing Center"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'wavMenu
        '
        Me.wavMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.wavMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.wavMenu.Location = New System.Drawing.Point(0, 0)
        Me.wavMenu.Name = "wavMenu"
        Me.wavMenu.Size = New System.Drawing.Size(1723, 28)
        Me.wavMenu.TabIndex = 3
        Me.wavMenu.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.PrintToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "file"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(179, 26)
        Me.NewToolStripMenuItem.Text = "new"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(179, 26)
        Me.OpenToolStripMenuItem.Text = "open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(179, 26)
        Me.SaveToolStripMenuItem.Text = "save"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(179, 26)
        Me.PrintToolStripMenuItem.Text = "print"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(179, 26)
        Me.ExitToolStripMenuItem.Text = "exit"
        '
        'flightinfo
        '
        Me.flightinfo.BackColor = System.Drawing.Color.DimGray
        Me.flightinfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.flightinfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.flightinfo.ForeColor = System.Drawing.Color.DarkRed
        Me.flightinfo.Location = New System.Drawing.Point(0, 35)
        Me.flightinfo.Margin = New System.Windows.Forms.Padding(4)
        Me.flightinfo.Name = "flightinfo"
        Me.flightinfo.Size = New System.Drawing.Size(1723, 44)
        Me.flightinfo.TabIndex = 36
        Me.flightinfo.Text = "Flight Info"
        Me.flightinfo.UseVisualStyleBackColor = False
        '
        'AircraftType
        '
        Me.AircraftType.BackColor = System.Drawing.Color.DimGray
        Me.AircraftType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AircraftType.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AircraftType.ForeColor = System.Drawing.Color.DarkRed
        Me.AircraftType.Location = New System.Drawing.Point(0, 181)
        Me.AircraftType.Margin = New System.Windows.Forms.Padding(4)
        Me.AircraftType.Name = "AircraftType"
        Me.AircraftType.Size = New System.Drawing.Size(1723, 37)
        Me.AircraftType.TabIndex = 37
        Me.AircraftType.Text = "AircraftType"
        Me.AircraftType.UseVisualStyleBackColor = False
        '
        'PAYLOAD
        '
        Me.PAYLOAD.BackColor = System.Drawing.Color.DimGray
        Me.PAYLOAD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PAYLOAD.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PAYLOAD.ForeColor = System.Drawing.Color.DarkRed
        Me.PAYLOAD.Location = New System.Drawing.Point(0, 303)
        Me.PAYLOAD.Margin = New System.Windows.Forms.Padding(4)
        Me.PAYLOAD.Name = "PAYLOAD"
        Me.PAYLOAD.Size = New System.Drawing.Size(1736, 38)
        Me.PAYLOAD.TabIndex = 38
        Me.PAYLOAD.Text = "PAYLOAD"
        Me.PAYLOAD.UseVisualStyleBackColor = False
        '
        'Route
        '
        Me.Route.BackColor = System.Drawing.Color.DimGray
        Me.Route.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Route.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Route.ForeColor = System.Drawing.Color.DarkRed
        Me.Route.Location = New System.Drawing.Point(0, 413)
        Me.Route.Margin = New System.Windows.Forms.Padding(4)
        Me.Route.Name = "Route"
        Me.Route.Size = New System.Drawing.Size(1736, 37)
        Me.Route.TabIndex = 39
        Me.Route.Text = "Route"
        Me.Route.UseVisualStyleBackColor = False
        '
        'alternates
        '
        Me.alternates.BackColor = System.Drawing.Color.DimGray
        Me.alternates.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.alternates.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alternates.ForeColor = System.Drawing.Color.DarkRed
        Me.alternates.Location = New System.Drawing.Point(-16, 547)
        Me.alternates.Margin = New System.Windows.Forms.Padding(4)
        Me.alternates.Name = "alternates"
        Me.alternates.Size = New System.Drawing.Size(1739, 42)
        Me.alternates.TabIndex = 40
        Me.alternates.Text = "alternates"
        Me.alternates.UseVisualStyleBackColor = False
        '
        'Button12
        '
        Me.Button12.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.Image = CType(resources.GetObject("Button12.Image"), System.Drawing.Image)
        Me.Button12.Location = New System.Drawing.Point(0, 683)
        Me.Button12.Margin = New System.Windows.Forms.Padding(4)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(1736, 65)
        Me.Button12.TabIndex = 45
        Me.Button12.Text = "complete flight"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'save1
        '
        Me.save1.Location = New System.Drawing.Point(0, 768)
        Me.save1.Margin = New System.Windows.Forms.Padding(4)
        Me.save1.Name = "save1"
        Me.save1.Size = New System.Drawing.Size(1736, 48)
        Me.save1.TabIndex = 47
        Me.save1.Text = "save"
        Me.save1.UseVisualStyleBackColor = True
        '
        'Form3mll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(1723, 873)
        Me.Controls.Add(Me.save1)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.alternates)
        Me.Controls.Add(Me.Route)
        Me.Controls.Add(Me.PAYLOAD)
        Me.Controls.Add(Me.AircraftType)
        Me.Controls.Add(Me.flightinfo)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.wavMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.wavMenu
        Me.Name = "Form3mll"
        Me.Text = "wav Dispatch Center"
        Me.wavMenu.ResumeLayout(False)
        Me.wavMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents wavMenu As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents flightinfo As Button
    Friend WithEvents AircraftType As Button
    Friend WithEvents PAYLOAD As Button
    Friend WithEvents Route As Button
    Friend WithEvents alternates As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents save1 As Button
End Class
