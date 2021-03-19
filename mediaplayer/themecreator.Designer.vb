<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class themecreator
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
        Me.bgset = New System.Windows.Forms.Button()
        Me.backgrocolorpicker = New System.Windows.Forms.ColorDialog()
        Me.btset = New System.Windows.Forms.Button()
        Me.buttoncolorpicker = New System.Windows.Forms.ColorDialog()
        Me.textcolorpicker = New System.Windows.Forms.ColorDialog()
        Me.txset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bgset
        '
        Me.bgset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bgset.Location = New System.Drawing.Point(12, 27)
        Me.bgset.Name = "bgset"
        Me.bgset.Size = New System.Drawing.Size(413, 64)
        Me.bgset.TabIndex = 0
        Me.bgset.Text = "Change Background Color"
        Me.bgset.UseVisualStyleBackColor = True
        '
        'backgrocolorpicker
        '
        Me.backgrocolorpicker.AnyColor = True
        Me.backgrocolorpicker.FullOpen = True
        '
        'btset
        '
        Me.btset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btset.Location = New System.Drawing.Point(12, 115)
        Me.btset.Name = "btset"
        Me.btset.Size = New System.Drawing.Size(413, 64)
        Me.btset.TabIndex = 1
        Me.btset.Text = "Change Button Color"
        Me.btset.UseVisualStyleBackColor = True
        '
        'txset
        '
        Me.txset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txset.Location = New System.Drawing.Point(12, 205)
        Me.txset.Name = "txset"
        Me.txset.Size = New System.Drawing.Size(413, 64)
        Me.txset.TabIndex = 2
        Me.txset.Text = "Change Button Text Color"
        Me.txset.UseVisualStyleBackColor = True
        '
        'themecreator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 342)
        Me.Controls.Add(Me.txset)
        Me.Controls.Add(Me.btset)
        Me.Controls.Add(Me.bgset)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "themecreator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Media Player Theme Creator"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bgset As System.Windows.Forms.Button
    Friend WithEvents backgrocolorpicker As System.Windows.Forms.ColorDialog
    Friend WithEvents btset As System.Windows.Forms.Button
    Friend WithEvents buttoncolorpicker As System.Windows.Forms.ColorDialog
    Friend WithEvents textcolorpicker As System.Windows.Forms.ColorDialog
    Friend WithEvents txset As System.Windows.Forms.Button
End Class
