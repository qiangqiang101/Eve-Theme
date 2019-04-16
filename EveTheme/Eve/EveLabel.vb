Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Public Class EveLabel
    Inherits Control

    Dim rectText, rectLink, rectBracketL, rectBracketR As Rectangle
    Dim _mousePos As Point = Point.Empty
    Private _mouseText As Boolean = False
    Private _mouseLink As Boolean = False
    Private _parent As Control = Nothing
    Private WithEvents _tooltipForm As EveToolTip
    Private WithEvents _linkTooltipForm As EveToolTip

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

    <Browsable(False),
    EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never),
    DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public ReadOnly Property HasLink() As Boolean
        Get
            Return Not String.IsNullOrEmpty(_link)
        End Get
    End Property

    Private _linktext As String
    <Category("Appearance")>
    Public Property LinkText() As String
        Get
            Return _linktext
        End Get
        Set(value As String)
            _linktext = value
            Invalidate()
        End Set
    End Property

    Private _link As String
    <Category("Behavior")>
    Public Property Link() As String
        Get
            Return _link
        End Get
        Set(value As String)
            _link = value
        End Set
    End Property

    Private _linknormalcolor As Color = Color.FromArgb(144, 139, 135)
    <Category("Appearance")>
    Public Property LinkNormalColor() As Color
        Get
            Return _linknormalcolor
        End Get
        Set(value As Color)
            _linknormalcolor = value
            Invalidate()
        End Set
    End Property

    Private _linkhovercolor As Color = Color.White
    <Category("Appearance")>
    Public Property LinkHoverColor() As Color
        Get
            Return _linkhovercolor
        End Get
        Set(value As Color)
            _linkhovercolor = value
            Invalidate()
        End Set
    End Property

    Private _showbrackets As Boolean = True
    <Category("Appearance")>
    Public Property ShowBrackets() As Boolean
        Get
            Return _showbrackets
        End Get
        Set(value As Boolean)
            _showbrackets = value
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

    Private _linktooltiptext As String
    <Category("Behavior")>
    Public Property LinkToolTipText() As String
        Get
            Return _linktooltiptext
        End Get
        Set(value As String)
            _linktooltiptext = value
        End Set
    End Property

    <Browsable(False),
    EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never),
    DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public ReadOnly Property ShowLinkToolTip() As Boolean
        Get
            Return Not String.IsNullOrEmpty(_linktooltiptext)
        End Get
    End Property

    Protected Overrides Sub SetBoundsCore(x As Integer, y As Integer, width As Integer, height As Integer, specified As BoundsSpecified)
        If _autosize AndAlso (specified And BoundsSpecified.Size) <> 0 Then
            Dim size As Size = Size.Empty
            If HasLink Then
                If _showbrackets Then
                    size = New Size(TextWidth() + BracketWidth() + LinkWidth() + 2, TextHeight() + 2)
                Else
                    size = New Size(TextWidth() + LinkWidth() + 2, TextHeight() + 2)
                End If
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
            rectLink = New Rectangle(TextWidth() + (BracketWidth() / 2) + 1, 1, LinkWidth, LinkHeight)
            Dim rectLinks As New Rectangle(TextWidth() + (BracketWidth() / 2) + 2, 2, LinkWidth() + 1, TextHeight)
            Dim rectLinkWOB = New Rectangle(TextWidth() + 1, 1, LinkWidth, LinkHeight)
            Dim rectLinkWOBs As New Rectangle(TextWidth() + 2, 2, LinkWidth() + 1, TextHeight)
            rectBracketL = New Rectangle(TextWidth(), 1, BracketWidth, BracketHeight)
            Dim rectBracketLs As New Rectangle(TextWidth() + 1, 2, BracketWidth() + 1, BracketHeight)
            rectBracketR = New Rectangle(TextWidth() + LinkWidth() + 1, 1, BracketWidth(), BracketHeight)
            Dim rectBracketRs As New Rectangle(TextWidth() + LinkWidth() + 2, 2, BracketWidth() + 1, BracketHeight)

            Dim flags As TextFormatFlags = TextFormatFlags.Left Or TextFormatFlags.WordBreak
            formGraphics.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias
            If HasLink Then
                If _showbrackets Then
                    TextRenderer.DrawText(formGraphics, Text, f, rectTexts, Color.Black, flags)
                    TextRenderer.DrawText(formGraphics, Text, f, rectText, ForeColor, flags)
                    TextRenderer.DrawText(formGraphics, "[", f, rectBracketLs, Color.Black, flags)
                    TextRenderer.DrawText(formGraphics, "[", f, rectBracketL, _linknormalcolor, flags)
                    TextRenderer.DrawText(formGraphics, _linktext, f, rectLinks, Color.Black, flags)
                    TextRenderer.DrawText(formGraphics, _linktext, f, rectLink, If(_mouseLink, _linkhovercolor, _linknormalcolor), flags)
                    TextRenderer.DrawText(formGraphics, "]", f, rectBracketRs, Color.Black, flags)
                    TextRenderer.DrawText(formGraphics, "]", f, rectBracketR, _linknormalcolor, flags)
                Else
                    TextRenderer.DrawText(formGraphics, Text, f, rectTexts, Color.Black, flags)
                    TextRenderer.DrawText(formGraphics, Text, f, rectText, ForeColor, flags)
                    TextRenderer.DrawText(formGraphics, _linktext, f, rectLinkWOBs, Color.Black, flags)
                    TextRenderer.DrawText(formGraphics, _linktext, f, rectLinkWOB, If(_mouseLink, _linkhovercolor, _linknormalcolor), flags)
                End If
            Else
                TextRenderer.DrawText(formGraphics, Text, f, rectTexts, Color.Black, flags)
                TextRenderer.DrawText(formGraphics, Text, f, rectText, ForeColor, flags)
            End If
        End Using
    End Sub

    Private Function BracketWidth() As Integer
        Return TextRenderer.MeasureText("[", Font).Width
    End Function

    Private Function BracketHeight() As Integer
        Return TextRenderer.MeasureText("[", Font).Height
    End Function

    Private Function TextWidth() As Integer
        Return TextRenderer.MeasureText(Text, Font).Width
    End Function

    Private Function TextHeight() As Integer
        Return TextRenderer.MeasureText(Text, Font).Height
    End Function

    Private Function LinkWidth() As Integer
        Return TextRenderer.MeasureText(_linktext, Font).Width
    End Function

    Private Function LinkHeight() As Integer
        Return TextRenderer.MeasureText(_linktext, Font).Height
    End Function

    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        MyBase.OnMouseEnter(e)

    End Sub

    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)

        _mouseText = False
        _mouseLink = False
        Invalidate()

        If _tooltipForm.Visible Then _tooltipForm.Hide()
        If _linkTooltipForm.Visible Then _linkTooltipForm.Hide()
    End Sub

    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
        MyBase.OnMouseMove(e)

        _mousePos = New Point(e.X, e.Y)

        _mouseText = rectText.Contains(_mousePos)
        _mouseLink = rectLink.Contains(_mousePos)

        If _mouseLink Then Cursor = Cursors.Hand Else Cursor = Cursors.Default

        If _mouseLink AndAlso ShowLinkToolTip Then
            If Not _linkTooltipForm.Visible Then _linkTooltipForm.Show(_linktooltiptext, New Point(rectLink.Location.X + Parent.PointToScreen(Me.Location).X - (rectLink.Width / 2), rectLink.Location.Y + Parent.PointToScreen(Me.Location).Y - (rectLink.Size.Height * 1.9)))
        End If

        If _mouseText AndAlso ShowToolTip Then
            If Not _tooltipForm.Visible Then _tooltipForm.Show(_tooltiptext, New Point(rectText.Location.X + Parent.PointToScreen(Me.Location).X - (rectText.Width / 2), rectText.Location.Y + Parent.PointToScreen(Me.Location).Y - (rectText.Size.Height * 1.9)))
        End If

        Invalidate()
    End Sub

    Protected Overrides Sub OnClick(e As EventArgs)
        MyBase.OnClick(e)

        If _mouseLink Then
            Try
                Process.Start(_link)
            Catch ex As Exception
                Process.Start("https://www.imnotmental.com/")
            End Try
        End If
    End Sub

    Protected Overrides Sub Dispose(disposing As Boolean)
        MyBase.Dispose(disposing)

        _tooltipForm.Close()
        _linkTooltipForm.Close()
    End Sub

    Public Sub New()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        SetStyle(ControlStyles.UserPaint, True)
        BackColor = Color.Transparent
        DoubleBuffered = True
        ForeColor = Color.White
        _parent = Parent
        _tooltipForm = New EveToolTip()
        _linkTooltipForm = New EveToolTip()
    End Sub

    Private Sub _tooltipForm_VisibleChanged(sender As Object, e As EventArgs) Handles _tooltipForm.VisibleChanged
        If _mouseText Then
            _linkTooltipForm.Visible = Not _tooltipForm.Visible
        End If
    End Sub

    Private Sub _linkTooltipForm_VisibleChanged(sender As Object, e As EventArgs) Handles _linkTooltipForm.VisibleChanged
        If _mouseLink Then
            _tooltipForm.Visible = Not _linkTooltipForm.Visible
        End If
    End Sub

End Class
