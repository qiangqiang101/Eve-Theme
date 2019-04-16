Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.Reflection
Imports System.Windows.Forms

<DefaultEvent("Click")>
Public Class EveNewsItem
    Inherits Panel

    Private _opacity As Single = 0.8F

    Private _backcolor As Color = BackColor
    <Category("Appearance")>
    Public Property BackgroundColor() As Color
        Get
            Return _backcolor
        End Get
        Set(value As Color)
            _backcolor = value
            BackColor = Color.FromArgb(SingleToAlpha(_opacity), _backcolor)
            Invalidate()
        End Set
    End Property

    <Browsable(False),
    EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never),
    DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Shadows Property BackColor() As Color
        Get
            Return MyBase.BackColor
        End Get
        Set(value As Color)
            MyBase.BackColor = value
            Invalidate()
        End Set
    End Property

    <Browsable(True),
    EditorBrowsable(System.ComponentModel.EditorBrowsableState.Always),
    DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Shadows Property Text() As String
        Get
            Return MyBase.Text
        End Get
        Set(value As String)
            MyBase.Text = value
            Invalidate()
        End Set
    End Property

    Private _title As String = Name
    <Category("Behavior")>
    Public Property Title() As String
        Get
            Return _title
        End Get
        Set(value As String)
            _title = value
        End Set
    End Property

    Private _date As String
    <Category("Behavior")>
    Public Property PubDate() As String
        Get
            Return _date
        End Get
        Set(value As String)
            _date = value
        End Set
    End Property

    Private _link As String = "https://www.imnotmental.com/"
    <Category("Behavior")>
    Public Property Link() As String
        Get
            Return _link
        End Get
        Set(value As String)
            _link = value
        End Set
    End Property

    Private _image As Image = New Bitmap(Width, Height)
    <Category("Appearance")>
    Public Property Image() As Image
        Get
            Return _image
        End Get
        Set(value As Image)
            _image = value
        End Set
    End Property

    Private Function SingleToAlpha(value As Single) As Integer
        Return CInt(value * 255)
    End Function

    Private Function GetImageSizeF() As SizeF
        Return New SizeF(Width, Height * 0.45F)
    End Function

    Private Function GetTextStartPosF() As PointF
        Return New PointF(0, Height * 0.45F)
    End Function

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        Dim formGraphics As Graphics = e.Graphics

        Dim tbrush As New TextureBrush(_image)
        Dim sbrush As New SolidBrush(_backcolor)
        Dim colormat As New ColorMatrix()
        Dim imgattr As New ImageAttributes()
        colormat.Matrix33 = _opacity
        imgattr.SetColorMatrix(colormat)

        formGraphics.DrawImage(_image, New Rectangle(0, 0, CInt(GetImageSizeF.Width), CInt(GetImageSizeF.Height)), 0, 0, _image.Width, _image.Height, GraphicsUnit.Pixel, imgattr)

        Using f As Font = New Font(Font.Name, Font.SizeInPoints, Font.Style, GraphicsUnit.Point)
            Dim df As New Font(f.FontFamily, f.SizeInPoints - 2.0F, f.Style)
            Dim dateWidth = TextRenderer.MeasureText(Convert.ToDateTime(_date).ToString("yyyy/MM/dd"), df).Width
            Dim dateHeight = TextRenderer.MeasureText(Convert.ToDateTime(_date).ToString("yyyy/MM/dd"), df).Height
            Dim rectTitle As New Rectangle(20, GetTextStartPosF.Y + 20, Width - 20, 40)
            Dim rectText As New Rectangle(20, GetTextStartPosF.Y + 70, Width - 30, 60)
            Dim rectDate As New Rectangle(GetImageSizeF.Width - 10 - dateWidth, GetImageSizeF.Height - 25, dateWidth, dateHeight)
            Dim flags As TextFormatFlags = TextFormatFlags.Left Or TextFormatFlags.WordBreak
            formGraphics.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias

            formGraphics.FillRectangle(sbrush, rectDate)
            TextRenderer.DrawText(formGraphics, Convert.ToDateTime(_date).ToString("yyyy/MM/dd"), df, rectDate, ForeColor, flags)
            TextRenderer.DrawText(formGraphics, _title.ToUpper, f, rectTitle, ForeColor, flags)
            TextRenderer.DrawText(formGraphics, Text, f, rectText, ForeColor, flags)
        End Using

        tbrush.Dispose()
        sbrush.Dispose()
        imgattr.Dispose()

    End Sub

    Public Sub New()
        SetStyle(ControlStyles.UserPaint, True)
        Size = New Size(272, 317)
        DoubleBuffered = True
        ForeColor = Color.White
        Cursor = Cursors.Hand
    End Sub

    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        MyBase.OnMouseEnter(e)

        _opacity = 0.9F
        BackColor = Color.FromArgb(SingleToAlpha(_opacity), _backcolor)
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)

        _opacity = 0.8F
        BackColor = Color.FromArgb(SingleToAlpha(_opacity), _backcolor)
        Invalidate()
    End Sub

    Protected Overrides Sub OnClick(e As EventArgs)
        MyBase.OnClick(e)

        Try
            Process.Start(_link)
        Catch ex As Exception
            Process.Start("https://www.imnotmental.com/")
        End Try
    End Sub

    '272 x 371

End Class
