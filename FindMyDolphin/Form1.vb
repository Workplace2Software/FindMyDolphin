Public Class Form1
    Dim f As Form2
    Dim a As AboutBox1
    Dim r As New System.Random()

    Private Sub Wait(ByVal centis As Integer)
        For i As Integer = 0 To centis
            System.Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
    End Sub

    Private Sub WaitForProgress(
        ByVal statusmsg As String,
        ByVal waittime As Integer
    )
        Dim percent As Integer = 0
        Dim stepp As Integer = 0
        Dim bye As Boolean = False


        Do
            stepp = r.Next(1, 7)
            ProgressBar.Step = stepp

            percent += stepp
            If percent >= 100 Then percent = 100 : bye = True
            StatusLabel.Text = statusmsg + Str(percent) + "%"

            ProgressBar.PerformStep()

            Wait(waittime)

            If bye Then Exit Do
        ProgressBar.Visible = True
        Loop

        ProgressBar.Visible = False
        ProgressBar.Value = 0
        ProgressBar.Step = 1
    End Sub

    Private Sub Form1_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        My.Computer.Audio.Play(My.Resources.tts, AudioPlayMode.WaitToComplete)
        My.Computer.Audio.Play(My.Resources.yourcall, AudioPlayMode.BackgroundLoop)
    End Sub

    Dim cantfindctr As Integer = 0

    Private Sub LocateButton_ReplacementHandler_Click(
        ByVal sender As Object, ByVal e As EventArgs
    )
        Select Case cantfindctr
            Case 1
                MessageBox.Show(
                    "Please try again later.",
                    "Try again later",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )
            Case 2
                MessageBox.Show(
                    "Please try again later. As in, not now. But later.",
                    "Try again *later*",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )
            Case 3
                MessageBox.Show(
                    "You need to wait before trying again; that is, you need to try again later.",
                    "Try again LATER!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )
            Case 4
                LocateButton.Enabled = False
                MessageBox.Show(
                    "There's no help for people like you."
                )
            Case Else
        End Select
        cantfindctr += 1
    End Sub

    Private Sub LaterTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaterTimer.Tick
        If cantfindctr > 0 Then
            LaterTimer.Stop()
            cantfindctr = 0

            MessageBox.Show(
                "It Is Later Now :D",
                ":D",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            AddHandler LocateButton.Click, AddressOf LocateButton_Click
            RemoveHandler LocateButton.Click, AddressOf LocateButton_ReplacementHandler_Click

            LocateButton.Enabled = True
        End If
    End Sub

    Private Sub LocateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocateButton.Click
        Dim percent As Integer = 0
        Dim stepp As Integer = 0
        Dim cantscan As Integer = r.Next(1, 25)

        LocateButton.Enabled = False

        WaitForProgress("Scanning for Dolphin's Existence", 10)
        If cantscan = 22 Then
            cantfindctr = 1

            StatusLabel.Text = "Dolphin could not be located."
            LocateButton.Enabled = True

            LaterTimer.Start()

            AddHandler LocateButton.Click, AddressOf LocateButton_ReplacementHandler_Click
            RemoveHandler LocateButton.Click, AddressOf LocateButton_Click

            MessageBox.Show(
                "Dolphin does not exist! Try again later",
                "Could not find dolphin",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

            Exit Sub
        End If

        WaitForProgress("Finding General Location of Dolphin", 10)
        WaitForProgress("Triangulating Dolphin's Exact Position", 20)

        StatusLabel.Text = "FOUND DOLPHIN!!"

        If f Is Nothing Then f = New Form2
        Try : f.Show()
        Catch ex As ObjectDisposedException
            f = New Form2 : f.Show()
        End Try

        LocateButton.Enabled = True
    End Sub

    Private Sub MuteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MuteButton.Click
        Dim retval As Integer

        retval = MessageBox.Show(
            "Are you sure you want to mute the audio?",
            "Are you sure?",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        )
        If retval <> DialogResult.Yes Then Exit Sub

        retval = MessageBox.Show(
            "The music is really good though",
            "Are you really sure?",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        )
        If retval <> DialogResult.Yes Then Exit Sub

        retval = MessageBox.Show(
            "So you're sure that you're really not sure?",
            "You're sure you're not sure, right?",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        )
        If retval <> DialogResult.No Then
            MessageBox.Show(
                "HA! Got you -- that was a double negative!",
                "Gotcha!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )
            Exit Sub
        End If

        retval = MessageBox.Show(
            "Well, at least I almost got you with that double negative, right?",
            "That was a good one, right?",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        )

        If retval <> DialogResult.Yes Then
            MessageBox.Show(
                "Wow, that really hurts... I try my best to deliver a funny joke " &
                "and you dismiss it that easily?" & vbNewLine &
                "Well, guess what? I'm not going to let you mute anymore.",
                "Fr*ck you!!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
            MuteButton.Enabled = False
            Exit Sub
        End If

        retval = MessageBox.Show(
            "So, anyway, you want to mute the audio, right?",
            "Confirmation",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        )

        If retval = DialogResult.Yes Then
            MessageBox.Show(
                "OK, I'll mute it for you! :D",
                "Muting audio",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )
            My.Computer.Audio.Stop()
        Else
            MessageBox.Show(
                "Well, if you didn't want to mute it in the first place, " &
                "why did you go through all this dialog?",
                "You're Weird",
                MessageBoxButtons.OK,
                MessageBoxIcon.Question
            )
        End If
    End Sub

    Private Sub WebpageButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WebpageButton.Click
        Process.Start("iexplore", "http://www.theworkplace.tk")
    End Sub

    Private Sub AboutButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutButton.Click
        If a Is Nothing Then a = New AboutBox1
        Try : a.Show()
        Catch ex As ObjectDisposedException
            a = New AboutBox1 : a.Show()
        End Try
    End Sub
End Class
