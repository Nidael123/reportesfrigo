Public Class reportehojamovi
    Private Sub reportehojamovi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ReportesDataSet.HOJAMDATA' Puede moverla o quitarla según sea necesario.
        Me.HOJAMDATATableAdapter.Fill(Me.ReportesDataSet.HOJAMDATA)
        'TODO: esta línea de código carga datos en la tabla 'reportesDataSet.HOJAMDATA' Puede moverla o quitarla según sea necesario.
        Me.HOJAMDATATableAdapter.Fill(Me.reportesDataSet.HOJAMDATA)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class