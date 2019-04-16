Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

<DefaultEvent("Click")>
Public Class EveImageSlider
    Inherits Panel

    Private WithEvents tmSwitch As New Timer With {.Enabled = True, .Interval = 8000}
    Private WithEvents bgSwitch As New BackgroundWorker With {.WorkerSupportsCancellation = True}

    Private _opacity As Integer = 255
    Private _mousePrev As Boolean = False
    Private _mouseNext As Boolean = False
    Dim rectPrev, rectNext, rectPrev2, rectNext2 As Rectangle
    Dim _mousePos As Point = Point.Empty

    Private _curImg As EveImages = Nothing

    Private ReadOnly Property ImageCount() As Integer
        Get
            Return _imagesCollection.Count
        End Get
    End Property

    Private _imagesCollection As List(Of EveImages)
    <Browsable(False)>
    <EditorBrowsable(EditorBrowsableState.Never)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property Images() As List(Of EveImages)
        Get
            Return _imagesCollection
        End Get
        Set(value As List(Of EveImages))
            _imagesCollection = value
            _curImg = _imagesCollection.FirstOrDefault
            Invalidate()
        End Set
    End Property

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        Dim formGraphics As Graphics = e.Graphics

        Dim tbrush As TextureBrush
        If _curImg IsNot Nothing Then
            tbrush = New TextureBrush(_curImg.Image)
            formGraphics.DrawImage(_curImg.Image, New Rectangle(0, 0, Width, Height))
        End If

        Dim sbrush As New SolidBrush(Color.FromArgb(_opacity, Color.Black))
        formGraphics.FillRectangle(sbrush, New Rectangle(0, 0, Width, Height))

        Using f As Font = New Font(Font.Name, 23S, Font.Style, GraphicsUnit.Point)
            Dim f2 As New Font(Font.Name, 15S, Font.Style, GraphicsUnit.Point)

            Dim flags As TextFormatFlags = TextFormatFlags.Left
            formGraphics.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias

            TextRenderer.DrawText(formGraphics, "⚪", f, rectPrev, If(_mousePrev, _hoverColor, _normalColor), flags)
            TextRenderer.DrawText(formGraphics, "<", f2, rectPrev2, If(_mousePrev, _hoverColor, _normalColor), flags)
            TextRenderer.DrawText(formGraphics, "⚪", f, rectNext, If(_mouseNext, _hoverColor, _normalColor), flags)
            TextRenderer.DrawText(formGraphics, ">", f2, rectNext2, If(_mouseNext, _hoverColor, _normalColor), flags)

            formGraphics.DrawRectangle(Pens.Transparent, rectPrev)
            formGraphics.DrawRectangle(Pens.Transparent, rectNext)
        End Using
    End Sub

    Private Sub PreviousImage()
        Dim index = _imagesCollection.IndexOf(_curImg)
        If index - 1 <= 0 Then
            _curImg = _imagesCollection.LastOrDefault
        Else
            _curImg = _imagesCollection.Item(index - 1)
        End If
    End Sub

    Private Sub NextImage()
        Dim index = _imagesCollection.IndexOf(_curImg)
        If _imagesCollection.Count > index + 1 Then
            _curImg = _imagesCollection.Item(index + 1)
        Else
            _curImg = _imagesCollection.FirstOrDefault
        End If
    End Sub

    Private _normalColor As Color = Color.FromArgb(97, 93, 90)
    <Category("Appearance")>
    Public Property NormalColor() As Color
        Get
            Return _normalColor
        End Get
        Set(value As Color)
            _normalColor = value
        End Set
    End Property

    Private _hoverColor As Color = Color.White
    <Category("Appearance")>
    Public Property HoverColor() As Color
        Get
            Return _hoverColor
        End Get
        Set(value As Color)
            _hoverColor = value
        End Set
    End Property

    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        MyBase.OnMouseEnter(e)

        If tmSwitch.Enabled Then tmSwitch.Stop()
    End Sub

    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)

        If Not tmSwitch.Enabled Then tmSwitch.Start()

        _mousePrev = False
        _mouseNext = False
        Invalidate()
    End Sub

    Private Sub tmSwitch_Tick(sender As Object, e As EventArgs) Handles tmSwitch.Tick
        If Not _imagesCollection.Count = 0 Then
            If Not bgSwitch.IsBusy Then
                bgSwitch.RunWorkerAsync()
            Else
                bgSwitch.CancelAsync()
                bgSwitch.RunWorkerAsync()
            End If
        End If
    End Sub

    Private Sub bgSwitch_Dowork(sender As Object, e As EventArgs) Handles bgSwitch.DoWork
        If _mousePrev Then
            Dim i As Integer = 0
            Do Until i = 255
                _opacity = i
                Refresh()
                i += 15
            Loop
            PreviousImage()
            Invalidate()
            Do Until i = 0
                _opacity = i
                Refresh()
                i -= 15
            Loop
        ElseIf _mouseNext Then
            Dim i As Integer = 0
            Do Until i = 255
                _opacity = i
                Refresh()
                i += 15
            Loop
            NextImage()
            Invalidate()
            Do Until i = 0
                _opacity = i
                Refresh()
                i -= 15
            Loop
        ElseIf Not _mousePrev AndAlso Not _mouseNext Then
            Dim i As Integer = 0
            Do Until i = 255
                _opacity = i
                Refresh()
                i += 15
            Loop
            NextImage()
            Invalidate()
            Do Until i = 0
                _opacity = i
                Refresh()
                i -= 15
            Loop
        End If
    End Sub

    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
        MyBase.OnMouseMove(e)

        _mousePos = New Point(e.X, e.Y)

        _mousePrev = rectPrev.Contains(_mousePos)
        _mouseNext = rectNext.Contains(_mousePos)

        Invalidate()
    End Sub

    Protected Overrides Sub OnClick(e As EventArgs)
        MyBase.OnClick(e)

        If Not _mousePrev AndAlso Not _mouseNext Then
            Try
                Process.Start(_curImg.Link)
            Catch ex As Exception
                Process.Start("https://www.imnotmental.com/")
            End Try
        Else
            If Not bgSwitch.IsBusy Then
                bgSwitch.RunWorkerAsync()
            Else
                bgSwitch.CancelAsync()
                bgSwitch.RunWorkerAsync()
            End If
        End If
    End Sub

    Public Sub New()
        SetStyle(ControlStyles.UserPaint, True)
        CheckForIllegalCrossThreadCalls = False
        Size = New Size(272, 317)
        DoubleBuffered = True
        Cursor = Cursors.Hand
        _imagesCollection = New List(Of EveImages)

        rectPrev = New Rectangle(Width - 75, Height - 45, 30, 35)
        rectNext = New Rectangle(Width - 45, Height - 45, 30, 35)
        rectPrev2 = New Rectangle(Width - 68, Height - 39, 30, 35)
        rectNext2 = New Rectangle(Width - 36, Height - 39, 30, 35)
    End Sub

    Private Sub EveSliderItem_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Visible Then If Not ImageCount = 0 Then If _curImg Is Nothing Then bgSwitch.RunWorkerAsync()
    End Sub
End Class

Public Class EveImages

    Public Property Image() As Image
    Public Property Link() As String

    Public Sub New(i As Image, l As String)
        Image = i
        Link = l
    End Sub

End Class
