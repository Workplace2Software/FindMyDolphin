Imports System.Runtime.InteropServices

Public Class Form2
    Private blinkToggle As Boolean = True
    Private r As New System.Random
    Private placeurl As String

    Private Function GetMap() As String
        Dim lat As Double = Math.Round((360 * r.NextDouble()) - 180, 4)
        Dim lon As Double = Math.Round((180 * r.NextDouble()) - 90, 4)
        Return "https://www.google.com/maps/place/" _
                               & Str(lat) & "+" & Str(lon) _
                               & "/@" & Str(lat) & "," & Str(lon) & ",12z"
    End Function

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        placeurl = GetMap()

        Dim instance As SHDocVw.WebBrowser = CType(
            coolBrowser.ActiveXInstance, SHDocVw.WebBrowser
        )
        AddHandler instance.NavigateError, AddressOf instance_NavigateError

        coolBrowser.Navigate(placeurl)
    End Sub

    Private Sub InvokeJimmy(ByVal errmsg As String)
        SplitContainer1.Panel2.Controls.Remove(coolBrowser)
        coolBrowser.Dispose()

        DolphinImage.Visible = True

        EnableBlinkText()

        WindowState = FormWindowState.Maximized
        MinimumSize = Size

        Dim errpage As New MapErrorPage(errmsg)
        errpage.Visible = True
        errpage.Dock = DockStyle.Fill
        SplitContainer1.Panel2.Controls.Add(errpage)
    End Sub

    Private Sub instance_NavigateError( _
        ByVal pDisp As Object, ByRef url As Object, ByRef frame As Object, _
        ByRef statusCode As Object, ByRef cancel As Boolean _
    )
        InvokeJimmy("IE error: 0x" & Hex(CInt(statusCode)))
    End Sub

    Private WithEvents scriptWindow As HtmlWindow

    Private Sub WebBrowser_Navigated(
        ByVal sender As System.Object,
        ByVal e As System.Windows.Forms.WebBrowserNavigatedEventArgs
    ) Handles coolBrowser.Navigated
        If (coolBrowser.Document Is Nothing) Then
            InvokeJimmy("Internal error: document was nothing") : Exit Sub
        End If
        scriptWindow = coolBrowser.Document.Window
    End Sub

    Private Sub scriptWindow_Error(
        ByVal sender As Object, ByVal e As HtmlElementErrorEventArgs
    ) Handles scriptWindow.Error
        e.Handled = True
        InvokeJimmy("Script error: " & e.Description)
    End Sub


    Private Sub coolBrowser_DocumentCompleted(
        ByVal sender As System.Object,
        ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs
    ) Handles coolBrowser.DocumentCompleted
        My.Computer.Audio.Play(My.Resources.ooo, AudioPlayMode.Background)

        DolphinImage.Visible = True
        coolBrowser.Visible = True

        EnableBlinkText()

        WindowState = FormWindowState.Maximized
        MinimumSize = Size
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim retval As Integer
        retval = MessageBox.Show( _
            "WARNING: This option should only be used if Revolutionary Browsing Technology has Catastrophically Failed." & _
            vbCrLf & "Locating your dolphin in an External Bowser could result in a DEGRADED EXPERIENCE!" & _
            vbCrLf & vbCrLf & "Cancel this operation?",
            "Are you sure?",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        )
        If retval = DialogResult.No Then Process.Start(placeurl)
    End Sub
End Class