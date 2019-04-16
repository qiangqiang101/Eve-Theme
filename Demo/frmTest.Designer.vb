Imports EveTheme

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTest
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.EveNewsItem1 = New EveTheme.EveNewsItem()
        Me.EveSliderItem1 = New EveTheme.EveImageSlider()
        Me.EveNewsItem2 = New EveTheme.EveNewsItem()
        Me.EveNewsItem3 = New EveTheme.EveNewsItem()
        Me.EveNewsItem4 = New EveTheme.EveNewsItem()
        Me.EveFALabel1 = New EveTheme.EveFALabel()
        Me.EveLabel3 = New EveTheme.EveLabel()
        Me.EveSeparator2 = New EveTheme.EveSeparator()
        Me.EveLabel2 = New EveTheme.EveLabel()
        Me.EveSeparator1 = New EveTheme.EveSeparator()
        Me.EveLabel1 = New EveTheme.EveLabel()
        Me.EveButton2 = New EveTheme.EveButton()
        Me.EveTextButton4 = New EveTheme.EveTextButton()
        Me.EveTextButton3 = New EveTheme.EveTextButton()
        Me.EveTextButton2 = New EveTheme.EveTextButton()
        Me.EveProgressBar1 = New EveTheme.EveProgressBar()
        Me.EveControlButtons1 = New EveTheme.EveControlButtons()
        Me.EveContextMenuStrip1 = New EveTheme.EveContextMenuStrip()
        Me.Item1ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Item2ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Item3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EveTextButton1 = New EveTheme.EveTextButton()
        Me.EveButton1 = New EveTheme.EveButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.EveContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Eve_Demo.My.Resources.Resources.eve
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(516, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 40)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel1.Controls.Add(Me.EveNewsItem1)
        Me.FlowLayoutPanel1.Controls.Add(Me.EveSliderItem1)
        Me.FlowLayoutPanel1.Controls.Add(Me.EveNewsItem2)
        Me.FlowLayoutPanel1.Controls.Add(Me.EveNewsItem3)
        Me.FlowLayoutPanel1.Controls.Add(Me.EveNewsItem4)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(12, 108)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1160, 326)
        Me.FlowLayoutPanel1.TabIndex = 16
        '
        'EveNewsItem1
        '
        Me.EveNewsItem1.BackgroundColor = System.Drawing.Color.Black
        Me.EveNewsItem1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EveNewsItem1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.EveNewsItem1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.EveNewsItem1.Image = Global.Eve_Demo.My.Resources.Resources._1983_Videodrome_Poster2
        Me.EveNewsItem1.Link = "https://www.imnotmental.com/"
        Me.EveNewsItem1.Location = New System.Drawing.Point(8, 3)
        Me.EveNewsItem1.Margin = New System.Windows.Forms.Padding(8, 3, 8, 3)
        Me.EveNewsItem1.Name = "EveNewsItem1"
        Me.EveNewsItem1.PubDate = "12/Apr/2019"
        Me.EveNewsItem1.Size = New System.Drawing.Size(272, 317)
        Me.EveNewsItem1.TabIndex = 2
        Me.EveNewsItem1.Text = "Tournament rules and sign-ups for EVE Russia are now available!"
        Me.EveNewsItem1.Title = "Updated: Invasion Tournament Series"
        '
        'EveSliderItem1
        '
        Me.EveSliderItem1.BackColor = System.Drawing.Color.Transparent
        Me.EveSliderItem1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EveSliderItem1.HoverColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.EveSliderItem1.Location = New System.Drawing.Point(296, 3)
        Me.EveSliderItem1.Margin = New System.Windows.Forms.Padding(8, 3, 8, 3)
        Me.EveSliderItem1.Name = "EveSliderItem1"
        Me.EveSliderItem1.NormalColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.EveSliderItem1.Size = New System.Drawing.Size(272, 317)
        Me.EveSliderItem1.TabIndex = 5
        '
        'EveNewsItem2
        '
        Me.EveNewsItem2.BackgroundColor = System.Drawing.Color.Black
        Me.EveNewsItem2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EveNewsItem2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.EveNewsItem2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.EveNewsItem2.Image = Global.Eve_Demo.My.Resources.Resources._1982_The_Escape_Artist_Poster1
        Me.EveNewsItem2.Link = "https://www.imnotmental.com/"
        Me.EveNewsItem2.Location = New System.Drawing.Point(584, 3)
        Me.EveNewsItem2.Margin = New System.Windows.Forms.Padding(8, 3, 8, 3)
        Me.EveNewsItem2.Name = "EveNewsItem2"
        Me.EveNewsItem2.PubDate = "11/Apr/2019"
        Me.EveNewsItem2.Size = New System.Drawing.Size(272, 317)
        Me.EveNewsItem2.TabIndex = 6
        Me.EveNewsItem2.Text = "We are happy to share that the Streamfleet Showdown Invitation will be the first " &
    "CCP supported..."
        Me.EveNewsItem2.Title = "Streamfleet Showdown Invitational"
        '
        'EveNewsItem3
        '
        Me.EveNewsItem3.BackgroundColor = System.Drawing.Color.Black
        Me.EveNewsItem3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EveNewsItem3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.EveNewsItem3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.EveNewsItem3.Image = Global.Eve_Demo.My.Resources.Resources._1981_Gallipoli_Poster1
        Me.EveNewsItem3.Link = "https://www.imnotmental.com/"
        Me.EveNewsItem3.Location = New System.Drawing.Point(872, 3)
        Me.EveNewsItem3.Margin = New System.Windows.Forms.Padding(8, 3, 8, 3)
        Me.EveNewsItem3.Name = "EveNewsItem3"
        Me.EveNewsItem3.PubDate = "11/Apr/2019"
        Me.EveNewsItem3.Size = New System.Drawing.Size(272, 317)
        Me.EveNewsItem3.TabIndex = 3
        Me.EveNewsItem3.Text = "The a look at this devblog for more information on what's happening with New..."
        Me.EveNewsItem3.Title = "Monthy Economic Report - March 2019"
        '
        'EveNewsItem4
        '
        Me.EveNewsItem4.BackgroundColor = System.Drawing.Color.Black
        Me.EveNewsItem4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EveNewsItem4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.EveNewsItem4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.EveNewsItem4.Image = Global.Eve_Demo.My.Resources.Resources._3_Stooges_Poster3
        Me.EveNewsItem4.Link = "https://www.imnotmental.com/"
        Me.EveNewsItem4.Location = New System.Drawing.Point(1160, 3)
        Me.EveNewsItem4.Margin = New System.Windows.Forms.Padding(8, 3, 8, 3)
        Me.EveNewsItem4.Name = "EveNewsItem4"
        Me.EveNewsItem4.PubDate = "09/Apr/2019"
        Me.EveNewsItem4.Size = New System.Drawing.Size(272, 317)
        Me.EveNewsItem4.TabIndex = 7
        Me.EveNewsItem4.Text = "Take a look at this news item for full details on the April release, including..." &
    ""
        Me.EveNewsItem4.Title = "The April Release is now Live!"
        '
        'EveFALabel1
        '
        Me.EveFALabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.EveFALabel1.AutoSize = True
        Me.EveFALabel1.BackColor = System.Drawing.Color.Transparent
        Me.EveFALabel1.FAIcon = ""
        Me.EveFALabel1.Font = New System.Drawing.Font("FontAwesome", 13.0!)
        Me.EveFALabel1.ForeColor = System.Drawing.Color.White
        Me.EveFALabel1.HoverColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.EveFALabel1.LinkNormalColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.EveFALabel1.Location = New System.Drawing.Point(25, 523)
        Me.EveFALabel1.Name = "EveFALabel1"
        Me.EveFALabel1.Size = New System.Drawing.Size(25, 20)
        Me.EveFALabel1.TabIndex = 27
        Me.EveFALabel1.Text = "test"
        Me.EveFALabel1.ToolTipPosition = EveTheme.ToolTipPos.Right
        Me.EveFALabel1.ToolTipText = "Launcher settings"
        '
        'EveLabel3
        '
        Me.EveLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.EveLabel3.AutoSize = True
        Me.EveLabel3.BackColor = System.Drawing.Color.Transparent
        Me.EveLabel3.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.EveLabel3.ForeColor = System.Drawing.Color.White
        Me.EveLabel3.Link = ""
        Me.EveLabel3.LinkHoverColor = System.Drawing.Color.White
        Me.EveLabel3.LinkNormalColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.EveLabel3.LinkText = "Patch Notes"
        Me.EveLabel3.LinkToolTipText = Nothing
        Me.EveLabel3.Location = New System.Drawing.Point(335, 543)
        Me.EveLabel3.Name = "EveLabel3"
        Me.EveLabel3.ShowBrackets = True
        Me.EveLabel3.Size = New System.Drawing.Size(41, 22)
        Me.EveLabel3.TabIndex = 25
        Me.EveLabel3.Text = "6.1.9"
        Me.EveLabel3.ToolTipText = Nothing
        '
        'EveSeparator2
        '
        Me.EveSeparator2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.EveSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.EveSeparator2.Location = New System.Drawing.Point(324, 543)
        Me.EveSeparator2.Name = "EveSeparator2"
        Me.EveSeparator2.Size = New System.Drawing.Size(5, 22)
        Me.EveSeparator2.Style = EveTheme.EveSeparator.SStyle.Vertical
        Me.EveSeparator2.TabIndex = 24
        Me.EveSeparator2.Text = "EveSeparator2"
        Me.EveSeparator2.Thickness = 2
        '
        'EveLabel2
        '
        Me.EveLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.EveLabel2.AutoSize = True
        Me.EveLabel2.BackColor = System.Drawing.Color.Transparent
        Me.EveLabel2.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.EveLabel2.ForeColor = System.Drawing.Color.White
        Me.EveLabel2.Link = ""
        Me.EveLabel2.LinkHoverColor = System.Drawing.Color.White
        Me.EveLabel2.LinkNormalColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.EveLabel2.LinkText = ""
        Me.EveLabel2.LinkToolTipText = "Launcher version"
        Me.EveLabel2.Location = New System.Drawing.Point(251, 543)
        Me.EveLabel2.Name = "EveLabel2"
        Me.EveLabel2.ShowBrackets = True
        Me.EveLabel2.Size = New System.Drawing.Size(67, 22)
        Me.EveLabel2.TabIndex = 22
        Me.EveLabel2.Text = "1456374"
        Me.EveLabel2.ToolTipText = "Launcher version"
        '
        'EveSeparator1
        '
        Me.EveSeparator1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.EveSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.EveSeparator1.Location = New System.Drawing.Point(236, 543)
        Me.EveSeparator1.Name = "EveSeparator1"
        Me.EveSeparator1.Size = New System.Drawing.Size(5, 22)
        Me.EveSeparator1.Style = EveTheme.EveSeparator.SStyle.Vertical
        Me.EveSeparator1.TabIndex = 20
        Me.EveSeparator1.Text = "EveSeparator1"
        Me.EveSeparator1.Thickness = 2
        '
        'EveLabel1
        '
        Me.EveLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.EveLabel1.AutoSize = True
        Me.EveLabel1.BackColor = System.Drawing.Color.Transparent
        Me.EveLabel1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.EveLabel1.ForeColor = System.Drawing.Color.White
        Me.EveLabel1.Link = "https://www.eveonline.com/articles/patch-notes/?origin=launcher"
        Me.EveLabel1.LinkHoverColor = System.Drawing.Color.White
        Me.EveLabel1.LinkNormalColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.EveLabel1.LinkText = "Patch Notes"
        Me.EveLabel1.LinkToolTipText = "Patch note for live server"
        Me.EveLabel1.Location = New System.Drawing.Point(62, 543)
        Me.EveLabel1.Name = "EveLabel1"
        Me.EveLabel1.ShowBrackets = True
        Me.EveLabel1.Size = New System.Drawing.Size(168, 22)
        Me.EveLabel1.TabIndex = 18
        Me.EveLabel1.Text = "1487069"
        Me.EveLabel1.ToolTipText = "Client Version"
        '
        'EveButton2
        '
        Me.EveButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.EveButton2.BackColor = System.Drawing.Color.GhostWhite
        Me.EveButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EveButton2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.EveButton2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.EveButton2.HoveredColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.EveButton2.Location = New System.Drawing.Point(247, 457)
        Me.EveButton2.Name = "EveButton2"
        Me.EveButton2.NormalColor = System.Drawing.Color.GhostWhite
        Me.EveButton2.Size = New System.Drawing.Size(202, 45)
        Me.EveButton2.TabIndex = 14
        Me.EveButton2.Text = "ADD ACCOUNT"
        Me.EveButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EveTextButton4
        '
        Me.EveTextButton4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.EveTextButton4.AutoSize = True
        Me.EveTextButton4.BackColor = System.Drawing.Color.Transparent
        Me.EveTextButton4.BarColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.EveTextButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EveTextButton4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.EveTextButton4.ForeColor = System.Drawing.Color.White
        Me.EveTextButton4.Location = New System.Drawing.Point(888, 37)
        Me.EveTextButton4.Name = "EveTextButton4"
        Me.EveTextButton4.Size = New System.Drawing.Size(71, 30)
        Me.EveTextButton4.TabIndex = 12
        Me.EveTextButton4.Text = "SUPPORT"
        '
        'EveTextButton3
        '
        Me.EveTextButton3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.EveTextButton3.AutoSize = True
        Me.EveTextButton3.BackColor = System.Drawing.Color.Transparent
        Me.EveTextButton3.BarColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.EveTextButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EveTextButton3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.EveTextButton3.ForeColor = System.Drawing.Color.White
        Me.EveTextButton3.Location = New System.Drawing.Point(704, 37)
        Me.EveTextButton3.Name = "EveTextButton3"
        Me.EveTextButton3.Size = New System.Drawing.Size(160, 30)
        Me.EveTextButton3.TabIndex = 11
        Me.EveTextButton3.Text = "ACCOUNT MANAGEMENT"
        '
        'EveTextButton2
        '
        Me.EveTextButton2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.EveTextButton2.AutoSize = True
        Me.EveTextButton2.BackColor = System.Drawing.Color.Transparent
        Me.EveTextButton2.BarColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.EveTextButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EveTextButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.EveTextButton2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.EveTextButton2.Location = New System.Drawing.Point(361, 37)
        Me.EveTextButton2.Name = "EveTextButton2"
        Me.EveTextButton2.Size = New System.Drawing.Size(120, 30)
        Me.EveTextButton2.TabIndex = 10
        Me.EveTextButton2.Text = "ADD OMEGA TIME"
        '
        'EveProgressBar1
        '
        Me.EveProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EveProgressBar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.EveProgressBar1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.EveProgressBar1.ForegroundColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.EveProgressBar1.Location = New System.Drawing.Point(62, 532)
        Me.EveProgressBar1.MarqueeAnimationSpeed = 5.0!
        Me.EveProgressBar1.Maximum = 100
        Me.EveProgressBar1.Minimum = 0
        Me.EveProgressBar1.Name = "EveProgressBar1"
        Me.EveProgressBar1.Size = New System.Drawing.Size(1098, 5)
        Me.EveProgressBar1.Style = EveTheme.EveProgressBar.PBStyle.Continuous
        Me.EveProgressBar1.TabIndex = 8
        Me.EveProgressBar1.Text = "EveProgressBar1"
        Me.EveProgressBar1.Value = 50
        '
        'EveControlButtons1
        '
        Me.EveControlButtons1.AllowMoveform = True
        Me.EveControlButtons1.BackColor = System.Drawing.Color.Transparent
        Me.EveControlButtons1.ContextMenuStrip = Me.EveContextMenuStrip1
        Me.EveControlButtons1.ControlButton1 = EveTheme.EveControlButtons.ControlButtonType.Close
        Me.EveControlButtons1.ControlButton2 = EveTheme.EveControlButtons.ControlButtonType.Minimize
        Me.EveControlButtons1.ControlButton3 = EveTheme.EveControlButtons.ControlButtonType.Menu
        Me.EveControlButtons1.ControlButton4 = EveTheme.EveControlButtons.ControlButtonType.Help
        Me.EveControlButtons1.ControlButton5 = EveTheme.EveControlButtons.ControlButtonType.[Nothing]
        Me.EveControlButtons1.Dock = System.Windows.Forms.DockStyle.Top
        Me.EveControlButtons1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.EveControlButtons1.ForeColor = System.Drawing.Color.White
        Me.EveControlButtons1.HoveredBackColor = System.Drawing.Color.White
        Me.EveControlButtons1.HoveredColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.EveControlButtons1.Location = New System.Drawing.Point(0, 0)
        Me.EveControlButtons1.Name = "EveControlButtons1"
        Me.EveControlButtons1.NormalColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.EveControlButtons1.Showtitle = False
        Me.EveControlButtons1.Size = New System.Drawing.Size(1184, 25)
        Me.EveControlButtons1.TabIndex = 7
        Me.EveControlButtons1.Text = "EveControlButtons1"
        '
        'EveContextMenuStrip1
        '
        Me.EveContextMenuStrip1.ForeColor = System.Drawing.Color.White
        Me.EveContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Item1ToolStripMenuItem1, Me.ToolStripSeparator1, Me.Item2ToolStripMenuItem1, Me.Item3ToolStripMenuItem, Me.ClientSettingsToolStripMenuItem})
        Me.EveContextMenuStrip1.Name = "EveContextMenuStrip1"
        Me.EveContextMenuStrip1.ShowImageMargin = False
        Me.EveContextMenuStrip1.Size = New System.Drawing.Size(138, 98)
        '
        'Item1ToolStripMenuItem1
        '
        Me.Item1ToolStripMenuItem1.Name = "Item1ToolStripMenuItem1"
        Me.Item1ToolStripMenuItem1.Size = New System.Drawing.Size(137, 22)
        Me.Item1ToolStripMenuItem1.Text = "Server List"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(134, 6)
        '
        'Item2ToolStripMenuItem1
        '
        Me.Item2ToolStripMenuItem1.Name = "Item2ToolStripMenuItem1"
        Me.Item2ToolStripMenuItem1.Size = New System.Drawing.Size(137, 22)
        Me.Item2ToolStripMenuItem1.Text = "Settings..."
        '
        'Item3ToolStripMenuItem
        '
        Me.Item3ToolStripMenuItem.Name = "Item3ToolStripMenuItem"
        Me.Item3ToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.Item3ToolStripMenuItem.Text = "Shared Cached..."
        '
        'ClientSettingsToolStripMenuItem
        '
        Me.ClientSettingsToolStripMenuItem.Name = "ClientSettingsToolStripMenuItem"
        Me.ClientSettingsToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.ClientSettingsToolStripMenuItem.Text = "Client Settings..."
        '
        'EveTextButton1
        '
        Me.EveTextButton1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.EveTextButton1.AutoSize = True
        Me.EveTextButton1.BackColor = System.Drawing.Color.Transparent
        Me.EveTextButton1.BarColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.EveTextButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EveTextButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.EveTextButton1.ForeColor = System.Drawing.Color.White
        Me.EveTextButton1.Location = New System.Drawing.Point(291, 37)
        Me.EveTextButton1.Name = "EveTextButton1"
        Me.EveTextButton1.Size = New System.Drawing.Size(51, 30)
        Me.EveTextButton1.TabIndex = 4
        Me.EveTextButton1.Text = "NEWS"
        '
        'EveButton1
        '
        Me.EveButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.EveButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.EveButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EveButton1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.EveButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.EveButton1.HoveredColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.EveButton1.Location = New System.Drawing.Point(28, 457)
        Me.EveButton1.Name = "EveButton1"
        Me.EveButton1.NormalColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.EveButton1.Size = New System.Drawing.Size(202, 45)
        Me.EveButton1.TabIndex = 0
        Me.EveButton1.Text = "PLAY NOW"
        Me.EveButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.Eve_Demo.My.Resources.Resources._153450
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1184, 580)
        Me.Controls.Add(Me.EveFALabel1)
        Me.Controls.Add(Me.EveLabel3)
        Me.Controls.Add(Me.EveSeparator2)
        Me.Controls.Add(Me.EveLabel2)
        Me.Controls.Add(Me.EveSeparator1)
        Me.Controls.Add(Me.EveLabel1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.EveButton2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.EveTextButton4)
        Me.Controls.Add(Me.EveTextButton3)
        Me.Controls.Add(Me.EveTextButton2)
        Me.Controls.Add(Me.EveProgressBar1)
        Me.Controls.Add(Me.EveControlButtons1)
        Me.Controls.Add(Me.EveTextButton1)
        Me.Controls.Add(Me.EveButton1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(1184, 580)
        Me.Name = "frmTest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EVE"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.EveContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents EveButton1 As EveButton
    Friend WithEvents EveNewsItem1 As EveNewsItem
    Friend WithEvents EveTextButton1 As EveTextButton
    Friend WithEvents EveSliderItem1 As EveImageSlider
    Friend WithEvents EveControlButtons1 As EveControlButtons
    Friend WithEvents EveProgressBar1 As EveProgressBar
    Friend WithEvents EveContextMenuStrip1 As EveContextMenuStrip
    Friend WithEvents Item1ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Item2ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents Item3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EveTextButton2 As EveTextButton
    Friend WithEvents EveTextButton3 As EveTextButton
    Friend WithEvents EveTextButton4 As EveTextButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents EveButton2 As EveButton
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents EveNewsItem2 As EveNewsItem
    Friend WithEvents EveNewsItem3 As EveNewsItem
    Friend WithEvents EveNewsItem4 As EveNewsItem
    Friend WithEvents EveLabel1 As EveLabel
    Friend WithEvents EveSeparator1 As EveSeparator
    Friend WithEvents EveLabel2 As EveLabel
    Friend WithEvents EveSeparator2 As EveSeparator
    Friend WithEvents EveLabel3 As EveLabel
    Friend WithEvents EveFALabel1 As EveFALabel
    Friend WithEvents ClientSettingsToolStripMenuItem As ToolStripMenuItem
End Class
