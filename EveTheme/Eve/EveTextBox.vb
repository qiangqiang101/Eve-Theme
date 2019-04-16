Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

<DefaultEvent("TextChanged")>
Public Class EveTextBox
    Inherits Control

    Private WithEvents Base As PHTextbox

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

    Protected Overrides Sub OnHandleCreated(e As EventArgs)
        If Not Controls.Contains(Base) Then
            Controls.Add(Base)
        End If

        MyBase.OnHandleCreated(e)
    End Sub

    <Category("Appearance")>
    Public Property PlaceHolder() As String
        Get
            Return Base.PlaceholderText
        End Get
        Set(value As String)
            Base.PlaceholderText = value
        End Set
    End Property

    Private _placeholdercolor As Color = Color.FromArgb(117, 117, 117)
    <Category("Appearance")>
    Public Property PlaceHolderColor() As Color
        Get
            Return _placeholdercolor
        End Get
        Set(value As Color)
            _placeholdercolor = value
        End Set
    End Property

    Sub New()
        'SetStyle(DirectCast(139286, ControlStyles), True)
        SetStyle(ControlStyles.Selectable, True)
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        DoubleBuffered = True

        Cursor = Cursors.IBeam

        Base = New PHTextbox
        Base.Font = Font
        Base.Text = Text
        Base.PlaceholderText = PlaceHolder
        Base.MaxLength = _MaxLength
        Base.Multiline = _Multiline
        Base.ReadOnly = _ReadOnly
        Base.UseSystemPasswordChar = _UseSystemPasswordChar
        Base.BackColor = BackColor
        Base.ForeColor = ForeColor
        Base.PlaceHolderColor = _placeholdercolor

        Base.BorderStyle = BorderStyle.None

        Base.Location = New Point(5, 5)
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
        formGraphics.FillRectangle(sbrush, rect)

        sbrush.Dispose()
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

    Private Function TextHeight() As Integer
        Return TextRenderer.MeasureText("TEXT", Font).Height
    End Function

    Protected Overrides Sub OnResize(ByVal e As EventArgs)
        MyBase.OnResize(e)

        Base.Location = New Point(5, 5)

        If Not _Multiline Then
            Size = New Size(Width, 26)
        End If

        Base.Width = Width - 10
        Base.Height = Height - 11
    End Sub

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        Base.Focus()
        MyBase.OnMouseDown(e)
    End Sub

    Protected Overrides Sub OnEnter(e As EventArgs)
        Base.Focus()
        Invalidate()
        MyBase.OnEnter(e)
    End Sub

    Protected Overrides Sub OnLeave(e As EventArgs)
        Invalidate()
        MyBase.OnLeave(e)
    End Sub

    Private Sub EveTextBox_BackColorChanged(sender As Object, e As EventArgs) Handles Me.BackColorChanged
        Base.BackColor = BackColor
    End Sub

    Private Sub EveTextBox_ForeColorChanged(sender As Object, e As EventArgs) Handles Me.ForeColorChanged
        Base.ForeColor = ForeColor
    End Sub

End Class
