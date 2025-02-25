ns('Resinplast.Indicadores.Web.Login.Index.Controller');
Resinplast.Indicadores.Web.Login.Index.Controller = function () {
    var base = this;
    base.Ini = function (opts) {
        'use strict';
        base.Control.Validador = new Resinplast.Indicadores.Web.Components.Validator({
            form: 'frmLogin'
        });

        //base.Control.slcCentroDistribucion().change(base.Event.ListarCuentas);

        base.Control.btnIngresar().click(base.Event.BtnContinuarClick);
        //base.Control.btnSalir().click(base.Event.BtnSalirClick);
        //if (base.Function.AplicarBinding(Resinplast.Indicadores.Web.Login.Models.Index)) {

        //}
    };

    base.Parameters = {

    };

    base.Control = {
        Mensaje: new Resinplast.Indicadores.Web.Components.Message(),

        txtUsuario: function () { return $('#txtUsuario'); },
        txtPassword: function () { return $('#txtPassword'); },

        btnIngresar: function () { return $('#btnIngresar'); }
    };

    base.Event = {
        BtnContinuarClick: function () {
            if (base.Control.Validador.isValid()) {
                base.Ajax.AjaxAssignment.data = {
                    Usuario: base.Control.txtUsuario().val(),
                    Password: base.Control.txtPassword().val(),
                };

                base.Ajax.AjaxAssignment.submit();
            }
        },

        AssignmentSuccess: function (data) {
            switch (data.CodigoError) {
                case -1:
                    base.Control.Mensaje.Warning({ message: Resinplast.Indicadores.Web.Shared.General.Resources.EtiquetaEjecutoNingunProceso });
                    break;

                case 0:
                    window.location.href = Resinplast.Indicadores.Web.Login.Actions.Ruta;
                    break;

                case 1:
                    base.Control.Mensaje.Error({ message: data.DescripcionError });
                    break;

                default:
                    base.Control.Mensaje.Error({
                        message: Resinplast.Indicadores.Web.Shared.General.Resources.EtiquetaError + ' - ' + data.DescripcionError
                    });
                    break;
            }
        },
            
    };

    base.Ajax = {
         AjaxAssignment: new Resinplast.Indicadores.Web.Components.Ajax({
            action: Resinplast.Indicadores.Web.Login.Actions.AssignmentCredentials,
            autoSubmit: false,
            onSuccess: base.Event.AssignmentSuccess
        }),

    };

    base.Function = {
        
        AplicarBinding: function (model, contenedor) {
            var esValido = (typeof model !== 'undefined');
            if (esValido) {
                var contenedorDom = (contenedor) ? contenedor[0] : contenedor;
                esValido = (model.Error.Code == 0);

                if (esValido) {
                    ko.applyBindings(model, contenedorDom);
                } else {
                    base.Control.Mensaje.Warning({ message: model.Error.Message });
                }
            } else {
                base.Control.Mensaje.Error({ message: Resinplast.Indicadores.Web.Shared.Message.Resources.ErrorCargarViewModel });
            }

            return esValido;
        }
    };
};