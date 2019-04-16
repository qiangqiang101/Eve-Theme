Imports System.ComponentModel
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

<ToolboxItem(False), DefaultEvent("TextChanged")>
Public Class PHTextbox
    Inherits TextBox

    Const DEFAULT_PLACEHOLDER As String = "<Input>"
    Public Event PlaceholderColorChanged(ByVal sender As Object, ByVal e As EventArgs)
    Public Event PlaceholderActivechanged As EventHandler(Of PlaceholderActivechangedEventArgs)
    Private avoidTextChanged As Boolean

    Private _isPlaceholderActive As Boolean = False
    <Browsable(False)>
    Public Property IsPlaceHolderActive() As Boolean
        Get
            Return _isPlaceholderActive
        End Get
        Set(value As Boolean)
            If value <> _isPlaceholderActive Then
                _isPlaceholderActive = value
                OnPlaceHolderActivechanged(value)
            End If
        End Set
    End Property

    Private _placeholdetText As String = DEFAULT_PLACEHOLDER
    Public Property PlaceholderText() As String
        Get
            Return _placeholdetText
        End Get
        Set(value As String)
            _placeholdetText = value
            If IsPlaceHolderActive Then
                Text = value
            End If
        End Set
    End Property

    Private _placeholderColor As Color = Color.FromArgb(117, 117, 117)
    Public Property PlaceHolderColor() As Color
        Get
            Return _placeholderColor
        End Get
        Set(value As Color)
            _placeholderColor = value
            RaiseEvent PlaceholderColorChanged(Me, Nothing)
        End Set
    End Property

    <Browsable(False)>
    Public Overrides Property Text As String
        Get
            If IsPlaceHolderActive AndAlso MyBase.Text = PlaceholderText Then Return String.Empty
            Return MyBase.Text
        End Get
        Set(value As String)
            MyBase.Text = value
        End Set
    End Property

    Public Overrides Property ForeColor As Color
        Get
            If IsPlaceHolderActive AndAlso Environment.StackTrace.Contains("System.Windows.Forms.Control.InitializeDCForWmCtlColor(IntPtr dc, Int32 msg)") Then Return _placeholderColor
            Return MyBase.ForeColor
        End Get
        Set(value As Color)
            MyBase.ForeColor = value
        End Set
    End Property

    Public Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        SetStyle(ControlStyles.Opaque, True)
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        MyBase.Text = PlaceholderText
        SubscribeEvents()
        IsPlaceHolderActive = True
        DoubleBuffered = True
    End Sub

    Public Sub Reset()
        IsPlaceHolderActive = True
        ActionWithoutTextChanged(Sub() Text = PlaceholderText)
        [Select](0, 0)
    End Sub

    Private Sub ActionWithoutTextChanged(act As Action)
        avoidTextChanged = True
        act.Invoke
        avoidTextChanged = False
    End Sub

    Private Sub SubscribeEvents()
        AddHandler TextChanged, AddressOf PHTextbox_TextChanged
    End Sub

    Private Sub PHTextbox_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
        If avoidTextChanged Then Return

        ActionWithoutTextChanged(Sub()
                                     If String.IsNullOrEmpty(Me.Text) Then
                                         Reset()
                                         Return
                                     End If

                                     If Me.IsPlaceHolderActive Then
                                         Me.IsPlaceHolderActive = False
                                         Me.Text = Me.Text.Replace(Me.PlaceholderText, String.Empty)
                                         Me.[Select](Me.TextLength, 0)
                                     End If
                                 End Sub)
        Font = Font
    End Sub

    Protected Overrides Sub OnGotFocus(e As EventArgs)
        MyBase.OnGotFocus(e)

        [Select](0, 0)
    End Sub

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)

        If IsPlaceHolderActive Then Reset()
    End Sub

    Protected Overrides Sub OnKeyDown(e As KeyEventArgs)
        MyBase.OnKeyDown(e)

        If IsPlaceHolderActive AndAlso (e.KeyCode = Keys.Left OrElse e.KeyCode = Keys.Right OrElse e.KeyCode = Keys.Up OrElse e.KeyCode = Keys.Down) Then e.Handled = True
    End Sub

    Protected Overridable Sub OnPlaceHolderActivechanged(newValue As Boolean)
        RaiseEvent PlaceholderActivechanged(Me, New PlaceholderActivechangedEventArgs(newValue))
    End Sub

    Public Class PlaceholderActivechangedEventArgs
        Inherits EventArgs

        Public Property NewValue As Boolean

        Public Sub New(newValue As Boolean)
            Me.NewValue = newValue
        End Sub
    End Class

End Class