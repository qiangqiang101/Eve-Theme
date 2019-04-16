Public Class frmLoginTest

    Protected Overrides Sub OnResizeBegin(e As EventArgs)
        MyBase.OnResizeBegin(e)

        SuspendLayout()
    End Sub

    Protected Overrides Sub OnResizeEnd(e As EventArgs)
        MyBase.OnResizeEnd(e)

        ResumeLayout(True)
    End Sub

    Private Sub EveSocialButton1_Click(sender As Object, e As EventArgs) Handles EveSocialButton1.Click
        Process.Start("https://login.eveonline.com/account/external?provider=Fb&returnUrl=%2F")
    End Sub

    Private Sub EveSocialButton2_Click(sender As Object, e As EventArgs) Handles EveSocialButton2.Click
        Process.Start("https://login.eveonline.com/account/external?provider=Steam&returnUrl=%2F")
    End Sub
End Class