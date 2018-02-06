<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BingoForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BingoForm))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ScammerBingoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutScammerBingoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BoardGroupBox = New System.Windows.Forms.GroupBox()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ResetGroupBox = New System.Windows.Forms.GroupBox()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.InfoGroupBox = New System.Windows.Forms.GroupBox()
        Me.InfoRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.ScoreGroupBox = New System.Windows.Forms.GroupBox()
        Me.ScoreLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.BoardGroupBox.SuspendLayout()
        Me.ResetGroupBox.SuspendLayout()
        Me.InfoGroupBox.SuspendLayout()
        Me.ScoreGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ScammerBingoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(834, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip"
        '
        'ScammerBingoToolStripMenuItem
        '
        Me.ScammerBingoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutScammerBingoToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ScammerBingoToolStripMenuItem.Name = "ScammerBingoToolStripMenuItem"
        Me.ScammerBingoToolStripMenuItem.Size = New System.Drawing.Size(103, 20)
        Me.ScammerBingoToolStripMenuItem.Text = "Scammer Bingo"
        '
        'AboutScammerBingoToolStripMenuItem
        '
        Me.AboutScammerBingoToolStripMenuItem.Name = "AboutScammerBingoToolStripMenuItem"
        Me.AboutScammerBingoToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.AboutScammerBingoToolStripMenuItem.Text = "About Scammer Bingo"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'BoardGroupBox
        '
        Me.BoardGroupBox.Controls.Add(Me.Button16)
        Me.BoardGroupBox.Controls.Add(Me.Button17)
        Me.BoardGroupBox.Controls.Add(Me.Button18)
        Me.BoardGroupBox.Controls.Add(Me.Button19)
        Me.BoardGroupBox.Controls.Add(Me.Button20)
        Me.BoardGroupBox.Controls.Add(Me.Button11)
        Me.BoardGroupBox.Controls.Add(Me.Button12)
        Me.BoardGroupBox.Controls.Add(Me.Button13)
        Me.BoardGroupBox.Controls.Add(Me.Button14)
        Me.BoardGroupBox.Controls.Add(Me.Button15)
        Me.BoardGroupBox.Controls.Add(Me.Button6)
        Me.BoardGroupBox.Controls.Add(Me.Button7)
        Me.BoardGroupBox.Controls.Add(Me.Button8)
        Me.BoardGroupBox.Controls.Add(Me.Button9)
        Me.BoardGroupBox.Controls.Add(Me.Button10)
        Me.BoardGroupBox.Controls.Add(Me.Button5)
        Me.BoardGroupBox.Controls.Add(Me.Button4)
        Me.BoardGroupBox.Controls.Add(Me.Button3)
        Me.BoardGroupBox.Controls.Add(Me.Button2)
        Me.BoardGroupBox.Controls.Add(Me.Button1)
        Me.BoardGroupBox.ForeColor = System.Drawing.Color.White
        Me.BoardGroupBox.Location = New System.Drawing.Point(12, 27)
        Me.BoardGroupBox.Name = "BoardGroupBox"
        Me.BoardGroupBox.Size = New System.Drawing.Size(665, 343)
        Me.BoardGroupBox.TabIndex = 1
        Me.BoardGroupBox.TabStop = False
        Me.BoardGroupBox.Text = "Bingo Board"
        '
        'Button16
        '
        Me.Button16.ForeColor = System.Drawing.Color.Black
        Me.Button16.Location = New System.Drawing.Point(533, 259)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(126, 74)
        Me.Button16.TabIndex = 19
        Me.Button16.Text = "Hacked IP"
        Me.Button16.UseVisualStyleBackColor = True
        '
        'Button17
        '
        Me.Button17.ForeColor = System.Drawing.Color.Black
        Me.Button17.Location = New System.Drawing.Point(401, 259)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(126, 74)
        Me.Button17.TabIndex = 18
        Me.Button17.Text = "Stopped services"
        Me.Button17.UseVisualStyleBackColor = True
        '
        'Button18
        '
        Me.Button18.ForeColor = System.Drawing.Color.Black
        Me.Button18.Location = New System.Drawing.Point(269, 259)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(126, 74)
        Me.Button18.TabIndex = 17
        Me.Button18.Text = "Network security"
        Me.Button18.UseVisualStyleBackColor = True
        '
        'Button19
        '
        Me.Button19.ForeColor = System.Drawing.Color.Black
        Me.Button19.Location = New System.Drawing.Point(137, 259)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(126, 74)
        Me.Button19.TabIndex = 16
        Me.Button19.Text = "Windows Key + R"
        Me.Button19.UseVisualStyleBackColor = True
        '
        'Button20
        '
        Me.Button20.ForeColor = System.Drawing.Color.Black
        Me.Button20.Location = New System.Drawing.Point(5, 259)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(126, 74)
        Me.Button20.TabIndex = 15
        Me.Button20.Text = "Trying to stick to the script"
        Me.Button20.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.ForeColor = System.Drawing.Color.Black
        Me.Button11.Location = New System.Drawing.Point(533, 179)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(126, 74)
        Me.Button11.TabIndex = 14
        Me.Button11.Text = "Secure server"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.ForeColor = System.Drawing.Color.Black
        Me.Button12.Location = New System.Drawing.Point(401, 179)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(126, 74)
        Me.Button12.TabIndex = 13
        Me.Button12.Text = "Lifetime package"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.ForeColor = System.Drawing.Color.Black
        Me.Button13.Location = New System.Drawing.Point(269, 179)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(126, 74)
        Me.Button13.TabIndex = 12
        Me.Button13.Text = "Corrupted drivers"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.ForeColor = System.Drawing.Color.Black
        Me.Button14.Location = New System.Drawing.Point(137, 179)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(126, 74)
        Me.Button14.TabIndex = 11
        Me.Button14.Text = "$$$$$"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Button15
        '
        Me.Button15.ForeColor = System.Drawing.Color.Black
        Me.Button15.Location = New System.Drawing.Point(5, 179)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(126, 74)
        Me.Button15.TabIndex = 10
        Me.Button15.Text = "tree"
        Me.Button15.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.ForeColor = System.Drawing.Color.Black
        Me.Button6.Location = New System.Drawing.Point(534, 99)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(126, 74)
        Me.Button6.TabIndex = 9
        Me.Button6.Text = "netstat"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.ForeColor = System.Drawing.Color.Black
        Me.Button7.Location = New System.Drawing.Point(402, 99)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(126, 74)
        Me.Button7.TabIndex = 8
        Me.Button7.Text = "One time charge"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.ForeColor = System.Drawing.Color.Black
        Me.Button8.Location = New System.Drawing.Point(270, 99)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(126, 74)
        Me.Button8.TabIndex = 7
        Me.Button8.Text = "eventvwr"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.ForeColor = System.Drawing.Color.Black
        Me.Button9.Location = New System.Drawing.Point(138, 99)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(126, 74)
        Me.Button9.TabIndex = 6
        Me.Button9.Text = "support.me"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.ForeColor = System.Drawing.Color.Black
        Me.Button10.Location = New System.Drawing.Point(6, 99)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(126, 74)
        Me.Button10.TabIndex = 5
        Me.Button10.Text = "syskey"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.ForeColor = System.Drawing.Color.Black
        Me.Button5.Location = New System.Drawing.Point(534, 19)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(126, 74)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Microsoft certified"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Location = New System.Drawing.Point(402, 19)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(126, 74)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "iexplore"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(270, 19)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(126, 74)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "hh"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(138, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(126, 74)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Do one thing"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(6, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 74)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "msconfig"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ResetGroupBox
        '
        Me.ResetGroupBox.Controls.Add(Me.ResetButton)
        Me.ResetGroupBox.ForeColor = System.Drawing.Color.White
        Me.ResetGroupBox.Location = New System.Drawing.Point(683, 27)
        Me.ResetGroupBox.Name = "ResetGroupBox"
        Me.ResetGroupBox.Size = New System.Drawing.Size(145, 100)
        Me.ResetGroupBox.TabIndex = 2
        Me.ResetGroupBox.TabStop = False
        Me.ResetGroupBox.Text = "Reset"
        '
        'ResetButton
        '
        Me.ResetButton.ForeColor = System.Drawing.Color.Black
        Me.ResetButton.Location = New System.Drawing.Point(6, 19)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(133, 74)
        Me.ResetButton.TabIndex = 0
        Me.ResetButton.Text = "Reset board"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'InfoGroupBox
        '
        Me.InfoGroupBox.Controls.Add(Me.InfoRichTextBox)
        Me.InfoGroupBox.ForeColor = System.Drawing.Color.White
        Me.InfoGroupBox.Location = New System.Drawing.Point(683, 133)
        Me.InfoGroupBox.Name = "InfoGroupBox"
        Me.InfoGroupBox.Size = New System.Drawing.Size(145, 174)
        Me.InfoGroupBox.TabIndex = 3
        Me.InfoGroupBox.TabStop = False
        Me.InfoGroupBox.Text = "Info"
        '
        'InfoRichTextBox
        '
        Me.InfoRichTextBox.BackColor = System.Drawing.Color.Gray
        Me.InfoRichTextBox.ForeColor = System.Drawing.Color.White
        Me.InfoRichTextBox.Location = New System.Drawing.Point(6, 19)
        Me.InfoRichTextBox.Name = "InfoRichTextBox"
        Me.InfoRichTextBox.ReadOnly = True
        Me.InfoRichTextBox.Size = New System.Drawing.Size(133, 144)
        Me.InfoRichTextBox.TabIndex = 0
        Me.InfoRichTextBox.Text = "Beat the scammer!" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "When the scammer says something in any of the boxes, click it." &
    " The aim of the game is to get the scammer to say all 20 things!" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "Good luck!"
        '
        'ScoreGroupBox
        '
        Me.ScoreGroupBox.Controls.Add(Me.ScoreLabel)
        Me.ScoreGroupBox.ForeColor = System.Drawing.Color.White
        Me.ScoreGroupBox.Location = New System.Drawing.Point(683, 313)
        Me.ScoreGroupBox.Name = "ScoreGroupBox"
        Me.ScoreGroupBox.Size = New System.Drawing.Size(145, 57)
        Me.ScoreGroupBox.TabIndex = 4
        Me.ScoreGroupBox.TabStop = False
        Me.ScoreGroupBox.Text = "Score"
        '
        'ScoreLabel
        '
        Me.ScoreLabel.AutoSize = True
        Me.ScoreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScoreLabel.Location = New System.Drawing.Point(39, 20)
        Me.ScoreLabel.Name = "ScoreLabel"
        Me.ScoreLabel.Size = New System.Drawing.Size(71, 26)
        Me.ScoreLabel.TabIndex = 0
        Me.ScoreLabel.Text = "00/20"
        '
        'BingoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(834, 376)
        Me.Controls.Add(Me.ScoreGroupBox)
        Me.Controls.Add(Me.InfoGroupBox)
        Me.Controls.Add(Me.ResetGroupBox)
        Me.Controls.Add(Me.BoardGroupBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "BingoForm"
        Me.Text = "Scammer Bingo"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.BoardGroupBox.ResumeLayout(False)
        Me.ResetGroupBox.ResumeLayout(False)
        Me.InfoGroupBox.ResumeLayout(False)
        Me.ScoreGroupBox.ResumeLayout(False)
        Me.ScoreGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ScammerBingoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutScammerBingoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BoardGroupBox As GroupBox
    Friend WithEvents Button16 As Button
    Friend WithEvents Button17 As Button
    Friend WithEvents Button18 As Button
    Friend WithEvents Button19 As Button
    Friend WithEvents Button20 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ResetGroupBox As GroupBox
    Friend WithEvents ResetButton As Button
    Friend WithEvents InfoGroupBox As GroupBox
    Friend WithEvents InfoRichTextBox As RichTextBox
    Friend WithEvents ScoreGroupBox As GroupBox
    Friend WithEvents ScoreLabel As Label
End Class
