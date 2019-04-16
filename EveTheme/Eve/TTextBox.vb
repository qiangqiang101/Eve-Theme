Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

<ToolboxItem(False), DefaultEvent("TextChanged")>
Public Class TTextbox
    Inherits RichTextBox

    <DllImport("kernel32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function LoadLibrary(ByVal lpFileName As String) As IntPtr
    End Function

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim params As CreateParams = MyBase.CreateParams
            If LoadLibrary("msftedit.dll") <> IntPtr.Zero Then
                If _useSystemPasswordchar Then
                    params.Style = params.Style Or &H20
                    params.ExStyle = params.ExStyle Or &H20
                Else
                    params.ExStyle = params.ExStyle Or &H20
                End If
                params.ClassName = "RICHEDIT50W"
            End If
            Return params
        End Get
    End Property

    Public Property TextAlign() As HorizontalAlignment

    Private _useSystemPasswordchar As Boolean = False
    Public Property UseSystemPasswordChar() As Boolean
        Get
            Return _useSystemPasswordchar
        End Get
        Set(value As Boolean)
            _useSystemPasswordchar = value
        End Set
    End Property

    Public Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        SetStyle(ControlStyles.Opaque, True)
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        DoubleBuffered = True
    End Sub

    Protected Overrides Sub OnTextChanged(e As EventArgs)
        MyBase.OnTextChanged(e)

        [Select](Text.Length, Text.Length)
    End Sub

End Class