Imports EveTheme

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLoginTest
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.EvePanel2 = New EveTheme.EvePanel()
        Me.EveLabel3 = New EveTheme.EveLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.EvePanel1 = New EveTheme.EvePanel()
        Me.EveSocialButton2 = New EveTheme.EveSocialButton()
        Me.EveSocialButton1 = New EveTheme.EveSocialButton()
        Me.EveLinkLabel1 = New EveTheme.EveLinkLabel()
        Me.EveLabel2 = New EveTheme.EveLabel()
        Me.EveButton1 = New EveTheme.EveButton()
        Me.EveCheckbox1 = New EveTheme.EveCheckbox()
        Me.EveWebTextBox2 = New EveTheme.EveWebTextBox()
        Me.EveWebTextBox1 = New EveTheme.EveWebTextBox()
        Me.EveLabel1 = New EveTheme.EveLabel()
        Me.EvePanel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EvePanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'EvePanel2
        '
        Me.EvePanel2.BackColorEx = System.Drawing.Color.Black
        Me.EvePanel2.BarColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.EvePanel2.Controls.Add(Me.EveLabel3)
        Me.EvePanel2.Controls.Add(Me.PictureBox1)
        Me.EvePanel2.Controls.Add(Me.EvePanel1)
        Me.EvePanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EvePanel2.Location = New System.Drawing.Point(0, 0)
        Me.EvePanel2.Name = "EvePanel2"
        Me.EvePanel2.Opacity = 1.0!
        Me.EvePanel2.ShowBar = False
        Me.EvePanel2.Size = New System.Drawing.Size(570, 644)
        Me.EvePanel2.TabIndex = 51
        Me.EvePanel2.Wallpaper = Global.EVE_Demo.My.Resources.Resources.background
        '
        'EveLabel3
        '
        Me.EveLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.EveLabel3.AutoSize = True
        Me.EveLabel3.BackColor = System.Drawing.Color.Transparent
        Me.EveLabel3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.EveLabel3.ForeColor = System.Drawing.Color.White
        Me.EveLabel3.Link = "https://secure.eveonline.com/signup/"
        Me.EveLabel3.LinkHoverColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.EveLabel3.LinkNormalColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.EveLabel3.LinkText = "CREATE ACCOUNT"
        Me.EveLabel3.LinkToolTipText = Nothing
        Me.EveLabel3.Location = New System.Drawing.Point(131, 595)
        Me.EveLabel3.Name = "EveLabel3"
        Me.EveLabel3.ShowBrackets = False
        Me.EveLabel3.Size = New System.Drawing.Size(307, 23)
        Me.EveLabel3.TabIndex = 50
        Me.EveLabel3.Text = "NEW TO EVE ONLINE?"
        Me.EveLabel3.ToolTipText = Nothing
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.EVE_Demo.My.Resources.Resources.eve
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(210, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(157, 71)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'EvePanel1
        '
        Me.EvePanel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.EvePanel1.BackColorEx = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(8, Byte), Integer))
        Me.EvePanel1.BarColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.EvePanel1.Controls.Add(Me.EveSocialButton2)
        Me.EvePanel1.Controls.Add(Me.EveSocialButton1)
        Me.EvePanel1.Controls.Add(Me.EveLinkLabel1)
        Me.EvePanel1.Controls.Add(Me.EveLabel2)
        Me.EvePanel1.Controls.Add(Me.EveButton1)
        Me.EvePanel1.Controls.Add(Me.EveCheckbox1)
        Me.EvePanel1.Controls.Add(Me.EveWebTextBox2)
        Me.EvePanel1.Controls.Add(Me.EveWebTextBox1)
        Me.EvePanel1.Controls.Add(Me.EveLabel1)
        Me.EvePanel1.Location = New System.Drawing.Point(43, 106)
        Me.EvePanel1.Name = "EvePanel1"
        Me.EvePanel1.Opacity = 0.5!
        Me.EvePanel1.ShowBar = False
        Me.EvePanel1.Size = New System.Drawing.Size(484, 462)
        Me.EvePanel1.TabIndex = 15
        Me.EvePanel1.Wallpaper = Nothing
        '
        'EveSocialButton2
        '
        Me.EveSocialButton2.BackColor = System.Drawing.Color.Transparent
        Me.EveSocialButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EveSocialButton2.CustomIcon = ""
        Me.EveSocialButton2.ForeColor = System.Drawing.Color.White
        Me.EveSocialButton2.HoverColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.EveSocialButton2.LinkNormalColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.EveSocialButton2.Location = New System.Drawing.Point(360, 402)
        Me.EveSocialButton2.Name = "EveSocialButton2"
        Me.EveSocialButton2.Size = New System.Drawing.Size(35, 35)
        Me.EveSocialButton2.SocialIcon = EveTheme.EveSocialButton.SocialIcons.steam
        Me.EveSocialButton2.TabIndex = 51
        Me.EveSocialButton2.Text = ""
        '
        'EveSocialButton1
        '
        Me.EveSocialButton1.BackColor = System.Drawing.Color.Transparent
        Me.EveSocialButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EveSocialButton1.CustomIcon = ""
        Me.EveSocialButton1.ForeColor = System.Drawing.Color.White
        Me.EveSocialButton1.HoverColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.EveSocialButton1.LinkNormalColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.EveSocialButton1.Location = New System.Drawing.Point(400, 402)
        Me.EveSocialButton1.Name = "EveSocialButton1"
        Me.EveSocialButton1.Size = New System.Drawing.Size(35, 35)
        Me.EveSocialButton1.SocialIcon = EveTheme.EveSocialButton.SocialIcons.facebook
        Me.EveSocialButton1.TabIndex = 50
        Me.EveSocialButton1.Text = " "
        '
        'EveLinkLabel1
        '
        Me.EveLinkLabel1.AngleRight = False
        Me.EveLinkLabel1.AutoSize = True
        Me.EveLinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.EveLinkLabel1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.EveLinkLabel1.ForeColor = System.Drawing.Color.White
        Me.EveLinkLabel1.LinkHoverColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.EveLinkLabel1.LinkNormalColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.EveLinkLabel1.Location = New System.Drawing.Point(320, 361)
        Me.EveLinkLabel1.Name = "EveLinkLabel1"
        Me.EveLinkLabel1.Size = New System.Drawing.Size(120, 21)
        Me.EveLinkLabel1.TabIndex = 49
        Me.EveLinkLabel1.Text = "Forgot password?"
        '
        'EveLabel2
        '
        Me.EveLabel2.AutoSize = True
        Me.EveLabel2.BackColor = System.Drawing.Color.Transparent
        Me.EveLabel2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.EveLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.EveLabel2.Link = Nothing
        Me.EveLabel2.LinkHoverColor = System.Drawing.Color.White
        Me.EveLabel2.LinkNormalColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.EveLabel2.LinkText = Nothing
        Me.EveLabel2.LinkToolTipText = Nothing
        Me.EveLabel2.Location = New System.Drawing.Point(39, 413)
        Me.EveLabel2.Name = "EveLabel2"
        Me.EveLabel2.ShowBrackets = True
        Me.EveLabel2.Size = New System.Drawing.Size(144, 21)
        Me.EveLabel2.TabIndex = 48
        Me.EveLabel2.Text = "Other sign-in services"
        Me.EveLabel2.ToolTipText = Nothing
        '
        'EveButton1
        '
        Me.EveButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.EveButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EveButton1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.EveButton1.ForeColor = System.Drawing.Color.White
        Me.EveButton1.HoveredColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.EveButton1.Location = New System.Drawing.Point(42, 297)
        Me.EveButton1.Name = "EveButton1"
        Me.EveButton1.NormalColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.EveButton1.Size = New System.Drawing.Size(398, 54)
        Me.EveButton1.TabIndex = 47
        Me.EveButton1.Text = "LOG IN"
        Me.EveButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EveCheckbox1
        '
        Me.EveCheckbox1.AutoSize = True
        Me.EveCheckbox1.BackColor = System.Drawing.Color.Transparent
        Me.EveCheckbox1.CheckBoxColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.EveCheckbox1.Checked = False
        Me.EveCheckbox1.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EveCheckbox1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.EveCheckbox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.EveCheckbox1.Location = New System.Drawing.Point(39, 263)
        Me.EveCheckbox1.Name = "EveCheckbox1"
        Me.EveCheckbox1.Size = New System.Drawing.Size(139, 22)
        Me.EveCheckbox1.TabIndex = 46
        Me.EveCheckbox1.Text = "Remember me"
        '
        'EveWebTextBox2
        '
        Me.EveWebTextBox2.BackColor = System.Drawing.Color.Transparent
        Me.EveWebTextBox2.Caption = "PASSWORD"
        Me.EveWebTextBox2.CaptionColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.EveWebTextBox2.CaptionFocusedColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.EveWebTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.EveWebTextBox2.Errorcolor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.EveWebTextBox2.ErrorText = "Please enter a password"
        Me.EveWebTextBox2.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.EveWebTextBox2.ForeColor = System.Drawing.Color.White
        Me.EveWebTextBox2.IsError = True
        Me.EveWebTextBox2.Location = New System.Drawing.Point(39, 188)
        Me.EveWebTextBox2.MaxLength = 32767
        Me.EveWebTextBox2.Multiline = False
        Me.EveWebTextBox2.Name = "EveWebTextBox2"
        Me.EveWebTextBox2.ReadOnly = False
        Me.EveWebTextBox2.Size = New System.Drawing.Size(403, 69)
        Me.EveWebTextBox2.TabIndex = 45
        Me.EveWebTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.EveWebTextBox2.UseSystemPasswordChar = False
        '
        'EveWebTextBox1
        '
        Me.EveWebTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.EveWebTextBox1.Caption = "USERNAME"
        Me.EveWebTextBox1.CaptionColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.EveWebTextBox1.CaptionFocusedColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.EveWebTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.EveWebTextBox1.Errorcolor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.EveWebTextBox1.ErrorText = "Please enter username"
        Me.EveWebTextBox1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.EveWebTextBox1.ForeColor = System.Drawing.Color.White
        Me.EveWebTextBox1.IsError = False
        Me.EveWebTextBox1.Location = New System.Drawing.Point(39, 113)
        Me.EveWebTextBox1.MaxLength = 32767
        Me.EveWebTextBox1.Multiline = False
        Me.EveWebTextBox1.Name = "EveWebTextBox1"
        Me.EveWebTextBox1.ReadOnly = False
        Me.EveWebTextBox1.Size = New System.Drawing.Size(403, 69)
        Me.EveWebTextBox1.TabIndex = 44
        Me.EveWebTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.EveWebTextBox1.UseSystemPasswordChar = False
        '
        'EveLabel1
        '
        Me.EveLabel1.AutoSize = True
        Me.EveLabel1.BackColor = System.Drawing.Color.Transparent
        Me.EveLabel1.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.EveLabel1.ForeColor = System.Drawing.Color.White
        Me.EveLabel1.Link = Nothing
        Me.EveLabel1.LinkHoverColor = System.Drawing.Color.White
        Me.EveLabel1.LinkNormalColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.EveLabel1.LinkText = Nothing
        Me.EveLabel1.LinkToolTipText = Nothing
        Me.EveLabel1.Location = New System.Drawing.Point(115, 39)
        Me.EveLabel1.Name = "EveLabel1"
        Me.EveLabel1.ShowBrackets = True
        Me.EveLabel1.Size = New System.Drawing.Size(255, 30)
        Me.EveLabel1.TabIndex = 0
        Me.EveLabel1.Text = "LOG IN TO YOUR ACCOUNT"
        Me.EveLabel1.ToolTipText = Nothing
        '
        'frmLoginTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(570, 644)
        Me.Controls.Add(Me.EvePanel2)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Name = "frmLoginTest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EVE"
        Me.EvePanel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EvePanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents EvePanel1 As EvePanel
    Friend WithEvents EveLabel1 As EveLabel
    Friend WithEvents EveLabel2 As EveLabel
    Friend WithEvents EveButton1 As EveButton
    Friend WithEvents EveCheckbox1 As EveCheckbox
    Friend WithEvents EveWebTextBox2 As EveWebTextBox
    Friend WithEvents EveWebTextBox1 As EveWebTextBox
    Friend WithEvents EveLinkLabel1 As EveLinkLabel
    Friend WithEvents EveLabel3 As EveLabel
    Friend WithEvents EvePanel2 As EvePanel
    Friend WithEvents EveSocialButton1 As EveSocialButton
    Friend WithEvents EveSocialButton2 As EveSocialButton
End Class
