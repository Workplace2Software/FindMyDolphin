Public Class MapErrorPage
    Public Sub New(ByVal errmsg As String)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ErrLabel.Text = errmsg
    End Sub
End Class
