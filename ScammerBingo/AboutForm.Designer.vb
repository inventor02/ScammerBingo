<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutForm))
        Me.VersionLabel = New System.Windows.Forms.Label()
        Me.InfoRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.LicenseRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.TextPictureBox = New System.Windows.Forms.PictureBox()
        Me.LinksGroupBox = New System.Windows.Forms.GroupBox()
        Me.LinksRichTextBox = New System.Windows.Forms.RichTextBox()
        CType(Me.TextPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LinksGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'VersionLabel
        '
        Me.VersionLabel.AutoSize = True
        Me.VersionLabel.Location = New System.Drawing.Point(292, 63)
        Me.VersionLabel.Name = "VersionLabel"
        Me.VersionLabel.Size = New System.Drawing.Size(31, 13)
        Me.VersionLabel.TabIndex = 1
        Me.VersionLabel.Text = "0.0.0"
        '
        'InfoRichTextBox
        '
        Me.InfoRichTextBox.Location = New System.Drawing.Point(13, 84)
        Me.InfoRichTextBox.Name = "InfoRichTextBox"
        Me.InfoRichTextBox.ReadOnly = True
        Me.InfoRichTextBox.Size = New System.Drawing.Size(318, 165)
        Me.InfoRichTextBox.TabIndex = 2
        Me.InfoRichTextBox.Text = resources.GetString("InfoRichTextBox.Text")
        '
        'LicenseRichTextBox
        '
        Me.LicenseRichTextBox.Location = New System.Drawing.Point(12, 255)
        Me.LicenseRichTextBox.Name = "LicenseRichTextBox"
        Me.LicenseRichTextBox.ReadOnly = True
        Me.LicenseRichTextBox.Size = New System.Drawing.Size(319, 96)
        Me.LicenseRichTextBox.TabIndex = 3
        Me.LicenseRichTextBox.Text = resources.GetString("LicenseRichTextBox.Text")
        '
        'TextPictureBox
        '
        Me.TextPictureBox.Image = Global.ScammerBingo.My.Resources.Resources.Text
        Me.TextPictureBox.Location = New System.Drawing.Point(12, 12)
        Me.TextPictureBox.Name = "TextPictureBox"
        Me.TextPictureBox.Size = New System.Drawing.Size(319, 61)
        Me.TextPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.TextPictureBox.TabIndex = 0
        Me.TextPictureBox.TabStop = False
        '
        'LinksGroupBox
        '
        Me.LinksGroupBox.Controls.Add(Me.LinksRichTextBox)
        Me.LinksGroupBox.Location = New System.Drawing.Point(13, 358)
        Me.LinksGroupBox.Name = "LinksGroupBox"
        Me.LinksGroupBox.Size = New System.Drawing.Size(318, 100)
        Me.LinksGroupBox.TabIndex = 4
        Me.LinksGroupBox.TabStop = False
        Me.LinksGroupBox.Text = "Links"
        '
        'LinksRichTextBox
        '
        Me.LinksRichTextBox.Location = New System.Drawing.Point(6, 19)
        Me.LinksRichTextBox.Name = "LinksRichTextBox"
        Me.LinksRichTextBox.ReadOnly = True
        Me.LinksRichTextBox.Size = New System.Drawing.Size(304, 75)
        Me.LinksRichTextBox.TabIndex = 0
        Me.LinksRichTextBox.Text = resources.GetString("LinksRichTextBox.Text")
        '
        'AboutForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 466)
        Me.Controls.Add(Me.LinksGroupBox)
        Me.Controls.Add(Me.LicenseRichTextBox)
        Me.Controls.Add(Me.InfoRichTextBox)
        Me.Controls.Add(Me.VersionLabel)
        Me.Controls.Add(Me.TextPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "AboutForm"
        Me.Text = "About Scammer Bingo"
        CType(Me.TextPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LinksGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextPictureBox As PictureBox
    Friend WithEvents VersionLabel As Label
    Friend WithEvents InfoRichTextBox As RichTextBox
    Friend WithEvents LicenseRichTextBox As RichTextBox
    Friend WithEvents LinksGroupBox As GroupBox
    Friend WithEvents LinksRichTextBox As RichTextBox
End Class
