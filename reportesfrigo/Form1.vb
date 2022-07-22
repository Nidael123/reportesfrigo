Public Class Form1
    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        enlace()

    End Sub

    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles ingresar.Click
        Try
            If usuarioRegistrado(txtuser.Text) = True Then
                Dim contra As String = contraseña(txtuser.Text)
                Dim area As Integer = roluser(txtuser.Text)
                Dim activo As Integer = actuser(txtuser.Text)
                If activo.Equals(1) Then

                    If contra.Equals(txtpass.Text) = True Then

                        If area.Equals(1) Then

                            TextBox1.Text = txtuser.Text
                            rrhh.Show()
                            rrhh.user.Text = TextBox1.Text
                            Hide()
                        ElseIf (area.Equals(2)) Then
                            rol.Show()
                            Hide()
                        Else
                            logistica.Show()
                            Hide()

                        End If


                    Else
                        MsgBox("Contraseña Invalida", MsgBoxStyle.Critical, "Advertencia")
                    End If


                Else
                    MsgBox("El usuario se encuentra inactivo", MsgBoxStyle.Critical, "Advertencia")
                End If
            Else
                MsgBox("El Usuario: " + txtuser.Text + " no se encuentra registrado", MsgBoxStyle.Critical, "Advertencia")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub






    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        conexion.Close()
    End Sub

    Private Sub ingresar_Click(sender As Object, e As EventArgs) Handles ingresar.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
