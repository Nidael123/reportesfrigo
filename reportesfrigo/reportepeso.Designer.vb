<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class reportepeso
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DataSet1 = New reportesfrigo.DataSet1()
        Me.TEMP_PESOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TEMP_PESOSTableAdapter = New reportesfrigo.DataSet1TableAdapters.TEMP_PESOSTableAdapter()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEMP_PESOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource2.Name = "myDataSet1"
        ReportDataSource2.Value = Me.TEMP_PESOSBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "reportesfrigo.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(-8, 3)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1088, 933)
        Me.ReportViewer1.TabIndex = 0
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TEMP_PESOSBindingSource
        '
        Me.TEMP_PESOSBindingSource.DataMember = "TEMP_PESOS"
        Me.TEMP_PESOSBindingSource.DataSource = Me.DataSet1
        '
        'TEMP_PESOSTableAdapter
        '
        Me.TEMP_PESOSTableAdapter.ClearBeforeFill = True
        '
        'reportepeso
        '
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1092, 948)
        Me.Controls.Add(Me.ReportViewer1)
        Me.MaximizeBox = False
        Me.Name = "reportepeso"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEMP_PESOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TEMP_PESOSBindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents TEMP_PESOSTableAdapter As DataSet1TableAdapters.TEMP_PESOSTableAdapter
End Class
