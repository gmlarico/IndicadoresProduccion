@Code
    Layout = "~/Views/Shared/_BaseLayout.vbhtml"
End Code

<div class="py-30 text-center">
    <div class="display-3 text-info">
        <i class="fa fa-lock"></i> 404
    </div>
    <h1 class="h2 font-w700 mt-30 mb-10">@Html.Raw("Vaya ... acabas de encontrar una página de error ...")</h1>
    <h2 class="h3 font-w400 text-muted mb-50">@Html.Raw("Lo sentimos, pero no se puede encontrar el recurso solicitado.")</h2>

    <a class="btn btn-hero btn-rounded btn-alt-secondary" href="/Login/Index">
        <i class="fa fa-arrow-left mr-10"></i> @Html.Raw("Volver al Inicio")
    </a>
</div>