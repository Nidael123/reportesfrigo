Imports System.Data.SqlClient
Imports Microsoft.Office.Interop

Public Class logistica
    Private Const V As Boolean = True
    Dim opglobal As DataTable
    Dim envase As String
    Dim posicion As Integer
    Public lleno As Boolean
    Public dtDataTable As New DataTable
    Dim cantidadcajas As Int64
    Dim cantidadmaster As Int64
    Dim peso As Double
    Dim cajetas As Int64
    Private Sub Button1_Click(sender As Object, e As EventArgs)


    End Sub
    Sub iniciagrid()
        dtDataTable.Columns.Clear()
        dtDataTable.Columns.Add("PRODUCTO")
        dtDataTable.Columns.Add("DESCRIPCIÓN")
        dtDataTable.Columns.Add("CANT. MASTERS")
        dtDataTable.Columns.Add("CANT. CAJAS/FUNDAS")
        dtDataTable.Columns.Add("TALLA")
        dtDataTable.Columns.Add("TALLA MARCADA")
        dtDataTable.Columns.Add("LOTE")
        dtDataTable.Columns.Add("LOTE MARCADO")
        dtDataTable.Columns.Add("CANTIDAD")
        dtDataTable.Columns.Add("UNIDAD MEDIDA")
        dtDataTable.Columns.Add("DEPÓSITO ORIGEN")
        dtDataTable.Columns.Add("UBICACIÓN ORIGEN")
        dtDataTable.Columns.Add("DESPACHO")
        dtDataTable.Columns.Add("ENVASE")
        dtDataTable.Columns.Add("DEPÓSITO DESTINO")
        dtDataTable.Columns.Add("UBICACIÓN DESTINO")
        dtDataTable.Columns.Add("COSTO REPOSITORIO")

        DataGridView1.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill

        DataGridView1.DataSource = dtDataTable

        'sacar deposito
        Dim conexion2 As New SqlConnection("Data Source=192.168.0.158;Initial Catalog=reportes;Persist Security Info=True;User ID=sa;Password=frigopesca2223+")
        Dim command2 As New SqlCommand("SP_SACARDEPOSITOSINV", conexion2)
        Dim op2 As New DataTable()
        command2.CommandType = CommandType.StoredProcedure
        Dim adapter2 As New SqlDataAdapter
        posicion = 0
        Try
            conexion2.Open()
            command2.ExecuteNonQuery()
            adapter2.SelectCommand = command2
            adapter2.Fill(op2)
            While (posicion <= op2.Rows.Count - 1)
                DEPOSITOORIGEN.Items.Add(op2.Rows(posicion).Item("NOMBRE").ToString())
                DEPOSITODESTINO.Items.Add(op2.Rows(posicion).Item("NOMBRE").ToString())
                posicion = posicion + 1
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexion2.Dispose()
            command2.Dispose()
        End Try

        'Dim conexion As New SqlConnection("Data Source=192.168.0.158;Initial Catalog=reportes;Persist Security Info=True;User ID=sa;Password=frigopesca2223+")
        'Dim command As New SqlCommand("SP_CARGARTALLA", conexion)
        'Dim op As New DataTable()
        'command.CommandType = CommandType.StoredProcedure
        'Dim adapter As New SqlDataAdapter

        'posicion = 0
        'ordenes.Text = "SELECCIONE ORDEN DE PRODUCCION"
        'Try
        '    conexion.Open()
        '    command.ExecuteNonQuery()
        '    adapter.SelectCommand = command
        '    adapter.Fill(op)
        '    While (posicion <= op.Rows.Count - 1)
        '        combotalla.Items.Add(op.Rows(posicion).Item("talla").ToString())
        '        posicion = posicion + 1
        '    End While
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'Finally
        '    conexion.Dispose()
        '    command.Dispose()
        'End Try
        ''cargar los depositos y las ubicaciones 

        ''SACAR LOS CODIGOS DE PRODUCTO
        'Dim conexion3 As New SqlConnection("Data Source=192.168.0.158;Initial Catalog=reportes;Persist Security Info=True;User ID=sa;Password=frigopesca2223+")
        'Dim command3 As New SqlCommand("SP_SACARCODPRO", conexion3)
        'Dim op3 As New DataTable()
        'command3.CommandType = CommandType.StoredProcedure
        'Dim adapter3 As New SqlDataAdapter
        'posicion = 0
        'Try
        '    conexion3.Open()
        '    command3.ExecuteNonQuery()
        '    adapter3.SelectCommand = command3
        '    adapter3.Fill(op3)
        '    While (posicion <= op3.Rows.Count - 1)
        '        comboproductos.Items.Add(op3.Rows(posicion).Item("descripcion").ToString())
        '        comcodpro.Items.Add(op3.Rows(posicion).Item("codigo").ToString())
        '        posicion = posicion + 1
        '    End While

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'Finally
        '    conexion3.Dispose()
        '    command3.Dispose()
        'End Try

        ''Dim conexion5 As New SqlConnection("Data Source=192.168.0.158;Initial Catalog=reportes;Persist Security Info=True;User ID=sa;Password=frigopesca2223+")
        ''Dim command5 As New SqlCommand("SP_SACAROP", conexion5)
        ''Dim op5 As New DataTable()
        ''command5.CommandType = CommandType.StoredProcedure
        ''Dim adapter5 As New SqlDataAdapter

        ''posicion = 0
        ''ordenes.Text = "SELECCIONE ORDEN DE PRODUCCION"
        ''Try
        ''    conexion5.Open()
        ''    command5.ExecuteNonQuery()
        ''    adapter5.SelectCommand = command5
        ''    adapter5.Fill(op5)
        ''    While (posicion <= op5.Rows.Count - 1)
        ''        ordenes.Items.Add(op5.Rows(posicion).Item("op").ToString())
        ''        posicion = posicion + 1
        ''    End While
        ''    ordenes.AutoCompleteMode = AutoCompleteMode.Suggest
        ''    ordenes.AutoCompleteSource = AutoCompleteSource.ListItems
        ''Catch ex As Exception
        ''    MessageBox.Show(ex.Message)
        ''Finally
        ''    conexion5.Dispose()
        ''    command5.Dispose()
        ''End Try

    End Sub

    Private Sub logistica_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        iniciagrid()
        cargarsaldo()
    End Sub
    Private Sub ordenes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ordenes.SelectedIndexChanged

        Dim conexion As New SqlConnection("Data Source=192.168.0.158;Initial Catalog=reportes;Persist Security Info=True;User ID=sa;Password=frigopesca2223+")
        Dim adapter As New SqlDataAdapter
        Dim command As New SqlCommand("SP_INFOPRODUCTO", conexion)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@codigopro", comcodpro.SelectedItem) ' Error al tomar los valores de nombre del combobox
        Dim op As New DataTable()
        Try
            conexion.Open()
            Command.ExecuteNonQuery()
            adapter.SelectCommand = command
            adapter.Fill(op)
            opglobal = op

            unidad.Text = opglobal.Rows(0).Item("unidad").ToString()
            peso = Convert.ToDouble(opglobal.Rows(0).Item("peso").ToString)
            cajetas = Convert.ToInt64(opglobal.Rows(0).Item("cajas").ToString)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexion.Dispose()
            Command.Dispose()
        End Try
        despacho.Text = ordenes.SelectedItem


    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles master.KeyPress
        If master.TextLength < 0 Then
            caja.Enabled = True
        Else
            caja.Enabled = False
        End If
    End Sub

    Private Sub btn_cajeta_Click(sender As Object, e As EventArgs) Handles btn_cajeta.Click

        Dim canti As Integer
        If cantidad.Text.Trim = "" Then

            canti = 0
        Else
            canti = Convert.ToUInt64(cantidad.Text.Trim)
        End If


        If cantidad.Text.Trim <> "" And canti > 0 And ordenes.Text.Length > 0 Then
            If Convert.ToInt64(cantidad.Text) <= Convert.ToInt64(cantcajeta.Text) Then
                btn_master.Enabled = False
                master.Text = 0

                caja.Text = cantidad.Text.ToString.TrimStart("0")
                cantidad.Enabled = False
                TextBox5.Text = ((Convert.ToDouble(caja.Text.Trim.ToString)) * peso).ToString
            Else
                MessageBox.Show("la cantidad a transferir es mayor a la de del stock")
            End If

        Else
            MessageBox.Show("Debe ingresar una cantidad diferente de cero y/o escojer una orden")
        End If
        envase = "Cajeta"

    End Sub
    Private Sub btn_master_Click(sender As Object, e As EventArgs) Handles btn_master.Click
        Dim op As DataTable
        op = opglobal
        Dim canti As Integer
        If cantidad.Text.Trim = "" Then
            canti = 0
        Else
            canti = Convert.ToUInt64(cantidad.Text.Trim)
        End If
        If cantidad.Text.Trim <> "" And canti > 0 And ordenes.Text.Length > 0 Then
            If Convert.ToInt64(cantidad.Text) <= Convert.ToInt64(cantmaster.Text) Then
                btn_cajeta.Enabled = False
                cantidad.Enabled = False
                master.Text = cantidad.Text.ToString.TrimStart("0")
                caja.Text = 0
                'MessageBox.Show(Convert.ToDouble(opglobal.Rows(0).Item("peso").ToString))
                TextBox5.Text = ((Convert.ToDouble(master.Text.Trim.ToString)) * (peso) * cajetas).ToString
            Else
                MessageBox.Show("Debe ingresar una cantidad diferente de cero y/o escojer una orden")
            End If

        Else
            MessageBox.Show("Debe ingresar primero una cantidad diferente de cero y/o escojer una orden")
        End If
        envase = "Master"
    End Sub
    Sub crear_excel()
        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet
        exLibro = exApp.Workbooks.Add
        exHoja = exLibro.Worksheets.Add()

        Dim NCol As Integer = DataGridView1.ColumnCount
        Dim NRow As Integer = DataGridView1.RowCount
        For i As Integer = 1 To NCol
            exHoja.Cells.Item(1, i) = DataGridView1.Columns(i - 1).Name.ToString
            'exHoja.Cells.Item(1, i).HorizontalAlignment = 3
        Next

        For Fila As Integer = 0 To NRow - 1
            For Col As Integer = 0 To NCol - 1
                exHoja.Cells.Item(Fila + 2, Col + 1) = DataGridView1.Rows(Fila).Cells(Col).Value
            Next
        Next



        exHoja.Rows.Item(1).Font.Bold = 1
        exHoja.Rows.Item(1).HorizontalAlignment = 3
        exHoja.Rows.Item(2).Font.Bold = 1
        exHoja.Columns.AutoFit()


        exApp.Application.Visible = True



        exHoja.Protect("sistemas2223")
        exHoja = Nothing
        exLibro = Nothing
        exApp = Nothing
    End Sub

    Private Sub exportar_Click(sender As Object, e As EventArgs) Handles exportar.Click
        Dim envase2 As String
        envase2 = envase
        Dim conexion As New SqlConnection("Data Source=192.168.0.158;Initial Catalog=reportes;Persist Security Info=True;User ID=sa;Password=frigopesca2223+")
        Dim adapter As New SqlDataAdapter
        posicion = 0
        Dim command As New SqlCommand("sumatoriacantidades", conexion)
        command.CommandType = CommandType.StoredProcedure
        Dim op As New DataTable()
        Try


            If DataGridView1.Rows.Count < 1 Then
                MessageBox.Show("Debe agregar mínimo una fila")
            Else

                'insetar los datos de las modificaciones en la tabla 
                For Each filas As DataGridViewRow In DataGridView1.Rows

                    If filas.Cells(13).Value.ToString = "C01 - Cajeta" Then
                        envase2 = "Cajeta"
                    Else
                        envase2 = "Master"
                    End If

                    guardaritems(filas.Cells(10).Value.ToString, Convert.ToDecimal(filas.Cells(8).Value.ToString), filas.Cells(6).Value.ToString, filas.Cells(11).Value.ToString, filas.Cells(15).Value.ToString,
                    filas.Cells(14).Value.ToString, filas.Cells(5).Value.ToString, envase2, filas.Cells(0).Value.ToString, Convert.ToInt64(filas.Cells(3).Value.ToString), Convert.ToInt64(filas.Cells(2).Value.ToString),
                    filas.Cells(1).Value.ToString)

                    guardarusuario(filas.Cells(10).Value.ToString, Convert.ToDecimal(filas.Cells(8).Value.ToString), filas.Cells(6).Value.ToString, filas.Cells(11).Value.ToString, filas.Cells(15).Value.ToString,
                    filas.Cells(14).Value.ToString, filas.Cells(5).Value.ToString, envase2, filas.Cells(0).Value.ToString, Convert.ToInt64(filas.Cells(3).Value.ToString), Convert.ToInt64(filas.Cells(2).Value.ToString))

                    eliminarreserva(filas.Cells(10).Value.ToString, Convert.ToDecimal(filas.Cells(8).Value.ToString), filas.Cells(6).Value.ToString, filas.Cells(11).Value.ToString, filas.Cells(15).Value.ToString,
                    filas.Cells(14).Value.ToString, filas.Cells(5).Value.ToString, envase2, filas.Cells(0).Value.ToString, Convert.ToInt64(filas.Cells(3).Value.ToString), Convert.ToInt64(filas.Cells(2).Value.ToString))
                Next

                limpiar()
                borrar()
                crear_excel()

                For i As Integer = DataGridView1.Rows.Count - 1 To 0 Step -1
                    DataGridView1.Rows.RemoveAt(i)
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            command.Dispose()
        End Try
    End Sub

    Public Sub limpiar()
        btn_cajeta.Enabled = True
        btn_master.Enabled = True
        cantidad.Enabled = True
        combotalla.Items.Clear()
        ordenes.Items.Clear()
        ComboBox1.Items.Clear()
        combotalla.Text = ""
        ordenes.Text = ""
        tallamarcada.Text = ""
    End Sub

    Private Sub DEPOSITOORIGEN_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DEPOSITOORIGEN.SelectedIndexChanged
        Dim conexion As New SqlConnection("Data Source=192.168.0.158;Initial Catalog=reportes;Persist Security Info=True;User ID=sa;Password=frigopesca2223+")
        Dim adapter As New SqlDataAdapter
        posicion = 0
        Dim command As New SqlCommand("SP_SACARUBICACION1", conexion)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@deposito", DEPOSITOORIGEN.SelectedItem) ' Error al tomar los valores de nombre del combobox
        Dim op As New DataTable()
        Try
            conexion.Open()
            command.ExecuteNonQuery()
            adapter.SelectCommand = command
            adapter.Fill(op)

            While (posicion <= op.Rows.Count - 1)
                UBICACIONORIGEN.Items.Clear()
                UBICACIONORIGEN.Items.Add(op.Rows(posicion).Item("NOMBRE").ToString())
                posicion = posicion + 1
            End While
        Catch ex As Exception

        Finally
            conexion.Dispose()
            command.Dispose()
        End Try

        'Dim conexion As New SqlConnection("Data Source=192.168.0.158;Initial Catalog=reportes;Persist Security Info=True;User ID=sa;Password=frigopesca2223+")
        'Dim adapter As New SqlDataAdapter
        'posicion = 0
        'Dim command As New SqlCommand("SP_SACARUBICACION", conexion)
        'command.CommandType = CommandType.StoredProcedure
        'command.Parameters.AddWithValue("@deposito", DEPOSITOORIGEN.SelectedItem)
        'command.Parameters.AddWithValue("@lote", ComboBox1.SelectedItem)
        'Dim op As New DataTable()
        'Try
        '    conexion.Open()
        '    command.ExecuteNonQuery()
        '    adapter.SelectCommand = command
        '    adapter.Fill(op)
        '    UBICACIONORIGEN.Items.Clear()
        '    While (posicion <= op.Rows.Count - 1)
        '        UBICACIONORIGEN.Items.Clear()
        '        UBICACIONORIGEN.Items.Add(op.Rows(posicion).Item("NOMBRE").ToString())
        '        posicion = posicion + 1
        '    End While

        'Catch ex As Exception

        'Finally
        '    conexion.Dispose()
        '    command.Dispose()
        'End Try
    End Sub

    Private Sub DEPOSITODESTINO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DEPOSITODESTINO.SelectedIndexChanged
        Dim conexion As New SqlConnection("Data Source=192.168.0.158;Initial Catalog=reportes;Persist Security Info=True;User ID=sa;Password=frigopesca2223+")
        Dim adapter As New SqlDataAdapter
        posicion = 0
        Dim command As New SqlCommand("SP_SACARUBICACION1", conexion)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@deposito", DEPOSITODESTINO.SelectedItem) ' Error al tomar los valores de nombre del combobox
        Dim op As New DataTable()
        Try
            conexion.Open()
            command.ExecuteNonQuery()
            adapter.SelectCommand = command
            adapter.Fill(op)

            While (posicion <= op.Rows.Count - 1)
                UBICACIONDESTINO.Items.Clear()
                UBICACIONDESTINO.Items.Add(op.Rows(posicion).Item("NOMBRE").ToString())
                posicion = posicion + 1
            End While
        Catch ex As Exception

        Finally
            conexion.Dispose()
            command.Dispose()
        End Try
    End Sub
    Sub borrar()



        DEPOSITOORIGEN.SelectedIndex = -1
        UBICACIONORIGEN.SelectedIndex = -1
        DEPOSITODESTINO.SelectedIndex = -1
        UBICACIONDESTINO.SelectedIndex = -1
        comcodpro.Items.Clear()
        comboproductos.Items.Clear()
        cantcajeta.Text = ""
        cantmaster.Text = ""
        despacho.Text = ""

        unidad.Text = ""
        cantidad.Text = ""
        master.Text = ""
        caja.Text = ""


        TextBox1.Text = ""
        TextBox5.Text = ""


        btn_cajeta.Enabled = True
        btn_master.Enabled = True
        cantidad.Enabled = True


    End Sub

    Sub validar_campos()
        If despacho.Text = "" Or
           unidad.Text = "" Or
           cantidad.Text = "" Or
           master.Text = "" Or
           caja.Text = "" Or
           ComboBox1.SelectedIndex = -1 Or
           TextBox1.Text = "" Or
           TextBox5.Text = "" Or
           DEPOSITODESTINO.SelectedIndex = -1 Or
           DEPOSITOORIGEN.SelectedIndex = -1 Or
           UBICACIONDESTINO.SelectedIndex = -1 Or
           UBICACIONORIGEN.SelectedIndex = -1 Or
           cantidad.Enabled = V Then
            lleno = False
        Else
            lleno = True
        End If

    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim valor As Boolean
        valor = buscarreservado(DEPOSITOORIGEN.Text, TextBox5.Text, ComboBox1.Text, UBICACIONORIGEN.Text, combotalla.Text, envase, comcodpro.Text, caja.Text, master.Text)
        If valor = True Then
            validar_campos()
            If lleno = True Then
                Dim entrada = dtDataTable.NewRow()
                If btn_cajeta.Enabled = True Then
                    entrada("ENVASE") = "C01 - Cajeta"

                Else
                    entrada("ENVASE") = "M01 - Master"
                End If


                entrada("PRODUCTO") = comcodpro.Text
                entrada("DESCRIPCIÓN") = comboproductos.Text
                entrada("DESPACHO") = despacho.Text
                entrada("TALLA") = combotalla.Text
                entrada("UNIDAD MEDIDA") = unidad.Text
                entrada("CANTIDAD") = TextBox5.Text
                entrada("CANT. MASTERS") = master.Text
                entrada("CANT. CAJAS/FUNDAS") = caja.Text
                entrada("TALLA MARCADA") = tallamarcada.Text
                entrada("LOTE") = ComboBox1.Text
                entrada("LOTE MARCADO") = TextBox1.Text
                entrada("DEPÓSITO ORIGEN") = DEPOSITOORIGEN.Text
                entrada("UBICACIÓN ORIGEN") = UBICACIONORIGEN.Text
                entrada("DEPÓSITO DESTINO") = DEPOSITODESTINO.Text
                entrada("UBICACIÓN DESTINO") = UBICACIONDESTINO.Text
                entrada("COSTO REPOSITORIO") = TextBox6.Text.ToString
                dtDataTable.Rows.Add(entrada)
                DataGridView1.DataSource = dtDataTable
                guardarreserva(DEPOSITOORIGEN.Text, TextBox5.Text, ComboBox1.Text, UBICACIONORIGEN.Text, combotalla.Text, envase, comcodpro.Text, caja.Text, master.Text)
                borrar()
                limpiar()
            Else
                MessageBox.Show("Por favor llene todos los campos")
            End If
        Else
            MessageBox.Show("el valor a sido escojido en otra transaccion espere que termine e intente otra vez ")
            cantidad.Text = ""
            btn_cajeta.Enabled = True
            btn_master.Enabled = True
            'master.Text = ""
            'caja.Text = ""
            'TextBox5.Text = ""
            cantidad.Enabled = True
        End If
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (DataGridView1.SelectedRows.Count > 0) Then
            Dim Row = DataGridView1.SelectedRows

            DataGridView1.Rows.RemoveAt(DataGridView1.SelectedRows(0).Index)

        Else
            MessageBox.Show("Por favor seleccione una fila ")
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub cantidad_TextChanged(sender As Object, e As EventArgs) Handles cantidad.TextChanged

    End Sub
    Private Sub cantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cantidad.KeyPress

        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(8) Then


            e.Handled = False
        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        'CARGAR LA TALLA SEGUN EL LOTE 

        Dim conexion As New SqlConnection("Data Source=192.168.0.158;Initial Catalog=reportes;Persist Security Info=True;User ID=sa;Password=frigopesca2223+")
        Dim command As New SqlCommand("SP_CARGARTALLA", conexion)
        Dim op As New DataTable()
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@lote", ComboBox1.Text)
        command.Parameters.AddWithValue("@deposito", DEPOSITOORIGEN.SelectedItem)
        command.Parameters.AddWithValue("@ubicacion", UBICACIONORIGEN.SelectedItem)
        command.Parameters.AddWithValue("@codigoprod", comcodpro.SelectedItem)
        Dim adapter As New SqlDataAdapter

        posicion = 0

        Try
            conexion.Open()
            command.ExecuteNonQuery()
            adapter.SelectCommand = command
            adapter.Fill(op)
            combotalla.Items.Clear()
            While (posicion <= op.Rows.Count - 1)
                combotalla.Items.Add(op.Rows(posicion).Item("talla").ToString())
                posicion = posicion + 1
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexion.Dispose()
            command.Dispose()
        End Try

        TextBox1.Text = ComboBox1.Text

        'CARGAR OP SEGUN EL LOTE 
        Dim conexion1 As New SqlConnection("Data Source=192.168.0.158;Initial Catalog=reportes;Persist Security Info=True;User ID=sa;Password=frigopesca2223+")
        Dim adapter1 As New SqlDataAdapter
        Dim command1 As New SqlCommand("SP_INFOOP", conexion1)
        command1.CommandType = CommandType.StoredProcedure
        command1.Parameters.AddWithValue("@orden", ComboBox1.Text) ' Error al tomar los valores de nombre del combobox
        Dim op1 As New DataTable()
        posicion = 0
        Try
            conexion1.Open()
            command1.ExecuteNonQuery()
            adapter1.SelectCommand = command1
            adapter1.Fill(op1)
            While (posicion <= op1.Rows.Count - 1)
                ordenes.Items.Add(op1.Rows(posicion).Item("descripcion").ToString())
                posicion = posicion + 1
            End While
            'productonombre.Text = op1.Rows(0).Item("producto").ToString()
            'descripcion.Text = op1.Rows(0).Item("descripcion").ToString()
            'despacho.Text = op1.Rows(0).Item("despacho").ToString()
            'serie.Text = op1.Rows(0).Item("talla").ToString()
            'tallamarcada.Text = op1.Rows(0).Item("talla").ToString()
            'unidad.Text = op1.Rows(0).Item("unidad").ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexion1.Dispose()
            command1.Dispose()
        End Try





















        'Dim ops = New DataTable

        'Dim conexion As New SqlConnection("Data Source=192.168.0.158;Initial Catalog=reportes;Persist Security Info=True;User ID=sa;Password=frigopesca2223+")
        'Dim adapter As New SqlDataAdapter
        'posicion = 0



        'conexion.Open()



        '' cambiar los datos de los depositos
        'Dim command = New SqlCommand("SP_SACARDEPOSITO", conexion)
        'command.CommandType = CommandType.StoredProcedure
        'command.Parameters.AddWithValue("@lote", ComboBox1.Text)
        'command.ExecuteNonQuery()
        'adapter.SelectCommand = command
        'adapter.Fill(ops)
        'DEPOSITOORIGEN.Items.Clear()
        'While (posicion <= ops.Rows.Count - 1)
        '    DEPOSITOORIGEN.Items.Add(ops.Rows(posicion).Item("NOMBRE").ToString())
        '    posicion = posicion + 1
        'End While


    End Sub

    Private Sub UBICACIONORIGEN_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UBICACIONORIGEN.SelectedIndexChanged
        ''cargar los productos segun el deposito y ubicacion 
        Dim conexion4 As New SqlConnection("Data Source=192.168.0.158;Initial Catalog=reportes;Persist Security Info=True;User ID=sa;Password=frigopesca2223+")
        Dim command4 As New SqlCommand("SP_SACARCODPRO", conexion4)
        Dim op4 As New DataTable()
        command4.CommandType = CommandType.StoredProcedure
        command4.Parameters.AddWithValue("@deposito", DEPOSITOORIGEN.SelectedItem)
        command4.Parameters.AddWithValue("@ubicacion", UBICACIONORIGEN.SelectedItem)
        Dim adapter4 As New SqlDataAdapter
        posicion = 0
        Try
            conexion4.Open()
            command4.ExecuteNonQuery()
            adapter4.SelectCommand = command4
            adapter4.Fill(op4)

            comcodpro.Items.Clear()
            comboproductos.Items.Clear()
            While (posicion <= op4.Rows.Count - 1)

                comboproductos.Items.Add(op4.Rows(posicion).Item("producto").ToString())
                comcodpro.Items.Add(op4.Rows(posicion).Item("codigoProducto").ToString())
                posicion = posicion + 1
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexion4.Dispose()
            command4.Dispose()
        End Try
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        limpiar()
        borrar()
    End Sub
    Private Sub comcodpro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comcodpro.SelectedIndexChanged
        Dim d As Integer
        d = comcodpro.SelectedIndex
        comboproductos.SelectedIndex = d

        'CARGO LOS LOTES 

        Dim conexion6 As New SqlConnection("Data Source=192.168.0.158;Initial Catalog=reportes;Persist Security Info=True;User ID=sa;Password=frigopesca2223+")
        Dim adapter6 As New SqlDataAdapter
        posicion = 0
        Dim command6 As New SqlCommand("SP_SACARLOTE", conexion6)
        command6.CommandType = CommandType.StoredProcedure
        command6.Parameters.AddWithValue("@codigo", comcodpro.SelectedItem)
        command6.Parameters.AddWithValue("@deposito", DEPOSITOORIGEN.SelectedItem)
        command6.Parameters.AddWithValue("@ubicacion", UBICACIONORIGEN.SelectedItem)
        Dim op6 As New DataTable()
        Try
            conexion6.Open()
            command6.ExecuteNonQuery()
            adapter6.SelectCommand = command6
            adapter6.Fill(op6)
            ComboBox1.Items.Clear()

            While (posicion <= op6.Rows.Count - 1)
                ComboBox1.Items.Add(op6.Rows(posicion).Item("lote").ToString())
                posicion = posicion + 1
            End While
            'ComboBox1.AutoCompleteMode = AutoCompleteMode.Suggest
            'ComboBox1.AutoCompleteSource = AutoCompleteSource.ListItems
            If (op6.Rows.Count = 0) Then
                MessageBox.Show("No hay Lote asignado para esta orden")
            End If
        Catch ex As Exception
            MessageBox.Show("Error al buscar los lotes")
        Finally
            conexion6.Dispose()
            command6.Dispose()
        End Try

    End Sub
    Private Sub comboproductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboproductos.SelectedIndexChanged
        Dim d As Integer
        d = comboproductos.SelectedIndex
        comcodpro.SelectedIndex = d
    End Sub
    Private Sub combotalla_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combotalla.SelectedIndexChanged
        tallamarcada.Text = combotalla.Text
        cargarsaldos()
    End Sub
    Public Sub guardaritems(deposito As String, cantidad As Decimal, lote As String, ubicacion As String, ubicaciondes As String, depositodes As String, talla As String, envases As String, codigopro As String, cantidadcajetas As Int64, cantidadmas As Int64, producto As String)
        Dim conexion As New SqlConnection("Data Source=192.168.0.158;Initial Catalog=reportes;Persist Security Info=True;User ID=sa;Password=frigopesca2223+")
        Dim adapter As New SqlDataAdapter
        posicion = 0
        Dim command As New SqlCommand("sumatoriacantidades", conexion)
        command.CommandType = CommandType.StoredProcedure
        Dim op As New DataTable()

        Try
            If DataGridView1.Rows.Count < 1 Then
                MessageBox.Show("Debe agregar mínimo una fila")
            Else
                command.Parameters.AddWithValue("@deposito", deposito)
                command.Parameters.AddWithValue("@cantidad", cantidad)
                command.Parameters.AddWithValue("@lote", lote)
                command.Parameters.AddWithValue("@ubicacion", ubicacion)
                command.Parameters.AddWithValue("@ubicaciondes", ubicaciondes)
                command.Parameters.AddWithValue("@depositodes", depositodes)
                command.Parameters.AddWithValue("@talla", talla)
                command.Parameters.AddWithValue("@envase", envases)
                command.Parameters.AddWithValue("@codigoproducto", codigopro)
                command.Parameters.AddWithValue("@cantidadcajetas", cantidadcajetas)
                command.Parameters.AddWithValue("@cantidadmaster", cantidadmas)
                command.Parameters.AddWithValue("@producto", producto)
                conexion.Open()
                command.ExecuteNonQuery()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            conexion.Dispose()
            command.Dispose()
        End Try
    End Sub

    Public Sub cargarsaldos()

        Dim conexion As New SqlConnection("Data Source=192.168.0.158;Initial Catalog=reportes;Persist Security Info=True;User ID=sa;Password=frigopesca2223+")
        Dim adapter As New SqlDataAdapter
        posicion = 0
        Dim command As New SqlCommand("SP_SALDOCAJAMASTER", conexion)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@deposito", DEPOSITOORIGEN.SelectedItem)
        command.Parameters.AddWithValue("@lote", ComboBox1.SelectedItem)
        command.Parameters.AddWithValue("@talla", combotalla.SelectedItem)
        command.Parameters.AddWithValue("@codigoproducto", comcodpro.SelectedItem)
        conexion.Open()
        command.ExecuteNonQuery()
        Dim op As New DataTable()
        Try
            adapter.SelectCommand = command
            adapter.Fill(op)

            cantcajeta.Text = op.Rows(0).Item("cantidadcajeta").ToString()
            cantmaster.Text = op.Rows(0).Item("cantidadmaster").ToString()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            conexion.Dispose()
            command.Dispose()
        End Try
    End Sub
    Public Sub guardarusuario(deposito As String, cantidad As Decimal, lote As String, ubicacion As String, ubicaciondes As String, depositodes As String, talla As String, envases As String, codigopro As String, caja As Int64, master As Int64)
        Dim conexion As New SqlConnection("Data Source=192.168.0.158;Initial Catalog=reportes;Persist Security Info=True;User ID=sa;Password=frigopesca2223+")
        Dim adapter As New SqlDataAdapter
        posicion = 0
        Dim command As New SqlCommand("SP_GUARDARUSUARIO", conexion)
        command.CommandType = CommandType.StoredProcedure
        Dim op As New DataTable()

        Try
            If DataGridView1.Rows.Count < 1 Then
                MessageBox.Show("Debe agregar mínimo una fila")
            Else
                command.Parameters.AddWithValue("@usuario", txtuser.Text)
                command.Parameters.AddWithValue("@deposito", deposito)
                command.Parameters.AddWithValue("@cantidad", cantidad)
                command.Parameters.AddWithValue("@lote", lote)
                command.Parameters.AddWithValue("@ubicacion", ubicacion)
                command.Parameters.AddWithValue("@ubicaciondes", ubicaciondes)
                command.Parameters.AddWithValue("@depositodes", depositodes)
                command.Parameters.AddWithValue("@talla", talla)
                command.Parameters.AddWithValue("@envase", envases)
                command.Parameters.AddWithValue("@codigoproducto", codigopro)
                command.Parameters.AddWithValue("@cantidadcajeta", caja)
                command.Parameters.AddWithValue("@cantidadmaster", master)
                conexion.Open()
                command.ExecuteNonQuery()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            conexion.Dispose()
            command.Dispose()
        End Try
    End Sub
    Public Sub guardarreserva(deposito As String, cantidad As Decimal, lote As String, ubicacion As String, talla As String, envases As String, codigopro As String, caja As Int64, master As Int64)
        Dim conexion As New SqlConnection("Data Source=192.168.0.158;Initial Catalog=reportes;Persist Security Info=True;User ID=sa;Password=frigopesca2223+")
        Dim adapter As New SqlDataAdapter
        posicion = 0
        Dim command As New SqlCommand("SP_GUARDARRESERVA", conexion)
        command.CommandType = CommandType.StoredProcedure
        Dim op As New DataTable()
        Try
            If DataGridView1.Rows.Count < 1 Then
                MessageBox.Show("Debe agregar mínimo una fila")
            Else
                command.Parameters.AddWithValue("@deposito", deposito)
                command.Parameters.AddWithValue("@cantidad", cantidad)
                command.Parameters.AddWithValue("@lote", lote)
                command.Parameters.AddWithValue("@ubicacion", ubicacion)
                command.Parameters.AddWithValue("@talla", talla)
                command.Parameters.AddWithValue("@envase", envases)
                command.Parameters.AddWithValue("@codigoproducto", codigopro)
                command.Parameters.AddWithValue("@cantidadcajeta", caja)
                command.Parameters.AddWithValue("@cantidadmaster", master)
                command.Parameters.AddWithValue("@usuario", txtuser.Text)
                conexion.Open()
                command.ExecuteNonQuery()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            conexion.Dispose()
            command.Dispose()
        End Try
    End Sub

    Public Function buscarreservado(deposito As String, cantidad As Decimal, lote As String, ubicacion As String, talla As String, envases As String, codigopro As String, cajas As Int64, masters As Int64) As Boolean 'reviso si hay productos reservados si nohay los añado 
        Dim valor As Boolean
        Dim conexion As New SqlConnection("Data Source=192.168.0.158;Initial Catalog=reportes;Persist Security Info=True;User ID=sa;Password=frigopesca2223+")
        Dim adapter As New SqlDataAdapter
        posicion = 0
        Dim command As New SqlCommand("SP_BUSCARRESERVA", conexion)
        command.CommandType = CommandType.StoredProcedure
        Dim op As New DataTable()
        Try
            command.Parameters.AddWithValue("@deposito", deposito)
            command.Parameters.AddWithValue("@lote", lote)
            command.Parameters.AddWithValue("@ubicacion", ubicacion)
            command.Parameters.AddWithValue("@talla", talla)
            command.Parameters.AddWithValue("@envase", envases)
            command.Parameters.AddWithValue("@codigoproducto", codigopro)
            conexion.Open()
            command.ExecuteNonQuery()
            adapter.SelectCommand = command
            adapter.Fill(op)
            opglobal = op
            If op.Rows(0).Item("cajetas") <= -1 And op.Rows(0).Item("master") <= -1 Then
                valor = True
            Else
                If Convert.ToDecimal(master.Text) <> "0" Then
                    'trabajo con los master

                    If Convert.ToDecimal(cantmaster.Text) - Convert.ToDecimal(op.Rows(0).Item("master")) >= Convert.ToDecimal(master.Text) Then
                        valor = True
                    Else
                        valor = False
                    End If
                Else
                    'trabajo con los cajetas
                    If Convert.ToDecimal(cantcajeta.Text) - Convert.ToDecimal(op.Rows(0).Item("cajetas")) >= Convert.ToDecimal(caja.Text) Then
                        valor = True
                    Else
                        valor = False
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            conexion.Dispose()
            command.Dispose()
        End Try
        Return valor
    End Function

    Public Sub cargarsaldo()

        Dim conexion As New SqlConnection("Data Source=192.168.0.158;Initial Catalog=reportes;Persist Security Info=True;User ID=sa;Password=frigopesca2223+")
        Dim adapter As New SqlDataAdapter
        posicion = 0
        Dim command As New SqlCommand("SP_LLENARSALDO", conexion)
        command.CommandType = CommandType.StoredProcedure
        Dim op As New DataTable()
        Try
            conexion.Open()
            command.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            conexion.Dispose()
            command.Dispose()
        End Try

    End Sub

    Public Sub eliminarreserva(deposito As String, cantidad As Decimal, lote As String, ubicacion As String, ubicaciondes As String, depositodes As String, talla As String, envases As String, codigopro As String, caja As Int64, master As Int64)
        Dim conexion As New SqlConnection("Data Source=192.168.0.158;Initial Catalog=reportes;Persist Security Info=True;User ID=sa;Password=frigopesca2223+")
        Dim adapter As New SqlDataAdapter
        posicion = 0
        Dim command As New SqlCommand("SP_ELIMINARRESERVA", conexion)
        command.CommandType = CommandType.StoredProcedure
        Dim op As New DataTable()

        Try
            If DataGridView1.Rows.Count < 1 Then
                MessageBox.Show("Debe agregar mínimo una fila")
            Else
                command.Parameters.AddWithValue("@usuario", txtuser.Text)
                command.Parameters.AddWithValue("@deposito", deposito)

                command.Parameters.AddWithValue("@lote", lote)
                command.Parameters.AddWithValue("@ubicacion", ubicacion)
                command.Parameters.AddWithValue("@talla", talla)
                command.Parameters.AddWithValue("@envase", envases)
                command.Parameters.AddWithValue("@codigoproducto", codigopro)
                conexion.Open()
                command.ExecuteNonQuery()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            conexion.Dispose()
            command.Dispose()
        End Try
    End Sub
End Class