@Imports Resinplast.Indicadores.Utils
@Imports Resinplast.Indicadores.Web.Resources
<!DOCTYPE html>
<html>
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0, shrink-to-fit=no">
    <link rel="icon" type="image/jpg" sizes="192x192" href="~/Content/assets/media/favicons/ResinplastLogo.jpg">
    <title>Resinplast S.A. - Indicadores</title>
    <meta name="description" content="Indicadores de tareas de producción de diseño">
    <meta name="author" content="Resinplast">
    <meta name="robots" content="web">

    @Styles.Render("~/content/specials/css")
    @Styles.Render("~/content/css")
    @Styles.Render("~/content/plugins/css")

    <!-- JQuery -->
    @Scripts.Render("~/bundles/core")
    @Scripts.Render("~/bundles/plugins")
    @Scripts.Render("~/bundles/components")

    <script type="text/javascript">
        ns('Resinplast.Indicadores.Web.Global.Format');
        Resinplast.Indicadores.Web.Global.Format.Date = '@Enumerated.ConfigurationInitial.FormatDate';
        Resinplast.Indicadores.Web.Global.Format.DateTime = '@Enumerated.ConfigurationInitial.FormatDateTime';
        Resinplast.Indicadores.Web.Global.Format.DateGrid = '@Enumerated.ConfigurationInitial.FormatDateGrid';
        Resinplast.Indicadores.Web.Global.Format.DateTimeGrid = '@Enumerated.ConfigurationInitial.FormatDateTimeGrid';
        Resinplast.Indicadores.Web.Global.Format.DateTimeFilter = '@Enumerated.ConfigurationInitial.FormatDateFilter';
        Resinplast.Indicadores.Web.Global.Format.HourGrid = '@Enumerated.ConfigurationInitial.FormatHourGrid';

        ns('Resinplast.Indicadores.Web.Global.Format');
        Resinplast.Indicadores.Web.Global.Format.Language = "es-ES";

        ns('Resinplast.Indicadores.Web.Global.Grid.Options');
        Resinplast.Indicadores.Web.Global.Grid.Options.PagerpageSize = '@Enumerated.ConfigurationInitial.RowsPerPage';
        Resinplast.Indicadores.Web.Global.Grid.Options.PreventPageState= @(Html.Raw(Json.Encode(IIf(ViewBag.MantienePaginacion! = Nothing, ViewBag.MantienePaginacion, Nothing))));

        //Resinplast.Indicadores.Web.Global.Grid.Acciones.ValidarSeguridad = function (accion, seguridad, title) {
        //    var cadena = "";

        //    if (title == undefined || title == null || title == '') {
        //        title = accion.title;
        //    }

        //    if (seguridad.Visible) {
        //        cadena += '<a data-toggle="tooltip" style="cursor:pointer;margin-left:4px"'
        //        var identificador = '';

        //        if (seguridad.Enabled) {
        //            cadena += ' title="' + title + '" ';
        //            identificador = accion.id;
        //        } else {
        //            cadena += ' class="enabled" ';
        //        }

        //        //cadena += '><i class="' + accion.icon + ' ' + identificador + '"></i></a>';
        //        if (accion.color != '') {
        //            cadena += '><i class="' + accion.icon + ' ' + identificador + '" style="color:' + accion.color + ';"></i></a>';
        //        }
        //        else {
        //            cadena += '><i class="' + accion.icon + ' ' + identificador + '"></i></a>';
        //        }
        //    }

        //    return cadena;
        //};

        //Resinplast.Indicadores.Web.Global.Grid.Acciones.ValidarSeguridadLink = function (accion, seguridad, url, parametro, title) {
        //    var cadena = "";

        //    if (title == undefined || title == null || title == '') {
        //        title = accion.title;
        //    }

        //    if (seguridad.Visible) {
        //        cadena += '<a data-toggle="tooltip" style="cursor:pointer;margin-left:4px"'
        //        var identificador = '';

        //        if (seguridad.Enabled) {
        //            cadena += ' title="' + title + '" ';
        //            cadena += ' href="' + url + "/" + parametro + '" ';
        //            identificador = accion.id;
        //        } else {
        //            cadena += ' class="enabled" ';
        //        }

        //        cadena += '><i class="' + accion.icon + ' ' + identificador + '"></i></a>';
        //    }

        //    cadena = cadena.replace("//", "/");
        //    return cadena;
        //};



        ns('Resinplast.Indicadores.Web.Global.Politicas');
        var ancho = 1100;
        var alto = 600;
        var posicion_x;
        var posicion_y;

        posicion_x = (screen.width / 2) - (ancho / 2);
        posicion_y = (screen.height / 2) - ((alto + 100) / 2);

        Resinplast.Indicadores.Web.Global.Politicas.Reportes = {
            SePresentaPopup: false,
            FormatoPresentacion: {
                Horizontal: "width=" + ancho + ", height=" + alto + ", menubar=0, toolbar=0, directories=0, scrollbars=no, resizable=no, left=" + posicion_x + ", top=" + posicion_y + "",
                Vertical: 'width=700, height=500'
            }
        };

    </script>

</head>
<body>
    <!-- Page Container -->
    <div id="page-container" class="sidebar-o side-scroll page-header-modern page-header-fixed">
        <!-- Side Overlay-->
        <aside id="side-overlay">
            <!-- Side Overlay Scroll Container -->
            <div id="side-overlay-scroll">
                <!-- Side Header -->
                <div class="content-header content-header-fullrow">
                    <div class="content-header-section align-parent">
                        <!-- Close Side Overlay -->
                        <!-- Layout API, functionality initialized in Codebase() -> uiApiLayout() -->
                        <button type="button" class="btn btn-circle btn-dual-secondary align-v-r" data-toggle="layout" data-action="side_overlay_close">
                            <i class="fa fa-times text-primary"></i>
                        </button>
                        <!-- END Close Side Overlay -->
                        <!-- User Info -->
                        <div class="content-header-item">
                            <a class="img-link mr-5" href="#">
                                @*<img class="img-avatar img-avatar32" src="@Url.Content("~/Images/avatars/avatar0.jpg")" alt="">*@
                            </a>
                            <a class="align-middle link-effect text-primary-dark font-w600" href="#">Resinplast S.A.</a>
                        </div>
                        <!-- END User Info -->
                    </div>
                </div>
                <!-- END Side Header -->
                <!-- Side Content -->
                <div class="content-side">
                </div>
                <!-- END Side Content -->
            </div>
            <!-- END Side Overlay Scroll Container -->
        </aside>
        <!-- END Side Overlay -->
        <!-- Sidebar -->
        <nav id="sidebar">
            <!-- Sidebar Scroll Container -->
            <div id="sidebar-scroll">
                <!-- Sidebar Content -->
                <div class="sidebar-content">
                    <!-- Side Header -->
                    <div class="content-header content-header-fullrow px-15">
                        <!-- Normal Mode -->
                        <div class="content-header-section text-center align-parent sidebar-mini-hidden">
                            <!-- Close Sidebar, Visible only on mobile screens -->
                            <!-- Layout API, functionality initialized in Codebase() -> uiApiLayout() -->
                            <button type="button" class="btn btn-circle btn-dual-secondary d-lg-none align-v-r" data-toggle="layout" data-action="sidebar_close">
                                <i class="fa fa-times text-primary"></i>
                            </button>
                            <!-- END Close Sidebar -->
                            <!-- Logo -->
                            <div class="content-header-item">
                                <a class="link-effect font-w700" href="#">
                                    @*<img class="img-link" src="@Url.Content("~/Images/logoDinet02.png")" style="max-height: 55px" />*@
                                </a>
                            </div>
                            <!-- END Logo -->
                        </div>
                        <!-- END Normal Mode -->
                    </div>
                    <!-- END Side Header -->
                    <!-- Side User -->
                    <div class="content-side content-side-full content-side-user px-10 align-parent">
                        <!-- Visible only in normal mode -->
                        <div class="sidebar-mini-hidden-b text-center">
                            @*<a class="img-link" href="be_pages_generic_profile.html">*@
                            <img class="img-avatar img-avatar96" src="@Url.Content("~/Imagenes/General/LOGO_RESI.png")" alt="" style="border-radius:11%">
                            @*</a>*@
                            <ul class="list-inline mt-10">
                                <li class="list-inline-item">
                                    <a class="link-effect text-dual-primary-dark font-size-xs font-w600 text-uppercase" href="https://www.resinplast.com.pe/">Resinplast S.A.</a>
                                </li>
                            </ul>
                        </div>
                        <!-- END Visible only in normal mode -->
                    </div>
                    <!-- END Side User -->
                    <!-- Side Navigation -->
                    <div class="content-side content-side-full pt-5">
                        <ul id="ulMenuGeneral" class="nav-main">
                            <li class="nav-main-item">
                                <a href="#"><i class="si si-home"></i><span class="sidebar-mini-hide">Resinplast Indicadores</span></a>
                            </li>
                            <li class="nav-main-item open">

                                @code
                                    Dim nImpresion As Integer = 0
                                    Dim nDiseño As Integer = 0
                                    Dim ncotizaciones As Integer = 0
                                    Dim nCountProceso As Integer = 0
                                    Dim nCountReporteGerencia As Integer = 0
                                    Dim nCountAuditoria As Integer = 0
                                    Dim nCountControlInterno As Integer = 0
                                End Code

                                @Try

                                    @For Each item In Session("lstPermisos")
                                        If item.IdDocumento = "INDIMPRE" Then
                                            nImpresion = nImpresion + 1
                                        End If
                                    Next

                                    @For Each item In Session("lstPermisos")
                                        If item.IdDocumento = "INDDISEÑ" Then
                                            nDiseño = nDiseño + 1
                                        End If
                                    Next
                                    @For Each item In Session("lstPermisos")
                                        If item.IdDocumento = "INDCOTIZ" Then
                                            ncotizaciones = ncotizaciones + 1
                                        End If
                                    Next

                                    @If nImpresion >= 1 Then
                                        @<li class="nav-main-item" id="menuImpresion">
                                        <a class="nav-submenu" data-toggle="nav-submenu" href="#"><i class="fa fa-print"></i><span class="sidebar-mini-hide">Impresión</span></a>
                                        <ul>
                                            @For Each item In Session("lstPermisos")
                                                If item.IdDocumento = "INDIMPRE" Then
                                                @<li class="@item.IdDocumento">
                                                    <a href="@Url.Content("~/Impresion/General")">
                                                        Indicadores
                                                    </a>
                                                </li>
                                                End If
                                            Next
                                        </ul>
                                    </li>
                                    End If


                                    @If nDiseño >= 1 Then
                                        @<li class="nav-main-item" id="menuDiseño">
                                            <a class="nav-submenu" data-toggle="nav-submenu" href="#"><i class="fa fa-file-photo-o"></i><span class="sidebar-mini-hide">Diseño</span></a>
                                            <ul>
                                                @For Each item In Session("lstPermisos")
                                                    If item.IdDocumento = "INDDISEÑ" Then
                                                        @<li class="@item.IdDocumento">
                                                             <a href="@Url.Content("~/Diseno/General")">
                                                                 Indicadores
                                                             </a>
                                                        </li>
                                                    End If
                                                Next
                                            </ul>
                                        </li>
                                    End If

                                    @If ncotizaciones >= 1 Then
                                        @<li class="nav-main-item" id="menuCotizacion">
                                            <a class="nav-submenu" data-toggle="nav-submenu" href="#"><i class="fa fa-file-text"></i><span class="sidebar-mini-hide">Cotizaciones</span></a>
                                            <ul>
                                                @For Each item In Session("lstPermisos")
                                                    If item.IdDocumento = "INDCOTIZ" Then
                                                        @<li class="@item.IdDocumento">
                                                            <a  href="">
                                                                Indicadores
                                                            </a>
                                                        </li>
                                                    End If
                                                Next
                                            </ul>
                                        </li>
                                    End If



                                Catch ex As Exception
                                    Response.Redirect("/Error/ErrorApplication")
                                End Try
                            </li>




                        </ul>
                    </div>
                    <!-- END Side Navigation -->
                </div>
                <!-- Sidebar Content -->
            </div>
            <!-- END Sidebar Scroll Container -->
        </nav>

        <!-- Header -->
        <header id = "page-header" >
        <!-- Header Content -->
            <div Class="content-header">
                <!-- Left Section -->
                <div Class="content-header-section">
                    <!-- Toggle Sidebar -->
                    <!-- Layout API, functionality initialized in Codebase() -> uiApiLayout() -->
                    <Button type = "button" Class="btn btn-circle btn-dual-secondary" data-toggle="layout" data-action="sidebar_toggle">
                        <i Class="fa fa-navicon"></i>
                    </Button>
                    <!-- END Toggle Sidebar -->
                </div>
                <!-- END Left Section -->
                <!-- Right Section -->
                <div Class="content-header-section">
                    <!-- User Dropdown -->
                    <div Class="btn-group" role="group">
                        <Button type = "button" Class="btn btn-rounded btn-dual-secondary" id="page-header-user-dropdown" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                            Usuario Conectado :   @Session("sUsuario")<i class="fa fa-angle-down ml-5"></i>
                        </Button>
                        <div class="dropdown-menu dropdown-menu-right min-width-150" aria-labelledby="page-header-user-dropdown">
                            <a class="dropdown-item" href="@Url.Content("~/Mantenimiento/CambioContraseña")">
                                    <i class="fa fa-gear mr-5"></i> @Html.Raw(GeneralResource.EtiquetaContraseña)
                                </a>
                            <div class="dropdown-divider"></div>
                            <a id="btndesconectar" class="dropdown-item" href="@Url.Content("~/Login/index")">
                                <i class="si si-logout mr-5"></i>@Html.Raw(GeneralResource.EtiquetaDesconectar)                                
                            </a>
                        </div>
                    </div>
                    <!-- END User Dropdown -->
                    <!-- Toggle Side Overlay -->
                    <!-- Layout API, functionality initialized in Codebase() -> uiApiLayout() -->
                    @*<button type="button" class="btn btn-circle btn-dual-secondary" data-toggle="layout" data-action="side_overlay_toggle">
                            <i class="fa fa-tasks"></i>
                        </button>*@
                    <!-- END Toggle Side Overlay -->
                </div>
                <!-- END Right Section -->
            </div>
            <!-- END Header Content -->
        </header>

        <!-- Main Container -->
        <main id="main-container">
            <!-- Page Content -->
            @RenderSection("featured", required:=False)
            <div id="divRenderBody" class="content">
                @RenderBody()
            </div>
            <!-- END Page Content -->
        </main>
        <!-- END Main Container -->

        <footer id="page-footer">
            <div class="content py-20 font-size-sm clearfix" style="max-width: 100%">

                <div class="float-right">
                    <a class="font-w600" target="_blank">Resinplast S.A</a> &copy; <span class="js-year-copy"></span>
                </div>
            </div>
        </footer>
    </div>
    <!-- END Page Container -->
    @*@Scripts.Render("~/bundles/jquery")*@
    @*<script src="~/Content/assets/js/codebase.core.min.js"></script>*@
    @*<script src="~/Content/assets/js/codebase.app.min.js"></script>*@
    @*<script type="text/javascript" src="~/Scripts/View/OrdenTrabajo/ListarOrdenesTrabajo.js"></script>*@
    @*@RenderSection("scripts", required:=False)*@


    @*<script type="text/javascript" src="~/Scripts/View/Layout/Controller.js"></script>
        <script type="text/javascript" src="~/Scripts/View/Layout/Index.js"></script>*@

    @RenderSection("scripts", required:=False)

    @Scripts.Render("~/bundles/componentsExtern")



    @*@RenderBody()

        @Scripts.Render("~/bundles/jquery")
        @RenderSection("scripts", required:=False)*@
</body>
</html>
