try {
    ns('Resinplast.Indicadores.Web.Login.Index');
    $(document).ready(function () {
        'use strict';
        Resinplast.Indicadores.Web.Login.Index.Page = new Resinplast.Indicadores.Web.Login.Index.Controller();
        Resinplast.Indicadores.Web.Login.Index.Page.Ini();
    });
} catch (ex) {
    alert(ex.message);
}