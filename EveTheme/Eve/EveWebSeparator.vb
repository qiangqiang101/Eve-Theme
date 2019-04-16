Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Public Class EveWebSeparator
    Inherits Control

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)

        Size = New Size(Width, 10)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        Dim formGraphics As Graphics = e.Graphics
        Dim sbrush As New SolidBrush(ForeColor)
        Dim rectLine As New Rectangle(0, 0, Width, 2)
        Dim rectDiamond As New Rectangle(30, -2, 8, 8)
        Dim matrix As New Matrix

        formGraphics.FillRectangle(sbrush, rectLine)

        rectLine.Location = New Point(35, 2)
        rectLine.Size = New Size(84, 6)
        formGraphics.FillRectangle(sbrush, rectLine)

        matrix.RotateAt(45, New Point(rectDiamond.X + rectDiamond.Width / 2, rectDiamond.Y + rectDiamond.Height / 2))
        formGraphics.Transform = matrix
        formGraphics.FillRectangle(sbrush, rectDiamond)

        rectDiamond.Location = New Point(90, -62)
        formGraphics.FillRectangle(sbrush, rectDiamond)

        sbrush.Dispose()
        matrix.Dispose()
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
