

Imports System.Runtime.InteropServices

Imports System.Data.SqlClient
Imports System.ComponentModel

Public Class rrhh

    Public conexion As SqlConnection
    Public comando As SqlCommand

    Public estado As String
    Public enunciado As SqlCommand
    Public respuesta As SqlDataReader
    Public adaptador As SqlDataAdapter
    Public tabla As DataTable
    Public dia, mes, año As String
    Public MiReporte As Object





    Public Sub rrhh_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        enlacepeso()


        consulta()






    End Sub

    Sub consulta()

        dia = time.Value.ToString("dd")
        mes = time.Value.ToString("MM")
        año = time.Value.ToString("yyyy")


        comando = New SqlCommand("
SELECT
	PR032DPESOSVA.FECHAREGISTRO AS FECHA, 
	PR031CPESOSVA.TURNO AS TURNO, 
	PR032DPESOSVA.CEDULA AS CEDULA, 
	PR031MPROCESOS.DESCRIPCION AS PROCESO, 
	PR031MTALLAS.DESCRIPCION AS TALLA, 
	PR031CPESOSVA.LOTE AS LOTE, 
	PR032DPESOSVA.PESO AS PESO, 
	PR031CPESOSVA.ID_USUARIO_CREA AS SUPERVISOR
                                                   FROM  PR031CPESOSVA
	LEFT JOIN
	dbo.PR032DPESOSVA

ON 
		PR031CPESOSVA.ID_EMPRESA = PR032DPESOSVA.ID_EMPRESA AND
		PR031CPESOSVA.ID_PESOS = PR032DPESOSVA.ID_PESOS AND
		PR031CPESOSVA.ID_PESOS = PR032DPESOSVA.ID_PESOS

	LEFT JOIN dbo.PR031MPROCESOS
ON 
		PR032DPESOSVA.PROCESO = PR031MPROCESOS.ID_PROCESO

LEFT JOIN dbo.PR031MTALLAS
ON 
		PR032DPESOSVA.TALLA = PR031MTALLAS.ID_TALLA

       where  datepart(mm, FECHAREGISTRO)= '" & mes & "'  
       and  datepart(yyyy, FECHAREGISTRO) = '" & año & "' 
and datepart(dd, FECHAREGISTRO)= '" & dia & "'          
and TURNO= '" & turno.Text & "'          ", conexionpeso)




        adaptador = New SqlDataAdapter()
        adaptador.SelectCommand = comando
        tabla = New DataTable()
        adaptador.Fill(tabla)
        data1.DataSource = tabla











    End Sub


    Private Sub time_TextChanged(sender As Object, e As EventArgs) Handles time.TextChanged







































    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim respuesta02 As DialogResult = MessageBox.Show("Advertencia,¿Desea Cerrar el tuno del día seleccionado?",
                                                      "APROBACIÓN",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question)

        If respuesta02 = vbYes Then



            'INSERTAR DATOS A TABLA DE ACTIVIDAD
            Dim conexion As SqlConnection
            conexion = New SqlConnection("Data Source=192.168.0.158;Initial Catalog=reportes;Persist Security Info=True;User ID=sa;Password=frigopesca2223+")
            conexion.Open()






            Dim fecha As String = datef.Text
            Dim proceso As String = "Reporte de pesos"
            Dim usuario As String = user.Text
            Dim consulta As String = time.Text
            Dim turnoconsu As String = turno.Text
            Dim estad As String = "CERRADO"



            Dim cadena As String = "insert into ACT_USER(PROCESO, USUARIO, FECHA, consulta, TURNOCON, estado)
            values ('" & proceso & "','" & usuario & "', '" & fecha & "','" & consulta & "','" & turnoconsu & "','" & estad & "')"

            Dim base As SqlCommand
            base = New SqlCommand(cadena, conexion)
            base.ExecuteNonQuery()



            conexion.Close()
            MsgBox("El turno del dia seleccionado fue cerrado correctamente", MsgBoxStyle.Exclamation, "Atención")





            data1.DataSource = Nothing

            Button1.Enabled = False
            ProgressBar1.Visible = False
            Label3.Visible = False



        End If


        Dim conexion2 As SqlConnection
        conexion2 = New SqlConnection("Data Source=192.168.0.18;Initial Catalog=appfrigopesca;Persist Security Info=True;User ID=sa;Password=frigopesca2223+")
        conexion2.Open()




        Dim cadena2 As String = "UPDATE  PR031CPESOSVA  set INGESTADO= 'C' FROM PR031CPESOSVA where  datepart(mm,INGFECCREA)='" & mes & "' and datepart(yyyy,INGFECCREA) = '" & año & "' and datepart(dd,INGFECCREA)='" & dia & "'AND TURNO= '" & turno.Text & "'"


        Dim base2 As SqlCommand
        base2 = New SqlCommand(cadena2, conexion2)
        base2.ExecuteNonQuery()



        conexion2.Close()


        Button5.Enabled = False



    End Sub

    Private Sub delay(v As Integer)
        Throw New NotImplementedException()
    End Sub

    Private Sub data1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles data1.CellContentClick

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        datef.Text = Date.Now
        hour.Text = Format(Now, "H:mm:ss")




    End Sub

    Private Sub user_Click(sender As Object, e As EventArgs) Handles user.Click

    End Sub

    Private Sub time_ValueChanged(sender As Object, e As EventArgs) Handles time.ValueChanged

    End Sub

    Private Sub turno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles turno.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button1.Enabled = False
        If turno.Text = "" Then
            MsgBox("Por favor ingrese un turno a consultar", MsgBoxStyle.Critical, "Atención")
            data1.DataSource = Nothing
            Button5.Enabled = False
        Else
            If consultagenerada(time.Value.Date.ToShortDateString, turno.Text) = True Then




                MessageBox.Show("El reporte perteneciente a la fecha y turno seleccionado se encuentra en estado cerrado ")

                data1.DataSource = Nothing
                Button1.Enabled = False

                Button5.Enabled = False
                Label6.Visible = False
                Label7.Visible = False

            Else



                consulta()
                Button5.Enabled = True


                Label6.Visible = True
                Label7.Visible = True

                If data1.Rows.Count < 2 Then
                    MessageBox.Show("No exiten datos para el dia consultado")

                    Button5.Enabled = False

                End If


            End If

        End If


















    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If data1.DataSource Is Nothing Then

            MsgBox("Primero debe realizar una consulta", MsgBoxStyle.Critical, "Advertencia")
        Else

            data1.Sort(data1.Columns(2), ListSortDirection.Ascending)

        End If













    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        data1.DataSource = Nothing

        Dim salida As Form1
        salida = New Form1()
        salida.Show()
        Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click



        Dim conexion As SqlConnection
        conexion = New SqlConnection("Data Source=192.168.0.158;Initial Catalog=reportes;Persist Security Info=True;User ID=sa;Password=frigopesca2223+")
        conexion.Open()


        'carga de tabla al reporte


        For i = 0 To data1.Rows.Count - 1

            Dim fecha As String = datef.Text
            Dim fechat As String = data1.Rows(i).Cells(0).Value
            Dim fechacon As String = time.Value.ToShortDateString
            Dim turno As String = data1.Rows(i).Cells(1).Value
            Dim cedula As String = data1.Rows(i).Cells(2).Value
            Dim proceso As String = data1.Rows(i).Cells(3).Value
            Dim talla As String = data1.Rows(i).Cells(4).Value
            Dim lote As String = data1.Rows(i).Cells(5).Value
            Dim peso As String = data1.Rows(i).Cells(6).Value
            Dim supervisor As String = data1.Rows(i).Cells(6).Value


            Dim cadena As String = "insert into TEMP_PESOS(fecha, fechat, fechacon, turno, cedula, proceso, talla, lote, peso, supervisor)
            values ('" & fecha & "','" & fechat & "', '" & fechacon & "','" & turno & "','" & cedula & "','" & proceso & "','" & talla & "','" & lote & "','" & peso & "','" & supervisor & "')"

            Dim base As SqlCommand
            base = New SqlCommand(cadena, conexion)
            base.ExecuteNonQuery()
        Next

        Label3.Visible = True


        ProgressBar1.Visible = True



        For l As Integer = 1 To 7000

            ProgressBar1.Increment(l)


        Next l

        Dim monitoreo As reportepeso
        monitoreo = New reportepeso()
        monitoreo.Show()
            ProgressBar1.Visible = False
            Label3.Visible = False





        Button5.Enabled = False
        '

        Button1.Enabled = True


        Dim cadena2 As String = "truncate table TEMP_PESOS"

        Dim base2 As SqlCommand
        base2 = New SqlCommand(cadena2, conexion)
        base2.ExecuteNonQuery()










    End Sub

    Private Sub turno_TextChanged(sender As Object, e As EventArgs) Handles turno.TextChanged



















    End Sub

    Private Sub rrhh_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        conexionpeso.Close()

    End Sub


End Class