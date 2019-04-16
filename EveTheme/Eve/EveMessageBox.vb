Imports System.Drawing
Imports System.Windows.Forms

Public Class EveMessageBox

    Public Shared Function ShowYesNo(text As String, caption As String) As DialogResult
        Try
            Dim F As Form = CreateDialog(text, caption)

            Dim B1 As New EveButton
            Dim B2 As New EveButton

            Dim S As New Size(90, 25)
            B1.Size = S
            B2.Size = S

            B2.Location = New Point(108, 119)
            B1.Location = New Point(12, 119)

            B1.Text = "YES"
            B2.Text = "NO"

            B1.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
            B2.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)

            B1.Anchor = AnchorStyles.Bottom
            B2.Anchor = AnchorStyles.Bottom

            B2.BackColor = Color.GhostWhite
            B2.ForeColor = Color.FromArgb(41, 128, 185)
            B2.HoveredColor = Color.FromArgb(221, 221, 222)
            B2.NormalColor = Color.GhostWhite

            AddHandler B1.Click, Sub() F.DialogResult = DialogResult.Yes
            AddHandler B2.Click, Sub() F.DialogResult = DialogResult.No

            F.Controls.Add(B1)
            F.Controls.Add(B2)

            Return F.ShowDialog()
        Catch ex As Exception
        End Try
    End Function

    Public Shared Function ShowYesNo(text As String, icon As MessageBoxIcon, caption As String) As DialogResult
        Try
            Dim F As Form

            Dim I As Bitmap = Nothing
            Select Case icon
                Case MessageBoxIcon.Asterisk
                    I = SystemIcons.Asterisk.ToBitmap()
                Case MessageBoxIcon.Error, MessageBoxIcon.Stop
                    I = SystemIcons.Error.ToBitmap()
                Case MessageBoxIcon.Exclamation
                    I = SystemIcons.Exclamation.ToBitmap()
                Case MessageBoxIcon.Hand
                    I = SystemIcons.Hand.ToBitmap()
                Case MessageBoxIcon.Information
                    I = SystemIcons.Information.ToBitmap()
                Case MessageBoxIcon.Question
                    I = SystemIcons.Question.ToBitmap()
                Case MessageBoxIcon.Warning
                    I = SystemIcons.Warning.ToBitmap()
                Case MessageBoxIcon.None
                    I = Nothing
            End Select
            Dim P As New PictureBox
            P.Size = New Size(30, 30)
            P.Location = New Point(12, 38)
            P.Image = I
            P.SizeMode = PictureBoxSizeMode.StretchImage
            F = CreateDialog(text, caption, P.Size.Width + P.Location.X + 3, 38)
            F.Controls.Add(P)

            Dim B1 As New EveButton
            Dim B2 As New EveButton

            Dim S As New Size(90, 25)
            B1.Size = S
            B2.Size = S

            B2.Location = New Point(108, 119)
            B1.Location = New Point(12, 119)

            B1.Text = "YES"
            B2.Text = "NO"

            B1.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
            B2.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)

            B1.Anchor = AnchorStyles.Bottom
            B2.Anchor = AnchorStyles.Bottom

            B2.BackColor = Color.GhostWhite
            B2.ForeColor = Color.FromArgb(41, 128, 185)
            B2.HoveredColor = Color.FromArgb(221, 221, 222)
            B2.NormalColor = Color.GhostWhite

            AddHandler B1.Click, Sub() F.DialogResult = DialogResult.Yes
            AddHandler B2.Click, Sub() F.DialogResult = DialogResult.No

            F.Controls.Add(B1)
            F.Controls.Add(B2)

            Return F.ShowDialog()
        Catch ex As Exception
        End Try
    End Function

    Public Shared Function ShowOk(text As String, caption As String) As DialogResult
        Try
            Dim F As Form = CreateDialog(text, caption)

            Dim B1 As New EveButton

            Dim S As New Size(90, 25)
            B1.Size = S

            B1.Location = New Point(12, 119)

            B1.Text = "OK"

            B1.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)

            B1.Anchor = AnchorStyles.Bottom

            AddHandler B1.Click, Sub() F.DialogResult = DialogResult.OK

            F.Controls.Add(B1)

            Return F.ShowDialog()
        Catch ex As Exception
        End Try
    End Function

    Public Shared Function ShowOk(text As String, icon As MessageBoxIcon, caption As String) As DialogResult
        Try
            Dim F As Form

            Dim I As Bitmap = Nothing
            Select Case icon
                Case MessageBoxIcon.Asterisk
                    I = SystemIcons.Asterisk.ToBitmap()
                Case MessageBoxIcon.Error, MessageBoxIcon.Stop
                    I = SystemIcons.Error.ToBitmap()
                Case MessageBoxIcon.Exclamation
                    I = SystemIcons.Exclamation.ToBitmap()
                Case MessageBoxIcon.Hand
                    I = SystemIcons.Hand.ToBitmap()
                Case MessageBoxIcon.Information
                    I = SystemIcons.Information.ToBitmap()
                Case MessageBoxIcon.Question
                    I = SystemIcons.Question.ToBitmap()
                Case MessageBoxIcon.Warning
                    I = SystemIcons.Warning.ToBitmap()
                Case MessageBoxIcon.None
                    I = Nothing
            End Select
            Dim P As New PictureBox
            P.Size = New Size(30, 30)
            P.Location = New Point(12, 38)
            P.Image = I
            P.SizeMode = PictureBoxSizeMode.StretchImage
            F = CreateDialog(text, caption, P.Size.Width + P.Location.X + 3, 38)
            F.Controls.Add(P)

            Dim B1 As New EveButton

            Dim S As New Size(90, 25)
            B1.Size = S

            B1.Location = New Point(12, 119)

            B1.Text = "OK"

            B1.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)

            B1.Anchor = AnchorStyles.Bottom

            AddHandler B1.Click, Sub() F.DialogResult = DialogResult.OK

            F.Controls.Add(B1)

            Return F.ShowDialog()
        Catch ex As Exception
        End Try
    End Function

    Private Shared Function CreateDialog(text As String, caption As String, Optional p1 As Integer = 12, Optional p2 As Integer = 38) As Form
        Dim F As New Form

        Try
            Dim MControlButton1 As New EveControlButtons()
            Dim Label1 As New Label()

            F.Controls.Add(MControlButton1)
            F.Controls.Add(Label1)
            F.FormBorderStyle = FormBorderStyle.None
            F.Size = New Size(386, 156)
            F.BackColor = Color.FromArgb(48, 50, 55)
            F.ForeColor = Color.White

            MControlButton1.ControlButton1 = EveControlButtons.ControlButtonType.Close
            MControlButton1.ControlButton2 = EveControlButtons.ControlButtonType.Nothing
            MControlButton1.ControlButton3 = EveControlButtons.ControlButtonType.Nothing
            MControlButton1.ControlButton4 = EveControlButtons.ControlButtonType.Nothing
            MControlButton1.ControlButton5 = EveControlButtons.ControlButtonType.Nothing
            MControlButton1.Dock = DockStyle.Top
            MControlButton1.Showtitle = True

            Label1.Text = text
            Label1.ForeColor = Color.White
            Label1.Location = New Point(p1, p2)
            Label1.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular)
            Dim C As Integer = LineCount(Label1) * 8
            Label1.Size = New Size(312, C)
            Label1.TextAlign = ContentAlignment.MiddleLeft

            'Title.Text = caption
            'Title.ForeColor = Color.White
            'Title.Location = New Point(2, 2)
            'Title.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular)
            'Title.Size = TextRenderer.MeasureText(caption, Title.Font)
            'Title.TextAlign = ContentAlignment.MiddleLeft

            F.StartPosition = FormStartPosition.CenterParent
            F.ClientSize = New Size(386, Label1.Size.Height + 125)
            F.Text = caption
            F.ShowIcon = False
            F.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular)
            F.TopMost = True
        Catch ex As Exception
        End Try

        Return F
    End Function

    Private Shared Function LineCount(Label As Label) As Integer
        Dim g As Graphics = Label.CreateGraphics

        Dim LineHeight As Single = g.MeasureString("X", Label.Font).Height
        Dim TotalHeight As Single = g.MeasureString(Label.Text, Label.Font, Label.Width).Height

        Return CInt(Math.Round(TotalHeight / LineHeight))
    End Function

End Class
