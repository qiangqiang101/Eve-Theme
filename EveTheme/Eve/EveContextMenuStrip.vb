Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Public Class EveContextMenuStrip
    Inherits ContextMenuStrip

    Protected Overrides Sub OnTextChanged(e As EventArgs)
        MyBase.OnTextChanged(e)

        Invalidate()
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        Dim formGraphics As Graphics = e.Graphics
        formGraphics.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit
    End Sub

    Public Sub New()
        MyBase.New

        SetStyle(ControlStyles.UserPaint, True)
        Renderer = New ToolStripProfessionalRenderer(New TColorTable())
        ShowImageMargin = False
        ForeColor = Color.White
        DoubleBuffered = True
    End Sub

    Class TColorTable
        Inherits ProfessionalColorTable

        Private _backcolor As Color = Color.FromArgb(21, 30, 39)
        <Category("Appearance")>
        Public Property BackColor() As Color
            Get
                Return _backcolor
            End Get
            Set(value As Color)
                _backcolor = value
            End Set
        End Property

        Private _checkedcolor As Color = Color.FromArgb(33, 47, 66)
        <Category("Appearance")>
        Public Property CheckedColor() As Color
            Get
                Return _checkedcolor
            End Get
            Set(value As Color)
                _checkedcolor = value
            End Set
        End Property

        Private _bordercolor As Color = Color.Transparent
        <Category("Appearance")>
        Public Property BorderColor() As Color
            Get
                Return _bordercolor
            End Get
            Set(value As Color)
                _bordercolor = value
            End Set
        End Property

        Private _separatorcolor As Color = Color.FromArgb(15, 19, 25)
        <Category("Appearance")>
        Public Property SeparatorColor() As Color
            Get
                Return _separatorcolor
            End Get
            Set(value As Color)
                _separatorcolor = value
            End Set
        End Property

        Public Overrides ReadOnly Property ButtonSelectedBorder As Color
            Get
                Return _backcolor
            End Get
        End Property
        Public Overrides ReadOnly Property CheckBackground() As Color
            Get
                Return _checkedcolor
            End Get
        End Property
        Public Overrides ReadOnly Property CheckPressedBackground() As Color
            Get
                Return _checkedcolor
            End Get
        End Property
        Public Overrides ReadOnly Property CheckSelectedBackground() As Color
            Get
                Return _checkedcolor
            End Get
        End Property
        Public Overrides ReadOnly Property ImageMarginGradientBegin() As Color
            Get
                Return _checkedcolor
            End Get
        End Property
        Public Overrides ReadOnly Property ImageMarginGradientEnd() As Color
            Get
                Return _checkedcolor
            End Get
        End Property
        Public Overrides ReadOnly Property ImageMarginGradientMiddle() As Color
            Get
                Return _checkedcolor
            End Get
        End Property
        Public Overrides ReadOnly Property MenuBorder() As Color
            Get
                Return _bordercolor
            End Get
        End Property
        Public Overrides ReadOnly Property MenuItemBorder() As Color
            Get
                Return _bordercolor
            End Get
        End Property
        Public Overrides ReadOnly Property MenuItemSelected() As Color
            Get
                Return _checkedcolor
            End Get
        End Property
        Public Overrides ReadOnly Property SeparatorDark() As Color
            Get
                Return _separatorcolor
            End Get
        End Property
        Public Overrides ReadOnly Property ToolStripDropDownBackground() As Color
            Get
                Return _backcolor
            End Get
        End Property

    End Class

End Class
