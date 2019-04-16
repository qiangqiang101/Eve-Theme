Imports System.ComponentModel
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

<DefaultEvent("HelpPressed")>
Public Class EveControlButtons
    Inherits Control

    Dim _mousePos As Point = Point.Empty
    Private _rect1, _rect2, _rect3, _rect4, _rect5 As Rectangle
    Private _mouse1 As Boolean = False, _mouse2 As Boolean = False, _mouse3 As Boolean = False, _mouse4 As Boolean = False, _mouse5 As Boolean = False
    Dim _isDragging As Boolean = False
    Dim _mouseDownPos As Point = Point.Empty

    Private _normalColor As Color = Color.FromArgb(193, 211, 221)
    <Category("Appearance")>
    Public Property NormalColor() As Color
        Get
            Return _normalColor
        End Get
        Set(value As Color)
            _normalColor = value
        End Set
    End Property

    Private _hoveredColor As Color = Color.FromArgb(17, 38, 59)
    <Category("Appearance")>
    Public Property HoveredColor() As Color
        Get
            Return _hoveredColor
        End Get
        Set(value As Color)
            _hoveredColor = value
        End Set
    End Property

    Private _hoveredBackColor As Color = Color.White
    <Category("Appearance")>
    Public Property HoveredBackColor() As Color
        Get
            Return _hoveredBackColor
        End Get
        Set(value As Color)
            _hoveredBackColor = value
        End Set
    End Property

    Private _allowMoveForm As Boolean = True
    <Category("Behavior")>
    Public Property AllowMoveform() As Boolean
        Get
            Return _allowMoveForm
        End Get
        Set(value As Boolean)
            _allowMoveForm = value
        End Set
    End Property

    Private _ctrl1 As ControlButtonType = ControlButtonType.Close
    <Category("Behavior")>
    Public Property ControlButton1() As ControlButtonType
        Get
            Return _ctrl1
        End Get
        Set(value As ControlButtonType)
            _ctrl1 = value
        End Set
    End Property

    Private _ctrl2 As ControlButtonType = ControlButtonType.Maximize
    <Category("Behavior")>
    Public Property ControlButton2() As ControlButtonType
        Get
            Return _ctrl2
        End Get
        Set(value As ControlButtonType)
            _ctrl2 = value
        End Set
    End Property

    Private _ctrl3 As ControlButtonType = ControlButtonType.Minimize
    <Category("Behavior")>
    Public Property ControlButton3() As ControlButtonType
        Get
            Return _ctrl3
        End Get
        Set(value As ControlButtonType)
            _ctrl3 = value
        End Set
    End Property

    Private _ctrl4 As ControlButtonType = ControlButtonType.Help
    <Category("Behavior")>
    Public Property ControlButton4() As ControlButtonType
        Get
            Return _ctrl4
        End Get
        Set(value As ControlButtonType)
            _ctrl4 = value
        End Set
    End Property

    Private _ctrl5 As ControlButtonType = ControlButtonType.Menu
    <Category("Behavior")>
    Public Property ControlButton5() As ControlButtonType
        Get
            Return _ctrl5
        End Get
        Set(value As ControlButtonType)
            _ctrl5 = value
        End Set
    End Property

    Private _showTitle As Boolean = False
    <Category("Appearance")>
    Public Property Showtitle() As Boolean
        Get
            Return _showTitle
        End Get
        Set(value As Boolean)
            _showTitle = value
            Invalidate()
        End Set
    End Property

    Public ReadOnly Property Title() As String
        Get
            If TypeOf Parent Is Form Then
                Return Parent.Text
            End If
            Return Nothing
        End Get
    End Property

    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)

        _mouse1 = False
        _mouse2 = False
        _mouse3 = False
        _mouse4 = False
        _mouse5 = False

        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
        MyBase.OnMouseMove(e)

        _mousePos = New Point(e.X, e.Y)

        _mouse1 = _rect1.Contains(_mousePos)
        _mouse2 = _rect2.Contains(_mousePos)
        _mouse3 = _rect3.Contains(_mousePos)
        _mouse4 = _rect4.Contains(_mousePos)
        _mouse5 = _rect5.Contains(_mousePos)

        If _allowMoveForm Then
            If _isDragging Then
                Dim temp As Point = New Point

                temp.X = Parent.FindForm.Location.X + (e.X - _mouseDownPos.X)
                temp.Y = Parent.FindForm.Location.Y + (e.Y - _mouseDownPos.Y)
                Parent.FindForm.Location = temp
                temp = Nothing
            End If
        End If

        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)

        If e.Button = MouseButtons.Left Then
            If _allowMoveForm Then
                _isDragging = True
                _mouseDownPos = New Point(e.X, e.Y)
            End If
        End If
    End Sub

    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e)

        If e.Button = MouseButtons.Left Then
            If _allowMoveForm Then _isDragging = False
        End If
    End Sub

    Protected Overrides Sub OnMouseClick(e As MouseEventArgs)
        MyBase.OnMouseClick(e)

        If e.Button = MouseButtons.Left Then
            If _mouse1 Then
                Select Case _ctrl1
                    Case ControlButtonType.Close
                        Parent.FindForm.Close()
                    Case ControlButtonType.Help
                        RaiseEvent HelpPressed(Me, EventArgs.Empty)
                    Case ControlButtonType.Maximize
                        Select Case Parent.FindForm.WindowState
                            Case FormWindowState.Normal
                                Parent.FindForm.WindowState = FormWindowState.Maximized
                            Case FormWindowState.Maximized
                                Parent.FindForm.WindowState = FormWindowState.Normal
                        End Select
                    Case ControlButtonType.Menu
                        If MyBase.ContextMenuStrip IsNot Nothing Then
                            MyBase.ContextMenuStrip.Show(Me, New Point(_rect1.Location.X, _rect1.Location.Y + _rect1.Size.Height))
                        End If
                    Case ControlButtonType.Minimize
                        Parent.FindForm.WindowState = FormWindowState.Minimized
                End Select
            End If

            If _mouse2 Then
                Select Case _ctrl2
                    Case ControlButtonType.Close
                        Parent.FindForm.Close()
                    Case ControlButtonType.Help
                        RaiseEvent HelpPressed(Me, EventArgs.Empty)
                    Case ControlButtonType.Maximize
                        Select Case Parent.FindForm.WindowState
                            Case FormWindowState.Normal
                                Parent.FindForm.WindowState = FormWindowState.Maximized
                            Case FormWindowState.Maximized
                                Parent.FindForm.WindowState = FormWindowState.Normal
                        End Select
                    Case ControlButtonType.Menu
                        If MyBase.ContextMenuStrip IsNot Nothing Then
                            MyBase.ContextMenuStrip.Show(Me, New Point(_rect2.Location.X, _rect2.Location.Y + _rect2.Size.Height))
                        End If
                    Case ControlButtonType.Minimize
                        Parent.FindForm.WindowState = FormWindowState.Minimized
                End Select
            End If

            If _mouse3 Then
                Select Case _ctrl3
                    Case ControlButtonType.Close
                        Parent.FindForm.Close()
                    Case ControlButtonType.Help
                        RaiseEvent HelpPressed(Me, EventArgs.Empty)
                    Case ControlButtonType.Maximize
                        Select Case Parent.FindForm.WindowState
                            Case FormWindowState.Normal
                                Parent.FindForm.WindowState = FormWindowState.Maximized
                            Case FormWindowState.Maximized
                                Parent.FindForm.WindowState = FormWindowState.Normal
                        End Select
                    Case ControlButtonType.Menu
                        If MyBase.ContextMenuStrip IsNot Nothing Then
                            MyBase.ContextMenuStrip.Show(Me, New Point(_rect3.Location.X, _rect3.Location.Y + _rect3.Size.Height))
                        End If
                    Case ControlButtonType.Minimize
                        Parent.FindForm.WindowState = FormWindowState.Minimized
                End Select
            End If

            If _mouse4 Then
                Select Case _ctrl4
                    Case ControlButtonType.Close
                        Parent.FindForm.Close()
                    Case ControlButtonType.Help
                        RaiseEvent HelpPressed(Me, EventArgs.Empty)
                    Case ControlButtonType.Maximize
                        Select Case Parent.FindForm.WindowState
                            Case FormWindowState.Normal
                                Parent.FindForm.WindowState = FormWindowState.Maximized
                            Case FormWindowState.Maximized
                                Parent.FindForm.WindowState = FormWindowState.Normal
                        End Select
                    Case ControlButtonType.Menu
                        If MyBase.ContextMenuStrip IsNot Nothing Then
                            MyBase.ContextMenuStrip.Show(Me, New Point(_rect4.Location.X, _rect4.Location.Y + _rect4.Size.Height))
                        End If
                    Case ControlButtonType.Minimize
                        Parent.FindForm.WindowState = FormWindowState.Minimized
                End Select
            End If

            If _mouse5 Then
                Select Case _ctrl5
                    Case ControlButtonType.Close
                        Parent.FindForm.Close()
                    Case ControlButtonType.Help
                        RaiseEvent HelpPressed(Me, EventArgs.Empty)
                    Case ControlButtonType.Maximize
                        Select Case Parent.FindForm.WindowState
                            Case FormWindowState.Normal
                                Parent.FindForm.WindowState = FormWindowState.Maximized
                            Case FormWindowState.Maximized
                                Parent.FindForm.WindowState = FormWindowState.Normal
                        End Select
                    Case ControlButtonType.Menu
                        If MyBase.ContextMenuStrip IsNot Nothing Then
                            MyBase.ContextMenuStrip.Show(Me, New Point(_rect5.Location.X, _rect5.Location.Y + _rect5.Size.Height))
                        End If
                    Case ControlButtonType.Minimize
                        Parent.FindForm.WindowState = FormWindowState.Minimized
                End Select
            End If
        End If
    End Sub

    Public Event HelpPressed As EventHandler

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        Dim formGraphics As Graphics = e.Graphics

        If Not _ctrl1 = ControlButtonType.Nothing Then _rect1 = New Rectangle(Width - 30, 5, 17, 17)
        If Not _ctrl2 = ControlButtonType.Nothing Then _rect2 = New Rectangle(Width - 62, 5, 17, 17)
        If Not _ctrl3 = ControlButtonType.Nothing Then _rect3 = New Rectangle(Width - 94, 5, 17, 17)
        If Not _ctrl4 = ControlButtonType.Nothing Then _rect4 = New Rectangle(Width - 126, 5, 17, 17)
        If Not _ctrl5 = ControlButtonType.Nothing Then _rect5 = New Rectangle(Width - 158, 5, 17, 17)

        Dim flags As TextFormatFlags = TextFormatFlags.HorizontalCenter
        formGraphics.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias
        Dim sbrush As New SolidBrush(_hoveredBackColor)

        If _showTitle Then
            TextRendererDrawText(formGraphics, Title, Font, New Rectangle(New Point(2, 2), TextRenderer.MeasureText(Title, Font)), ForeColor, flags)
        End If

        If _mouse1 Then
            formGraphics.FillRectangle(sbrush, _rect1)
            TextRendererDrawText(formGraphics, GetSymbol(_ctrl1), GetSymbolFont(_ctrl1), _rect1, _hoveredColor, flags)
        Else
            TextRendererDrawText(formGraphics, GetSymbol(_ctrl1), GetSymbolFont(_ctrl1), _rect1, _normalColor, flags)
        End If

        If _mouse2 Then
            formGraphics.FillRectangle(sbrush, _rect2)
            TextRendererDrawText(formGraphics, GetSymbol(_ctrl2), GetSymbolFont(_ctrl2), _rect2, _hoveredColor, flags)
        Else
            TextRendererDrawText(formGraphics, GetSymbol(_ctrl2), GetSymbolFont(_ctrl2), _rect2, _normalColor, flags)
        End If

        If _mouse3 Then
            formGraphics.FillRectangle(sbrush, _rect3)
            TextRendererDrawText(formGraphics, GetSymbol(_ctrl3), GetSymbolFont(_ctrl3), _rect3, _hoveredColor, flags)
        Else
            TextRendererDrawText(formGraphics, GetSymbol(_ctrl3), GetSymbolFont(_ctrl3), _rect3, _normalColor, flags)
        End If

        If _mouse4 Then
            formGraphics.FillRectangle(sbrush, _rect4)
            TextRendererDrawText(formGraphics, GetSymbol(_ctrl4), GetSymbolFont(_ctrl4), _rect4, _hoveredColor, flags)
        Else
            TextRendererDrawText(formGraphics, GetSymbol(_ctrl4), GetSymbolFont(_ctrl4), _rect4, _normalColor, flags)
        End If

        If _mouse5 Then
            formGraphics.FillRectangle(sbrush, _rect5)
            TextRendererDrawText(formGraphics, GetSymbol(_ctrl5), GetSymbolFont(_ctrl5), _rect5, _hoveredColor, flags)
        Else
            TextRendererDrawText(formGraphics, GetSymbol(_ctrl5), GetSymbolFont(_ctrl5), _rect5, _normalColor, flags)
        End If

        sbrush.Dispose()
    End Sub

    Private Sub TextRendererDrawText(g As Graphics, str As String, fnt As Font, rect As Rectangle, col As Color, flag As TextFormatFlags)
        Dim rects As New Rectangle(rect.X + 1, rect.Y + 1, rect.Width, rect.Height)
        TextRenderer.DrawText(g, str, fnt, rects, Color.Black, flag)
        TextRenderer.DrawText(g, str, fnt, rect, col, flag)
    End Sub

    Private Function GetSymbol(cbType As ControlButtonType) As String
        Select Case cbType
            Case ControlButtonType.Close
                Return "r"
            Case ControlButtonType.Help
                Return ""
            Case ControlButtonType.Maximize
                Select Case Parent.FindForm.WindowState
                    Case FormWindowState.Normal
                        Return "1"
                    Case FormWindowState.Maximized
                        Return "2"
                End Select
            Case ControlButtonType.Menu
                Return "" 'W
            Case ControlButtonType.Minimize
                Return ""
        End Select
        Return ""
    End Function

    Private Function GetSymbolFont(cbtype As ControlButtonType) As Font
        Select Case cbtype
            Case ControlButtonType.Menu, ControlButtonType.Minimize, ControlButtonType.Help
                Return FontAwesome.GetInstance(12.0F, FontStyle.Regular) 'New Font("Segoe UI Symbol", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
            Case Else
                Return New Font("Marlett", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        End Select
    End Function

    Protected Overrides Sub CreateHandle()
        MyBase.CreateHandle()

        Dock = DockStyle.Top
    End Sub

    Public Sub New()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        SetStyle(ControlStyles.UserPaint, True)
        BackColor = Color.Transparent
        DoubleBuffered = True
        Size = New Size(Width, 25)
    End Sub

    Enum ControlButtonType
        [Nothing]
        Close
        Maximize
        Minimize
        Help
        Menu
    End Enum

End Class
