Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Threading
Imports System.Windows.Forms

<DefaultEvent("CheckedChanged")>
Public Class EveCheckbox
    Inherits Control

    Dim rectText, rectCheck As Rectangle
    Dim _mousePos As Point = Point.Empty
    Private _mouseText As Boolean = False
    Private _parent As Control = Nothing
    Private WithEvents bgChecked As New BackgroundWorker With {.WorkerSupportsCancellation = True}
    Private WithEvents bgUnchecked As New BackgroundWorker With {.WorkerSupportsCancellation = True}
    Private _angle As Integer = 0

    Public Event CheckedChanged(ByVal sender As Object, e As EventArgs)

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

    Private _checkboxcolor As Color = Color.FromArgb(144, 144, 144)
    <Category("Appearance")>
    Public Property CheckBoxColor() As Color
        Get
            Return _checkboxcolor
        End Get
        Set(value As Color)
            _checkboxcolor = value
            Invalidate()
        End Set
    End Property

    Private _checkedcolor As Color = Color.FromArgb(0, 173, 255)
    <Category("Appearance")>
    Public Property CheckedColor() As Color
        Get
            Return _checkedcolor
        End Get
        Set(value As Color)
            _checkedcolor = value
            Invalidate()
        End Set
    End Property

    Private _checked As Boolean = False
    <Category("Behavior")>
    Public Property Checked() As Boolean
        Get
            Return _checked
        End Get
        Set(value As Boolean)
            _checked = value
            If _checked Then bgUnchecked.RunWorkerAsync()
            If Not _checked Then bgChecked.RunWorkerAsync()
            Invalidate()
            RaiseEvent CheckedChanged(Me, Nothing)
        End Set
    End Property

    Protected Overrides Sub SetBoundsCore(x As Integer, y As Integer, width As Integer, height As Integer, specified As BoundsSpecified)
        If _autosize AndAlso (specified And BoundsSpecified.Size) <> 0 Then
            Dim size As Size = Size.Empty
            size = New Size(TextWidth() + 30 + 2, TextHeight() + 2)
            width = size.Width
            height = size.Height
        End If

        MyBase.SetBoundsCore(x, y, width, height, specified)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        Dim formGraphics As Graphics = e.Graphics
        Dim pen As New Pen(_checkboxcolor)
        Dim cpen As New Pen(_checkedcolor, 2)
        cpen.Alignment = PenAlignment.Outset
        Dim m As New Matrix

        Using f As Font = New Font(Font.Name, Font.SizeInPoints, Font.Style, GraphicsUnit.Point)
            rectCheck = New Rectangle(1, 1, 16, 16)
            rectText = New Rectangle(rectCheck.Width + 15, 0, TextWidth, TextHeight)
            Dim rectTexts As New Rectangle(rectCheck.Width + 16, 1, TextWidth, TextHeight)

            Dim flags As TextFormatFlags = TextFormatFlags.Left Or TextFormatFlags.WordBreak
            formGraphics.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias
            If _checked Then
                rectCheck.Size = New Size(18, 18)
                rectCheck.Location = New Point(-1, -10)
                m.RotateAt(_angle, New Point(rectCheck.X + rectCheck.Width / 2, rectCheck.Y + rectCheck.Height / 2))
                formGraphics.Transform = m
                formGraphics.DrawRectangle(cpen, rectCheck)
            Else
                rectCheck.Size = New Size(16, 16)
                rectCheck.Location = New Point(1, 1)
                m.RotateAt(_angle, New Point(rectCheck.X + rectCheck.Width / 2, rectCheck.Y + rectCheck.Height / 2))
                formGraphics.Transform = m
                formGraphics.DrawRectangle(pen, rectCheck)
            End If
            TextRenderer.DrawText(formGraphics, Text, f, rectTexts, Color.Black, flags)
            TextRenderer.DrawText(formGraphics, Text, f, rectText, ForeColor, flags)
        End Using

        pen.Dispose()
        cpen.Dispose()
        m.Dispose()
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
        _mouseText = ClientRectangle.Contains(_mousePos)
        If _mouseText Then Cursor = Cursors.Hand Else Cursor = Cursors.Default
        Invalidate()
    End Sub

    Protected Overrides Sub OnClick(e As EventArgs)
        MyBase.OnClick(e)

        Checked = Not Checked
    End Sub

    Public Sub New()
        CheckForIllegalCrossThreadCalls = False
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        SetStyle(ControlStyles.UserPaint, True)
        BackColor = Color.Transparent
        DoubleBuffered = True
        ForeColor = Color.White
        _parent = Parent
    End Sub

    Private Sub bgChecked_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgChecked.DoWork
        For i As Integer = -45 To 0
            _angle = i
            Refresh()
            Thread.Sleep(5)
            i += 1
        Next
    End Sub

    Private Sub bgUnchecked_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgUnchecked.DoWork
        For i As Integer = 0 To -45 Step -1
            _angle = i
            Refresh()
            Thread.Sleep(5)
            i -= 1
        Next
    End Sub
End Class
