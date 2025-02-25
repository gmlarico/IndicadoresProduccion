Imports System.Web.Mvc
Imports Newtonsoft.Json
Imports Resinplast.Indicadores.Wrapper
Imports Resinplast.Indicadores.Web.SeguridadService
Imports Resinplast.Indicadores.Web.Models
Imports Resinplast.Indicadores.Web.Models.Base
Imports Resinplast.Indicadores.Utils


Namespace Resinplast.Indicadores.Web
    Public Class MantenimientoController
        Inherits System.Web.Mvc.Controller


        Public OSeguridadServicio As New SeguridadService.AutenticacionClient()

        Function CambioContraseña() As ActionResult
            Return View()
        End Function


        Public Function ActualizarContrasena(ByVal Contrasena As String) As JsonResult
            Dim result As BaseResponse = New BaseResponse()
            OSeguridadServicio = New SeguridadService.AutenticacionClient()

            Try

                Dim IdUsuario = Session("sUsuario")



                If (IdUsuario = Nothing Or IdUsuario = "") Then
                    result.CodigoError = 1
                    result.DescripcionError = "Usuario no valido para el cambio de contraseña"

                Else

                    Dim ListMantenientoContraseña = OSeguridadServicio.ActualizarContrasena(New SeguridadService.UsuariosRequest() With {
                                                                                     .IdUsuario = IdUsuario,
                                                                                     .Contrasena = Contrasena,
                                                                                     .UsuarioModificacion = IdUsuario
                                                                                     })

                    OSeguridadServicio.Close()

                    If ListMantenientoContraseña.CodigoError = 0 Then
                        result.CodigoError = 0
                    End If

                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Return Json(result)

        End Function


    End Class
End Namespace

