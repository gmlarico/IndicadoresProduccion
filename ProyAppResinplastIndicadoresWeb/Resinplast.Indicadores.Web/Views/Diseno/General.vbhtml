@Imports Resinplast.Indicadores.Wrapper
@Imports Resinplast.Indicadores.Web.Models.Base

@Code
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<div class="block block-themed ">
    <div class="block-content">
        <form id="frmPizarraPrincipalIndex" method="post" autocomplete="off">
            <div class="row">
                <div class="col-md-12">
                    <div class="block block-mode">
                        <div class="block-header block-header-default">
                            <h3 class="block"><strong>Indicadores de diseño</strong></h3>
                            <div class="block-options">
                                <button id="btnBuscar" type="button" class="btn-block-option" data-bind="visible: Consultar.Visible, enable: Consultar.Enabled" data-toggle="tooltip" data-placement="top" title="Buscar">
                                    <i class="fa fa-search fa-2x"></i>
                                </button>
                                <button id="btnRefrescar" type="button" class="btn-block-option" data-toggle="tooltip" data-placement="top" title="Actualizar">
                                    <i class="fa fa-repeat fa-2x"></i>
                                </button>
                                <button type="button" class="btn-block-option fa-2x" data-toggle="block-option" data-action="content_toggle" data-bs-toggle="collapse"></button>
                            </div>
                        </div>
                        <div class="block-content" style="padding-top: 0px">
                            <div class="row tab-pane">
                                <div class="col-md-2">
                                    <div class="form-material form-material-sm floating">
                                        <select class="form-control form-control-sm" id="SelectAños" name="SelectAños">
                                            <option value=""></option>
                                            <option id="Inicial2021" value="2021">2021</option>
                                            <option id="Inicial2022" value="2022">2022</option>
                                            <option id="Inicial2023" value="2023">2023</option>
                                            <option id="Inicial2024" value="2024">2024</option>
                                            <option id="Inicial2025" value="2025">2025</option>
                                            <option id="Inicial2026" value="2026">2026</option>
                                            <option id="Inicial2027" value="2027">2027</option>
                                        </select>

                                        <label for="SelectAños">@Html.Raw("AÑO")</label>
                                    </div>
                                </div>
                                <div class="col-md-2">
                                    <div class="form-material form-material-sm floating">
                                        <select class="form-control form-control-sm" id="SelectMes" name="SelectMes">
                                            <option value=""></option>
                                            <option value="01">ENERO</option>
                                            <option value="02">FEBRERO</option>
                                            <option value="03">MARZO</option>
                                            <option value="04">ABRIL</option>
                                            <option value="05">MAYO</option>
                                            <option value="06">JUNIO</option>
                                            <option value="07">JULIO</option>
                                            <option value="08">AGOSTO</option>
                                            <option value="09">SETIEMBRE</option>
                                            <option value="10">OCTUBRE</option>
                                            <option value="11">NOVIEMBRE</option>
                                            <option value="12">DICIEMBRE</option>
                                        </select>

                                        <label for="SelectMes">@Html.Raw("MES")</label>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </form>
    </div>
</div>

<div class="block block-themed ">
    <div class="block-content">
        <h3 class="block"><strong>Indicadores de Apertura</strong></h3>
        <div class="main-content">
            <div class="container-fluid">
                <div class="row">
                    <div class="col-lg-12">
                        <div class="row">
                            <div class="col-6 col-xl-4">
                                <!-- Card -->
                                <a class="block block-rounded block-transparent bg-gd-sun" href="javascript:void(0)">
                                    <div class="block-content block-content-full block-sticky-options" style="background-color:#424949">

                                        <div class="py-20 text-center">
                                            <label for="re-listing-bedrooms" class="font-size-h2 font-w700 mb-0 text-white" id="txtCantTrabajosAperturaAño"></label>
                                            <div class="font-size-sm font-w600 text-uppercase text-white-op">Trabajos completados por año</div>
                                        </div>
                                    </div>
                                </a>
                                <!-- End Card -->
                            </div>
                            <div class="col-6 col-xl-4">
                                <!-- Card -->
                                <a class="block block-rounded block-transparent bg-gd-leaf" href="javascript:void(0)">
                                    <div class="block-content block-content-full block-sticky-options" style="background-color:#424949">

                                        <div class="py-20 text-center">
                                            <label for="re-listing-bedrooms" class="font-size-h2 font-w700 mb-0 text-white" id="txtCantTrabajosAperturaMes"></label>
                                            <div class="font-size-sm font-w600 text-uppercase text-white-op">Trabajos completados por mes</div>
                                        </div>
                                    </div>
                                </a>
                                <!-- End Card -->
                            </div>
                            <div class="col-6 col-xl-4">
                                <!-- Card -->
                                <a class="block block-rounded block-transparent bg-gd-emerald" href="javascript:void(0)">
                                    <div class="block-content block-content-full block-sticky-options" style="background-color:#424949">

                                        <div class="py-20 text-center">
                                            <label for="re-listing-bedrooms" class="font-size-h2 font-w700 mb-0 text-white" id="txtCantTrabajosAperturaDias"></label>
                                            <div class="font-size-sm font-w600 text-uppercase text-white-op">Trabajos promedio por día</div>
                                        </div>
                                    </div>
                                </a>
                                <!-- End Card -->
                            </div>
                        </div>
                    </div>

                    <div class="col-lg-6">
                        <!-- Card -->

                        <div class="card mb-30" style="margin-bottom:5px !important">
                            
                                <div id="GrafMixAperturaSemana"></div>
                           
                        </div>
                        <!-- End Card -->
                    </div>


                    <div class="col-lg-6">
                        <!-- Card -->
                        <div class="card mb-30" style="margin-bottom:5px !important">
                          
                                <div id="GrafMixAperturaSemanaCompacion"></div>
                          
                        </div>
                        <!-- End Card -->
                    </div>



                    <div class="col-lg-12">
                        <!-- Card -->
                        <div class="card mb-30" style="margin-bottom:5px !important">
                          
                                <div id="GrafLineaAperturaDia"></div>
                          
                        </div>
                        <!-- End Card -->
                    </div>


                </div>
            </div>
        </div>
    </div>
</div>
<div class="block block-themed ">
    <div class="block-content">
        <h3 class="block"><strong>Indicadores de Pre Prensa</strong></h3>
        <div class="main-content">
            <div class="container-fluid">
                <div class="row">
                    <div class="col-lg-12">
                        <div class="row">
                            <div class="col-6 col-xl-4">
                                <!-- Card -->
                                <a class="block block-rounded block-transparent bg-gd-sun" href="javascript:void(0)">
                                    <div class="block-content block-content-full block-sticky-options" style="background-color:#424949">

                                        <div class="py-20 text-center">
                                            <label for="re-listing-bedrooms" class="font-size-h2 font-w700 mb-0 text-white" id="txtCantTrabajosPreprensaAño"></label>
                                            <div class="font-size-sm font-w600 text-uppercase text-white-op">Trabajos completados por año</div>
                                        </div>
                                    </div>
                                </a>
                                <!-- End Card -->
                            </div>
                            <div class="col-6 col-xl-4">
                                <!-- Card -->
                                <a class="block block-rounded block-transparent bg-gd-leaf" href="javascript:void(0)">
                                    <div class="block-content block-content-full block-sticky-options" style="background-color:#424949">

                                        <div class="py-20 text-center">
                                            <label for="re-listing-bedrooms" class="font-size-h2 font-w700 mb-0 text-white" id="txtCantTrabajosPreprensaMes"></label>
                                            <div class="font-size-sm font-w600 text-uppercase text-white-op">Trabajos completados por mes</div>
                                        </div>
                                    </div>
                                </a>
                                <!-- End Card -->
                            </div>
                            <div class="col-6 col-xl-4">
                                <!-- Card -->
                                <a class="block block-rounded block-transparent bg-gd-emerald" href="javascript:void(0)">
                                    <div class="block-content block-content-full block-sticky-options" style="background-color:#424949">

                                        <div class="py-20 text-center">
                                            <label for="re-listing-bedrooms" class="font-size-h2 font-w700 mb-0 text-white" id="txtCantTrabajosPreprensaDias"></label>
                                            <div class="font-size-sm font-w600 text-uppercase text-white-op">Trabajos promedio por día</div>
                                        </div>
                                    </div>
                                </a>
                                <!-- End Card -->
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-6">
                        <!-- Card -->
                        <div class="card mb-30" style="margin-bottom:5px !important">
                          
                                <div id="GrafMixPreprensaSemana"></div>
                           
                        </div>
                        <!-- End Card -->
                    </div>
                    <div class="col-lg-6">
                        <!-- Card -->
                        <div class="card mb-30" style="margin-bottom:5px !important">
                          
                                <div id="GrafMixPreprensaSemanaCompacion"></div>
                         
                        </div>
                        <!-- End Card -->
                    </div>
                    <div class="col-lg-12">
                        <!-- Card -->
                        <div class="card mb-30" style="margin-bottom:5px !important">
                          
                                <div id="GrafLineaPreprensaDia"></div>
                           
                        </div>
                        <!-- End Card -->
                    </div>
                    @*<div class="col-lg-6">
                            <div class="card mb-30">
                                <div class="p-sm-3">
                                    <div id="GrafBarHoriTrabajosPreprenCliente"></div>
                                </div>
                            </div>
                        </div>*@

                </div>
            </div>
        </div>
    </div>
</div>



<div class="modal" id="ModalAperturas" tabindex="-1" role="dialog" aria-labelledby="modal-large" aria-hidden="true">
    <div class="modal-dialog modal-lg" role="document">
        <div class="modal-body">
            <div class="block block-themed block-transparent mb-0" style="width:fit-content">
                <div class="block-header bg-primary-dark">
                    <h3 class="block-title">Detalle trabajos de Apertura</h3>
                    <div class="block-options">
                        <button type="button" class="btn-block-option" data-dismiss="modal" aria-label="Close">
                            <i class="si si-close"></i>
                        </button>
                    </div>
                </div>
                <div class="block-content" style="background-color: white">

                    <table class="js-table-sections table  table-bordered table-vcenter" id="TablaDatosApertura">

                        <thead style="background-color: #555555;color: white">
                            <tr>
                                <th class="text-center" style="width: 3%;font-size: 12px;vertical-align: middle">Orden trabajo (OT)</th>
                                <th class="text-center" style="width: 3%;font-size: 12px;vertical-align: middle">Cliente</th>
                                <th class="text-center" style="width: 10%;font-size: 12px;vertical-align: middle">Producto</th>
                                <th class="text-center" style="width: 3%;font-size: 12px;vertical-align: middle">Fecha Enviado a diseño</th>
                                <th class="text-center" style="width: 3%;font-size: 12px;vertical-align: middle">Fecha Enviado a Cliente</th>
                                <th class="text-center" style="width: 3%;font-size: 12px;vertical-align: middle">Duración (Días)</th>
                            </tr>
                        </thead>
                        <tbody class="js-table-sections-header" id="BodyTablaDatosApertura"></tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>
</div>
<div class="modal" id="ModalPreprensa" tabindex="-1" role="dialog" aria-labelledby="modal-large" aria-hidden="true">
    <div class="modal-dialog modal-lg" role="document">
        <div class="modal-body">
            <div class="block block-themed block-transparent mb-0">
                <div class="block-header bg-primary-dark">
                    <h3 class="block-title">Detalle trabajos de Pre Prensa</h3>
                    <div class="block-options">
                        <button type="button" class="btn-block-option" data-dismiss="modal" aria-label="Close">
                            <i class="si si-close"></i>
                        </button>
                    </div>
                </div>
                <div class="block-content" style="background-color: white">

                    <table class="js-table-sections table  table-bordered table-vcenter" id="TablaDatosPreprensa">

                        <thead style="background-color: #555555;color: white">
                            <tr>
                                <th class="text-center" style="width: 3%;font-size: 12px;vertical-align: middle">Orden trabajo (OT)</th>
                                <th class="text-center" style="width: 3%;font-size: 12px;vertical-align: middle">Cliente</th>
                                <th class="text-center" style="width: 10%;font-size: 12px;vertical-align: middle">Producto</th>
                                <th class="text-center" style="width: 3%;font-size: 12px;vertical-align: middle">Fecha numeración en pizarra</th>
                                <th class="text-center" style="width: 3%;font-size: 12px;vertical-align: middle">Fecha Enviado a Clichés o PC</th>
                                <th class="text-center" style="width: 3%;font-size: 12px;vertical-align: middle">Duración (Días)</th>
                            </tr>
                        </thead>
                        <tbody class="js-table-sections-header" id="BodyTablaDatosPreprensa"></tbody>

                    </table>
                </div>
            </div>
        </div>
    </div>
</div>
<div class="modal" id="ModalPreprensaSinPruebaColor" tabindex="-1" role="dialog" aria-labelledby="modal-large" aria-hidden="true">
    <div class="modal-dialog modal-lg" role="document">
        <div class="modal-body">
            <div class="block block-themed block-transparent mb-0">
                <div class="block-header bg-primary-dark">
                    <h3 class="block-title">Detalle trabajos de Pre Prensa</h3>
                    <div class="block-options">
                        <button type="button" class="btn-block-option" data-dismiss="modal" aria-label="Close">
                            <i class="si si-close"></i>
                        </button>
                    </div>
                </div>
                <div class="block-content" style="background-color: white">

                    <table class="js-table-sections table  table-bordered table-vcenter" id="TablaDatosPreprensaSinPruebaColor">

                        <thead style="background-color: #555555;color: white">
                            <tr>
                                <th class="text-center" style="width: 3%;font-size: 12px;vertical-align: middle">Orden trabajo (OT)</th>
                                <th class="text-center" style="width: 3%;font-size: 12px;vertical-align: middle">Cliente</th>
                                <th class="text-center" style="width: 10%;font-size: 12px;vertical-align: middle">Producto</th>
                                <th class="text-center" style="width: 3%;font-size: 12px;vertical-align: middle">Fecha numeración en pizarra</th>
                                <th class="text-center" style="width: 3%;font-size: 12px;vertical-align: middle">Fecha Enviado a Clichés</th>
                                <th class="text-center" style="width: 3%;font-size: 12px;vertical-align: middle">Duración (Días)</th>
                            </tr>
                        </thead>
                        <tbody class="js-table-sections-header" id="BodyTablaDatosPreprensaSinPruebaColor"></tbody>

                    </table>
                </div>
            </div>
        </div>
    </div>
</div>

<div class="modal" id="ModalPreprensaPruebaColor" tabindex="-1" role="dialog" aria-labelledby="modal-large" aria-hidden="true">
    <div class="modal-dialog modal-lg" role="document">
        <div class="modal-body">
            <div class="block block-themed block-transparent mb-0">
                <div class="block-header bg-primary-dark">
                    <h3 class="block-title">Detalle trabajos de Pre Prensa (con PC)</h3>
                    <div class="block-options">
                        <button type="button" class="btn-block-option" data-dismiss="modal" aria-label="Close">
                            <i class="si si-close"></i>
                        </button>
                    </div>
                </div>
                <div class="block-content" style="background-color: white">

                    <table class="js-table-sections table  table-bordered table-vcenter" id="TablaDatosPreprensaPruebaColor">

                        <thead style="background-color: #555555;color: white">
                            <tr>
                                <th class="text-center" style="width: 3%;font-size: 12px;vertical-align: middle">Orden trabajo (OT)</th>
                                <th class="text-center" style="width: 3%;font-size: 12px;vertical-align: middle">Cliente</th>
                                <th class="text-center" style="width: 10%;font-size: 12px;vertical-align: middle">Producto</th>
                                <th class="text-center" style="width: 3%;font-size: 12px;vertical-align: middle">Fecha numeración en pizarra</th>
                                <th class="text-center" style="width: 3%;font-size: 12px;vertical-align: middle">Fecha Enviado a PC </th>
                                <th class="text-center" style="width: 3%;font-size: 12px;vertical-align: middle">Duración (Días)</th>
                            </tr>
                        </thead>
                        <tbody class="js-table-sections-header" id="BodyTablaDatosPreprensaPruebaColor"></tbody>

                    </table>
                </div>
            </div>
        </div>
    </div>
</div>

<script src="~/Content/Plugins/apex/apexcharts.min.js"></script>
<script src="~/Scripts/View/Diseno/DisenoIndicadores.js"></script>