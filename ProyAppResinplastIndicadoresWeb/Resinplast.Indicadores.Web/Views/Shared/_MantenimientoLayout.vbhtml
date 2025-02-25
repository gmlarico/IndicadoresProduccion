@Imports Resinplast.Indicadores.Utils
@Imports Resinplast.Indicadores.Web.Resources
<!DOCTYPE html>
<html lang="es" Class="no-focus">
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0, user-scalable=0">

    <title>@Html.Raw("Resinplast S.A. - Indicadores")</title>

    @*<meta name="description" content="@Html.Raw(LayoutResource.TitleContent)">
        <meta name="author" content="@Html.Raw(LayoutResource.CompanyLabel)">
        <meta name="robots" content="noindex, nofollow">*@

    <!-- Open Graph Meta -->
    <!-- Icons -->
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0, shrink-to-fit=no">
    <link rel="icon" type="image/jpg" sizes="192x192" href="~/Content/assets/media/favicons/ResinplastLogo.jpg">
    <title>Resinplast S.A. - Indicadores</title>
    <meta name="description" content="Indicadores de tareas de producción de diseño">
    <meta name="author" content="Resinplast">
    <meta name="robots" content="web">
    <!-- Css -->
    @*<link rel="stylesheet" type="text/css" href="@Url.Content(" ~/Content/codebase.css")" />*@

    <!-- JQuery -->
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
    <div id="page-container" class="">
        <!-- Side Overlay-->
       
        <!-- END Side Overlay -->
        <!-- Sidebar -->
   

            <!-- Header -->
            <header id="page-header">
                <!-- Header Content -->
                <div Class="content-header">
                    <!-- Left Section -->
                    <div Class="content-header-section">
                        <!-- Toggle Sidebar -->
                        <!-- Layout API, functionality initialized in Codebase() -> uiApiLayout() -->
                        <Button type="button" Class="btn btn-circle btn-dual-secondary" style="min-width: 45px;height: 45px;" id="btnRegresoMenuPrincipal">
                            <i Class="fa fa-arrow-circle-left fa-2x"></i>
                        </Button>
                        <!-- END Toggle Sidebar -->
                    </div>
                    <!-- END Left Section -->
                    <!-- Right Section -->
                    <div Class="content-header-section">
                        <!-- User Dropdown -->
                        <div Class="btn-group" role="group">
                            <Button type="button" Class="btn btn-rounded btn-dual-secondary" id="page-header-user-dropdown" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
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
    

        @RenderSection("scripts", required:=False)

        @Scripts.Render("~/bundles/componentsExtern")

    </body>
</html>


<script>

    $(document).ready(function () {     
        $("#btnRegresoMenuPrincipal").click(function () {
            $(location).attr('href', '/Indicadores/Index')               
        });

    })



</script>>