

Imports System.Data.SqlClient
Public Module Module1

    Public conexion As SqlConnection

    Public conexionpeso As SqlConnection
    Public conexionrol As SqlConnection
    Public comando As SqlCommand

    Public estado As String
    Public enunciado As SqlCommand
    Public respuesta As SqlDataReader
    Public adaptador As SqlDataAdapter
    Public tabla As DataTable



    Sub enlace()
        Try
            conexion = New SqlConnection("Data Source=192.168.0.158;Initial Catalog=reportes;Persist Security Info=True;User ID=sa;Password=frigopesca2223+")


            conexion.Open()
            estado = "conectado"


        Catch ex As Exception
            estado = "no conectado"
            MsgBox("No se pudo establecer conexiòn con el servidor", MsgBoxStyle.Critical, "Atención")


        End Try


    End Sub

    Sub enlacepeso()
        Try
            conexionpeso = New SqlConnection("Data Source=192.168.0.18;Initial Catalog=appfrigopesca;Persist Security Info=True;User ID=sa;Password=frigopesca2223+")

            conexionpeso.Open()




        Catch ex As Exception
            MsgBox("No se pudo establecer conexiòn con el servidor de pesos", MsgBoxStyle.Critical, "Atención")



        End Try


    End Sub
    Sub enlacerol()
        Try
            conexionrol = New SqlConnection("Data Source=192.168.0.158;Initial Catalog=reportes;Persist Security Info=True;User ID=sa;Password=frigopesca2223+")


            conexionrol.Open()
            estado = "conectado"


        Catch ex As Exception
            estado = "no conectado"
            MsgBox("No se pudo establecer conexiòn con el servidor sp", MsgBoxStyle.Critical, "Atención")



        End Try
    End Sub





















    Function consultagenerada(ByVal fechaconsulta As String, ByVal turnoconsulta As String) As Boolean
        Dim resultado As Boolean = False
        Try
            enunciado = New SqlCommand("Select * from ACT_USER where CONSULTA='" & fechaconsulta & "'   and  TURNOCON='" & turnoconsulta & "'  ", conexion)
            respuesta = enunciado.ExecuteReader

            If respuesta.Read Then
                resultado = True
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function


    Function usuarioRegistrado(ByVal nombreUsuario As String) As Boolean
        Dim resultado As Boolean = False
        Try
            enunciado = New SqlCommand("Select * from USUARIOS where usuario='" & nombreUsuario & "'", conexion)
            respuesta = enunciado.ExecuteReader

            If respuesta.Read Then
                resultado = True
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function

    Function contraseña(ByVal nombreUsuario As String) As String
        Dim resultado As String = ""
        Try
            enunciado = New SqlCommand("Select Contraseña from USUARIOS where usuario='" & nombreUsuario & "'", conexion)
            respuesta = enunciado.ExecuteReader

            If respuesta.Read Then
                resultado = respuesta.Item("Contraseña")
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function


    Function roluser(ByVal nombreUsuario As String) As String
        Dim resultado As Integer
        Try
            enunciado = New SqlCommand("Select rol from USUARIOS where usuario='" & nombreUsuario & "'", conexion)
            respuesta = enunciado.ExecuteReader

            If respuesta.Read Then
                resultado = respuesta.Item("rol")
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function



    Function actuser(ByVal nombreUsuario As String) As String
        Dim resultado As Integer
        Try
            enunciado = New SqlCommand("Select estado from USUARIOS where usuario='" & nombreUsuario & "'", conexion)
            respuesta = enunciado.ExecuteReader

            If respuesta.Read Then
                resultado = respuesta.Item("estado")
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function
End Module

