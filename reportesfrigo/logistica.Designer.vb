<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class logistica
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(logistica))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ordenes = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.despacho = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.unidad = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.master = New System.Windows.Forms.TextBox()
        Me.caja = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cantidad = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DEPOSITOORIGEN = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.UBICACIONORIGEN = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DEPOSITODESTINO = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.UBICACIONDESTINO = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btn_cajeta = New System.Windows.Forms.Button()
        Me.btn_master = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.exportar = New System.Windows.Forms.Button()
        Me.comboproductos = New System.Windows.Forms.ComboBox()
        Me.combotalla = New System.Windows.Forms.ComboBox()
        Me.comcodpro = New System.Windows.Forms.ComboBox()
        Me.tallamarcada = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.cantcajeta = New System.Windows.Forms.TextBox()
        Me.cantmaster = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(962, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ESCOJA UNA ORDEN"
        '
        'ordenes
        '
        Me.ordenes.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ordenes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ordenes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ordenes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ordenes.FormattingEnabled = True
        Me.ordenes.Location = New System.Drawing.Point(923, 67)
        Me.ordenes.Name = "ordenes"
        Me.ordenes.Size = New System.Drawing.Size(215, 21)
        Me.ordenes.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(733, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "DESCRIPCION"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(411, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "PRODUCTO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(674, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "DESPACHO"
        '
        'despacho
        '
        Me.despacho.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.despacho.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.despacho.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.despacho.Location = New System.Drawing.Point(642, 67)
        Me.despacho.Name = "despacho"
        Me.despacho.ReadOnly = True
        Me.despacho.Size = New System.Drawing.Size(141, 20)
        Me.despacho.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(411, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "TALLA"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(823, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "UNIDAD"
        '
        'unidad
        '
        Me.unidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.unidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.unidad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.unidad.Location = New System.Drawing.Point(804, 68)
        Me.unidad.Name = "unidad"
        Me.unidad.ReadOnly = True
        Me.unidad.Size = New System.Drawing.Size(99, 20)
        Me.unidad.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(366, 99)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "CANT. MASTER"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(470, 99)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "CANT. CAJETA/FUNDA"
        '
        'master
        '
        Me.master.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.master.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.master.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.master.Location = New System.Drawing.Point(369, 115)
        Me.master.Name = "master"
        Me.master.ReadOnly = True
        Me.master.Size = New System.Drawing.Size(84, 20)
        Me.master.TabIndex = 16
        '
        'caja
        '
        Me.caja.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.caja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.caja.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.caja.Location = New System.Drawing.Point(486, 116)
        Me.caja.Name = "caja"
        Me.caja.ReadOnly = True
        Me.caja.Size = New System.Drawing.Size(84, 20)
        Me.caja.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(150, 50)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "LOTE"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(102, 66)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(136, 21)
        Me.ComboBox1.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(264, 50)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "LOTE MARCADO"
        '
        'cantidad
        '
        Me.cantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cantidad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cantidad.Location = New System.Drawing.Point(101, 116)
        Me.cantidad.MaxLength = 7
        Me.cantidad.Name = "cantidad"
        Me.cantidad.Size = New System.Drawing.Size(84, 20)
        Me.cantidad.TabIndex = 24
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(99, 101)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(86, 13)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "CANTIDAD M/C"
        '
        'DEPOSITOORIGEN
        '
        Me.DEPOSITOORIGEN.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DEPOSITOORIGEN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DEPOSITOORIGEN.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DEPOSITOORIGEN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DEPOSITOORIGEN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DEPOSITOORIGEN.FormattingEnabled = True
        Me.DEPOSITOORIGEN.Location = New System.Drawing.Point(102, 25)
        Me.DEPOSITOORIGEN.Name = "DEPOSITOORIGEN"
        Me.DEPOSITOORIGEN.Size = New System.Drawing.Size(136, 21)
        Me.DEPOSITOORIGEN.TabIndex = 27
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(116, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(107, 13)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "DEPOSITO ORIGEN"
        '
        'UBICACIONORIGEN
        '
        Me.UBICACIONORIGEN.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UBICACIONORIGEN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.UBICACIONORIGEN.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.UBICACIONORIGEN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UBICACIONORIGEN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.UBICACIONORIGEN.FormattingEnabled = True
        Me.UBICACIONORIGEN.Location = New System.Drawing.Point(251, 26)
        Me.UBICACIONORIGEN.Name = "UBICACIONORIGEN"
        Me.UBICACIONORIGEN.Size = New System.Drawing.Size(121, 21)
        Me.UBICACIONORIGEN.TabIndex = 29
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(262, 9)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(110, 13)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "UBICACION ORIGEN"
        '
        'DEPOSITODESTINO
        '
        Me.DEPOSITODESTINO.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DEPOSITODESTINO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DEPOSITODESTINO.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DEPOSITODESTINO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DEPOSITODESTINO.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DEPOSITODESTINO.FormattingEnabled = True
        Me.DEPOSITODESTINO.Location = New System.Drawing.Point(619, 115)
        Me.DEPOSITODESTINO.Name = "DEPOSITODESTINO"
        Me.DEPOSITODESTINO.Size = New System.Drawing.Size(121, 21)
        Me.DEPOSITODESTINO.TabIndex = 31
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(627, 101)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(113, 13)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "DEPOSITO DESTINO"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(928, 99)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(62, 13)
        Me.Label16.TabIndex = 33
        Me.Label16.Text = "CANTIDAD"
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TextBox5.Location = New System.Drawing.Point(919, 116)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(84, 20)
        Me.TextBox5.TabIndex = 32
        '
        'UBICACIONDESTINO
        '
        Me.UBICACIONDESTINO.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UBICACIONDESTINO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.UBICACIONDESTINO.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.UBICACIONDESTINO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UBICACIONDESTINO.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.UBICACIONDESTINO.FormattingEnabled = True
        Me.UBICACIONDESTINO.Location = New System.Drawing.Point(770, 115)
        Me.UBICACIONDESTINO.Name = "UBICACIONDESTINO"
        Me.UBICACIONDESTINO.Size = New System.Drawing.Size(121, 21)
        Me.UBICACIONDESTINO.TabIndex = 35
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(775, 101)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(116, 13)
        Me.Label17.TabIndex = 34
        Me.Label17.Text = "UBICACION DESTINO"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(1017, 99)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(121, 13)
        Me.Label18.TabIndex = 37
        Me.Label18.Text = "COSTO REPOSITORIO"
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TextBox6.Location = New System.Drawing.Point(1034, 116)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(84, 20)
        Me.TextBox6.TabIndex = 36
        Me.TextBox6.Text = "0.00"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TextBox1.Location = New System.Drawing.Point(251, 66)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(121, 20)
        Me.TextBox1.TabIndex = 38
        '
        'btn_cajeta
        '
        Me.btn_cajeta.Location = New System.Drawing.Point(200, 113)
        Me.btn_cajeta.Name = "btn_cajeta"
        Me.btn_cajeta.Size = New System.Drawing.Size(75, 23)
        Me.btn_cajeta.TabIndex = 39
        Me.btn_cajeta.Text = "CAJETA"
        Me.btn_cajeta.UseVisualStyleBackColor = True
        '
        'btn_master
        '
        Me.btn_master.Location = New System.Drawing.Point(281, 113)
        Me.btn_master.Name = "btn_master"
        Me.btn_master.Size = New System.Drawing.Size(75, 23)
        Me.btn_master.TabIndex = 40
        Me.btn_master.Text = "MASTER"
        Me.btn_master.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Uighur", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DataGridView1.Location = New System.Drawing.Point(10, 228)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Uighur", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.Size = New System.Drawing.Size(1348, 405)
        Me.DataGridView1.TabIndex = 42
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.Image = Global.reportesfrigo.My.Resources.Resources._2413539
        Me.Button3.Location = New System.Drawing.Point(10, 9)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(53, 62)
        Me.Button3.TabIndex = 45
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Image = Global.reportesfrigo.My.Resources.Resources.borraf1
        Me.Button2.Location = New System.Drawing.Point(101, 161)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(44, 51)
        Me.Button2.TabIndex = 44
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.reportesfrigo.My.Resources.Resources.nueva_fila
        Me.Button1.Location = New System.Drawing.Point(37, 161)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(43, 51)
        Me.Button1.TabIndex = 43
        Me.Button1.UseVisualStyleBackColor = True
        '
        'exportar
        '
        Me.exportar.Image = CType(resources.GetObject("exportar.Image"), System.Drawing.Image)
        Me.exportar.Location = New System.Drawing.Point(574, 641)
        Me.exportar.Name = "exportar"
        Me.exportar.Size = New System.Drawing.Size(46, 38)
        Me.exportar.TabIndex = 41
        Me.exportar.UseVisualStyleBackColor = True
        '
        'comboproductos
        '
        Me.comboproductos.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.comboproductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboproductos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.comboproductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboproductos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.comboproductos.FormattingEnabled = True
        Me.comboproductos.Location = New System.Drawing.Point(522, 25)
        Me.comboproductos.Name = "comboproductos"
        Me.comboproductos.Size = New System.Drawing.Size(539, 21)
        Me.comboproductos.TabIndex = 46
        '
        'combotalla
        '
        Me.combotalla.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.combotalla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combotalla.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.combotalla.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combotalla.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.combotalla.FormattingEnabled = True
        Me.combotalla.Location = New System.Drawing.Point(382, 66)
        Me.combotalla.Name = "combotalla"
        Me.combotalla.Size = New System.Drawing.Size(134, 21)
        Me.combotalla.TabIndex = 47
        '
        'comcodpro
        '
        Me.comcodpro.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.comcodpro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comcodpro.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.comcodpro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comcodpro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.comcodpro.FormattingEnabled = True
        Me.comcodpro.Location = New System.Drawing.Point(382, 25)
        Me.comcodpro.Name = "comcodpro"
        Me.comcodpro.Size = New System.Drawing.Size(116, 21)
        Me.comcodpro.TabIndex = 48
        '
        'tallamarcada
        '
        Me.tallamarcada.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tallamarcada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tallamarcada.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tallamarcada.Location = New System.Drawing.Point(521, 66)
        Me.tallamarcada.Name = "tallamarcada"
        Me.tallamarcada.ReadOnly = True
        Me.tallamarcada.Size = New System.Drawing.Size(99, 20)
        Me.tallamarcada.TabIndex = 49
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(524, 49)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 13)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "TALLA MARCADA"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(1170, 47)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(158, 20)
        Me.TextBox2.TabIndex = 51
        '
        'cantcajeta
        '
        Me.cantcajeta.Location = New System.Drawing.Point(604, 177)
        Me.cantcajeta.Name = "cantcajeta"
        Me.cantcajeta.ReadOnly = True
        Me.cantcajeta.Size = New System.Drawing.Size(183, 20)
        Me.cantcajeta.TabIndex = 52
        '
        'cantmaster
        '
        Me.cantmaster.Location = New System.Drawing.Point(965, 177)
        Me.cantmaster.Name = "cantmaster"
        Me.cantmaster.ReadOnly = True
        Me.cantmaster.Size = New System.Drawing.Size(183, 20)
        Me.cantmaster.TabIndex = 53
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(459, 180)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(139, 13)
        Me.Label19.TabIndex = 54
        Me.Label19.Text = "CANT. CAJETA EN STOCK"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(815, 180)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(144, 13)
        Me.Label20.TabIndex = 55
        Me.Label20.Text = "CANT. MASTER EN STOCK"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(1217, 28)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(56, 13)
        Me.Label21.TabIndex = 56
        Me.Label21.Text = "USUARIO"
        '
        'logistica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.cantmaster)
        Me.Controls.Add(Me.cantcajeta)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tallamarcada)
        Me.Controls.Add(Me.comcodpro)
        Me.Controls.Add(Me.combotalla)
        Me.Controls.Add(Me.comboproductos)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.exportar)
        Me.Controls.Add(Me.btn_master)
        Me.Controls.Add(Me.btn_cajeta)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.UBICACIONDESTINO)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.DEPOSITODESTINO)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.UBICACIONORIGEN)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.DEPOSITOORIGEN)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cantidad)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.caja)
        Me.Controls.Add(Me.master)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.unidad)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.despacho)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ordenes)
        Me.Controls.Add(Me.Label1)
        Me.Name = "logistica"
        Me.Text = "logistica"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents ordenes As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents despacho As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents unidad As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents master As TextBox
    Friend WithEvents caja As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cantidad As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents DEPOSITOORIGEN As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents UBICACIONORIGEN As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents DEPOSITODESTINO As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents UBICACIONDESTINO As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btn_cajeta As Button
    Friend WithEvents btn_master As Button
    Friend WithEvents exportar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents comboproductos As ComboBox
    Friend WithEvents combotalla As ComboBox
    Friend WithEvents comcodpro As ComboBox
    Friend WithEvents tallamarcada As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents cantcajeta As TextBox
    Friend WithEvents cantmaster As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
End Class
