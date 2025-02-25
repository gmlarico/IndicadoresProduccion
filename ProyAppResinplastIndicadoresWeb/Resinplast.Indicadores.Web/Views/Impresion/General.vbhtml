@Code
    ViewData("Title") = "General"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code


<div class="block block-themed ">
    <div class="block-content">
        <form id="frmIndicadoresPrincipalIndex" method="post" autocomplete="off">
            <div class="row">
                <div class="col-md-12">
                    <div class="block block-mode">
                        <div class="block-header block-header-default">
                            <h3 class="block"><strong>Indicadores de impresión</strong></h3>
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
                                        <select class="form-control form-control-sm" id="SelectAñosInicial" name="SelectAñosInicial">
                                            <option value=""></option>                                            
                                            <option id="Inicial2021" value="2021">2021</option>
                                            <option id="Inicial2022" value="2022">2022</option>
                                            <option id="Inicial2023" value="2023">2023</option>
                                            <option id="Inicial2024" value="2024">2024</option>
                                            <option id="Inicial2025" value="2025">2025</option>
                                            <option id="Inicial2026" value="2026">2026</option>
                                            <option id="Inicial2027" value="2027">2027</option>
                                        </select>

                                        <label for="SelectAñosInicial">@Html.Raw("Año inicio")</label>
                                    </div>
                                </div>
                                <div class="col-md-2">
                                    <div class="form-material form-material-sm floating">
                                        <select class="form-control form-control-sm" id="SelectAñosFinal" name="SelectAñosFinal">
                                            <option value=""></option>
                                            <option id="Final2021" value="2021" >2021</option>
                                            <option id="Final2022" value="2022" >2022</option>
                                            <option id="Final2023" value="2023" >2023</option>
                                            <option id="Final2024" value="2024" >2024</option>
                                            <option id="Final2025" value="2025" >2025</option>
                                            <option id="Final2026" value="2026" >2026</option>
                                            <option id="Final2027" value="2027" >2027</option>
                                        </select>

                                        <label for="SelectAñosFinal">@Html.Raw("Año fin")</label>
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

<div>
    <div class="block block-bordered block-rounded mb-2">

        <div class="block-header" role="tab" id="accordion2_h1">
            <a class="font-w600" data-toggle="collapse" data-parent="#accordion2" href="#accordion2_q1" aria-expanded="false" aria-controls="accordion2_q1" id="AcordionSetUp">Set Up</a>
            @*<h4 class="font-w600" data-toggle="collapse" data-parent="#accordion2" href="#accordion2_q1" aria-expanded="true" aria-controls="accordion2_q1">Indicadores de Aperturas</h4>*@

        </div>
        <div id="accordion2_q1" class="collapse" role="tabpanel" aria-labelledby="accordion2_h1">
            <div class="block-content ">
                <div class="block-header block-header-default">
                    <div class="block-options">
                        <div class="custom-control custom-radio custom-control-inline mb-5">
                            <input class="custom-control-input" type="radio" name="example-inline-radios" id="example-inline-radio1" value="option1" checked>
                            <label class="custom-control-label" for="example-inline-radio1">Total</label>
                        </div>
                        <div class="custom-control custom-radio custom-control-inline mb-5">
                            <input class="custom-control-input" type="radio" name="example-inline-radios" id="example-inline-radio2" value="option2">
                            <label class="custom-control-label" for="example-inline-radio2">Heptacromia</label>
                        </div>
                        <div class="custom-control custom-radio custom-control-inline mb-5">
                            <input class="custom-control-input" type="radio" name="example-inline-radios" id="example-inline-radio3" value="option3">
                            <label class="custom-control-label" for="example-inline-radio3">Sin heptacromia</label>
                        </div>
                    </div>
                </div>


                @*<button type="button" class="btn-block-option" data-toggle="block-option" data-action="state_toggle" data-action-mode="demo">
                        <i class="si si-refresh"></i>
                    </button>*@
                <div class="row">
                    <div class="col-lg-12">
                        <!-- Card -->
                        <div class="card mb-15" >
                        
                                <div id="SetUpGraficoTotal"></div>
                           
                        </div>
                        <!-- End Card -->
                    </div>
                    <div class="col-lg-6">
                        <!-- Card -->
                        <div class="card mb-15">
                            
                                <div id="SetUpFx07"></div>
                           
                        </div>
                        <!-- End Card -->
                    </div>
                    <div class="col-lg-6">
                        <!-- Card -->
                        <div class="card mb-15">
                            
                                <div id="SetUpFx08"></div>
                            
                        </div>
                        <!-- End Card -->
                    </div>
                    <div class="col-lg-6">
                        <!-- Card -->
                        <div class="card mb-15">
                           
                                <div id="SetUpFx09"></div>
                            
                        </div>
                        <!-- End Card -->
                    </div>
                    <div class="col-lg-6">
                        <!-- Card -->
                        <div class="card mb-15">
                            
                                <div id="SetUpFx10"></div>
                           
                        </div>
                        <!-- End Card -->
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<div>
    <div class="block block-bordered block-rounded mb-2">

        <div class="block-header" role="tab" id="accordion2_h2">
            <a class="font-w600" data-toggle="collapse" data-parent="#accordion2" href="#accordion2_q2" aria-expanded="true" aria-controls="accordion2_q2" id="AcordionVelocidad">Velocidad promedio (m/min)</a>
            @*<h4 class="font-w600" data-toggle="collapse" data-parent="#accordion2" href="#accordion2_q1" aria-expanded="true" aria-controls="accordion2_q1">Indicadores de Aperturas</h4>*@
        </div>
        <div id="accordion2_q2" class="collapse" role="tabpanel" aria-labelledby="accordion2_h2">
            <div class="block-content">

                @*<button type="button" class="btn-block-option" data-toggle="block-option" data-action="state_toggle" data-action-mode="demo">
                        <i class="si si-refresh"></i>
                    </button>*@
                <div class="row">

                    <div class="col-lg-12">
                        <!-- Card -->
                        <div class="card mb-15">
                      
                                <div id="VelocidadGraficoTotal"></div>
                          
                        </div>
                        <!-- End Card -->
                    </div>

                    <div class="col-lg-6">
                        <!-- Card -->
                        <div class="card mb-15">
                           
                                <div id="VelocidadGraficoFx07"></div>
                         
                        </div>
                        <!-- End Card -->
                    </div>
                    <div class="col-lg-6">
                        <!-- Card -->
                        <div class="card mb-15">
                          
                                <div id="VelocidadGraficoFx08"></div>
                      
                        </div>
                        <!-- End Card -->
                    </div>
                    <div class="col-lg-6">
                        <!-- Card -->
                        <div class="card mb-15">
                           
                                <div id="VelocidadGraficoFx09"></div>
                          
                        </div>
                        <!-- End Card -->
                    </div>
                    <div class="col-lg-6">
                        <!-- Card -->
                        <div class="card mb-15">
                            
                                <div id="VelocidadGraficoFx10"></div>
                          
                        </div>
                        <!-- End Card -->
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<div>
    <div class="block block-bordered block-rounded mb-2">

        <div class="block-header" role="tab" id="accordion2_h3">
            <a class="font-w600" data-toggle="collapse" data-parent="#accordion2" href="#accordion2_q3" aria-expanded="true" aria-controls="accordion2_q3" id="AcordionMetros">Producción en metros</a>
            @*<h4 class="font-w600" data-toggle="collapse" data-parent="#accordion2" href="#accordion2_q1" aria-expanded="true" aria-controls="accordion2_q1">Indicadores de Aperturas</h4>*@
        </div>
        <div id="accordion2_q3" class="collapse" role="tabpanel" aria-labelledby="accordion2_h3">
            <div class="block-content ">

                <div class="row">
                    <div class="col-lg-12">
                        <!-- Card -->
                        <div class="card mb-15">
                           
                                <div id="MetrosGraficaTotal"></div>
                           
                        </div>
                        <!-- End Card -->
                    </div>
                    <div class="col-lg-6">
                        <!-- Card -->
                        <div class="card mb-15">
                           
                                <div id="MetrosGraficaFx07"></div>
                         
                        </div>
                        <!-- End Card -->
                    </div>
                    <div class="col-lg-6">
                        <!-- Card -->
                        <div class="card mb-15">
                           
                                <div id="MetrosGraficaFx08"></div>
                           
                        </div>
                        <!-- End Card -->
                    </div>
                    <div class="col-lg-6">
                        <!-- Card -->
                        <div class="card mb-15">
                           
                                <div id="MetrosGraficaFx09"></div>
                           
                        </div>
                        <!-- End Card -->
                    </div>
                    <div class="col-lg-6">
                        <!-- Card -->
                        <div class="card mb-15">
                           
                                <div id="MetrosGraficaFx10"></div>
                          
                        </div>
                        <!-- End Card -->
                    </div>

                </div>
            </div>
        </div>
    </div>
</div>

<div>
    <div class="block block-bordered block-rounded mb-2">

        <div class="block-header" role="tab" id="accordion2_h4">
            <a class="font-w600" data-toggle="collapse" data-parent="#accordion2" href="#accordion2_q4" aria-expanded="true" aria-controls="accordion2_q4" id="AcordionMerma">Porcentaje de merma</a>
            @*<h4 class="font-w600" data-toggle="collapse" data-parent="#accordion2" href="#accordion2_q1" aria-expanded="true" aria-controls="accordion2_q1">Indicadores de Aperturas</h4>*@
        </div>
        <div id="accordion2_q4" class="collapse" role="tabpanel" aria-labelledby="accordion2_h4">
            <div class="block-content ">

                <div class="row">
                    <div class="col-lg-12">
                        <!-- Card -->
                        <div class="card mb-15">
                            
                                <div id="MermaGraficaTotal"></div>
                            
                        </div>
                        <!-- End Card -->
                    </div>
                    <div class="col-lg-6">
                        <!-- Card -->
                        <div class="card mb-15">
                           
                                <div id="MermaGraficaFx07"></div>
                            
                        </div>
                        <!-- End Card -->
                    </div>
                    <div class="col-lg-6">
                        <!-- Card -->
                        <div class="card mb-15">
                          
                                <div id="MermaGraficaFx08"></div>
                          
                        </div>
                        <!-- End Card -->
                    </div>
                    <div class="col-lg-6">
                        <!-- Card -->
                        <div class="card mb-15">
                            
                                <div id="MermaGraficaFx09"></div>
                           
                        </div>
                        <!-- End Card -->
                    </div>
                    <div class="col-lg-6">
                        <!-- Card -->
                        <div class="card mb-15">
                           
                                <div id="MermaGraficaFx10"></div>
                           
                        </div>
                        <!-- End Card -->
                    </div>


                </div>
            </div>
        </div>
    </div>
</div>


<script src="~/Content/Plugins/apex/apexcharts.min.js"></script>
<script src="~/Scripts/View/Impresion/ImpresionIndicadores.js"></script>
