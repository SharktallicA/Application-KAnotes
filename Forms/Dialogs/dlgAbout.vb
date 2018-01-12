Public Class dlgAbout
    Private Sub dlgAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load info about program into labels
        lblName.Text = My.Application.Info.AssemblyName
        lblVersion.Text = My.Application.Info.Version().ToString
        lblCopyright.Text = My.Application.Info.Copyright
    End Sub

    Private Sub btnOkay_Click(sender As Object, e As EventArgs) Handles btnOkay.Click
        'close program
        Close()
    End Sub
End Class