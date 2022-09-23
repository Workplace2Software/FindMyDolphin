Public Class MapErrorPage
    Private url As String

    Public Sub New(ByVal url As String, ByVal errmsg As String)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.url = url
        ErrLabel.Text = errmsg
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Process.Start(url)
    End Sub
End Class
