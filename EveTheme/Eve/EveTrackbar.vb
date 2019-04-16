Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

<DefaultEvent("Scroll")>
Public Class EveTrackBar
    Inherits Control

    Private W, H As Integer
    Private Val As Integer
    Private Bool As Boolean
    Private Track As Rectangle
    Private Knob As Rectangle
    Private _mouse As Boolean = False
    Private _mouseDown As Boolean = False
    Private _mousePos As Point = Point.Empty

    Public Event Scroll(ByVal sender As Object)

    Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
        MyBase.OnMouseDown(e)

        _mouseDown = True
        Invalidate()

        If e.Button = MouseButtons.Left Then
            Val = CInt((_value - _minimum) / (_maximum - _minimum) * (Width - 11))
            Track = New Rectangle(Val, 0, 10, 20)

            Bool = Track.Contains(e.Location)
        End If
    End Sub

    Protected Overrides Sub OnMouseMove(ByVal e As MouseEventArgs)
        MyBase.OnMouseMove(e)

        _mousePos = New Point(e.X, e.Y)
        _mouse = ClientRectangle.Contains(_mousePos)
        Invalidate()

        If Bool AndAlso e.X > -1 AndAlso e.X < (Width + 1) Then
            Value = _minimum + CInt((_maximum - _minimum) * (e.X / Width))
        End If
    End Sub

    Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
        MyBase.OnMouseUp(e)

        _mouseDown = False
        Invalidate()

        Bool = False
    End Sub

    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)

        _mouse = False
        Invalidate()
    End Sub

    Private _trackColor As Color = Color.FromArgb(41, 128, 185)
    <Category("Appearance")>
    Public Property TrackColor As Color
        Get
            Return _trackColor
        End Get
        Set(value As Color)
            _trackColor = value
        End Set
    End Property

    Private _backColor As Color = Color.FromArgb(96, 96, 96)
    <Category("Appearance")>
    Public Property BackgroundColor() As Color
        Get
            Return _backColor
        End Get
        Set(value As Color)
            _backColor = value
        End Set
    End Property

    Private _bulletColor As Color = Color.FromArgb(0, 174, 255)
    <Category("Appearance")>
    Public Property BulletColor() As Color
        Get
            Return _bulletColor
        End Get
        Set(value As Color)
            _bulletColor = value
        End Set
    End Property

    Private _minimum As Integer = 0
    <Category("Behavior")>
    Public Property Minimum As Integer
        Get
            Return Minimum
        End Get
        Set(value As Integer)
            If value < 0 Then
            End If

            _minimum = value

            If value > _value Then _value = value
            If value > _maximum Then _maximum = value
            Invalidate()
        End Set
    End Property

    Private _maximum As Integer = 10
    <Category("Behavior")>
    Public Property Maximum As Integer
        Get
            Return _maximum
        End Get
        Set(value As Integer)
            If value < 0 Then
            End If

            _maximum = value
            If value < _value Then _value = value
            If value < _minimum Then _minimum = value
            Invalidate()
        End Set
    End Property

    Private _value As Integer = 50
    <Category("Behavior")>
    Public Property Value As Integer
        Get
            Return _value
        End Get
        Set(value As Integer)
            If value = _value Then Return

            If value > _maximum OrElse value < _minimum Then
            End If

            _value = value
            Invalidate()
            RaiseEvent Scroll(Me)
        End Set
    End Property

    Protected Overrides Sub OnKeyDown(e As KeyEventArgs)
        MyBase.OnKeyDown(e)

        If e.KeyCode = Keys.Subtract Then
            If Value = 0 Then Exit Sub
            Value -= 1
        ElseIf e.KeyCode = Keys.Add Then
            If Value = _maximum Then Exit Sub
            Value += 1
        End If
    End Sub

    Protected Overrides Sub OnTextChanged(e As EventArgs)
        MyBase.OnTextChanged(e)

        Invalidate()
    End Sub

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)

        Height = 23
    End Sub

    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or
                 ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer, True)
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        DoubleBuffered = True
        Height = 18
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim formBitmap = New Bitmap(Width, Height)
        Dim formGraphics = Graphics.FromImage(formBitmap)
        W = Width - 1
        H = Height - 1

        Dim Base As New Rectangle(1, 8, W - 2, 5)
        Dim GP, GP2 As New GraphicsPath

        With formGraphics
            .SmoothingMode = 2
            .PixelOffsetMode = 2
            .TextRenderingHint = 5
            .Clear(BackColor)

            '-- Value
            Val = CInt((_value - _minimum) / (_maximum - _minimum) * (W - 10))
            Track = New Rectangle(Val, 0, 10, 20)
            Knob = New Rectangle(Val, 3, 14, 14)

            '-- Base
            GP.AddRectangle(Base)
            .SetClip(GP)
            .FillRectangle(New SolidBrush(_backColor), New Rectangle(0, 8, W, 5))
            .FillRectangle(New SolidBrush(_trackColor), New Rectangle(0, 8, Track.X + Track.Width, 5))
            .ResetClip()

            If _mouse Or _mouseDown Then
                GP2.AddEllipse(Knob)
                .FillPath(New SolidBrush(_bulletColor), GP2)
            End If
        End With

        MyBase.OnPaint(e)
        formGraphics.Dispose()
        e.Graphics.InterpolationMode = 7
        e.Graphics.DrawImageUnscaled(formBitmap, 0, 0)
        formGraphics.Dispose()
    End Sub

End Class