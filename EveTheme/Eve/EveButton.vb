Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Public Class EveButton
    Inherits Label

    Private _normalColor As Color = Color.FromArgb(41, 128, 185)
    <Category("Appearance")>
    Public Property NormalColor() As Color
        Get
            Return _normalColor
        End Get
        Set(value As Color)
            _normalColor = value
        End Set
    End Property

    Private _hoveredColor As Color = Color.FromArgb(36, 108, 155)
    <Category("Appearance")>
    Public Property HoveredColor() As Color
        Get
            Return _hoveredColor
        End Get
        Set(value As Color)
            _hoveredColor = value
        End Set
    End Property

    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        MyBase.OnMouseEnter(e)

        BackColor = _hoveredColor
    End Sub

    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)

        BackColor = _normalColor
    End Sub

    Public Sub New()
        SetStyle(ControlStyles.UserPaint, True)
        CheckForIllegalCrossThreadCalls = False
        TextAlign = ContentAlignment.MiddleCenter
        ForeColor = Color.White
        BackColor = _normalColor
        AutoSize = False
        DoubleBuffered = True
        Cursor = Cursors.Hand
        Size = New Size(202, 45)
    End Sub

End Class
