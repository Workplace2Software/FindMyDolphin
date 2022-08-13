Public Class Form2
    Dim blinkToggle As Boolean = True
    Dim r As New System.Random

    Private Sub GetMap()
        Dim lat As Double = Math.Round((360 * r.NextDouble()) - 180, 4)
        Dim lon As Double = Math.Round((180 * r.NextDouble()) - 90, 4)
        Dim placeurl As String = "https://www.google.com/maps/place/" _
                               + Str(lat) + "+" + Str(lon) _
                               + "/@" + Str(lat) + "," + Str(lon) + ",12z"
        WebBrowser.Url = New Uri(placeurl)
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler WebBrowser.Navigated, AddressOf WebBrowser_Navigated
        GetMap()
    End Sub

    Private Sub BlinkTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BlinkTimer.Tick
        blinkToggle = Not blinkToggle

        If blinkToggle Then
            BlinkText.ForeColor = Color.Red
        Else
            BlinkText.ForeColor = BlinkText.BackColor
        End If
    End Sub

    Private Sub WebBrowser_Navigated(
        ByVal sender As System.Object,
        ByVal e As System.Windows.Forms.WebBrowserNavigatedEventArgs
    ) Handles WebBrowser.Navigated

        My.Computer.Audio.Play(My.Resources.ooo, AudioPlayMode.Background)

        DolphinImage.Visible = True
        WebBrowser.Visible = True

        BlinkText.Font = New Font("Segoe Script", 32)
        BlinkText.ForeColor = Color.Red
        BlinkText.Text = "LOCATED DOLPHIN"
        BlinkTimer.Enabled = True

        WindowState = FormWindowState.Maximized
        MinimumSize = Size

        RemoveHandler WebBrowser.Navigated, AddressOf WebBrowser_Navigated
    End Sub
End Class