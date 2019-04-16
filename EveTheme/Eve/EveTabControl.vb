Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Public Class EveTabControl
    Inherits TabControl

    Private rect As Rectangle

    Private _overIndex As Integer = -1
    Private Property OverIndex() As Integer
        Get
            Return _overIndex
        End Get
        Set(value As Integer)
            _overIndex = value
            Invalidate()
        End Set
    End Property

    Private _tabSeparatorColor As Color = Color.FromArgb(117, 117, 117)
    <Category("Appearance")>
    Public Property TabSeparatorColor() As Color
        Get
            Return _tabSeparatorColor
        End Get
        Set(value As Color)
            _tabSeparatorColor = value
            Invalidate()
        End Set
    End Property

    Private _tabNormalColor As Color = Color.FromArgb(191, 191, 191)
    <Category("Appearance")>
    Public Property TabNormalColor() As Color
        Get
            Return _tabNormalColor
        End Get
        Set(value As Color)
            _tabNormalColor = value
            Invalidate()
        End Set
    End Property

    Private _tabSelectedColor As Color = Color.GhostWhite
    <Category("Appearance")>
    Public Property TabSelectedColor() As Color
        Get
            Return _tabSelectedColor
        End Get
        Set(value As Color)
            _tabSelectedColor = value
            Invalidate()
        End Set
    End Property

    Public Sub New()
        SetStyle(ControlStyles.UserPaint, True)
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        DoubleBuffered = True
        Alignment = TabAlignment.Left
        SizeMode = TabSizeMode.Fixed
        ItemSize = New Size(40, 280)
    End Sub

    Protected Overrides Sub OnControlAdded(e As ControlEventArgs)
        MyBase.OnControlAdded(e)

        e.Control.BackColor = Color.Transparent 'Color.FromArgb(48, 50, 55)
        e.Control.ForeColor = Color.White
        e.Control.Cursor = Cursors.Arrow
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        Dim formGraphics As Graphics = e.Graphics
        formGraphics.SmoothingMode = Drawing2D.SmoothingMode.HighSpeed
        formGraphics.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit

        formGraphics.Clear(Color.Transparent)
        PaintTransparentBackground(formGraphics, ClientRectangle)
        Dim bsbrush As New SolidBrush(Color.Black)

        For i As Integer = 0 To TabPages.Count - 1
            rect = GetTabRect(i)
            If String.IsNullOrEmpty(TabPages(i).Tag) Then
                If SelectedIndex = i Then
                    Using textcolor As New SolidBrush(_tabSelectedColor), textfont As New Font(Font.Name, Font.SizeInPoints, Font.Style)
                        If TabPages(i).ImageIndex = -1 Then
                            formGraphics.DrawString(TabPages(i).Text, textfont, bsbrush, New Point(rect.X + ItemSize.Width + 1, rect.Y + 13))
                            formGraphics.DrawString(TabPages(i).Text, textfont, textcolor, New Point(rect.X + ItemSize.Width, rect.Y + 12))
                        Else
                            formGraphics.DrawString(TabPages(i).Text, textfont, bsbrush, New Point(rect.X + 25 + ItemSize.Width + 1, rect.Y + 13))
                            formGraphics.DrawString(TabPages(i).Text, textfont, textcolor, New Point(rect.X + 25 + ItemSize.Width, rect.Y + 12))
                        End If
                    End Using
                Else
                    Using textcolor As New SolidBrush(_tabNormalColor), TextFont As New Font(Font.Name, Font.SizeInPoints, Font.Style)
                        If TabPages(i).ImageIndex = -1 Then
                            formGraphics.DrawString(TabPages(i).Text, TextFont, bsbrush, New Point(rect.X + ItemSize.Width + 1, rect.Y + 13))
                            formGraphics.DrawString(TabPages(i).Text, TextFont, textcolor, New Point(rect.X + ItemSize.Width, rect.Y + 12))
                        Else
                            formGraphics.DrawString(TabPages(i).Text, TextFont, bsbrush, New Point(rect.X + 25 + ItemSize.Width + 1, rect.Y + 13))
                            formGraphics.DrawString(TabPages(i).Text, TextFont, textcolor, New Point(rect.X + 25 + ItemSize.Width, rect.Y + 12))
                        End If
                    End Using
                End If

                If Not OverIndex = -1 And Not SelectedIndex = OverIndex Then
                    Using textColor As New SolidBrush(_tabSelectedColor), TextFont As New Font(Font.Name, Font.SizeInPoints, Font.Style)
                        If TabPages(OverIndex).ImageIndex = -1 Then
                            formGraphics.DrawString(TabPages(OverIndex).Text, TextFont, bsbrush, New Point(GetTabRect(OverIndex).X + ItemSize.Width + 1, GetTabRect(OverIndex).Y + 13))
                            formGraphics.DrawString(TabPages(OverIndex).Text, TextFont, textColor, New Point(GetTabRect(OverIndex).X + ItemSize.Width, GetTabRect(OverIndex).Y + 12))
                        Else
                            formGraphics.DrawString(TabPages(OverIndex).Text, TextFont, bsbrush, New Point(GetTabRect(OverIndex).X + 25 + ItemSize.Width + 1, GetTabRect(OverIndex).Y + 13))
                            formGraphics.DrawString(TabPages(OverIndex).Text, TextFont, textColor, New Point(GetTabRect(OverIndex).X + 25 + ItemSize.Width, GetTabRect(OverIndex).Y + 12))
                        End If
                    End Using

                    If Not IsNothing(ImageList) Then
                        If Not TabPages(OverIndex).ImageIndex < 0 Then
                            formGraphics.DrawImage(ImageList.Images(TabPages(OverIndex).ImageIndex), New Rectangle(GetTabRect(OverIndex).X + ItemSize.Width, GetTabRect(OverIndex).Y + ((GetTabRect(OverIndex).Height / 2) - 9), 16, 16))
                        End If
                    End If
                End If

                If Not IsNothing(ImageList) Then
                    If Not TabPages(i).ImageIndex < 0 Then
                        formGraphics.DrawImage(ImageList.Images(TabPages(i).ImageIndex), New Rectangle(rect.X + ItemSize.Width, rect.Y + ((rect.Height / 2) - 9), 16, 16))
                    End If
                End If
            Else
                Using TextColor As New SolidBrush(_tabSeparatorColor), TextFont As New Font(Font.Name, Font.SizeInPoints - (Font.SizeInPoints / 3), Font.Style)
                    formGraphics.DrawString(TabPages(i).Text.ToUpper, TextFont, bsbrush, New Point(rect.X + ItemSize.Width - 15 + 1, rect.Y + 17))
                    formGraphics.DrawString(TabPages(i).Text.ToUpper, TextFont, TextColor, New Point(rect.X + ItemSize.Width - 15, rect.Y + 16))
                End Using
            End If
        Next

        bsbrush.Dispose()
    End Sub

    Protected Sub PaintTransparentBackground(graphics As Graphics, clipRect As Rectangle)

        If (Me.Parent IsNot Nothing) Then
            clipRect.Offset(Me.Location)

            Dim state As GraphicsState = graphics.Save()
            graphics.TranslateTransform(CSng(-Me.Location.X), CSng(-Me.Location.Y))
            graphics.SmoothingMode = SmoothingMode.HighSpeed

            Dim e As New PaintEventArgs(graphics, clipRect)
            Try
                Me.InvokePaintBackground(Me.Parent, e)
                Me.InvokePaint(Me.Parent, e)
            Finally
                graphics.Restore(state)
                clipRect.Offset(-Me.Location.X, -Me.Location.Y)
            End Try
        End If
    End Sub

    Protected Overrides Sub OnSelecting(e As TabControlCancelEventArgs)
        MyBase.OnSelecting(e)

        If Not IsNothing(e.TabPage) Then
            If Not String.IsNullOrEmpty(e.TabPage.Tag) Then
                e.Cancel = True
            Else
                OverIndex = -1
            End If
        End If
    End Sub

    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
        MyBase.OnMouseMove(e)

        Cursor = Cursors.Hand
        For I As Integer = 0 To TabPages.Count - 1
            If GetTabRect(I).Contains(e.Location) And Not SelectedIndex = I And String.IsNullOrEmpty(TabPages(I).Tag) Then
                OverIndex = I
                Exit For
            Else
                OverIndex = -1
            End If
        Next
    End Sub

    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)

        Cursor = Cursors.Default
        OverIndex = -1
    End Sub

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property

End Class
