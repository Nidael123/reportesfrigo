<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class reportehojamovi
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.HOJAMDATABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportesDataSet = New reportesfrigo.reportesDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.HOJAMDATATableAdapter = New reportesfrigo.reportesDataSetTableAdapters.HOJAMDATATableAdapter()
        CType(Me.HOJAMDATABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HOJAMDATABindingSource
        '
        Me.HOJAMDATABindingSource.DataMember = "HOJAMDATA"
        Me.HOJAMDATABindingSource.DataSource = Me.ReportesDataSet
        '
        'ReportesDataSet
        '
        Me.ReportesDataSet.DataSetName = "reportesDataSet"
        Me.ReportesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.AutoScroll = True
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.HOJAMDATABindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "reportesfrigo.infore.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1818, 1049)
        Me.ReportViewer1.TabIndex = 0
        '
        'HOJAMDATATableAdapter
        '
        Me.HOJAMDATATableAdapter.ClearBeforeFill = True
        '
        'reportehojamovi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1830, 1061)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "reportehojamovi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REPORTE HOJA DE MOVIMIENTO"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.HOJAMDATABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReportesDataSet As reportesDataSet
    Friend WithEvents HOJAMDATABindingSource As BindingSource
    Friend WithEvents HOJAMDATATableAdapter As reportesDataSetTableAdapters.HOJAMDATATableAdapter
End Class
