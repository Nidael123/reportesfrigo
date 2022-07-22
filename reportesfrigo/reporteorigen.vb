Public Class reporteorigen



    Private Sub reporteorigenm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ReportesDataSet2.ORIGENMP' Puede moverla o quitarla según sea necesario.
        Me.ORIGENMPTableAdapter3.Fill(Me.ReportesDataSet2.ORIGENMP)
        'TODO: esta línea de código carga datos en la tabla 'ReportesDataSet11.HOJAMDATA' Puede moverla o quitarla según sea necesario.
        Me.HOJAMDATATableAdapter.Fill(Me.ReportesDataSet11.HOJAMDATA)
        'TODO: esta línea de código carga datos en la tabla 'ReportesDataSet11.ORIGENMP' Puede moverla o quitarla según sea necesario.
        Me.ORIGENMPTableAdapter2.Fill(Me.ReportesDataSet11.ORIGENMP)
        'TODO: esta línea de código carga datos en la tabla 'ReportesDataSet1.ORIGENMP' Puede moverla o quitarla según sea necesario.
        Me.ORIGENMPTableAdapter1.Fill(Me.ReportesDataSet1.ORIGENMP)

        Me.reporteorigenm.RefreshReport()

    End Sub

    Private Sub reporteorigenm_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class