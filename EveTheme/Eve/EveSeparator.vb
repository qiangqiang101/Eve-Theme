Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Public Class EveSeparator
    Inherits Control

    Private _vh As SStyle = SStyle.Horizontal
    <Category("Appearance")>
    Public Property Style() As SStyle
        Get
            Return _vh
        End Get
        Set(value As SStyle)
            _vh = value
        End Set
    End Property

    Private _thickness As Integer = 2
    <Category("Appearance")>
    Public Property Thickness() As Integer
        Get
            Return _thickness
        End Get
        Set(value As Integer)
            _thickness = value
        End Set
    End Property

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        Dim formGraphics As Graphics = e.Graphics
        Dim sbrush As New SolidBrush(Color.White)

        Select Case _vh
            Case SStyle.Horizontal
                formGraphics.FillRectangle(sbrush, New Rectangle(3, Height / 2, Width - 5, _thickness))
            Case SStyle.Vertical
                formGraphics.FillRectangle(sbrush, New Rectangle(Width / 2, 3, _thickness, Height - 5))
        End Select

        sbrush.Dispose()
    End Sub

    Public Sub New()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        SetStyle(ControlStyles.UserPaint, True)
        BackColor = Color.Transparent
        DoubleBuffered = True
    End Sub

    Enum SStyle
        Vertical
        Horizontal
    End Enum

End Class
