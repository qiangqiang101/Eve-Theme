Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Public Class EveToolTip
    Inherits Form

    Private _text As String
    Private _tooltippos As ToolTipPos = ToolTipPos.Top

    Public Sub New()
        MyBase.New

        CheckForIllegalCrossThreadCalls = False
        DoubleBuffered = True
        SetStyle(ControlStyles.UserPaint, True)
        SetStyle(ControlStyles.Selectable, False)
        BackColor = Color.Red
        TransparencyKey = Color.Red
        FormBorderStyle = FormBorderStyle.None
        ShowInTaskbar = False
        'TopMost = True
        Font = New Font("Segoe UI", 9.0F, FontStyle.Regular)
        StartPosition = FormStartPosition.Manual
    End Sub

    Public Overloads Sub Show(text As String, loc As Point)
        Show()

        _text = text
        Size = New Size(FormSize.Width + 20, FormSize.Height + 10)
        _tooltippos = ToolTipPos.Top
        Location = loc
    End Sub

    Public Overloads Sub Show(text As String, loc As Point, ttp As ToolTipPos)
        Show()

        _text = text
        Size = New Size(FormSize.Width + 20 + If(ttp = ToolTipPos.Right, 18, 0), FormSize.Height + 10)
        _tooltippos = ttp
        Location = loc
    End Sub

    Private Function FormSize() As Size
        Return TextRenderer.MeasureText(_text, Font)
    End Function

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        Dim formGraphics As Graphics = e.Graphics
        Dim addedSpace As Integer = 0
        If _tooltippos = ToolTipPos.Right Then addedSpace = 17
        Dim rect As New Rectangle(addedSpace, 0, FormSize.Width + 20, FormSize.Height + 10)
        Dim textRect As New Rectangle(10 + addedSpace, 5, rect.Width, rect.Height)
        Dim flags As TextFormatFlags = TextFormatFlags.Left Or TextFormatFlags.WordBreak
        Dim sbrush As New SolidBrush(Color.White)

        FillRoundedRectangle(formGraphics, rect, 3, sbrush)

        Using f As Font = New Font(Font.Name, Font.Size, Font.Style, GraphicsUnit.Point)
            TextRenderer.DrawText(formGraphics, _text, f, textRect, Color.Black, flags)
        End Using

        sbrush.Dispose()
    End Sub

    Private Sub FillRoundedRectangle(ByVal g As Graphics, ByVal r As Rectangle, ByVal d As Integer, ByVal b As Brush)
        Dim mode As SmoothingMode = g.SmoothingMode
        g.SmoothingMode = SmoothingMode.HighSpeed
        g.FillPie(b, r.X, r.Y, d, d, 180, 90)
        g.FillPie(b, r.X + r.Width - d, r.Y, d, d, 270, 90)
        g.FillPie(b, r.X, r.Y + r.Height - d, d, d, 90, 90)
        g.FillPie(b, r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90)
        g.FillRectangle(b, CInt(r.X + d / 2), r.Y, r.Width - d, CInt(d / 2))
        g.FillRectangle(b, r.X, CInt(r.Y + d / 2), r.Width, CInt(r.Height - d))
        g.FillRectangle(b, CInt(r.X + d / 2), CInt(r.Y + r.Height - d / 2), CInt(r.Width - d), CInt(d / 2))
        g.SmoothingMode = mode
        FillPentagon(g, b, r)
    End Sub

    Private Sub FillPentagon(ByVal g As Graphics, ByVal b As Brush, ByVal rr As Rectangle)
        Dim r As Rectangle
        Select Case _tooltippos
            Case ToolTipPos.Top
                r = New Rectangle(New Point(rr.X + (rr.Width / 2) - 10, rr.Y + rr.Height - 17), New Size(20, 20))
            Case ToolTipPos.Right
                r = New Rectangle(New Point(14, rr.Height - (rr.Height / 2) - 11), New Size(18, 18))
        End Select
        Dim m As New Matrix
        m.RotateAt(45, New Point(r.X + r.Width / 2, r.Y + r.Height / 2))
        g.Transform = m
        g.FillRectangle(b, r)
    End Sub

End Class

Public Enum ToolTipPos
    Top
    Right
End Enum