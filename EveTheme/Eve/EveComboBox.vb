Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Text
Imports System.Windows.Forms

<DefaultEvent("SelectedIndexChanged")>
Public Class EveComboBox
    Inherits ComboBox

    Public Shadows Property Enabled As Boolean
        Get
            Return EnabledCalc
        End Get
        Set(value As Boolean)
            _enabledCalc = value
            Invalidate()
        End Set
    End Property

    Private _enabledCalc As Boolean
    <DisplayName("Enabled")>
    Public Property EnabledCalc As Boolean
        Get
            Return _enabledCalc
        End Get
        Set(value As Boolean)
            MyBase.Enabled = value
            Enabled = value
            Invalidate()
        End Set
    End Property

    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
        SetStyle(ControlStyles.UserPaint, True)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        Dim formGraphics As Graphics = e.Graphics

        formGraphics.SmoothingMode = SmoothingMode.HighQuality
        formGraphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit
        formGraphics.Clear(Color.White)
        Dim sbrush As New SolidBrush(ForeColor)
        Dim dbrush As New SolidBrush(Color.FromArgb(208, 211, 215))
        Dim rect As New Rectangle(0, 0, Width, Height)
        Dim bsbrush As New SolidBrush(BackColor)

        formGraphics.FillRectangle(bsbrush, rect)

        If Enabled Then
            Using trianglefont As New Font("Marlett", 13)
                formGraphics.DrawString("6", trianglefont, sbrush, New Point(Width - 22, 3))
            End Using
        Else
            Using triangleFont As New Font("Marlett", 13)
                formGraphics.DrawString("6", triangleFont, dbrush, New Point(Width - 22, 3))
            End Using
        End If

        If Not IsNothing(Items) Then
            If Enabled Then
                If Not SelectedIndex = -1 Then
                    formGraphics.DrawString(GetItemText(Items(SelectedIndex)), Font, sbrush, New Point(7, 4))
                Else
                    Try
                        formGraphics.DrawString(GetItemText(Items(0)), Font, sbrush, New Point(7, 4))
                    Catch ex As Exception
                    End Try
                End If
            Else
                If Not SelectedIndex = -1 Then
                    formGraphics.DrawString(GetItemText(Items(SelectedIndex)), Font, dbrush, New Point(7, 4))
                Else
                    formGraphics.DrawString(GetItemText(Items(0)), Font, dbrush, New Point(7, 4))
                End If
            End If
        End If

        sbrush.Dispose()
        dbrush.Dispose()
        bsbrush.Dispose()
    End Sub

    Protected Overrides Sub OnDrawItem(e As DrawItemEventArgs)
        MyBase.OnDrawItem(e)

        Dim formGraphics As Graphics = e.Graphics
        formGraphics.SmoothingMode = SmoothingMode.HighQuality
        formGraphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit
        Dim rect As Rectangle

        If Enabled Then
            e.DrawBackground()
            rect = e.Bounds

            Try
                Using border As New Pen(Color.FromArgb(208, 213, 217))
                    If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
                        Using itemscolor As New SolidBrush(Color.White), itembg As New SolidBrush(Color.FromArgb(120, 183, 230))
                            formGraphics.FillRectangle(itembg, rect)
                            formGraphics.DrawString(GetItemText(Items(e.Index)), Font, itemscolor, New Point(rect.X + 5, rect.Y + 1))
                        End Using
                    Else
                        Using itemscolor As New SolidBrush(Color.FromArgb(124, 133, 142))
                            formGraphics.FillRectangle(Brushes.White, rect)
                            formGraphics.DrawString(GetItemText(Items(e.Index)), Font, itemscolor, New Point(rect.X + 5, rect.Y + 1))
                        End Using
                    End If
                End Using
            Catch ex As Exception
            End Try
        End If
    End Sub

    Protected Overrides Sub OnSelectedItemChanged(e As EventArgs)
        MyBase.OnSelectedItemChanged(e)

        Invalidate()
    End Sub

    Sub New()
        DoubleBuffered = True
        DropDownStyle = ComboBoxStyle.DropDownList
        Cursor = Cursors.Hand
        Enabled = True
        DrawMode = DrawMode.OwnerDrawFixed
        ItemHeight = 20
    End Sub


End Class
