Imports System.Data.SqlClient

Public Class rol
    Public conexion As SqlConnection
    Public comando As SqlCommand
        Public conexionrol As SqlConnection
    Public estado As String
    Public enunciado As SqlCommand
    Public respuesta As SqlDataReader
    Public adaptador As SqlDataAdapter
    Public tabla As DataTable
    Public dia, mes, año As String
    Public MiReporte As Object

    Private Sub rol_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        enlacerol()
        Dim filas As Integer


        Try


            Dim numero As String = factura.Text
            Dim conexionrol2 As SqlConnection
            conexionrol2 = New SqlConnection("Data Source=192.168.0.158;Initial Catalog=reportes;Persist Security Info=True;User ID=sa;Password=frigopesca2223+")


            conexionrol2.Open()
            'estado = "conectado"
            'MessageBox.Show("Conexiòn exitosa al Servidor sp")
            If factura.Text = "" Then

                MsgBox("Por favor ingrese un nùmero de factura a consultar", MsgBoxStyle.Critical, "Atención")

            Else

                comando = New SqlCommand("SP_HOJAMOVIENTO", conexionrol2)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@factura", numero)
                filas = comando.ExecuteNonQuery()
            End If




            If filas > 0 Then
                ProgressBar1.Visible = True
                Label5.Visible = True

                For l As Integer = 1 To 10000

                    ProgressBar1.Increment(l)


                Next l




                Dim monitoreo As reportehojamovi
                monitoreo = New reportehojamovi()
                monitoreo.Show()
                ProgressBar1.Visible = False
                Label5.Visible = False

            Else
                MsgBox("No se encontraron datos, compruebe que el número de factura sea el correcto", MsgBoxStyle.Exclamation, "Atención")
            End If


        Catch ex As Exception



        End Try '




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        enlacerol()
        Dim filas As Integer


        Try


            Dim numero As String = factura.Text
            Dim conexionrol2 As SqlConnection
            conexionrol2 = New SqlConnection("Data Source=192.168.0.158;Initial Catalog=reportes;Persist Security Info=True;User ID=sa;Password=frigopesca2223+")


            conexionrol2.Open()
            'estado = "conectado"
            'MessageBox.Show("Conexiòn exitosa al Servidor sp")
            If factura.Text = "" Then

                MsgBox("Por favor ingrese un nùmero de factura a consultar", MsgBoxStyle.Critical, "Atención")

            Else

                comando = New SqlCommand("SP_ORIGENMP", conexionrol2)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@factura", numero)
                filas = comando.ExecuteNonQuery()
            End If





            If filas > 0 Then
                ProgressBar1.Visible = True
                Label5.Visible = True

                For l As Integer = 1 To 10000

                    ProgressBar1.Increment(l)


                Next l

                Dim monitoreo As reporteorigen
                monitoreo = New reporteorigen()
                monitoreo.Show()
                ProgressBar1.Visible = False
                Label5.Visible = False
            Else
                MsgBox("No se encontraron datos, compruebe que el número de factura sea el correcto", MsgBoxStyle.Exclamation, "Atención")
            End If


        Catch ex As Exception



        End Try '



































    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        factura.Text = ""
        Dim salida As Form1
        salida = New Form1()
        salida.Show()
        Hide()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles factura.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles factura.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            If Not e.KeyChar = ChrW(8) Then
                e.Handled = True
            End If
        End If
    End Sub

End Class