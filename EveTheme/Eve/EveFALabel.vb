Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

<DefaultEvent("Click")>
Public Class EveFALabel
    Inherits Control

    Dim rectText As Rectangle
    Dim _mousePos As Point = Point.Empty
    Private _mouseText As Boolean = False
    Private _parent As Control = Nothing
    Private _tooltipForm As EveToolTip

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

    Private _autosize As Boolean = True
    <Browsable(True),
    EditorBrowsable(System.ComponentModel.EditorBrowsableState.Always),
    DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    <Category("Behavior")>
    Public Shadows Property AutoSize() As Boolean
        Get
            Return _autosize
        End Get
        Set(value As Boolean)
            _autosize = value
        End Set
    End Property

    Public Shadows Property Font() As Font
        Get
            Return FontAwesome.GetInstance(13.0F, FontStyle.Regular)
        End Get
        Set(value As Font)
            MyBase.Font = FontAwesome.GetInstance(13.0F, FontStyle.Regular)
        End Set
    End Property

    Private _normalcolor As Color = Color.FromArgb(144, 139, 135)
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

    Private _hovercolor As Color = Color.FromArgb(41, 128, 185)
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

    Protected Overrides Sub SetBoundsCore(x As Integer, y As Integer, width As Integer, height As Integer, specified As BoundsSpecified)
        If _autosize AndAlso (specified And BoundsSpecified.Size) <> 0 Then
            Dim size As Size = Size.Empty
            size = New Size(TextWidth() + 2, TextHeight() + 2)
            width = size.Width
            height = size.Height
        End If

        MyBase.SetBoundsCore(x, y, width, height, specified)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        Dim formGraphics As Graphics = e.Graphics

        Using f As Font = Font
            rectText = New Rectangle(1, 1, TextWidth, TextHeight)
            Dim rectTexts As New Rectangle(2, 2, TextWidth, TextHeight)

            Dim flags As TextFormatFlags = TextFormatFlags.Left Or TextFormatFlags.WordBreak
            formGraphics.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias

            TextRenderer.DrawText(formGraphics, _fa, f, rectTexts, Color.Black, flags)
            TextRenderer.DrawText(formGraphics, _fa, f, rectText, If(_mouseText, _hovercolor, _normalcolor), flags)
        End Using
    End Sub

    Private Function TextWidth() As Integer
        Return TextRenderer.MeasureText(_fa, Font).Width
    End Function

    Private Function TextHeight() As Integer
        Return TextRenderer.MeasureText(_fa, Font).Height
    End Function

    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        MyBase.OnMouseEnter(e)

    End Sub

    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)

        _mouseText = False
        Invalidate()

        If _tooltipForm.Visible Then _tooltipForm.Hide()
    End Sub

    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
        MyBase.OnMouseMove(e)

        _mousePos = New Point(e.X, e.Y)

        _mouseText = rectText.Contains(_mousePos)

        If _mouseText Then Cursor = Cursors.Hand Else Cursor = Cursors.Default

        If _mouseText AndAlso ShowToolTip Then
            If Not _tooltipForm.Visible Then _tooltipForm.Show(_tooltiptext, CalculateToolTipPosition(_tooltippos), _tooltippos)
        End If

        Invalidate()
    End Sub

    Private Function CalculateToolTipPosition(tooltippos As ToolTipPos) As Point
        Select Case tooltippos
            Case ToolTipPos.Top
                Return New Point(rectText.Location.X + Parent.PointToScreen(rectText.Location).X - (rectText.Width / 2), rectText.Location.Y + Parent.PointToScreen(Location).Y - (Size.Height * 1.9))
            Case ToolTipPos.Right
                Return New Point(rectText.Location.X + Parent.PointToScreen(rectText.Location).X + (rectText.Width * 2), rectText.Location.Y + Parent.PointToScreen(Location).Y - Size.Height + 17)
        End Select
    End Function

    Protected Overrides Sub OnClick(e As EventArgs)
        MyBase.OnClick(e)

    End Sub

    Protected Overrides Sub Dispose(disposing As Boolean)
        MyBase.Dispose(disposing)

        _tooltipForm.Close()
    End Sub

    Public Sub New()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        SetStyle(ControlStyles.UserPaint, True)
        BackColor = Color.Transparent
        DoubleBuffered = True
        ForeColor = Color.White
        _parent = Parent
        _tooltipForm = New EveToolTip()
    End Sub

End Class
