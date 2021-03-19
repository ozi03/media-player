<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.pausebutton = New System.Windows.Forms.Button()
        Me.playbutton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.hidebutton = New System.Windows.Forms.Button()
        Me.showbutton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'pausebutton
        '
        Me.pausebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pausebutton.Location = New System.Drawing.Point(193, 64)
        Me.pausebutton.Name = "pausebutton"
        Me.pausebutton.Size = New System.Drawing.Size(55, 30)
        Me.pausebutton.TabIndex = 0
        Me.pausebutton.Text = "Pause"
        Me.pausebutton.UseVisualStyleBackColor = True
        '
        'playbutton
        '
        Me.playbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.playbutton.Location = New System.Drawing.Point(12, 64)
        Me.playbutton.Name = "playbutton"
        Me.playbutton.Size = New System.Drawing.Size(55, 30)
        Me.playbutton.TabIndex = 1
        Me.playbutton.Text = "Play"
        Me.playbutton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(236, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Currently Playing - Never Gonna Give You Up"
        '
        'hidebutton
        '
        Me.hidebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.hidebutton.Location = New System.Drawing.Point(132, 64)
        Me.hidebutton.Name = "hidebutton"
        Me.hidebutton.Size = New System.Drawing.Size(55, 30)
        Me.hidebutton.TabIndex = 3
        Me.hidebutton.Text = "Hide"
        Me.hidebutton.UseVisualStyleBackColor = True
        '
        'showbutton
        '
        Me.showbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.showbutton.Location = New System.Drawing.Point(71, 64)
        Me.showbutton.Name = "showbutton"
        Me.showbutton.Size = New System.Drawing.Size(55, 30)
        Me.showbutton.TabIndex = 4
        Me.showbutton.Text = "Show"
        Me.showbutton.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(260, 106)
        Me.Controls.Add(Me.showbutton)
        Me.Controls.Add(Me.hidebutton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.playbutton)
        Me.Controls.Add(Me.pausebutton)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Miniplayer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pausebutton As System.Windows.Forms.Button
    Friend WithEvents playbutton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents hidebutton As System.Windows.Forms.Button
    Friend WithEvents showbutton As System.Windows.Forms.Button
End Class
