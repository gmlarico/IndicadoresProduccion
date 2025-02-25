Imports Resinplast.Indicadores.Web.SeguridadService

Namespace Resinplast.Indicadores.Web
    Public Class LoginController
        Inherits Controller

        Public OSeguridadServicio As New SeguridadService.AutenticacionClient()

        Function Index() As ActionResult
            Return View()
        End Function

        ''' <summary>
        ''' Validr datos de autenticacion
        ''' </summary>
        ''' <param name="Usuario"></param>
        ''' <param name="Password"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function Validar(ByVal Usuario As String, ByVal Password As String) As JsonResult

            OSeguridadServicio = New SeguridadService.AutenticacionClient()

            Dim lstDocumentoPermisoEL As New List(Of DocumentoPermisoEL)()


            Dim lstPerfilAcceso As SeguridadService.AutenticacionResponse = OSeguridadServicio.ListarPermisos(New AutenticacionRequest() With {
                                                                .IdSistema = ConfigurationManager.AppSettings("CodigoTipoAplicacion").ToString(),
                                                                .IdAplicacion = ConfigurationManager.AppSettings("CodigoSistema").ToString(),
                                                                .IdUsuario = Usuario,
                                                                .Contrasena = Password
                                                            })

            OSeguridadServicio.Close()


            If lstPerfilAcceso.ListaPermisos.Count() > 0 Then
                Session("sUsuario") = Usuario
                If lstPerfilAcceso.ListaPermisos(0).ListaAplicaciones.Count > 0 Then
                    If lstPerfilAcceso.ListaPermisos(0).ListaAplicaciones(0).ListaDocumentos.Count > 0 Then
                        lstDocumentoPermisoEL = lstPerfilAcceso.ListaPermisos(0).ListaAplicaciones(0).ListaDocumentos.ToList()
                    Else
                        lstDocumentoPermisoEL = New List(Of DocumentoPermisoEL)()
                    End If
                Else
                    lstDocumentoPermisoEL = New List(Of DocumentoPermisoEL)()
                End If

                If lstDocumentoPermisoEL.Count > 0 Then
                    Session("lstPermisos") = lstDocumentoPermisoEL
                Else
                    Session("lstPermisos") = Nothing
                End If

            End If

            Return Json(lstDocumentoPermisoEL)

        End Function

    End Class

End Namespace

