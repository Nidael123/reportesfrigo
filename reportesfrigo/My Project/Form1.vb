Imports System.Data.SqlClient

Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        enlace()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub


    Private Sub Textbox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = ChrW(8) Then

            e.Handled = False
        Else

            If Not IsNumeric(e.KeyChar) Then
                e.Handled = True
            End If


        End If


    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub aprobar_Click(sender As Object, e As EventArgs) Handles aprobar.Click
        Dim a As Integer
        a = Val(TextBox1.Text)
        Dim numero As String = TextBox1.Text
        If TextBox1.Text = "" Then


            MsgBox("Por favor ingrese el número de solicitud", MsgBoxStyle.Critical, "Atención")


        ElseIf a = 0 Then


            MsgBox("Por favor ingrese el número de solicitud correctamente", MsgBoxStyle.Critical, "Atención")


        Else


            comando = New SqlCommand("SP_APRO_SOL_ETIQUETAS", conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@solicitud", numero)
            comando.ExecuteNonQuery()


            Dim existe As Integer
            If ListBox1.Items.Count = 0 Then
                ListBox1.Items.Add("                 " + TextBox1.Text)
                MsgBox("Solicitud aprobada con éxito", MsgBoxStyle.Exclamation, "Atención")
            Else


                For Each item As String In ListBox1.Items


                    If LTrim(item).ToString = numero Then

                        existe = 1

                    End If

                Next

                If existe = 1 Then


                    MsgBox("Solicitud fue aprobada reciéntemente", MsgBoxStyle.Critical, "Atención")

                Else
                    ListBox1.Items.Add("                 " + TextBox1.Text)
                    MsgBox("Solicitud aprobada con éxito", MsgBoxStyle.Exclamation, "Atención")
                End If







            End If

        End If







    End Sub
End Class
