Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

<DefaultEvent("Click")>
Public Class EveFAButton
    Inherits Control

    Dim rectFA, rectText As Rectangle
    Dim _mousePos As Point = Point.Empty
    Private _mouseText As Boolean = False
    Private _parent As Control = Nothing

    Private _fa As String = ""
    <Category("Behavior")>
    Public Property FAIcon() As String
        Get
            Return _fa
        End Get
        Set(value As String)
            _fa = value
        End Set
    End Property

    <Browsable(True),
    EditorBrowsable(System.ComponentModel.EditorBrowsableState.Always),
    DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Shadows Property Text() As String
        Get
            Return MyBase.Text
        End Get
        Set(value As String)
            MyBase.Text = value
            SetBoundsCore(Location.X, Location.Y, Size.Width, Size.Height, BoundsSpecified.Size)
            Invalidate()
        End Set
    End Property

    Private _normalcolor As Color = Color.White
    <Category("Appearance")>
    Public Property LinkNormalColor() As Color
        Get
            Return _normalcolor
        End Get
        Set(value As Color)
            _normalcolor = value
            Invalidate()
        End Set
    End Property

    Private _hovercolor As Color = Color.FromArgb(117, 117, 117)
    <Category("Appearance")>
    Public Property HoverColor() As Color
        Get
            Return _hovercolor
        End Get
        Set(value As Color)
            _hovercolor = value
            Invalidate()
        End Set
    End Property

    Private _tooltiptext As String
    <Category("Behavior")>
    Public Property ToolTipText() As String
        Get
            Return _tooltiptext
        End Get
        Set(value As String)
            _tooltiptext = value
        End Set
    End Property

    <Browsable(False),
    EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never),
    DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public ReadOnly Property ShowToolTip() As Boolean
        Get
            Return Not String.IsNullOrEmpty(_tooltiptext)
        End Get
    End Property

    Private _tooltippos As ToolTipPos = ToolTipPos.Right
    <Category("Appearance")>
    Public Property ToolTipPosition() As ToolTipPos
        Get
            Return _tooltippos
        End Get
        Set(value As ToolTipPos)
            _tooltippos = value
        End Set
    End Property

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        Dim formGraphics As Graphics = e.Graphics
        Dim sbrush As New SolidBrush(_normalcolor)
        Dim pen As New Pen(sbrush)

        formGraphics.DrawRectangle(pen, New Rectangle(0, 0, Width - 1, Height - 1))

        Using f As Font = Font
            rectFA = New Rectangle(1, (Height - IconHeight()) / 2, IconWidth, IconHeight)
            Dim rectFAs As New Rectangle(2, ((Height - IconHeight()) / 2) + 1, IconWidth, IconHeight)
            rectText = New Rectangle(rectFA.Width, (Height - TextHeight()) / 2, TextWidth, TextHeight)
            Dim rectTexts As New Rectangle(rectFA.Width + 1, ((Height - TextHeight()) / 2) + 1, TextWidth() - rectFA.Width - 1, TextHeight)

            Dim flags As TextFormatFlags = TextFormatFlags.Left Or TextFormatFlags.WordBreak
            formGraphics.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias

            TextRenderer.DrawText(formGraphics, _fa, FontAwesome.GetInstance(13.0F, FontStyle.Regular), rectFAs, Color.Black, flags)
            TextRenderer.DrawText(formGraphics, _fa, FontAwesome.GetInstance(13.0F, FontStyle.Regular), rectFA, _normalcolor, flags)

            TextRenderer.DrawText(formGraphics, Text, f, rectTexts, Color.Black, flags)
            TextRenderer.DrawText(formGraphics, Text, f, rectText, If(_mouseText, _hovercolor, _normalcolor), flags)
        End Using

        pen.Dispose()
        sbrush.Dispose()
    End Sub

    Private Function IconWidth() As Integer
        Return TextRenderer.MeasureText(_fa, FontAwesome.GetInstance(13.0F, FontStyle.Regular)).Width
    End Function

    Private Function IconHeight() As Integer
        Return TextRenderer.MeasureText(_fa, FontAwesome.GetInstance(13.0F, FontStyle.Regular)).Height
    End Function

    Private Function TextWidth() As Integer
        Return TextRenderer.MeasureText(Text, Font).Width
    End Function

    Private Function TextHeight() As Integer
        Return TextRenderer.MeasureText(Text, Font).Height
    End Function

    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        MyBase.OnMouseEnter(e)

    End Sub

    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)

        _mouseText = False
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
        MyBase.OnMouseMove(e)

        _mousePos = New Point(e.X, e.Y)

        _mouseText = ClientRectangle.Contains(_mousePos)

        If _mouseText Then Cursor = Cursors.Hand Else Cursor = Cursors.Default

        Invalidate()
    End Sub

    Protected Overrides Sub OnClick(e As EventArgs)
        MyBase.OnClick(e)

    End Sub

    Public Sub New()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        SetStyle(ControlStyles.UserPaint, True)
        BackColor = Color.Transparent
        DoubleBuffered = True
        ForeColor = Color.White
        _parent = Parent
    End Sub

End Class
