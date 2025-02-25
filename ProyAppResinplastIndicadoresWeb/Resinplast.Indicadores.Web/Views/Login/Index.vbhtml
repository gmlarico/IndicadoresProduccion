@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head runat="server">

    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0, shrink-to-fit=no">
    <link rel="icon" type="image/jpg" sizes="192x192" href="../Content/assets/media/favicons/ResinplastLogo.jpg">
    <title>Resinplast S.A. - Indicadores</title>
    <meta name="description" content="Indicadores de produccion - Resinplast">
    <meta name="author" content="Resinplast">
    <meta name="robots" content="web">

    @*<link rel="stylesheet" id="css-main" href="Content/assets/css/codebase.min.css">*@

    <!-- END Stylesheets -->

    @Styles.Render("~/content/specials/css")
    @Styles.Render("~/content/css")
    @Styles.Render("~/content/plugins/css")

    <!-- JQuery -->
    @Scripts.Render("~/bundles/core")
    @Scripts.Render("~/bundles/plugins")
    @Scripts.Render("~/bundles/components")

    @*@Styles.Render("~/Content/css")
        @Scripts.Render("~/bundles/modernizr")*@

</head>
<body>
    <div id="page-container" class="main-content-boxed">
        <!-- Main Container -->
        <main id="main-container">

            <!-- Page Content -->
            <div class="bg-image" style="background-image: url('../Imagenes/Login/FondoWebResinplast.jpg');">
                <div class="row mx-0 bg-black-op">
                    <div class="hero-static col-md-6 col-xl-8 d-none d-md-flex align-items-md-end">
                        <div class="p-30 invisible" data-toggle="appear">
                            <p class="font-size-h3 font-w600 text-white">
                                RESINPLAST S.A.
                            </p>
                            <p class="font-italic text-white-op">
                                Copyright &copy; <span class="js-year-copy"></span>
                            </p>
                        </div>
                    </div>
                    <div class="hero-static col-md-6 col-xl-4 d-flex align-items-center bg-white invisible" data-toggle="appear" data-class="animated fadeInRight">
                        <div class="content content-full">
                            <!-- Header -->
                            <div class="px-30 py-10">
                                <h1 class="h3 font-w700 mt-30 mb-10">Bienvenido</h1>
                                <h2 class="h5 font-w400 text-muted mb-0">Por favor autenticarse</h2>
                            </div>
                            <!-- END Header -->
                            <!-- Sign In Form -->
                            @*<form class="js-validation-signin px-30" action="be_pages_auth_all.html" method="post">*@
                            <form method="post">
                                <div class="form-group row">
                                    <div class="col-12">
                                        <div class="form-material floating">
                                            <input id="txtUsuario" type="text" class="form-control" id="login-username" name="login-username">
                                            <label for="login-username">Usuario</label>
                                        </div>
                                    </div>
                                </div>
                                <div class="form-group row">
                                    <div class="col-12">
                                        <div class="form-material floating">
                                            <input id="txtPassword" type="password" class="form-control" id="login-password" name="login-password">
                                            <label for="login-password">Contraseña</label>
                                        </div>
                                    </div>
                                </div>
                                <div class="form-group">

                                </div>
                            </form>
                            <button id="btnIngresar" class="btn btn-sm btn-hero btn-alt-success">
                                Ingresar
                            </button>

                            <!-- END Sign In Form -->
                        </div>
                    </div>
                </div>
            </div>
            <!-- END Page Content -->
        </main>
        <!-- END Main Container -->
    </div>
    @Scripts.Render("~/bundles/jquery")
    @*<!-- END Page Container -->
        <script src="Content/assets/js/codebase.core.min.js"></script>
        <script src="Content/assets/js/codebase.app.min.js"></script>
        <!-- Page JS Plugins -->
        <script src="Content/assets/js/plugins/jquery-validation/jquery.validate.min.js"></script>
        <!-- Page JS Code -->
        <script src="Content/assets/js/pages/op_auth_signin.min.js"></script>*@
    @*<script type="text/javascript" src="~/Scripts/View/Login/Index.js"></script>*@
</body>
</html>

<script>
    $(document).ready(function () {
        sessionStorage.clear()
        $("#btnIngresar").click(function () {
            var txtUsuario = $("#txtUsuario").val();
            var txtPassword = $("#txtPassword").val();

            try {
                $.post("/Login/Validar", { "Usuario": txtUsuario, "Password": txtPassword },
                    function (data) {

                        if (data.length > 0) {
                            sessionStorage.setItem('Usuario', txtUsuario);

                            $.each(data, function (k) {

                            });

                            $(location).attr('href', '/Impresion/General')

                        } else {
                            var Mensaje = new Resinplast.Indicadores.Web.Components.Message()
                            Mensaje.Success({ message: 'El usuario ' + txtUsuario + ' no existe o los datos ingresados son incorrectos.' });
                        }


                        //if (data == 'OK') {

                        //    sessionStorage.setItem('Usuario', txtUsuario);

                        //    $(location).attr('href', '/Principal/IndicadoresGeneral')

                        //} else {
                        //    var Mensaje = new Resinplast.Indicadores.Web.Components.Message()
                        //    Mensaje.Success({ message: 'El usuario ' + txtUsuario + ' no existe o los datos ingresados son incorrectos.' });
                        //    //alert("El usuario " + txtUsuario + " no existe.");
                        //}

                    });

            } catch (ex) {
                alert(ex.message);
                $(location).attr('href', '/Error/ErrorApplication')
            }
        });

    })

    // id global de boton enter "13"
    $(document).on('keypress', function (e) {
        if (e.which == 13) {

            $("#btnIngresar").click();

            //var txtUsuario = $("#txtUsuario").val();
            //var txtPassword = $("#txtPassword").val();

            //try {
            //    $.post("/Login/Validar", { "Usuario": txtUsuario, "Password": txtPassword },
            //        function (data) {
            //            if (data == 'OK') {
            //                sessionStorage.setItem('Usuario', txtUsuario);
            //                $(location).attr('href', '/Principal/IndicadoresGeneral')
            //            } else {
            //                //alert("El usuario " + txtUsuario + " no existe.");
            //                var Mensaje = new Resinplast.Indicadores.Web.Components.Message()
            //                Mensaje.Success({ message: 'El usuario ' + txtUsuario + ' no existe o los datos ingresados son incorrectos.' });
            //            }
            //        });

            //} catch (ex) {
            //    alert(ex.message);
            //    $(location).attr('href', '/Errores/Error404')
            //}
        }
    });

</script>
