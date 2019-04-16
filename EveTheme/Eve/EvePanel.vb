Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Public Class EvePanel
    Inherits Panel

    Private bar As New EveBar() With {.ForeColor = _barcolor, .Dock = DockStyle.Top}

    Private _opacity As Single = 0.9F
    <Category("Appearance")>
    Public Property Opacity() As Single
        Get
            Return _opacity
        End Get
        Set(value As Single)
            _opacity = value
            MyBase.BackColor = Color.FromArgb(SingleToAlpha(value), BackColor)
        End Set
    End Property

    Private Function SingleToAlpha(value As Single) As Integer
        Return CInt(value * 255)
    End Function

    <Browsable(False),
    EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never),
    DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Overrides Property BackColor As Color
        Get
            Dim bc As Color = _backcolor
            Return Color.FromArgb(SingleToAlpha(_opacity), bc.R, bc.G, bc.B)
        End Get
        Set(value As Color)
            MyBase.BackColor = Color.FromArgb(SingleToAlpha(_opacity), value.R, value.G, value.B)
        End Set
    End Property

    <Browsable(False),
    EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never),
    DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Overrides Property BackgroundImage As Image
        Get
            Return MyBase.BackgroundImage
        End Get
        Set(value As Image)
            MyBase.BackgroundImage = value
        End Set
    End Property

    <Browsable(False),
    EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never),
    DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Overrides Property BackgroundImageLayout As ImageLayout
        Get
            Return MyBase.BackgroundImageLayout
        End Get
        Set(value As ImageLayout)
            MyBase.BackgroundImageLayout = value
        End Set
    End Property

    Private _backgroundImage As Image = Nothing
    <Category("Appearance")>
    Public Property Wallpaper() As Image
        Get
            Return _backgroundImage
        End Get
        Set(value As Image)
            _backgroundImage = value
            Invalidate()
        End Set
    End Property

    Private _backcolor As Color = Color.Black
    <Category("Appearance")>
    Public Property BackColorEx() As Color
        Get
            Return _backcolor
        End Get
        Set(value As Color)
            _backcolor = value
        End Set
    End Property

    Private _showbar As Boolean = False
    <Category("Appearance")>
    Public Property ShowBar() As Boolean
        Get
            Return _showbar
        End Get
        Set(value As Boolean)
            _showbar = value
            Invalidate()
        End Set
    End Property

    Private _barcolor As Color = Color.FromArgb(41, 128, 185)
    <Category("Appearance")>
    Public Property BarColor() As Color
        Get
            Return _barcolor
        End Get
        Set(value As Color)
            _barcolor = value
            bar.ForeColor = value
        End Set
    End Property

    Public Sub New()
        SetStyle(ControlStyles.UserPaint, True)
        SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        SetStyle(ControlStyles.ContainerControl, True)
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        SetStyle(ControlStyles.ResizeRedraw, True)
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        DoubleBuffered = True
    End Sub

    Protected Overrides Sub OnPaintBackground(e As PaintEventArgs)
        MyBase.OnPaintBackground(e)

        Dim formGraphics As Graphics = e.Graphics
        Dim bmp As New Bitmap(1, 1)
        Dim tbrush As New TextureBrush(If(_backgroundImage Is Nothing, bmp, _backgroundImage))

        If Not _backgroundImage Is Nothing Then
            tbrush.WrapMode = WrapMode.Clamp
            Dim xDisplayCenterRelative As New Point(ClientRectangle.Width / 2, ClientRectangle.Height / 2)
            Dim xImageCenterRelative As New Point(_backgroundImage.Width / 2, _backgroundImage.Height / 2)
            Dim xOffsetRelative As New Point(xDisplayCenterRelative.X - xImageCenterRelative.X, xDisplayCenterRelative.Y - xImageCenterRelative.Y)
            Dim xAbsolutePixel As Point = xOffsetRelative + New Size(ClientRectangle.Location)
            tbrush.TranslateTransform(xAbsolutePixel.X, xAbsolutePixel.Y)
            formGraphics.FillRectangle(tbrush, ClientRectangle)
        End If

        If _showbar Then
            If Not Controls.Contains(bar) Then Controls.Add(bar)
        End If

        tbrush.Dispose()
        bmp.Dispose()
    End Sub

    Protected Overrides Sub OnResize(eventargs As EventArgs)
        MyBase.OnResize(eventargs)

        Invalidate()
    End Sub

    Private Class EveBar
        Inherits Control

        Protected Overrides Sub OnResize(e As EventArgs)
            MyBase.OnResize(e)

            Size = New Size(Width, 2)
        End Sub

        Protected Overrides Sub OnPaint(e As PaintEventArgs)
            MyBase.OnPaint(e)

            Dim formGraphics As Graphics = e.Graphics
            Dim sbrush As New SolidBrush(ForeColor)
            Dim rectLine As New Rectangle(0, 0, Width, 2)

            formGraphics.FillRectangle(sbrush, rectLine)

            sbrush.Dispose()
        End Sub

        Public Sub New()
            SetStyle(ControlStyles.FixedWidth, True)
            SetStyle(ControlStyles.UserPaint, True)
            SetStyle(ControlStyles.ResizeRedraw, True)
            SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
            SetStyle(ControlStyles.SupportsTransparentBackColor, True)
            DoubleBuffered = True
            ForeColor = Color.FromArgb(41, 128, 185)
            BackColor = Color.Transparent
        End Sub

    End Class

End Class
