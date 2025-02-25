try {
    ns('Resinplast.Indicadores.Web.Home.Index');
    $(document).ready(function () {
        'use strict';
        Resinplast.Indicadores.Web.Home.Index.Page = new Resinplast.Indicadores.Web.Home.Index.Controller();
        Resinplast.Indicadores.Web.Home.Index.Page.Ini();
    });
} catch (ex) {
    alert(ex.message);
}