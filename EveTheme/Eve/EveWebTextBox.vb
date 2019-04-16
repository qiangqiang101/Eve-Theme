Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

<DefaultEvent("TextChanged")>
Public Class EveWebTextBox
    Inherits Control

    Private WithEvents Base As TTextbox

    Private _TextAlign As HorizontalAlignment = HorizontalAlignment.Left
    <Category("Appearance")>
    Public Property TextAlign() As HorizontalAlignment
        Get
            Return _TextAlign
        End Get
        Set(ByVal value As HorizontalAlignment)
            _TextAlign = value
            If Base IsNot Nothing Then
                Base.TextAlign = value
            End If
        End Set
    End Property

    Private _MaxLength As Integer = 32767
    <Category("Behavior")>
    Public Property MaxLength() As Integer
        Get
            Return _MaxLength
        End Get
        Set(ByVal value As Integer)
            _MaxLength = value
            If Base IsNot Nothing Then
                Base.MaxLength = value
            End If
        End Set
    End Property

    Private _ReadOnly As Boolean
    <Category("Appearance")>
    Public Property [ReadOnly]() As Boolean
        Get
            Return _ReadOnly
        End Get
        Set(ByVal value As Boolean)
            _ReadOnly = value
            If Base IsNot Nothing Then
                Base.ReadOnly = value
            End If
        End Set
    End Property

    Private _UseSystemPasswordChar As Boolean
    <Category("Appearance")>
    Public Property UseSystemPasswordChar() As Boolean
        Get
            Return _UseSystemPasswordChar
        End Get
        Set(ByVal value As Boolean)
            _UseSystemPasswordChar = value
            If Base IsNot Nothing Then
                Base.UseSystemPasswordChar = value
            End If
            Refresh()
        End Set
    End Property

    Private _Multiline As Boolean
    <Category("Appearance")>
    Public Property Multiline() As Boolean
        Get
            Return _Multiline
        End Get
        Set(ByVal value As Boolean)
            _Multiline = value
            If Base IsNot Nothing Then
                Base.Multiline = value

                If value Then
                    Base.Height = Height - 11
                Else
                    Height = Base.Height + 11
                End If
            End If
        End Set
    End Property

    Public Overrides Property Text As String
        Get
            Return MyBase.Text
        End Get
        Set(ByVal value As String)
            MyBase.Text = value
            If Base IsNot Nothing Then
                Base.Text = value
            End If
            Invalidate()
        End Set
    End Property

    Public Overrides Property Font As Font
        Get
            Return MyBase.Font
        End Get
        Set(ByVal value As Font)
            MyBase.Font = value
            If Base IsNot Nothing Then
                Base.Font = value
                Base.Location = New Point(5, 5)
                Base.Width = Width - 8

                If Not _Multiline Then
                    Height = Base.Height + 11
                End If
            End If
        End Set
    End Property

    Private _caption As String
    <Category("Appearance")>
    Public Property Caption() As String
        Get
            Return _caption
        End Get
        Set(value As String)
            _caption = value
        End Set
    End Property

    Private _captionColor As Color = Color.FromArgb(117, 117, 117)
    <Category("Appearance")>
    Public Property CaptionColor() As Color
        Get
            Return _captionColor
        End Get
        Set(value As Color)
            _captionColor = value
        End Set
    End Property

    Private _errorText As String
    <Category("Appearance")>
    Public Property ErrorText() As String
        Get
            Return _errorText
        End Get
        Set(value As String)
            _errorText = value
            Invalidate()
        End Set
    End Property

    Private _errorColor As Color = Color.FromArgb(210, 78, 78)
    <Category("Appearance")>
    Public Property Errorcolor() As Color
        Get
            Return _errorColor
        End Get
        Set(value As Color)
            _errorColor = value
        End Set
    End Property

    Private _error As Boolean = False
    <Category("Behavior")>
    Public Property IsError() As Boolean
        Get
            Return _error
        End Get
        Set(value As Boolean)
            _error = value
            Invalidate()
        End Set
    End Property

    Private _captionFocusedColor As Color = Color.FromArgb(46, 170, 218)
    <Category("Appearance")>
    Public Property CaptionFocusedColor() As Color
        Get
            Return _captionFocusedColor
        End Get
        Set(value As Color)
            _captionFocusedColor = value
        End Set
    End Property

    Protected Overrides Sub OnHandleCreated(e As EventArgs)
        If Not Controls.Contains(Base) Then
            Controls.Add(Base)
        End If

        MyBase.OnHandleCreated(e)
    End Sub

    Sub New()
        SetStyle(ControlStyles.Selectable, True)
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        DoubleBuffered = True

        Cursor = Cursors.IBeam

        Base = New TTextbox
        Base.Font = Font
        Base.Text = Text
        Base.MaxLength = _MaxLength
        Base.Multiline = _Multiline
        Base.ReadOnly = _ReadOnly
        Base.UseSystemPasswordChar = _UseSystemPasswordChar
        Base.BackColor = BackColor
        Base.ForeColor = ForeColor
        Base.BorderStyle = BorderStyle.None
        Base.Location = New Point(5, 5 + 4)
        Base.Width = Width - 14

        If _Multiline Then
            Base.Height = Height - 11
        Else
            Height = Base.Height + 11
        End If
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim formGraphics As Graphics = e.Graphics

        formGraphics.SmoothingMode = SmoothingMode.AntiAlias

        Dim rect As New Rectangle(0, 0, Width, Height)
        Dim sbrush As New SolidBrush(BackColor)
        Dim slinebrush As New SolidBrush(If(Base.Focused, _captionFocusedColor, _captionColor))
        Dim selbrush As New SolidBrush(_errorColor)
        formGraphics.FillRectangle(sbrush, rect)

        Using f As Font = Font
            Dim rectLine As New Rectangle(4, (TextSize.Height * 2) + 4 + 4, Width - 8, 1)
            Dim rectError As New Rectangle(0, (TextSize.Height * 2) + 5 + 4, Width, TextSize.Height)

            Dim flags As TextFormatFlags = TextFormatFlags.Left Or TextFormatFlags.WordBreak
            formGraphics.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias

            TextRenderer.DrawText(formGraphics, _caption, f, New Rectangle(rect.X + 1, rect.Y + 1, rect.Width, rect.Height), Color.Black, flags)
            TextRenderer.DrawText(formGraphics, _caption, f, rect, If(Base.Focused, _captionFocusedColor, _captionColor), flags)

            formGraphics.FillRectangle(If(_error, If(Base.Focused, slinebrush, selbrush), slinebrush), rectLine)

            If _error Then
                TextRenderer.DrawText(formGraphics, _errorText, f, New Rectangle(rectError.X + 1, rectError.Y + 1, rectError.Width, rectError.Height), Color.Black, flags)
                TextRenderer.DrawText(formGraphics, _errorText, f, rectError, _errorColor, flags)
            End If
        End Using

        sbrush.Dispose()
        slinebrush.Dispose()
        selbrush.Dispose()
    End Sub

    Private Sub OnBaseTextChanged(ByVal s As Object, ByVal e As EventArgs) Handles Base.TextChanged
        Text = Base.Text
        Invalidate()
    End Sub

    Private Sub OnBaseKeyDown(ByVal s As Object, ByVal e As KeyEventArgs) Handles Base.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.A Then
            Base.SelectAll()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Function TextSize() As Size
        Return TextRenderer.MeasureText("text", Font)
    End Function

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        Base.Focus()
        MyBase.OnMouseDown(e)
    End Sub

    Protected Overrides Sub OnEnter(e As EventArgs)
        MyBase.OnEnter(e)

        Base.Focus()
        Invalidate()
    End Sub

    Protected Overrides Sub OnLeave(e As EventArgs)
        MyBase.OnLeave(e)

        Invalidate()
    End Sub

    Private Sub EveTextBox_BackColorChanged(sender As Object, e As EventArgs) Handles Me.BackColorChanged
        Base.BackColor = BackColor
    End Sub

    Private Sub EveTextBox_ForeColorChanged(sender As Object, e As EventArgs) Handles Me.ForeColorChanged
        Base.ForeColor = ForeColor
    End Sub

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)

        Base.Location = New Point(5, TextSize.Height + 4)
        Base.Size = New Size(Width - 10, TextSize.Height)

        If Not _Multiline Then
            Size = New Size(Width, (TextSize.Height * 3) + 5 + 4)
        Else
            Size = Size
        End If
    End Sub

End Class
