Imports EveTheme

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOthers
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
        Me.EvePanel1 = New EveTheme.EvePanel()
        Me.EveLabel3 = New EveTheme.EveLabel()
        Me.EveLabel2 = New EveTheme.EveLabel()
        Me.EveTextBox1 = New EveTheme.EveTextBox()
        Me.EveComboBox1 = New EveTheme.EveComboBox()
        Me.EveLinkLabel2 = New EveTheme.EveLinkLabel()
        Me.EveWebSeparator1 = New EveTheme.EveWebSeparator()
        Me.EveLabel1 = New EveTheme.EveLabel()
        Me.EvePanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'EvePanel1
        '
        Me.EvePanel1.BackColorEx = System.Drawing.Color.Black
        Me.EvePanel1.BarColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.EvePanel1.Controls.Add(Me.EveLabel3)
        Me.EvePanel1.Controls.Add(Me.EveLabel2)
        Me.EvePanel1.Controls.Add(Me.EveTextBox1)
        Me.EvePanel1.Controls.Add(Me.EveComboBox1)
        Me.EvePanel1.Controls.Add(Me.EveLinkLabel2)
        Me.EvePanel1.Controls.Add(Me.EveWebSeparator1)
        Me.EvePanel1.Controls.Add(Me.EveLabel1)
        Me.EvePanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EvePanel1.Location = New System.Drawing.Point(0, 0)
        Me.EvePanel1.Name = "EvePanel1"
        Me.EvePanel1.Opacity = 0.9!
        Me.EvePanel1.ShowBar = False
        Me.EvePanel1.Size = New System.Drawing.Size(737, 569)
        Me.EvePanel1.TabIndex = 0
        Me.EvePanel1.Wallpaper = Global.Eve_Demo.My.Resources.Resources.background
        '
        'EveLabel3
        '
        Me.EveLabel3.AutoSize = True
        Me.EveLabel3.BackColor = System.Drawing.Color.Transparent
        Me.EveLabel3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.EveLabel3.ForeColor = System.Drawing.Color.White
        Me.EveLabel3.Link = Nothing
        Me.EveLabel3.LinkHoverColor = System.Drawing.Color.White
        Me.EveLabel3.LinkNormalColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.EveLabel3.LinkText = Nothing
        Me.EveLabel3.LinkToolTipText = Nothing
        Me.EveLabel3.Location = New System.Drawing.Point(28, 135)
        Me.EveLabel3.Name = "EveLabel3"
        Me.EveLabel3.ShowBrackets = True
        Me.EveLabel3.Size = New System.Drawing.Size(78, 21)
        Me.EveLabel3.TabIndex = 59
        Me.EveLabel3.Text = "Combobox"
        Me.EveLabel3.ToolTipText = Nothing
        '
        'EveLabel2
        '
        Me.EveLabel2.AutoSize = True
        Me.EveLabel2.BackColor = System.Drawing.Color.Transparent
        Me.EveLabel2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.EveLabel2.ForeColor = System.Drawing.Color.White
        Me.EveLabel2.Link = Nothing
        Me.EveLabel2.LinkHoverColor = System.Drawing.Color.White
        Me.EveLabel2.LinkNormalColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.EveLabel2.LinkText = Nothing
        Me.EveLabel2.LinkToolTipText = Nothing
        Me.EveLabel2.Location = New System.Drawing.Point(28, 103)
        Me.EveLabel2.Name = "EveLabel2"
        Me.EveLabel2.ShowBrackets = True
        Me.EveLabel2.Size = New System.Drawing.Size(164, 21)
        Me.EveLabel2.TabIndex = 58
        Me.EveLabel2.Text = "Textbox with Placeholder:"
        Me.EveLabel2.ToolTipText = Nothing
        '
        'EveTextBox1
        '
        Me.EveTextBox1.BackColor = System.Drawing.SystemColors.Window
        Me.EveTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.EveTextBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.EveTextBox1.ForeColor = System.Drawing.Color.Black
        Me.EveTextBox1.Location = New System.Drawing.Point(198, 102)
        Me.EveTextBox1.MaxLength = 32767
        Me.EveTextBox1.MinimumSize = New System.Drawing.Size(0, 24)
        Me.EveTextBox1.Multiline = False
        Me.EveTextBox1.Name = "EveTextBox1"
        Me.EveTextBox1.PlaceHolder = "Placeholder"
        Me.EveTextBox1.PlaceHolderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.EveTextBox1.ReadOnly = False
        Me.EveTextBox1.Size = New System.Drawing.Size(200, 26)
        Me.EveTextBox1.TabIndex = 57
        Me.EveTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.EveTextBox1.UseSystemPasswordChar = False
        '
        'EveComboBox1
        '
        Me.EveComboBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.EveComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.EveComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EveComboBox1.EnabledCalc = True
        Me.EveComboBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.EveComboBox1.ForeColor = System.Drawing.Color.Black
        Me.EveComboBox1.FormattingEnabled = True
        Me.EveComboBox1.ItemHeight = 20
        Me.EveComboBox1.Items.AddRange(New Object() {"Item1", "Item2", "Item3"})
        Me.EveComboBox1.Location = New System.Drawing.Point(198, 134)
        Me.EveComboBox1.Name = "EveComboBox1"
        Me.EveComboBox1.Size = New System.Drawing.Size(200, 26)
        Me.EveComboBox1.TabIndex = 56
        '
        'EveLinkLabel2
        '
        Me.EveLinkLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EveLinkLabel2.AngleRight = True
        Me.EveLinkLabel2.AutoSize = True
        Me.EveLinkLabel2.BackColor = System.Drawing.Color.Transparent
        Me.EveLinkLabel2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.EveLinkLabel2.ForeColor = System.Drawing.Color.White
        Me.EveLinkLabel2.LinkHoverColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.EveLinkLabel2.LinkNormalColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.EveLinkLabel2.Location = New System.Drawing.Point(614, 35)
        Me.EveLinkLabel2.Name = "EveLinkLabel2"
        Me.EveLinkLabel2.Size = New System.Drawing.Size(111, 23)
        Me.EveLinkLabel2.TabIndex = 54
        Me.EveLinkLabel2.Text = "READ MORE"
        '
        'EveWebSeparator1
        '
        Me.EveWebSeparator1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EveWebSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.EveWebSeparator1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.EveWebSeparator1.Location = New System.Drawing.Point(12, 64)
        Me.EveWebSeparator1.Name = "EveWebSeparator1"
        Me.EveWebSeparator1.Size = New System.Drawing.Size(713, 10)
        Me.EveWebSeparator1.TabIndex = 53
        Me.EveWebSeparator1.Text = "EveWebSeparator1"
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
        Me.EveLabel1.Location = New System.Drawing.Point(12, 28)
        Me.EveLabel1.Name = "EveLabel1"
        Me.EveLabel1.ShowBrackets = True
        Me.EveLabel1.Size = New System.Drawing.Size(180, 30)
        Me.EveLabel1.TabIndex = 0
        Me.EveLabel1.Text = "EVE ONLINE NEWS"
        Me.EveLabel1.ToolTipText = Nothing
        '
        'frmOthers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(737, 569)
        Me.Controls.Add(Me.EvePanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Name = "frmOthers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EVE"
        Me.EvePanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents EvePanel1 As EvePanel
    Friend WithEvents EveLabel1 As EveLabel
    Friend WithEvents EveWebSeparator1 As EveWebSeparator
    Friend WithEvents EveLinkLabel2 As EveLinkLabel
    Friend WithEvents EveTextBox1 As EveTextBox
    Friend WithEvents EveComboBox1 As EveComboBox
    Friend WithEvents EveLabel3 As EveLabel
    Friend WithEvents EveLabel2 As EveLabel
End Class
