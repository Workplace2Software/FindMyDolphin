Public Class MapErrorPage
    Private url As String

    Public Sub New(ByVal url As String, ByVal statuscode As Int32)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.url = url
        ErrLabel.Text = "0x" & Hex(statuscode)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Process.Start(url)
    End Sub
End Class
