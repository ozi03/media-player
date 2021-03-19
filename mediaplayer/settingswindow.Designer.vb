<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class settingswindow
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
        Me.darkmodeon = New System.Windows.Forms.Button()
        Me.darkmodeoff = New System.Windows.Forms.Button()
        Me.themcret = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SuspendLayout()
        '
        'darkmodeon
        '
        Me.darkmodeon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.darkmodeon.Location = New System.Drawing.Point(363, 35)
        Me.darkmodeon.Name = "darkmodeon"
        Me.darkmodeon.Size = New System.Drawing.Size(179, 37)
        Me.darkmodeon.TabIndex = 1
        Me.darkmodeon.Text = "Dark Mode On"
        Me.darkmodeon.UseVisualStyleBackColor = True
        '
        'darkmodeoff
        '
        Me.darkmodeoff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.darkmodeoff.Location = New System.Drawing.Point(363, 87)
        Me.darkmodeoff.Name = "darkmodeoff"
        Me.darkmodeoff.Size = New System.Drawing.Size(179, 37)
        Me.darkmodeoff.TabIndex = 2
        Me.darkmodeoff.Text = "Dark Mode Off"
        Me.darkmodeoff.UseVisualStyleBackColor = True
        '
        'themcret
        '
        Me.themcret.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.themcret.Location = New System.Drawing.Point(1, 527)
        Me.themcret.Name = "themcret"
        Me.themcret.Size = New System.Drawing.Size(99, 33)
        Me.themcret.TabIndex = 3
        Me.themcret.Text = "Theme Creator"
        Me.themcret.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(406, 539)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Version 1.10 made by Ozi03 (Finder)"
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(346, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(213, 132)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dark Mode"
        '
        'settingswindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 561)
        Me.Controls.Add(Me.darkmodeon)
        Me.Controls.Add(Me.darkmodeoff)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.themcret)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "settingswindow"
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents darkmodeon As System.Windows.Forms.Button
    Friend WithEvents darkmodeoff As System.Windows.Forms.Button
    Friend WithEvents themcret As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
