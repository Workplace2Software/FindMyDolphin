Imports System.Runtime.InteropServices

Public Class Form2
    Dim blinkToggle As Boolean = True
    Dim r As New System.Random
    Dim placeurl As String

    Private Function GetMap() As String
        Dim lat As Double = Math.Round((360 * r.NextDouble()) - 180, 4)
        Dim lon As Double = Math.Round((180 * r.NextDouble()) - 90, 4)
        Return "https://www.google.com/maps/place/" _
                               & Str(lat) & "+" & Str(lon) _
                               & "/@" & Str(lat) & "," & Str(lon) '& ",12z"
    End Function

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        placeurl = GetMap()

        Dim instance As SHDocVw.WebBrowser = coolBrowser.ActiveXInstance
        AddHandler instance.NavigateError, AddressOf instance_NavigateError

        coolBrowser.Navigate(placeurl)
    End Sub

    Private Sub instance_NavigateError( _
        ByVal pDisp As Object, ByRef url As Object, ByRef frame As Object, _
        ByRef statusCode As Object, ByRef cancel As Boolean _
    )
        SplitContainer1.Panel2.Controls.Remove(coolBrowser)
        coolBrowser.Dispose()

        'My.Computer.Audio.Play(My.Resources.ooo, AudioPlayMode.Background)
        DolphinImage.Visible = True

        EnableBlinkText()

        WindowState = FormWindowState.Maximized
        MinimumSize = Size

        Dim errpage As New MapErrorPage(placeurl, CInt(statusCode))
        errpage.Dock = DockStyle.Fill
        SplitContainer1.Panel2.Controls.Add(errpage)
    End Sub

    Private Sub WebBrowser_Navigated(
        ByVal sender As System.Object,
        ByVal e As System.Windows.Forms.WebBrowserNavigatedEventArgs
    ) Handles coolBrowser.Navigated

        My.Computer.Audio.Play(My.Resources.ooo, AudioPlayMode.Background)

        DolphinImage.Visible = True
        coolBrowser.Visible = True

        EnableBlinkText()

        WindowState = FormWindowState.Maximized
        MinimumSize = Size

        RemoveHandler coolBrowser.Navigated, AddressOf WebBrowser_Navigated
    End Sub

    Private Sub BlinkTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BlinkTimer.Tick
        blinkToggle = Not blinkToggle

        If blinkToggle Then
            BlinkText.ForeColor = Color.Red
        Else
            BlinkText.ForeColor = BlinkText.BackColor
        End If
    End Sub

    Private Sub EnableBlinkText()
        BlinkText.Font = New Font("Segoe Script", 32)
        BlinkText.ForeColor = Color.Red
        BlinkText.Text = "LOCATED DOLPHIN"
        BlinkTimer.Enabled = True
    End Sub
End Class