<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WinForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WinForm))
        Me.CakePictureBox = New System.Windows.Forms.PictureBox()
        Me.WinLabel = New System.Windows.Forms.Label()
        Me.OkButton = New System.Windows.Forms.Button()
        CType(Me.CakePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CakePictureBox
        '
        Me.CakePictureBox.Image = Global.ScammerBingo.My.Resources.Resources.Cake
        Me.CakePictureBox.Location = New System.Drawing.Point(29, 12)
        Me.CakePictureBox.Name = "CakePictureBox"
        Me.CakePictureBox.Size = New System.Drawing.Size(100, 103)
        Me.CakePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CakePictureBox.TabIndex = 0
        Me.CakePictureBox.TabStop = False
        '
        'WinLabel
        '
        Me.WinLabel.AutoSize = True
        Me.WinLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WinLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.WinLabel.Location = New System.Drawing.Point(159, 36)
        Me.WinLabel.Name = "WinLabel"
        Me.WinLabel.Size = New System.Drawing.Size(187, 51)
        Me.WinLabel.TabIndex = 1
        Me.WinLabel.Text = "You win!"
        '
        'OkButton
        '
        Me.OkButton.Location = New System.Drawing.Point(150, 124)
        Me.OkButton.Name = "OkButton"
        Me.OkButton.Size = New System.Drawing.Size(75, 23)
        Me.OkButton.TabIndex = 2
        Me.OkButton.Text = "Ok"
        Me.OkButton.UseVisualStyleBackColor = True
        '
        'WinForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 159)
        Me.Controls.Add(Me.OkButton)
        Me.Controls.Add(Me.WinLabel)
        Me.Controls.Add(Me.CakePictureBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "WinForm"
        Me.Text = "You win!"
        CType(Me.CakePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CakePictureBox As PictureBox
    Friend WithEvents WinLabel As Label
    Friend WithEvents OkButton As Button
End Class
