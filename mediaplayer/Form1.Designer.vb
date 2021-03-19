<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.stopbutton = New System.Windows.Forms.Button()
        Me.pausebutton = New System.Windows.Forms.Button()
        Me.playbutton = New System.Windows.Forms.Button()
        Me.urlbox = New System.Windows.Forms.TextBox()
        Me.selectfiledialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.browsebutton = New System.Windows.Forms.Button()
        Me.hidebutton = New System.Windows.Forms.Button()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.setbutton = New System.Windows.Forms.Button()
        Me.gobutton = New System.Windows.Forms.Button()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(11, 12)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(638, 425)
        Me.AxWindowsMediaPlayer1.TabIndex = 0
        '
        'stopbutton
        '
        Me.stopbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.stopbutton.Location = New System.Drawing.Point(131, 443)
        Me.stopbutton.Name = "stopbutton"
        Me.stopbutton.Size = New System.Drawing.Size(56, 39)
        Me.stopbutton.TabIndex = 3
        Me.stopbutton.Text = "Stop"
        Me.stopbutton.UseVisualStyleBackColor = True
        '
        'pausebutton
        '
        Me.pausebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pausebutton.Location = New System.Drawing.Point(71, 443)
        Me.pausebutton.Name = "pausebutton"
        Me.pausebutton.Size = New System.Drawing.Size(54, 39)
        Me.pausebutton.TabIndex = 4
        Me.pausebutton.Text = "Pause"
        Me.pausebutton.UseVisualStyleBackColor = True
        '
        'playbutton
        '
        Me.playbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.playbutton.Location = New System.Drawing.Point(11, 443)
        Me.playbutton.Name = "playbutton"
        Me.playbutton.Size = New System.Drawing.Size(54, 39)
        Me.playbutton.TabIndex = 5
        Me.playbutton.Text = "Play"
        Me.playbutton.UseVisualStyleBackColor = True
        '
        'urlbox
        '
        Me.urlbox.Location = New System.Drawing.Point(432, 443)
        Me.urlbox.Multiline = True
        Me.urlbox.Name = "urlbox"
        Me.urlbox.Size = New System.Drawing.Size(157, 38)
        Me.urlbox.TabIndex = 7
        Me.urlbox.Text = "http://"
        '
        'selectfiledialog1
        '
        Me.selectfiledialog1.Title = "Open Media File"
        '
        'browsebutton
        '
        Me.browsebutton.BackColor = System.Drawing.SystemColors.Control
        Me.browsebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.browsebutton.Location = New System.Drawing.Point(358, 443)
        Me.browsebutton.Name = "browsebutton"
        Me.browsebutton.Size = New System.Drawing.Size(68, 38)
        Me.browsebutton.TabIndex = 8
        Me.browsebutton.Text = "Browse"
        Me.browsebutton.UseVisualStyleBackColor = False
        '
        'hidebutton
        '
        Me.hidebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.hidebutton.Location = New System.Drawing.Point(298, 442)
        Me.hidebutton.Name = "hidebutton"
        Me.hidebutton.Size = New System.Drawing.Size(54, 39)
        Me.hidebutton.TabIndex = 9
        Me.hidebutton.Text = "Hide"
        Me.hidebutton.UseVisualStyleBackColor = True
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.BalloonTipText = "Media Player is currently running!"
        Me.NotifyIcon1.BalloonTipTitle = "Media Player"
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Media Player "
        Me.NotifyIcon1.Visible = True
        '
        'setbutton
        '
        Me.setbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.setbutton.Location = New System.Drawing.Point(193, 442)
        Me.setbutton.Name = "setbutton"
        Me.setbutton.Size = New System.Drawing.Size(99, 39)
        Me.setbutton.TabIndex = 10
        Me.setbutton.Text = "Settings"
        Me.setbutton.UseVisualStyleBackColor = True
        '
        'gobutton
        '
        Me.gobutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gobutton.Location = New System.Drawing.Point(596, 442)
        Me.gobutton.Name = "gobutton"
        Me.gobutton.Size = New System.Drawing.Size(52, 38)
        Me.gobutton.TabIndex = 11
        Me.gobutton.Text = "Go!"
        Me.gobutton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(661, 493)
        Me.Controls.Add(Me.gobutton)
        Me.Controls.Add(Me.setbutton)
        Me.Controls.Add(Me.hidebutton)
        Me.Controls.Add(Me.browsebutton)
        Me.Controls.Add(Me.urlbox)
        Me.Controls.Add(Me.playbutton)
        Me.Controls.Add(Me.pausebutton)
        Me.Controls.Add(Me.stopbutton)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Media Player"
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents stopbutton As System.Windows.Forms.Button
    Friend WithEvents pausebutton As System.Windows.Forms.Button
    Friend WithEvents playbutton As System.Windows.Forms.Button
    Friend WithEvents urlbox As System.Windows.Forms.TextBox
    Friend WithEvents selectfiledialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents browsebutton As System.Windows.Forms.Button
    Friend WithEvents hidebutton As System.Windows.Forms.Button
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents setbutton As System.Windows.Forms.Button
    Friend WithEvents gobutton As System.Windows.Forms.Button

End Class
