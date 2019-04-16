Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Public Class EveLinkLabel
    Inherits Control

    Dim rectText As Rectangle
    Dim _mousePos As Point = Point.Empty
    Private _mouseText As Boolean = False

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

    Private _autosize As Boolean = True
    <Browsable(True),
    EditorBrowsable(System.ComponentModel.EditorBrowsableState.Always),
    DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Shadows Property AutoSize() As Boolean
        Get
            Return _autosize
        End Get
        Set(value As Boolean)
            _autosize = value
        End Set
    End Property

    Private _normalcolor As Color = Color.FromArgb(41, 128, 185)
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

    Private _hovercolor As Color = Color.FromArgb(36, 108, 155)
    <Category("Appearance")>
    Public Property LinkHoverColor() As Color
        Get
            Return _hovercolor
        End Get
        Set(value As Color)
            _hovercolor = value
            Invalidate()
        End Set
    End Property

    Private _angleright As Boolean = False
    <Category("Appearance")>
    Public Property AngleRight() As Boolean
        Get
            Return _angleright
        End Get
        Set(value As Boolean)
            _angleright = value
        End Set
    End Property

    Protected Overrides Sub SetBoundsCore(x As Integer, y As Integer, width As Integer, height As Integer, specified As BoundsSpecified)
        If _autosize AndAlso (specified And BoundsSpecified.Size) <> 0 Then
            Dim size As Size = Size.Empty
            If _angleright Then
                size = New Size(TextWidth() + 14, TextHeight() + 2)
            Else
                size = New Size(TextWidth() + 2, TextHeight() + 2)
            End If
            width = size.Width
            height = size.Height
        End If

        MyBase.SetBoundsCore(x, y, width, height, specified)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        Dim formGraphics As Graphics = e.Graphics

        Using f As Font = New Font(Font.Name, Font.SizeInPoints, Font.Style, GraphicsUnit.Point)
            rectText = New Rectangle(1, 1, TextWidth, TextHeight)
            Dim rectTexts As New Rectangle(2, 2, TextWidth() + 1, TextHeight)
            Dim rectAngle As New Rectangle(TextWidth(), 0, TextWidth, TextHeight)
            Dim rectAngles As New Rectangle(TextWidth() + 1, 1, TextWidth() + 1, TextHeight)
            Dim flags As TextFormatFlags = TextFormatFlags.Left Or TextFormatFlags.WordBreak
            formGraphics.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias

            If _angleright Then
                TextRenderer.DrawText(formGraphics, Text, f, rectTexts, Color.Black, flags)
                TextRenderer.DrawText(formGraphics, Text, f, rectText, ForeColor, flags)
                TextRenderer.DrawText(formGraphics, "", FontAwesome.GetInstance(f.SizeInPoints * 1.5, FontStyle.Regular), rectAngles, Color.Black, flags)
                TextRenderer.DrawText(formGraphics, "", FontAwesome.GetInstance(f.SizeInPoints * 1.5, FontStyle.Regular), rectAngle, If(_mouseText, _hovercolor, _normalcolor), flags)
            Else
                TextRenderer.DrawText(formGraphics, Text, f, rectTexts, Color.Black, flags)
                TextRenderer.DrawText(formGraphics, Text, f, rectText, If(_mouseText, _hovercolor, _normalcolor), flags)
            End If
        End Using
    End Sub

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
        _mouseText = rectText.Contains(_mousePos)
        Cursor = Cursors.Hand
        Invalidate()
    End Sub

    Public Sub New()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        SetStyle(ControlStyles.UserPaint, True)
        BackColor = Color.Transparent
        DoubleBuffered = True
        ForeColor = Color.White
    End Sub

End Class
