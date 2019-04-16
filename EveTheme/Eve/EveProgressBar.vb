Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Public Class EveProgressBar
    Inherits Control

    Dim _marqueeSteps As Single = CSng($"-{Width / 2}")
    Dim WithEvents tmMarquee As New Timer() With {.Interval = 10}

    Private _backColor As Color = Color.FromArgb(96, 96, 96)
    <Category("Appearance")>
    Public Property BackgroundColor() As Color
        Get
            Return _backColor
        End Get
        Set(value As Color)
            _backColor = value
            BackColor = value
        End Set
    End Property

    Private _frontcolor As Color = Color.FromArgb(41, 128, 185)
    <Category("Appearance")>
    Public Property ForegroundColor() As Color
        Get
            Return _frontcolor
        End Get
        Set(value As Color)
            _frontcolor = value
        End Set
    End Property

    Private _val As Integer = 0
    <Category("Behavior")>
    Public Property Value() As Integer
        Get
            Return _val
        End Get
        Set(value As Integer)
            _val = value
            If _val > _max Then _val = _max
            Invalidate()
        End Set
    End Property

    Private _min As Integer = 0
    <Category("Behavior")>
    Public Property Minimum() As Integer
        Get
            Return _min
        End Get
        Set(value As Integer)
            _min = value
            Invalidate()
        End Set
    End Property

    Private _max As Integer = 100
    <Category("Behavior")>
    Public Property Maximum() As Integer
        Get
            Return _max
        End Get
        Set(value As Integer)
            _max = value
        End Set
    End Property

    Private _style As PBStyle = PBStyle.Continuous
    <Category("Appearance")>
    Public Property Style() As PBStyle
        Get
            Return _style
        End Get
        Set(value As PBStyle)
            _style = value
            If Not DesignMode Then If _style = PBStyle.Marquee Then tmMarquee.Start() Else tmMarquee.Stop()
        End Set
    End Property

    Private _marqueeSpeed As Single = 5.0F
    <Category("Behavior")>
    Public Property MarqueeAnimationSpeed() As Single
        Get
            Return _marqueeSpeed
        End Get
        Set(value As Single)
            _marqueeSpeed = value
        End Set
    End Property

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        Dim formGraphics As Graphics = e.Graphics
        Dim sbrush As New SolidBrush(_frontcolor)

        formGraphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        If Not _val = 0 Then
            If _style = PBStyle.Continuous Then
                formGraphics.FillRectangle(sbrush, New RectangleF(0, 0, _val / _max * Width - 1, Height - 1))
            End If
        End If

        If _style = PBStyle.Marquee Then
            Dim rectWidth As Single = Width / 2
            formGraphics.FillRectangle(sbrush, New RectangleF(_marqueeSteps, 0, rectWidth, Height - 1))
        End If

        sbrush.Dispose()
    End Sub

    Public Sub New()
        SetStyle(ControlStyles.UserPaint, True)
        CheckForIllegalCrossThreadCalls = False
        BackColor = _backColor
        DoubleBuffered = True
        If Not DesignMode Then If _style = PBStyle.Marquee Then tmMarquee.Start()
    End Sub

    Private Sub tmMarquee_Tick(sender As Object, e As EventArgs) Handles tmMarquee.Tick
        If Not _marqueeSteps >= Width - 1 Then
            _marqueeSteps += _marqueeSpeed
            Invalidate()
        Else
            _marqueeSteps = CSng($"-{Width / 2}")
            Invalidate()
        End If
    End Sub

    Public Sub Increment(value As Integer)
        _val += value
        Invalidate()
    End Sub

    Enum PBStyle
        Continuous
        Marquee
    End Enum

End Class
