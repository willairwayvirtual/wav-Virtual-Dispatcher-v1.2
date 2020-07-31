<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.WebBrowser2 = New System.Windows.Forms.WebBrowser()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.WebBrowser3 = New System.Windows.Forms.WebBrowser()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.WebBrowser4 = New System.Windows.Forms.WebBrowser()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.WebBrowser5 = New System.Windows.Forms.WebBrowser()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Location = New System.Drawing.Point(-3, -8)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1964, 813)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.WebBrowser2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1956, 784)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "rfinder"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'WebBrowser2
        '
        Me.WebBrowser2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser2.Location = New System.Drawing.Point(3, 3)
        Me.WebBrowser2.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser2.Name = "WebBrowser2"
        Me.WebBrowser2.Size = New System.Drawing.Size(1950, 778)
        Me.WebBrowser2.TabIndex = 0
        Me.WebBrowser2.Url = New System.Uri("http://rfinder.asalink.net/free/", System.UriKind.Absolute)
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.WebBrowser3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1956, 784)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "flightradar24."
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'WebBrowser3
        '
        Me.WebBrowser3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser3.Location = New System.Drawing.Point(3, 3)
        Me.WebBrowser3.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser3.Name = "WebBrowser3"
        Me.WebBrowser3.Size = New System.Drawing.Size(1950, 778)
        Me.WebBrowser3.TabIndex = 0
        Me.WebBrowser3.Url = New System.Uri("https://www.flightradar24.com/-30.52,-88.01/2", System.UriKind.Absolute)
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.WebBrowser1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1956, 784)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "weather1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(3, 3)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(1950, 778)
        Me.WebBrowser1.TabIndex = 0
        Me.WebBrowser1.Url = New System.Uri("https://aviationweather.gov/data/iffdp/2106.gif", System.UriKind.Absolute)
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.WebBrowser4)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1956, 784)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "weather2"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'WebBrowser4
        '
        Me.WebBrowser4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser4.Location = New System.Drawing.Point(3, 3)
        Me.WebBrowser4.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser4.Name = "WebBrowser4"
        Me.WebBrowser4.Size = New System.Drawing.Size(1950, 778)
        Me.WebBrowser4.TabIndex = 0
        Me.WebBrowser4.Url = New System.Uri("http://aviationweather.gov/data/iffdp/2105.gif", System.UriKind.Absolute)
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.WebBrowser5)
        Me.TabPage5.Location = New System.Drawing.Point(4, 25)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(1956, 784)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "North Atlantic Tracks "
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'WebBrowser5
        '
        Me.WebBrowser5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser5.Location = New System.Drawing.Point(3, 3)
        Me.WebBrowser5.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser5.Name = "WebBrowser5"
        Me.WebBrowser5.Size = New System.Drawing.Size(1950, 778)
        Me.WebBrowser5.TabIndex = 0
        Me.WebBrowser5.Url = New System.Uri("https://www.notams.faa.gov/common/nat.html", System.UriKind.Absolute)
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(1924, 729)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form4"
        Me.Text = "browser"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents WebBrowser2 As WebBrowser
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents WebBrowser3 As WebBrowser
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents WebBrowser4 As WebBrowser
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents WebBrowser5 As WebBrowser
End Class
