try {
    ns('Resinplast.Indicadores.Web.Layout');
    $(document).ready(function () {
        'use strict';
        Resinplast.Indicadores.Web.Layout.Index.Page = new Resinplast.Indicadores.Web.Layout.Index.Controller();
        Resinplast.Indicadores.Web.Layout.Index.Page.Ini();
    });
} catch (ex) {
    alert(ex.message);
}