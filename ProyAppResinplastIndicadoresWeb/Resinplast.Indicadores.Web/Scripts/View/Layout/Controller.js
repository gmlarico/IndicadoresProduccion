ns('Resinplast.Indicadores.Web.Layout.Index.Controller');
Resinplast.Indicadores.Web.Layout.Index.Controller = function () {
    var base = this;
    base.Ini = function (opts) {
        'use strict';

        base.Event.LoadBase();

        //base.Control.MenuCurrent = $.parseJSON(Resinplast.Indicadores.Web.Global.Menu.MenuCurrent);
        //base.Event.GenerateMenu(Resinplast.Indicadores.Web.Global.Menu.MyMenu);
    };

    base.Parameters = {

    };

    base.Control = {
        MenuCurrent: null,
        ulMenuGeneral: function () { return $('#ulMenuGeneral'); }
    };

    base.Event = {
        LoadBase: function () {
            applyToolTipButtons();

            //Codebase.helpers('select2');

            //moment.locale(Resinplast.Indicadores.Web.Global.Format.Language.toLowerCase());
        },

        GenerateMenu: function (data) {
            var newTitleHTML = Resinplast.Indicadores.Web.Shared.General.Resources.TitleLabel;

            base.Control.ulMenuGeneral().empty();

            if (data != "" && data != null && data != "null") {
                var jsonData = $.parseJSON(data);
                if (jsonData.length > 0) {
                    var htmlResultado = "";

                    //Generación de Menu
                    $.each(jsonData, function (index, val) {
                        htmlResultado += '<li id="li' + val.Codigo + '">';

                        if (val.FlagMenu == "0") {
                            if (val.Codigo == base.Control.MenuCurrent.CodigoModulo) {
                                newTitleHTML = val.Descripcion + ' - ' + Resinplast.Indicadores.Web.Shared.General.Resources.TitleLabel;
                                htmlResultado += ' <a class="active" href="' + val.URL + '"><i class="' + val.ArchivoIcono + '"></i><span class="sidebar-mini-hide">' + val.Descripcion + '</span></a>';
                            } else {
                                htmlResultado += ' <a href="' + val.URL + '"><i class="' + val.ArchivoIcono + '"></i><span class="sidebar-mini-hide">' + val.Descripcion + '</span></a>';
                            }
                        } else {
                            htmlResultado += ' <a class="nav-submenu" data-toggle="nav-submenu" href="#"><i class="' + val.ArchivoIcono + '"></i><span class="sidebar-mini-hide">' + val.Descripcion + '</span></a>';

                            //ListaOpcion
                            $.each(val.ListaOpcion, function (indexOpcion, valOpcion) {
                                htmlResultado += '<ul>';
                                htmlResultado += ' <li id="li' + valOpcion.Codigo + '">';

                                if (valOpcion.FlagMenu == "0") {
                                    if (valOpcion.Codigo == base.Control.MenuCurrent.CodigoOpcion) {
                                        newTitleHTML = valOpcion.Descripcion + ' - ' + Resinplast.Indicadores.Web.Shared.General.Resources.TitleLabel;
                                        htmlResultado += ' <a class="active" href="' + valOpcion.URL + '"><i class="' + valOpcion.ArchivoIcono + '"></i><span class="sidebar-mini-hide">' + valOpcion.Descripcion + '</span></a>';
                                    } else {
                                        htmlResultado += ' <a href="' + valOpcion.URL + '"><i class="' + valOpcion.ArchivoIcono + '"></i><span class="sidebar-mini-hide">' + valOpcion.Descripcion + '</span></a>';
                                    }
                                } else {
                                    htmlResultado += ' <a class="nav-submenu" data-toggle="nav-submenu" href="#"><i class="' + valOpcion.ArchivoIcono + '"></i><span class="sidebar-mini-hide">' + valOpcion.Descripcion + '</span></a>';

                                    //ListaSubOpcion
                                    $.each(valOpcion.ListaSubOpcion, function (indexSubOpcion, valSubOpcion) {
                                        htmlResultado += '<ul>';
                                        htmlResultado += ' <li id="li' + valSubOpcion.Codigo + '">';

                                        if (valSubOpcion.FlagMenu == "0") {
                                            if (valSubOpcion.Codigo == base.Control.MenuCurrent.CodigoSubOpcion) {
                                                newTitleHTML = valSubOpcion.Descripcion + ' - ' + Resinplast.Indicadores.Web.Shared.General.Resources.TitleLabel;
                                                htmlResultado += ' <a class="active" href="' + valSubOpcion.URL + '"><i class="' + valSubOpcion.ArchivoIcono + '"></i><span class="sidebar-mini-hide">' + valSubOpcion.Descripcion + '</span></a>';
                                            } else {
                                                htmlResultado += ' <a href="' + valSubOpcion.URL + '"><i class="' + valSubOpcion.ArchivoIcono + '"></i><span class="sidebar-mini-hide">' + valSubOpcion.Descripcion + '</span></a>';
                                            }
                                        } else {
                                            htmlResultado += ' <a class="nav-submenu" data-toggle="nav-submenu" href="#"><i class="' + valSubOpcion.ArchivoIcono + '"></i><span class="sidebar-mini-hide">' + valSubOpcion.Descripcion + '</span></a>';

                                            //ListaSubSubOpcion
                                            $.each(valSubOpcion.ListaSubSubOpcion, function (indexSubSubOpcion, valSubSubOpcion) {
                                                htmlResultado += '<ul>';
                                                htmlResultado += ' <li id="li' + valSubSubOpcion.Codigo + '">';

                                                if (valSubSubOpcion.FlagMenu == "0") {
                                                    if (valSubSubOpcion.Codigo == base.Control.MenuCurrent.CodigoSubSubOpcion) {
                                                        newTitleHTML = valSubSubOpcion.Descripcion + ' - ' + Resinplast.Indicadores.Web.Shared.General.Resources.TitleLabel;
                                                        htmlResultado += ' <a class="active" href="' + valSubSubOpcion.URL + '"><i class="' + valSubSubOpcion.ArchivoIcono + '"></i><span class="sidebar-mini-hide">' + valSubSubOpcion.Descripcion + '</span></a>';
                                                    } else {
                                                        htmlResultado += ' <a href="' + valSubSubOpcion.URL + '"><i class="' + valSubSubOpcion.ArchivoIcono + '"></i><span class="sidebar-mini-hide">' + valSubSubOpcion.Descripcion + '</span></a>';
                                                    }
                                                } else {
                                                    htmlResultado += ' <a class="nav-submenu" data-toggle="nav-submenu" href="#"><i class="' + valSubSubOpcion.ArchivoIcono + '"></i><span class="sidebar-mini-hide">' + valSubSubOpcion.Descripcion + '</span></a>';
                                                }

                                                htmlResultado += ' </li>';
                                                htmlResultado += '</ul>';
                                            });
                                        }

                                        htmlResultado += ' </li>';
                                        htmlResultado += '</ul>';
                                    });
                                }

                                htmlResultado += ' </li>';
                                htmlResultado += '</ul>';
                            });
                        }

                        htmlResultado += '</li>';
                    });
                    
                    base.Control.ulMenuGeneral().append(htmlResultado);

                    //Aplicar Class Open
                    $('#li' + base.Control.MenuCurrent.CodigoModulo).addClass('open');
                    $('#li' + base.Control.MenuCurrent.CodigoOpcion).addClass('open');
                    $('#li' + base.Control.MenuCurrent.CodigoSubOpcion).addClass('open');
                    $('#li' + base.Control.MenuCurrent.CodigoSubSubOpcion).addClass('open');

                    $("#sidebar-scroll").animate({ scrollTop: base.Control.ulMenuGeneral().offset().top }, 1000);
                }
            }

            $('html head').find('title').text(newTitleHTML);
        },
    };

    base.Ajax = {

    };

    base.Function = {

    };
};