Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

<DefaultEvent("Click")>
Public Class EveSocialButton
    Inherits Control

    Dim rectFA As Rectangle
    Private _mouse As Boolean = False

    Private _social As SocialIcons = SocialIcons.facebook
    <Category("Appearance")>
    Public Property SocialIcon() As SocialIcons
        Get
            Return _social
        End Get
        Set(value As SocialIcons)
            _social = value
            Invalidate()
        End Set
    End Property

    Private _customicon As String = ""
    <Category("Appearance")>
    Public Property CustomIcon() As String
        Get
            Return _customicon
        End Get
        Set(value As String)
            _customicon = value
        End Set
    End Property

    Public Shadows Property Font() As Font
        Get
            Return FontAwesome.GetInstance5(20.0F, FontStyle.Regular)
        End Get
        Set(value As Font)
            MyBase.Font = FontAwesome.GetInstance5(20.0F, FontStyle.Regular)
        End Set
    End Property

    Private _normalcolor As Color = Color.FromArgb(59, 89, 152)
    <Category("Appearance")>
    Public Property LinkNormalColor() As Color
        Get
            Return _normalcolor
        End Get
        Set(value As Color)
            _normalcolor = value
            Invalidate()
        End Set
    End Property

    Private _hovercolor As Color = Color.FromArgb(62, 87, 142)
    <Category("Appearance")>
    Public Property HoverColor() As Color
        Get
            Return _hovercolor
        End Get
        Set(value As Color)
            _hovercolor = value
            Invalidate()
        End Set
    End Property

    Private Function GetIcon() As String
        Select Case _social
            Case SocialIcons.facebook
                Return " "
            Case SocialIcons.delicious
                Return ""
            Case SocialIcons.digg
                Return ""
            Case SocialIcons.discord
                Return ""
            Case SocialIcons.github
                Return ""
            Case SocialIcons.google
                Return ""
            Case SocialIcons.patreon
                Return ""
            Case SocialIcons.psn
                Return ""
            Case SocialIcons.qq
                Return ""
            Case SocialIcons.reddit
                Return ""
            Case SocialIcons.renren
                Return ""
            Case SocialIcons.skype
                Return ""
            Case SocialIcons.snapchat
                Return ""
            Case SocialIcons.soundcloud
                Return ""
            Case SocialIcons.steam
                Return ""
            Case SocialIcons.telegram
                Return ""
            Case SocialIcons.teamspeak
                Return ""
            Case SocialIcons.tencentweibo
                Return ""
            Case SocialIcons.tumblr
                Return ""
            Case SocialIcons.twitch
                Return ""
            Case SocialIcons.twitter
                Return ""
            Case SocialIcons.viber
                Return ""
            Case SocialIcons.vimeo
                Return ""
            Case SocialIcons.vine
                Return ""
            Case SocialIcons.vk
                Return ""
            Case SocialIcons.weibo
                Return ""
            Case SocialIcons.weixin, SocialIcons.wechat
                Return ""
            Case SocialIcons.whatsapp
                Return ""
            Case SocialIcons.windows
                Return ""
            Case SocialIcons.xbox
                Return ""
            Case SocialIcons.yahoo
                Return ""
            Case SocialIcons.youtube
                Return ""
            Case SocialIcons.zhihu
                Return ""
            Case SocialIcons.instagram
                Return ""
            Case SocialIcons.custom
                Return _customicon
        End Select
        Return _customicon
    End Function

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        Dim formGraphics As Graphics = e.Graphics
        Dim sbrush As New SolidBrush(If(_mouse, _hovercolor, _normalcolor))

        formGraphics.FillRectangle(sbrush, ClientRectangle)

        Using f As Font = Font
            rectFA = New Rectangle(0, 5, TextWidth, TextHeight)
            Dim rectFAs As New Rectangle(1, 6, TextWidth, TextHeight)

            Dim flags As TextFormatFlags = TextFormatFlags.Left Or TextFormatFlags.WordBreak
            formGraphics.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias

            TextRenderer.DrawText(formGraphics, GetIcon, f, rectFAs, Color.Black, flags)
            TextRenderer.DrawText(formGraphics, GetIcon, f, rectFA, ForeColor, flags)
        End Using
    End Sub

    Private Function TextWidth() As Integer
        Return TextRenderer.MeasureText(GetIcon, Font).Width
    End Function

    Private Function TextHeight() As Integer
        Return TextRenderer.MeasureText(GetIcon, Font).Height
    End Function

    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        MyBase.OnMouseEnter(e)

        _mouse = True
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)

        _mouse = False
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
        MyBase.OnMouseMove(e)

        _mouse = True
        Invalidate()
    End Sub

    Public Sub New()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        SetStyle(ControlStyles.UserPaint, True)
        BackColor = Color.Transparent
        DoubleBuffered = True
        ForeColor = Color.White
        Cursor = Cursors.Hand
    End Sub

    Public Enum SocialIcons
        delicious
        digg
        discord
        facebook
        github
        google
        patreon
        psn
        qq
        reddit
        renren
        skype
        snapchat
        soundcloud
        steam
        teamspeak
        telegram
        tencentweibo
        tumblr
        twitch
        twitter
        viber
        vimeo
        vine
        vk
        weixin
        weibo
        instagram
        whatsapp
        wechat
        windows
        xbox
        yahoo
        youtube
        zhihu
        custom
    End Enum

End Class
