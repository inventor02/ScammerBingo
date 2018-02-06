Public Class AboutForm
    Private Sub AboutForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VersionLabel.Text = My.Application.Info.Version.ToString(3)
    End Sub
End Class