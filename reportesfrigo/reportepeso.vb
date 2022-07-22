Public Class reportepeso
    Private Sub reportepeso_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub reportepeso_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.TEMP_PESOS' Puede moverla o quitarla según sea necesario.
        Me.TEMP_PESOSTableAdapter.Fill(Me.DataSet1.TEMP_PESOS)

        Me.ReportViewer1.RefreshReport()

    End Sub
End Class