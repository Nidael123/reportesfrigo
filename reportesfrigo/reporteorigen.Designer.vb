<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reporteorigen
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.reporteorigenm = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.BindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportesDataSet11 = New transferecia.reportesDataSet1()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportesDataSet1 = New transferecia.reportesDataSet()
        Me.ORIGENMPTableAdapter1 = New transferecia.reportesDataSetTableAdapters.ORIGENMPTableAdapter()
        Me.BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ORIGENMPTableAdapter2 = New transferecia.reportesDataSet1TableAdapters.ORIGENMPTableAdapter()
        Me.BindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.HOJAMDATABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HOJAMDATATableAdapter = New transferecia.reportesDataSet1TableAdapters.HOJAMDATATableAdapter()
        Me.ReportesDataSet2 = New transferecia.reportesDataSet2()
        Me.BindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ORIGENMPTableAdapter3 = New transferecia.reportesDataSet2TableAdapters.ORIGENMPTableAdapter()
        Me.ReportesDataSet2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.BindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportesDataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportesDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HOJAMDATABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportesDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportesDataSet2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'reporteorigenm
        '
        Me.reporteorigenm.AutoScroll = True
        Me.reporteorigenm.AutoSize = True
        ReportDataSource1.Name = "DATOSORIGEN"
        ReportDataSource1.Value = Me.ReportesDataSet2BindingSource
        Me.reporteorigenm.LocalReport.DataSources.Add(ReportDataSource1)
        Me.reporteorigenm.LocalReport.ReportEmbeddedResource = "reportesfrigo.inforigen.rdlc"
        Me.reporteorigenm.Location = New System.Drawing.Point(3, 3)
        Me.reporteorigenm.Name = "reporteorigenm"
        Me.reporteorigenm.ServerReport.BearerToken = Nothing
        Me.reporteorigenm.Size = New System.Drawing.Size(1846, 1001)
        Me.reporteorigenm.TabIndex = 0
        '
        'BindingSource4
        '
        Me.BindingSource4.DataMember = "ORIGENMP"
        Me.BindingSource4.DataSource = Me.ReportesDataSet11
        '
        'ReportesDataSet11
        '
        Me.ReportesDataSet11.DataSetName = "reportesDataSet1"
        Me.ReportesDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "ORIGENMP"
        Me.BindingSource1.DataSource = Me.ReportesDataSet1
        '
        'ReportesDataSet1
        '
        Me.ReportesDataSet1.DataSetName = "reportesDataSet"
        Me.ReportesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ORIGENMPTableAdapter1
        '
        Me.ORIGENMPTableAdapter1.ClearBeforeFill = True
        '
        'BindingSource2
        '
        Me.BindingSource2.DataMember = "ORIGENMP"
        Me.BindingSource2.DataSource = Me.ReportesDataSet11
        '
        'ORIGENMPTableAdapter2
        '
        Me.ORIGENMPTableAdapter2.ClearBeforeFill = True
        '
        'BindingSource3
        '
        Me.BindingSource3.DataMember = "ORIGENMP"
        Me.BindingSource3.DataSource = Me.ReportesDataSet11
        '
        'HOJAMDATABindingSource
        '
        Me.HOJAMDATABindingSource.DataMember = "HOJAMDATA"
        Me.HOJAMDATABindingSource.DataSource = Me.ReportesDataSet11
        '
        'HOJAMDATATableAdapter
        '
        Me.HOJAMDATATableAdapter.ClearBeforeFill = True
        '
        'ReportesDataSet2
        '
        Me.ReportesDataSet2.DataSetName = "reportesDataSet2"
        Me.ReportesDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingSource5
        '
        Me.BindingSource5.DataMember = "ORIGENMP"
        Me.BindingSource5.DataSource = Me.ReportesDataSet2
        '
        'ORIGENMPTableAdapter3
        '
        Me.ORIGENMPTableAdapter3.ClearBeforeFill = True
        '
        'ReportesDataSet2BindingSource
        '
        Me.ReportesDataSet2BindingSource.DataSource = Me.ReportesDataSet2
        Me.ReportesDataSet2BindingSource.Position = 0
        '
        'reporteorigen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1892, 1061)
        Me.Controls.Add(Me.reporteorigenm)
        Me.Name = "reporteorigen"
        Me.Text = "REPORTE ORIGEN DE MATERIA PRIMA"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.BindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportesDataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportesDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HOJAMDATABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportesDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportesDataSet2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents reporteorigenm As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ORIGENMPBindingSource As BindingSource
    Friend WithEvents reportesDataSet As reportesDataSet
    Friend WithEvents ORIGENMPTableAdapter As reportesDataSetTableAdapters.ORIGENMPTableAdapter
    Friend WithEvents ReportesDataSet1 As reportesDataSet
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents ORIGENMPTableAdapter1 As reportesDataSetTableAdapters.ORIGENMPTableAdapter
    Friend WithEvents ReportesDataSet11 As reportesDataSet1
    Friend WithEvents BindingSource2 As BindingSource
    Friend WithEvents ORIGENMPTableAdapter2 As reportesDataSet1TableAdapters.ORIGENMPTableAdapter
    Friend WithEvents BindingSource3 As BindingSource
    Friend WithEvents HOJAMDATABindingSource As BindingSource
    Friend WithEvents HOJAMDATATableAdapter As reportesDataSet1TableAdapters.HOJAMDATATableAdapter
    Friend WithEvents BindingSource4 As BindingSource
    Friend WithEvents ReportesDataSet2 As reportesDataSet2
    Friend WithEvents BindingSource5 As BindingSource
    Friend WithEvents ORIGENMPTableAdapter3 As reportesDataSet2TableAdapters.ORIGENMPTableAdapter
    Friend WithEvents ReportesDataSet2BindingSource As BindingSource
End Class
