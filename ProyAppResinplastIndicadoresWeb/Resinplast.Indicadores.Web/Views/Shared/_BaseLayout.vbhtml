
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
    <link rel="shortcut icon" href="@Url.Content(" ~/Images/favicons/favicon.png")">
    <link rel="icon" type="image/png" sizes="192x192" href="@Url.Content(" ~/Images/favicons/favicon-192x192.png")">
    <link rel="apple-touch-icon" sizes="180x180" href="@Url.Content(" ~/Images/favicons/apple-touch-icon-180x180.png")">

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
</head>
<body>
    <!-- Page Container -->
    <div id="page-container" class="main-content-boxed">
        <!-- Main Container -->
        <main id="main-container">
            <!-- Page Content -->
            <div class="hero bg-white">
                <div class="hero-inner">
                    @*@RenderSection("featured", required:     false)*@
                    <div class="content content-full">
                        @RenderBody()
                    </div>
                </div>
            </div>
            <!-- END Page Content -->
        </main>
        <!-- END Main Container -->
    </div>
    <!-- END Page Container -->
    @*@RenderSection("scripts", required:     false)*@
</body>
</html>