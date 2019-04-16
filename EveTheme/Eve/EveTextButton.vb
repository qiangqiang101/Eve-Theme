Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

<DefaultEvent("Click")>
Public Class EveTextButton
    Inherits Control

    <Browsable(True),
    EditorBrowsable(System.ComponentModel.EditorBrowsableState.Always),
    DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Shadows Property Text() As String
        Get
            Return MyBase.Text
        End Get
        Set(value As String)
            MyBase.Text = value
            Update()
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

    Protected Overrides Sub SetBoundsCore(x As Integer, y As Integer, width As Integer, height As Integer, specified As BoundsSpecified)
        If _autosize AndAlso (specified And BoundsSpecified.Size) <> 0 Then
            Dim size As Size = New Size(TextWidth() + 10, TextHeight() + 15)
            width = size.Width
            height = size.Height
        End If

        MyBase.SetBoundsCore(x, y, width, height, specified)
    End Sub

    Private _barWidth As Single = 0

    Private _barColor As Color = Color.FromArgb(41, 128, 185)
    <Category("Appearance")>
    Public Property BarColor() As Color
        Get
            Return _barColor
        End Get
        Set(value As Color)
            _barColor = value
        End Set
    End Property

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        Dim formGraphics As Graphics = e.Graphics
        Dim sbrush As New SolidBrush(_barColor)

        Using f As Font = New Font(Font.Name, Font.SizeInPoints, Font.Style, GraphicsUnit.Point)
            Dim rectText As New Rectangle(5, 8, Width - 10, Height - 15)
            Dim rectTexts As New Rectangle(6, 9, Width - 10, Height - 15)
            Dim flags As TextFormatFlags = TextFormatFlags.Left Or TextFormatFlags.WordBreak
            formGraphics.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias
            TextRenderer.DrawText(formGraphics, Text, f, rectTexts, Color.Black, flags)
            TextRenderer.DrawText(formGraphics, Text, f, rectText, ForeColor, flags)
        End Using

        formGraphics.FillRectangle(sbrush, New RectangleF(8.0F, 6.0F, _barWidth * 1.08F, 1.8F))

        sbrush.Dispose()
    End Sub

    Private Function TextWidth() As Integer
        Return TextRenderer.MeasureText(Text, Font).Width
    End Function

    Private Function TextHeight() As Integer
        Return TextRenderer.MeasureText(Text, Font).Height
    End Function

    Private WithEvents bgEnter As New BackgroundWorker With {.WorkerSupportsCancellation = True}
    Private WithEvents bgLeave As New BackgroundWorker With {.WorkerSupportsCancellation = True}

    Private Sub bgEnter_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgEnter.DoWork
        Do Until _barWidth >= TextWidth() - 20
            _barWidth += 2.0F
            Update()
            Invalidate()
        Loop
    End Sub

    Private Sub bgLeave_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgLeave.DoWork
        Do Until _barWidth <= 0
            _barWidth -= 2.0F
            Update()
            Invalidate()
        Loop
    End Sub

    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        MyBase.OnMouseEnter(e)

        bgLeave.CancelAsync()

        If Not bgEnter.IsBusy Then
            bgEnter.RunWorkerAsync()
        End If
    End Sub

    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)

        bgEnter.CancelAsync()

        If Not bgLeave.IsBusy Then
            bgLeave.RunWorkerAsync()
        End If
    End Sub

    Public Sub New()
        CheckForIllegalCrossThreadCalls = False
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        SetStyle(ControlStyles.UserPaint, True)
        BackColor = Color.Transparent
        DoubleBuffered = True
        Cursor = Cursors.Hand
        ForeColor = Color.White
    End Sub

End Class
