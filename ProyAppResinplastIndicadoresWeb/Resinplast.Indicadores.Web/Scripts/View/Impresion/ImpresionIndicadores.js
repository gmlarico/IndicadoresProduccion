$(function () {
    $('.INDIMPRE').css('background', '#3E7C17');
    $("#menuImpresion").addClass("open");

    var AcordionSetUp = "CERRADO"
    var AcordionVelocidad = "CERRADO"
    var AcordionMetros = "CERRADO"
    var AcordionMerma = "CERRADO"

    var SetUpGraficoTotal
    var SetUpFx07
    var SetUpFx08
    var SetUpFx09
    var SetUpFx10
    var VelocidadGraficoTotal
    var VelocidadGraficoFx07
    var VelocidadGraficoFx07
    var VelocidadGraficoFx07
    var VelocidadGraficoFx07
    var MetrosGraficaTotal
    var MetrosGraficaFx07
    var MetrosGraficaFx08
    var MetrosGraficaFx09
    var MetrosGraficaFx10
    var MermaGraficaTotal
    var MermaGraficaFx07
    var MermaGraficaFx08
    var MermaGraficaFx09
    var MermaGraficaFx10

    var fecha = new Date();
    var anoInicial = (fecha.getFullYear()) -1 ;
    var anoFinal = (fecha.getFullYear());
           
    $("#SelectAñosInicial option[value='" + anoInicial + "']").attr("selected", true);
    $("#SelectAñosFinal option[value='" + anoFinal + "']").attr("selected", true);

    for (var i = anoFinal + 1; i < 2050; i++) {
        $("#Inicial" + i).remove();
        $("#Final" + i).remove();
    }
    
    $("#AcordionSetUp").click(function () {
        if (AcordionSetUp == "CERRADO") {
            AcordionSetUp = "ABIERTO"
            DatosSetUpTotales(anoInicial, anoFinal);
            DatosSetUpIndividuales(anoInicial, anoFinal);
        }
    });

    $("#AcordionVelocidad").click(function () {
        if (AcordionVelocidad == "CERRADO") {
            AcordionVelocidad = "ABIERTO"
            DatosVelocidadTotales(anoInicial, anoFinal);
            DatosVelocidadIndividuales(anoInicial, anoFinal);
        }
    });

    $("#AcordionMetros").click(function () {
        if (AcordionMetros == "CERRADO") {
            AcordionMetros = "ABIERTO"
            DatosMetrosTotales(anoInicial, anoFinal);
            DatosMetrosIndividuales(anoInicial, anoFinal);
        }
    });

    $("#AcordionMerma").click(function () {
        if (AcordionMerma == "CERRADO") {
            AcordionMerma = "ABIERTO"
            DatosScrapTotales(anoInicial, anoFinal);
            DatosScrapIndividuales(anoInicial, anoFinal);
        }
    });

    $("#example-inline-radio1").click(function () {
        try {
            debugger
            destruirGraficoSetUp()
            DatosSetUpIndividuales(anoInicial, anoFinal)
            DatosSetUpTotales(anoInicial, anoFinal)

        } catch (ex) {

        }
    });

    $("#example-inline-radio2").click(function () {
        try {

            destruirGraficoSetUpHeptacromia()
            DatosSetUpConHeptacromia(anoInicial, anoFinal)
            DatosSetUpTotales(anoInicial, anoFinal)

        } catch (ex) {

        }
    });

    $("#example-inline-radio3").click(function () {
        try {

            destruirGraficoSetUpHeptacromia()
            DatosSetUpIndividuales(anoInicial, anoFinal, 'SinSetUP')
            DatosSetUpSinHeptacromiaIndividuales(anoInicial, anoFinal)
            DatosSetUpSinHeptacromiaTotal(anoInicial, anoFinal)


        } catch (ex) {

        }
    });

    $("#btnBuscar").click(function () {
        try {
            debugger
            anoInicial = document.getElementById("SelectAñosInicial").value;
            anoFinal = document.getElementById("SelectAñosFinal").value;
            AcordionSetUp = "CERRADO"
            AcordionVelocidad = "CERRADO"
            AcordionMetros = "CERRADO"
            AcordionMerma = "CERRADO"

            $("#example-inline-radio1").prop("checked", true);

            destruirGraficosGlobales();

            $('#accordion2_q1').attr('class', 'collapse');
            $('#accordion2_q2').attr('class', 'collapse');
            $('#accordion2_q3').attr('class', 'collapse');
            $('#accordion2_q4').attr('class', 'collapse');

        } catch (ex) {

        }
    });

});


function DatosSetUpTotales(AñoInicio,AñoFin) {
    let NumeroCambios = [];
    let SetUpObjetivo = [];
    let SetUpPromedio = [];
    let Fechas = [];
    let ImpresionIndicadoresSetUpRequest = [{
        BuscarFechaInicio:  AñoInicio + '/01/01',
        BuscarFechaFin: AñoFin + '/01/01'
    }]

    $.ajax({
        type: 'POST',
        dataType: "JSON",
        contentType: 'application/json; charset=utf-8',
        data: JSON.stringify(ImpresionIndicadoresSetUpRequest),
        url: '/Impresion/ListaIndicadoresSetUpTotal',
        success: function (ListaIndicadoresSetUpTotal) {


            //alert(JSON.stringify(ListaAperturaDiarias));
          
            //let Grupos = [];

            //for (i = AñoInicio; i <= AñoFin; i++ ) {
            //    Grupos.push({ title: i, cols: 12 });
            //}    


            if (ListaIndicadoresSetUpTotal.length > 0) {

                for (var i = 0; i < ListaIndicadoresSetUpTotal.length; i++) {

                    Fechas.push(ListaIndicadoresSetUpTotal[i].DescripcionFecha)
                    NumeroCambios.push(ListaIndicadoresSetUpTotal[i].NumeroCambios)
                    SetUpObjetivo.push(ListaIndicadoresSetUpTotal[i].SetUpObjetivo)
                    SetUpPromedio.push(ListaIndicadoresSetUpTotal[i].SetUpPromedio)

                }
                                
                AperturaGraficoSetUpPromedioTotal(Fechas, NumeroCambios, SetUpObjetivo, SetUpPromedio)

            }

        }
    })

}

function DatosSetUpIndividuales(AñoInicio, AñoFin, TipoSetUp) {
    let NumeroCambios_1 = [];
    let SetUpObjetivo_1 = [];
    let SetUpPromedio_1 = [];
    let Fechas_1 = [];
    let NumeroCambios_2 = [];
    let SetUpObjetivo_2 = [];
    let SetUpPromedio_2 = [];
    let Fechas_2 = [];
    let NumeroCambios_3 = [];
    let SetUpObjetivo_3 = [];
    let SetUpPromedio_3 = [];
    let Fechas_3 = [];
    let NumeroCambios_4 = [];
    let SetUpObjetivo_4 = [];
    let SetUpPromedio_4 = [];
    let Fechas_4 = [];

    let ImpresionIndicadoresSetUpRequest = [{
        TipoRecurso: "Individual",
        BuscarFechaInicio: AñoInicio + '/01/01',
        BuscarFechaFin: AñoFin + '/01/01'
    }];

    $.ajax({
        type: 'POST',
        dataType: "JSON",
        contentType: 'application/json; charset=utf-8',
        data: JSON.stringify(ImpresionIndicadoresSetUpRequest),
        url: '/Impresion/ListaIndicadoresSetUpIndividual',
        success: function (ListaIndicadoresSetUpIndividual) {


            //alert(JSON.stringify(ListaAperturaDiarias));


            if (ListaIndicadoresSetUpIndividual.length > 0) {

                for (var i = 0; i < ListaIndicadoresSetUpIndividual.length; i++) {

                    if (ListaIndicadoresSetUpIndividual[i].IdRecurso == 'FX07')
                    {
                        Fechas_1.push(ListaIndicadoresSetUpIndividual[i].DescripcionFecha)
                        NumeroCambios_1.push(ListaIndicadoresSetUpIndividual[i].NumeroCambios)
                        SetUpObjetivo_1.push(ListaIndicadoresSetUpIndividual[i].SetUpObjetivo)
                        SetUpPromedio_1.push(ListaIndicadoresSetUpIndividual[i].SetUpPromedio)
                    }
                    if (ListaIndicadoresSetUpIndividual[i].IdRecurso == 'FX08') {
                        Fechas_2.push(ListaIndicadoresSetUpIndividual[i].DescripcionFecha)
                        NumeroCambios_2.push(ListaIndicadoresSetUpIndividual[i].NumeroCambios)
                        SetUpObjetivo_2.push(ListaIndicadoresSetUpIndividual[i].SetUpObjetivo)
                        SetUpPromedio_2.push(ListaIndicadoresSetUpIndividual[i].SetUpPromedio)
                    }
                    if (ListaIndicadoresSetUpIndividual[i].IdRecurso == 'FX09') {
                        Fechas_3.push(ListaIndicadoresSetUpIndividual[i].DescripcionFecha)
                        NumeroCambios_3.push(ListaIndicadoresSetUpIndividual[i].NumeroCambios)
                        SetUpObjetivo_3.push(ListaIndicadoresSetUpIndividual[i].SetUpObjetivo)
                        SetUpPromedio_3.push(ListaIndicadoresSetUpIndividual[i].SetUpPromedio)
                    }
                    if (ListaIndicadoresSetUpIndividual[i].IdRecurso == 'FX10') {
                        Fechas_4.push(ListaIndicadoresSetUpIndividual[i].DescripcionFecha)
                        NumeroCambios_4.push(ListaIndicadoresSetUpIndividual[i].NumeroCambios)
                        SetUpObjetivo_4.push(ListaIndicadoresSetUpIndividual[i].SetUpObjetivo)
                        SetUpPromedio_4.push(ListaIndicadoresSetUpIndividual[i].SetUpPromedio)
                    }

                }
                if (TipoSetUp == 'SinSetUp') {
                    AperturaGraficoSetUpPromedio('FX07', Fechas_1, NumeroCambios_1, SetUpObjetivo_1, SetUpPromedio_1)
                    AperturaGraficoSetUpPromedio('FX08', Fechas_2, NumeroCambios_2, SetUpObjetivo_2, SetUpPromedio_2)
                } else {
                    AperturaGraficoSetUpPromedio('FX07', Fechas_1, NumeroCambios_1, SetUpObjetivo_1, SetUpPromedio_1)
                    AperturaGraficoSetUpPromedio('FX08', Fechas_2, NumeroCambios_2, SetUpObjetivo_2, SetUpPromedio_2)
                    AperturaGraficoSetUpPromedio('FX09', Fechas_3, NumeroCambios_3, SetUpObjetivo_3, SetUpPromedio_3)
                    AperturaGraficoSetUpPromedio('FX10', Fechas_4, NumeroCambios_4, SetUpObjetivo_4, SetUpPromedio_4)

                }
               
                //AperturaGraficoSetUpPromedioTotal(Fechas, NumeroCambios, SetUpObjetivo, SetUpPromedio)

            }

        }
    })

}

function DatosSetUpConHeptacromia(AñoInicio, AñoFin) {
    let NumeroCambios_1 = [];
    let SetUpObjetivo_1 = [];
    let SetUpPromedio_1 = [];
    let Fechas_1 = [];
    let NumeroCambios_2 = [];
    let SetUpObjetivo_2 = [];
    let SetUpPromedio_2 = [];
    let Fechas_2 = [];
    let NumeroCambios_3 = [];
    let SetUpObjetivo_3 = [];
    let SetUpPromedio_3 = [];
    let Fechas_3 = []; 
    let NumeroCambios_4 = [];
    let SetUpObjetivo_4 = [];
    let SetUpPromedio_4 = [];
    let Fechas_4 = []; 

    let ImpresionIndicadoresSetUpRequest = [{
        TipoRecurso: "Individual",
        BuscarFechaInicio: AñoInicio + '/01/01',
        BuscarFechaFin: AñoFin + '/01/01'
    }];

    $.ajax({
        type: 'POST',
        dataType: "JSON",
        contentType: 'application/json; charset=utf-8',
        data: JSON.stringify(ImpresionIndicadoresSetUpRequest),
        url: '/Impresion/ListaIndicadoresSetUpConHeptacromia',
        success: function (ListaIndicadoresSetUpConHeptacromia) {

            if (ListaIndicadoresSetUpConHeptacromia.length > 0) {

                for (var i = 0; i < ListaIndicadoresSetUpConHeptacromia.length; i++) {

                    if (ListaIndicadoresSetUpConHeptacromia[i].IdRecurso == 'FX09') {
                        Fechas_1.push(ListaIndicadoresSetUpConHeptacromia[i].DescripcionFecha)
                        NumeroCambios_1.push(ListaIndicadoresSetUpConHeptacromia[i].NumeroCambios)
                        SetUpObjetivo_1.push(ListaIndicadoresSetUpConHeptacromia[i].SetUpObjetivoHeptacromia)
                        SetUpPromedio_1.push(ListaIndicadoresSetUpConHeptacromia[i].SetUpPromedioHeptacromia)
                    } else if (ListaIndicadoresSetUpConHeptacromia[i].IdRecurso == 'FX10') {
                        Fechas_2.push(ListaIndicadoresSetUpConHeptacromia[i].DescripcionFecha)
                        NumeroCambios_2.push(ListaIndicadoresSetUpConHeptacromia[i].NumeroCambios)
                        SetUpObjetivo_2.push(ListaIndicadoresSetUpConHeptacromia[i].SetUpObjetivoHeptacromia)
                        SetUpPromedio_2.push(ListaIndicadoresSetUpConHeptacromia[i].SetUpPromedioHeptacromia)
                    } else if (ListaIndicadoresSetUpConHeptacromia[i].IdRecurso == 'FX07') {
                        Fechas_3.push(ListaIndicadoresSetUpConHeptacromia[i].DescripcionFecha)
                        NumeroCambios_3.push(ListaIndicadoresSetUpConHeptacromia[i].NumeroCambios)
                        SetUpObjetivo_3.push(ListaIndicadoresSetUpConHeptacromia[i].SetUpObjetivoHeptacromia)
                        SetUpPromedio_3.push(ListaIndicadoresSetUpConHeptacromia[i].SetUpPromedioHeptacromia)
                    } else if (ListaIndicadoresSetUpConHeptacromia[i].IdRecurso == 'FX08') {
                        Fechas_4.push(ListaIndicadoresSetUpConHeptacromia[i].DescripcionFecha)
                        NumeroCambios_4.push(ListaIndicadoresSetUpConHeptacromia[i].NumeroCambios)
                        SetUpObjetivo_4.push(ListaIndicadoresSetUpConHeptacromia[i].SetUpObjetivoHeptacromia)
                        SetUpPromedio_4.push(ListaIndicadoresSetUpConHeptacromia[i].SetUpPromedioHeptacromia)
                    }

                }

                AperturaGraficoSetUpPromedioHeptacromia('FX09', Fechas_1, NumeroCambios_1, SetUpObjetivo_1, SetUpPromedio_1)
                AperturaGraficoSetUpPromedioHeptacromia('FX10', Fechas_2, NumeroCambios_2, SetUpObjetivo_2, SetUpPromedio_2)               
                AperturaGraficoSetUpPromedioHeptacromia('FX07', Fechas_3, NumeroCambios_3, SetUpObjetivo_3, SetUpPromedio_3)
                AperturaGraficoSetUpPromedioHeptacromia('FX08', Fechas_4, NumeroCambios_4, SetUpObjetivo_4, SetUpPromedio_4)
            }

        }
    })

}

function DatosSetUpSinHeptacromiaTotal(AñoInicio, AñoFin) {
    let NumeroCambios = [];
    let SetUpObjetivo = [];
    let SetUpPromedio = [];
    let Fechas = [];
    let ImpresionIndicadoresSetUpRequest = [{
        BuscarFechaInicio: AñoInicio + '/01/01',
        BuscarFechaFin: AñoFin + '/01/01'
    }];

    $.ajax({
        type: 'POST',
        dataType: "JSON",
        contentType: 'application/json; charset=utf-8',
        data: JSON.stringify(ImpresionIndicadoresSetUpRequest),
        url: '/Impresion/ListaIndicadoresSetUpSinHeptacromiaTotal',
        success: function (ListaIndicadoresSetUpSinHeptacromiaTotal) {


            //alert(JSON.stringify(ListaAperturaDiarias));


            if (ListaIndicadoresSetUpSinHeptacromiaTotal.length > 0) {

                for (var i = 0; i < ListaIndicadoresSetUpSinHeptacromiaTotal.length; i++) {

                    Fechas.push(ListaIndicadoresSetUpSinHeptacromiaTotal[i].DescripcionFecha)
                    NumeroCambios.push(ListaIndicadoresSetUpSinHeptacromiaTotal[i].NumeroCambios)
                    SetUpObjetivo.push(ListaIndicadoresSetUpSinHeptacromiaTotal[i].SetUpObjetivoSinHeptacromia)
                    SetUpPromedio.push(ListaIndicadoresSetUpSinHeptacromiaTotal[i].SetUpPromedioSinHeptacromia)

                }

                AperturaGraficoSetUpPromedioTotalSinHeptacromia(Fechas, NumeroCambios, SetUpObjetivo, SetUpPromedio)

            }

        }
    })

}

function DatosSetUpSinHeptacromiaIndividuales(AñoInicio, AñoFin) {
    let NumeroCambios_1 = [];
    let SetUpObjetivo_1 = [];
    let SetUpPromedio_1 = [];
    let Fechas_1 = [];
    let NumeroCambios_2 = [];
    let SetUpObjetivo_2 = [];
    let SetUpPromedio_2 = [];
    let Fechas_2 = [];
 

    let ImpresionIndicadoresSetUpRequest = [{
        TipoRecurso: "Individual",
        BuscarFechaInicio: AñoInicio + '/01/01',
        BuscarFechaFin: AñoFin + '/01/01'
    }];

    $.ajax({
        type: 'POST',
        dataType: "JSON",
        contentType: 'application/json; charset=utf-8',
        data: JSON.stringify(ImpresionIndicadoresSetUpRequest),
        url: '/Impresion/ListaIndicadoresSetUpSinHeptacromiaIndividual',
        success: function (ListaIndicadoresSetUpSinHeptacromiaIndividual) {


            //alert(JSON.stringify(ListaAperturaDiarias));


            if (ListaIndicadoresSetUpSinHeptacromiaIndividual.length > 0) {

                for (var i = 0; i < ListaIndicadoresSetUpSinHeptacromiaIndividual.length; i++) {

                    if (ListaIndicadoresSetUpSinHeptacromiaIndividual[i].IdRecurso == 'FX09') {
                        Fechas_1.push(ListaIndicadoresSetUpSinHeptacromiaIndividual[i].DescripcionFecha)
                        NumeroCambios_1.push(ListaIndicadoresSetUpSinHeptacromiaIndividual[i].NumeroCambios)
                        SetUpObjetivo_1.push(ListaIndicadoresSetUpSinHeptacromiaIndividual[i].SetUpObjetivoSinHeptacromia)
                        SetUpPromedio_1.push(ListaIndicadoresSetUpSinHeptacromiaIndividual[i].SetUpPromedioSinHeptacromia)
                    } else if (ListaIndicadoresSetUpSinHeptacromiaIndividual[i].IdRecurso == 'FX10') {
                        Fechas_2.push(ListaIndicadoresSetUpSinHeptacromiaIndividual[i].DescripcionFecha)
                        NumeroCambios_2.push(ListaIndicadoresSetUpSinHeptacromiaIndividual[i].NumeroCambios)
                        SetUpObjetivo_2.push(ListaIndicadoresSetUpSinHeptacromiaIndividual[i].SetUpObjetivoSinHeptacromia)
                        SetUpPromedio_2.push(ListaIndicadoresSetUpSinHeptacromiaIndividual[i].SetUpPromedioSinHeptacromia)
                    }
                   

                }

                AperturaGraficoSetUpPromedioSinHeptacromia('FX09', Fechas_1, NumeroCambios_1, SetUpObjetivo_1, SetUpPromedio_1)
                AperturaGraficoSetUpPromedioSinHeptacromia('FX10', Fechas_2, NumeroCambios_2, SetUpObjetivo_2, SetUpPromedio_2)
             
                //AperturaGraficoSetUpPromedioTotal(Fechas, NumeroCambios, SetUpObjetivo, SetUpPromedio)

            }

        }
    })

}

function DatosVelocidadTotales(AñoInicio, AñoFin) {
    let VelocidadTotal = [];
    let VelocidadObjetivo = [];
    let VelocidadPromedio = [];
    let Fechas = [];
    let ImpresionIndicadoresVelocidadRequest = [{
        TipoRecurso: "Individual",
        BuscarFechaInicio: AñoInicio + '/01/01',
        BuscarFechaFin: AñoFin + '/01/01'
    }];

    $.ajax({
        type: 'POST',
        dataType: "JSON",
        contentType: 'application/json; charset=utf-8',
        data: JSON.stringify(ImpresionIndicadoresVelocidadRequest),
        url: '/Impresion/ListaIndicadoresVelocidadTotales',
        success: function (ListaIndicadoresVelocidadTotales) {


            //alert(JSON.stringify(ListaAperturaDiarias));


            if (ListaIndicadoresVelocidadTotales.length > 0) {

                for (var i = 0; i < ListaIndicadoresVelocidadTotales.length; i++) {

                    Fechas.push(ListaIndicadoresVelocidadTotales[i].DescripcionFecha)
                    VelocidadTotal.push(ListaIndicadoresVelocidadTotales[i].VelocidadTotal)
                    VelocidadObjetivo.push(ListaIndicadoresVelocidadTotales[i].VelocidadObjetivo)
                    VelocidadPromedio.push(ListaIndicadoresVelocidadTotales[i].VelocidadEfectiva)

                }

                AperturaGraficoVelocidadTotal(Fechas, VelocidadTotal, VelocidadObjetivo, VelocidadPromedio)

            }

        }
    })

}

function DatosVelocidadIndividuales(AñoInicio, AñoFin) {
    let VelocidadTotal_1 = [];
    let VelocidadObjetivo_1 = [];
    let VelocidadPromedio_1 = [];
    let Fechas_1 = [];
    let VelocidadTotal_2 = [];
    let VelocidadObjetivo_2 = [];
    let VelocidadPromedio_2 = [];
    let Fechas_2 = [];
    let VelocidadTotal_3 = [];
    let VelocidadObjetivo_3 = [];
    let VelocidadPromedio_3 = [];
    let Fechas_3 = [];
    let VelocidadTotal_4 = [];
    let VelocidadObjetivo_4 = [];
    let VelocidadPromedio_4 = [];
    let Fechas_4 = [];

    let ImpresionIndicadoresVelocidadRequest = [{
        TipoRecurso: "Individual",
        BuscarFechaInicio: AñoInicio + '/01/01',
        BuscarFechaFin: AñoFin + '/01/01'
    }];

    $.ajax({
        type: 'POST',
        dataType: "JSON",
        contentType: 'application/json; charset=utf-8',
        data: JSON.stringify(ImpresionIndicadoresVelocidadRequest),
        url: '/Impresion/ListaIndicadoresVelocidadIndividuales',
        success: function (ListaIndicadoresVelocidadIndividuales) {


            //alert(JSON.stringify(ListaAperturaDiarias));


            if (ListaIndicadoresVelocidadIndividuales.length > 0) {

                for (var i = 0; i < ListaIndicadoresVelocidadIndividuales.length; i++) {

                    if (ListaIndicadoresVelocidadIndividuales[i].IdRecurso == 'FX07') {
                        Fechas_1.push(ListaIndicadoresVelocidadIndividuales[i].DescripcionFecha)
                        VelocidadTotal_1.push(ListaIndicadoresVelocidadIndividuales[i].VelocidadTotal)
                        VelocidadObjetivo_1.push(ListaIndicadoresVelocidadIndividuales[i].VelocidadObjetivo)
                        VelocidadPromedio_1.push(ListaIndicadoresVelocidadIndividuales[i].VelocidadEfectiva)
                    }
                    if (ListaIndicadoresVelocidadIndividuales[i].IdRecurso == 'FX08') {
                        Fechas_2.push(ListaIndicadoresVelocidadIndividuales[i].DescripcionFecha)
                        VelocidadTotal_2.push(ListaIndicadoresVelocidadIndividuales[i].VelocidadTotal)
                        VelocidadObjetivo_2.push(ListaIndicadoresVelocidadIndividuales[i].VelocidadObjetivo)
                        VelocidadPromedio_2.push(ListaIndicadoresVelocidadIndividuales[i].VelocidadEfectiva)
                    }
                    if (ListaIndicadoresVelocidadIndividuales[i].IdRecurso == 'FX09') {
                        Fechas_3.push(ListaIndicadoresVelocidadIndividuales[i].DescripcionFecha)
                        VelocidadTotal_3.push(ListaIndicadoresVelocidadIndividuales[i].VelocidadTotal)
                        VelocidadObjetivo_3.push(ListaIndicadoresVelocidadIndividuales[i].VelocidadObjetivo)
                        VelocidadPromedio_3.push(ListaIndicadoresVelocidadIndividuales[i].VelocidadEfectiva)
                    }
                    if (ListaIndicadoresVelocidadIndividuales[i].IdRecurso == 'FX10') {
                        Fechas_4.push(ListaIndicadoresVelocidadIndividuales[i].DescripcionFecha)
                        VelocidadTotal_4.push(ListaIndicadoresVelocidadIndividuales[i].VelocidadTotal)
                        VelocidadObjetivo_4.push(ListaIndicadoresVelocidadIndividuales[i].VelocidadObjetivo)
                        VelocidadPromedio_4.push(ListaIndicadoresVelocidadIndividuales[i].VelocidadEfectiva)
                    }

                }

                AperturaGraficoVelocidad('FX07', Fechas_1, VelocidadTotal_1, VelocidadObjetivo_1, VelocidadPromedio_1)
                AperturaGraficoVelocidad('FX08', Fechas_2, VelocidadTotal_2, VelocidadObjetivo_2, VelocidadPromedio_2)
                AperturaGraficoVelocidad('FX09', Fechas_3, VelocidadTotal_3, VelocidadObjetivo_3, VelocidadPromedio_3)
                AperturaGraficoVelocidad('FX10', Fechas_4, VelocidadTotal_4, VelocidadObjetivo_4, VelocidadPromedio_4)
                //AperturaGraficoSetUpPromedioTotal(Fechas, NumeroCambios, SetUpObjetivo, SetUpPromedio)

            }

        }
    })

}

function DatosMetrosTotales(AñoInicio, AñoFin) {
    let MetrosTotal = [];
    let MetrosObjetivo = [];
    let PorcentajeCumplimiento = [];
    let Fechas = [];
    let ImpresionIndicadoresMetrosRequest = [{
        TipoRecurso: "Individual",
        BuscarFechaInicio: AñoInicio + '/01/01',
        BuscarFechaFin: AñoFin + '/01/01'
    }];

    $.ajax({
        type: 'POST',
        dataType: "JSON",
        contentType: 'application/json; charset=utf-8',
        data: JSON.stringify(ImpresionIndicadoresMetrosRequest),
        url: '/Impresion/ListaIndicadoresMetrosTotales',
        success: function (ListaIndicadoresMetrosTotales) {


            //alert(JSON.stringify(ListaAperturaDiarias));


            if (ListaIndicadoresMetrosTotales.length > 0) {

                for (var i = 0; i < ListaIndicadoresMetrosTotales.length; i++) {

                    Fechas.push(ListaIndicadoresMetrosTotales[i].DescripcionFecha)
                    MetrosTotal.push(ListaIndicadoresMetrosTotales[i].ProduccionMetrosMiles)
                    MetrosObjetivo.push(ListaIndicadoresMetrosTotales[i].MetrosObjetivos)
                    PorcentajeCumplimiento.push(ListaIndicadoresMetrosTotales[i].MetrosCumplidos)

                }

                AperturaGraficoMetroTotales(Fechas, MetrosTotal, MetrosObjetivo, PorcentajeCumplimiento)

            }

        }
    })

}

function DatosMetrosIndividuales(AñoInicio, AñoFin) {
    let MetrosTotal_1 = [];
    let MetrosObjetivo_1 = [];
    let PorcentajeCumplimiento_1 = [];
    let Fechas_1 = [];
    let MetrosTotal_2 = [];
    let MetrosObjetivo_2 = [];
    let PorcentajeCumplimiento_2 = [];
    let Fechas_2 = [];
    let MetrosTotal_3 = [];
    let MetrosObjetivo_3 = [];
    let PorcentajeCumplimiento_3 = [];
    let Fechas_3 = [];
    let MetrosTotal_4 = [];
    let MetrosObjetivo_4 = [];
    let PorcentajeCumplimiento_4 = [];
    let Fechas_4 = [];

    let ImpresionIndicadoresMetrosRequest = [{
        TipoRecurso: "Individual",
        BuscarFechaInicio: AñoInicio + '/01/01',
        BuscarFechaFin: AñoFin + '/01/01'
    }];

    $.ajax({
        type: 'POST',
        dataType: "JSON",
        contentType: 'application/json; charset=utf-8',
        data: JSON.stringify(ImpresionIndicadoresMetrosRequest),
        url: '/Impresion/ListaIndicadoresMetrosIndividuales',
        success: function (ListaIndicadoresMetrosIndividuales) {


            //alert(JSON.stringify(ListaAperturaDiarias));
            

            if (ListaIndicadoresMetrosIndividuales.length > 0) {

                for (var i = 0; i < ListaIndicadoresMetrosIndividuales.length; i++) {

                    if (ListaIndicadoresMetrosIndividuales[i].IdRecurso == 'FX07') {
                        Fechas_1.push(ListaIndicadoresMetrosIndividuales[i].DescripcionFecha)
                        MetrosTotal_1.push(ListaIndicadoresMetrosIndividuales[i].ProduccionMetrosMiles)
                        MetrosObjetivo_1.push(ListaIndicadoresMetrosIndividuales[i].MetrosObjetivos)
                        PorcentajeCumplimiento_1.push(ListaIndicadoresMetrosIndividuales[i].MetrosCumplidos)
                    }
                    if (ListaIndicadoresMetrosIndividuales[i].IdRecurso == 'FX08') {
                        Fechas_2.push(ListaIndicadoresMetrosIndividuales[i].DescripcionFecha)
                        MetrosTotal_2.push(ListaIndicadoresMetrosIndividuales[i].ProduccionMetrosMiles)
                        MetrosObjetivo_2.push(ListaIndicadoresMetrosIndividuales[i].MetrosObjetivos)
                        PorcentajeCumplimiento_2.push(ListaIndicadoresMetrosIndividuales[i].MetrosCumplidos)
                    }
                    if (ListaIndicadoresMetrosIndividuales[i].IdRecurso == 'FX09') {
                        Fechas_3.push(ListaIndicadoresMetrosIndividuales[i].DescripcionFecha)
                        MetrosTotal_3.push(ListaIndicadoresMetrosIndividuales[i].ProduccionMetrosMiles)
                        MetrosObjetivo_3.push(ListaIndicadoresMetrosIndividuales[i].MetrosObjetivos)
                        PorcentajeCumplimiento_3.push(ListaIndicadoresMetrosIndividuales[i].MetrosCumplidos)
                    }
                    if (ListaIndicadoresMetrosIndividuales[i].IdRecurso == 'FX10') {
                        Fechas_4.push(ListaIndicadoresMetrosIndividuales[i].DescripcionFecha)
                        MetrosTotal_4.push(ListaIndicadoresMetrosIndividuales[i].ProduccionMetrosMiles)
                        MetrosObjetivo_4.push(ListaIndicadoresMetrosIndividuales[i].MetrosObjetivos)
                        PorcentajeCumplimiento_4.push(ListaIndicadoresMetrosIndividuales[i].MetrosCumplidos)
                    }

                }

                AperturaGraficoMetroDetalle('FX07', Fechas_1, MetrosTotal_1, MetrosObjetivo_1, PorcentajeCumplimiento_1)
                AperturaGraficoMetroDetalle('FX08', Fechas_2, MetrosTotal_2, MetrosObjetivo_2, PorcentajeCumplimiento_2)
                AperturaGraficoMetroDetalle('FX09', Fechas_3, MetrosTotal_3, MetrosObjetivo_3, PorcentajeCumplimiento_3)
                AperturaGraficoMetroDetalle('FX10', Fechas_4, MetrosTotal_4, MetrosObjetivo_4, PorcentajeCumplimiento_4)
                //AperturaGraficoSetUpPromedioTotal(Fechas, NumeroCambios, SetUpObjetivo, SetUpPromedio)

            }

        }
    })

}

function DatosScrapTotales(AñoInicio, AñoFin) {
    let ScrapResultante = [];
    let ScrapObjetivo = [];
    let Fechas = [];
    let ImpresionIndicadoresScrapRequest = [{
        TipoRecurso: "Individual",
        BuscarFechaInicio: AñoInicio + '/01/01',
        BuscarFechaFin: AñoFin + '/01/01'
    }];

    $.ajax({
        type: 'POST',
        dataType: "JSON",
        contentType: 'application/json; charset=utf-8',
        data: JSON.stringify(ImpresionIndicadoresScrapRequest),
        url: '/Impresion/ListaIndicadoresScrapTotales',
        success: function (ListaIndicadoresScrapTotales) {


            //alert(JSON.stringify(ListaAperturaDiarias));


            if (ListaIndicadoresScrapTotales.length > 0) {

                for (var i = 0; i < ListaIndicadoresScrapTotales.length; i++) {

                    Fechas.push(ListaIndicadoresScrapTotales[i].DescripcionFecha)
                    ScrapResultante.push(ListaIndicadoresScrapTotales[i].MermaResultante)
                    ScrapObjetivo.push(ListaIndicadoresScrapTotales[i].MermaObjetivo)

                }

                AperturaGraficoScrapTotales(Fechas, ScrapResultante, ScrapObjetivo)

            }

        }
    })

}

function DatosScrapIndividuales(AñoInicio, AñoFin) {
    let ScrapResultante_1 = [];
    let ScrapObjetivo_1 = [];
    let Fechas_1 = [];
    let ScrapResultante_2 = [];
    let ScrapObjetivo_2 = [];
    let Fechas_2 = [];
    let ScrapResultante_3 = [];
    let ScrapObjetivo_3 = [];
    let Fechas_3 = [];
    let ScrapResultante_4 = [];
    let ScrapObjetivo_4 = [];
    let Fechas_4 = [];

    let ImpresionIndicadoresMetrosRequest = [{
        TipoRecurso: "Individual",
        BuscarFechaInicio: AñoInicio + '/01/01',
        BuscarFechaFin: AñoFin + '/01/01'
    }];

    $.ajax({
        type: 'POST',
        dataType: "JSON",
        contentType: 'application/json; charset=utf-8',
        data: JSON.stringify(ImpresionIndicadoresMetrosRequest),
        url: '/Impresion/ListaIndicadoresScrapIndividuales',
        success: function (ListaIndicadoresScrapIndividuales) {


            //alert(JSON.stringify(ListaAperturaDiarias));
            

            if (ListaIndicadoresScrapIndividuales.length > 0) {

                for (var i = 0; i < ListaIndicadoresScrapIndividuales.length; i++) {

                    if (ListaIndicadoresScrapIndividuales[i].IdRecurso == 'FX07') {
                        Fechas_1.push(ListaIndicadoresScrapIndividuales[i].DescripcionFecha)
                        ScrapResultante_1.push(ListaIndicadoresScrapIndividuales[i].MermaResultante)
                        ScrapObjetivo_1.push(ListaIndicadoresScrapIndividuales[i].MermaObjetivo)
                    }
                    if (ListaIndicadoresScrapIndividuales[i].IdRecurso == 'FX08') {
                        Fechas_2.push(ListaIndicadoresScrapIndividuales[i].DescripcionFecha)
                        ScrapResultante_2.push(ListaIndicadoresScrapIndividuales[i].MermaResultante)
                        ScrapObjetivo_2.push(ListaIndicadoresScrapIndividuales[i].MermaObjetivo)
                    }
                    if (ListaIndicadoresScrapIndividuales[i].IdRecurso == 'FX09') {
                        Fechas_3.push(ListaIndicadoresScrapIndividuales[i].DescripcionFecha)
                        ScrapResultante_3.push(ListaIndicadoresScrapIndividuales[i].MermaResultante)
                        ScrapObjetivo_3.push(ListaIndicadoresScrapIndividuales[i].MermaObjetivo)
                    }
                    if (ListaIndicadoresScrapIndividuales[i].IdRecurso == 'FX10') {
                        Fechas_4.push(ListaIndicadoresScrapIndividuales[i].DescripcionFecha)
                        ScrapResultante_4.push(ListaIndicadoresScrapIndividuales[i].MermaResultante)
                        ScrapObjetivo_4.push(ListaIndicadoresScrapIndividuales[i].MermaObjetivo)
                    }

                }

                AperturaGraficoScrapDetalle('FX07', Fechas_1, ScrapResultante_1, ScrapObjetivo_1)
                AperturaGraficoScrapDetalle('FX08', Fechas_2, ScrapResultante_2, ScrapObjetivo_2)
                AperturaGraficoScrapDetalle('FX09', Fechas_3, ScrapResultante_3, ScrapObjetivo_3)
                AperturaGraficoScrapDetalle('FX10', Fechas_4, ScrapResultante_4, ScrapObjetivo_4)
                //AperturaGraficoSetUpPromedioTotal(Fechas, NumeroCambios, SetUpObjetivo, SetUpPromedio)

            }

        }
    })

}




function AperturaGraficoSetUpPromedio(IdRecurso,Fechas, NumeroCambios, SetUpObjetivo, SetUpPromedio) {

    var options = {
        series: [{
            name: 'Número de Cambios',
            measure: 'Numero',
            type: 'column',
            data: NumeroCambios
        }, {
            name: 'Set Up promedio',
            measure: 'Tiempo',
            type: 'line',
            data: SetUpPromedio

        }, {
            name: 'Set Up objetivo',
            measure: 'Tiempo',
            type: 'line',
            data: SetUpObjetivo

        }],
        chart: {
            redrawOnParentResize: true,
            height: 350,
            type: 'line',
            zoom: {
                enabled: false
            },
            events: {                
                mounted: (chart) => {
                    chart.windowResizeHandler();
                }
            }
        },
        stroke: {
            width: [0, 4, 4]
        },
        title: {
            text: 'Set Up promedio ' + IdRecurso + ' (hr/cam)',
            align: 'center',
            style: {
                fontSize: '18px'
            },
        },
        colors: ['#1ec21b', '#FF4560', '#000000'],
        plotOptions: {
            bar: {
                borderRadius: 4,
                columnWidth: '40%',
                dataLabels: {
                    position: 'bottom',

                }
            },
            dataLabels: {
                enabled: true,
                offsetX: 30
            },
        },
        dataLabels: {
            enabled: true,
            enabledOnSeries: [0, 1],
            offsetY: -4,
            style: {
                colors: ['#1ec21b', '#B3B6B7']
            },
            background: {
                enabled: true,
                borderRadius: 2,
                foreColor: '#17202A',
                borderColor: '#17202A',
            },
            formatter: function (value, config) {



                if (config.w.config.series[config.seriesIndex].measure == "Numero") {
                    return parseInt(value, 10);
                } else {
                    return minTommss(value);
                }

            }

        },
        labels: Fechas,
        xaxis: {
            tickPlacement: 'on',
            labels: {
                show: true,
                rotate: -45,
                rotateAlways: true,
            }
        },
        legend: {
            position: 'bottom',
            offsetY: 10
        },
        yaxis: [{
            opposite: true,
            title: {
                text: 'Número de cambios',
                style: {
                    //color: '#1ec21b',
                }
            },
            labels: {
                show: true,
                formatter: function (value) {

                    return parseInt(value, 10);
                }
            }
        }, {
            title: {
                text: 'Set Up promedio (Horas)',
                style: {
                    color: '#343A40',
                }
            },
            seriesName: "Set Up promedio", // Time data
            tickAmount: 5, // number of lines
            min: 0, // minimum value allowed
            max: 3, // maximum value allowed
            labels: {
                show: true,
                formatter: function (value) {

                    return minTommss(value);
                }
            }
        }, {
            seriesName: "Set Up promedio", // Time data
            tickAmount: 5, // number of lines
            min: 0, // minimum value allowed
            max: 3, // maximum value allowed
            labels: {
                show: false,
                formatter: function (value) {

                    return minTommss(value);
                }
            }

        }],
        markers: {
            size: [0, 2],
        }

    };

    if (IdRecurso == 'FX07') {
        SetUpFx07 = new ApexCharts(document.querySelector("#SetUpFx07"), options);
        SetUpFx07.render();
    } else if (IdRecurso == 'FX08') {
        SetUpFx08 = new ApexCharts(document.querySelector("#SetUpFx08"), options);
        SetUpFx08.render();
    
    } else if (IdRecurso == 'FX09') {
        SetUpFx09 = new ApexCharts(document.querySelector("#SetUpFx09"), options);
        SetUpFx09.render();
    } else if (IdRecurso == 'FX10') {

        SetUpFx10 = new ApexCharts(document.querySelector("#SetUpFx10"), options);
        SetUpFx10.render();
    }

};

function AperturaGraficoSetUpPromedioTotal(Fechas, NumeroCambios, SetUpObjetivo, SetUpPromedio) {

    var options = {
        series: [{
            name: 'Número de cambios',
            measure: 'Numero',
            type: 'column',
            data: NumeroCambios
        }, {
            name: 'Set Up promedio',
            measure: 'Tiempo',
            type: 'line',
            data: SetUpPromedio

        }, {
            name: 'Set Up objetivo',
            measure: 'Tiempo',
            type: 'line',
            data: SetUpObjetivo

        }],
        chart: {
            redrawOnParentResize: true,
            height: 350,
            type: 'line',
            zoom: {
                enabled: false
            },
            events: {
                mounted: (chart) => {
                    chart.windowResizeHandler();
                }
            }
        },
        stroke: {
            width: [0, 4, 4]
        },
        title: {
            text: 'Set Up promedio impresoras (hr/cam)',
            align: 'center',
            style: {
                fontSize: '18px'
            },
        },
        colors: ['#1ec21b', '#FF4560', '#000000'],
        plotOptions: {
            bar: {
                borderRadius: 4,
                columnWidth: '40%',
                dataLabels: {
                    position: 'bottom',

                }
            },
            dataLabels: {
                enabled: true,
                offsetX: 30
            },
        },
        dataLabels: {
            enabled: true,
            enabledOnSeries: [0, 1],
            offsetY: -4,
            style: {
                colors: ['#1ec21b', '#B3B6B7']
            },
            background: {
                enabled: true,
                borderRadius: 2,
                foreColor: '#17202A',
                borderColor: '#17202A',
            },
            formatter: function (value, config) {



                if (config.w.config.series[config.seriesIndex].measure == "Numero") {
                    return parseInt(value, 10);
                } else {
                    return minTommss(value);
                }

            }

        },
        labels: Fechas,
        xaxis: {            
            tickPlacement: 'on',
            labels: {
                show: true,
                rotate: -45,
                rotateAlways: true,
            },
            group: {
                style: {
                    fontSize: '10px',
                    fontWeight: 700
                },
                groups: [{ title: '2019', cols: 5 }]
            }
        },
        legend: {
            position: 'bottom',
            offsetY: 10
        },
        yaxis: [{
            opposite: true,
            title: {
                text: 'Número de cambios',
                style: {
                    //color: '#1ec21b',
                }
            },
            labels: {
                show: true,
                formatter: function (value) {

                    return parseInt(value, 10);
                }
            }
        }, {
            title: {
                text: 'Set Up promedio (Horas)',
                style: {
                    color: '#343A40',
                }
            },
            seriesName: "Set Up promedio", // Time data
            tickAmount: 5, // number of lines
            min: 0, // minimum value allowed
            max: 3, // maximum value allowed
            labels: {
                show: true,
                formatter: function (value) {

                    return minTommss(value);
                }
            }
        }, {
            seriesName: "Set Up promedio", // Time data
            tickAmount: 5, // number of lines
            min: 0, // minimum value allowed
            max: 3, // maximum value allowed
            labels: {
                show: false,
                formatter: function (value) {

                    return minTommss(value);
                }
            }

        }],
        markers: {
            size: [0,2],
        }

    };

    SetUpGraficoTotal = new ApexCharts(document.querySelector("#SetUpGraficoTotal"), options);


    SetUpGraficoTotal.render();

};

function AperturaGraficoSetUpPromedioHeptacromia(IdRecurso, Fechas, NumeroCambios, SetUpObjetivo, SetUpPromedio) {

    var options = {
        series: [{
            name: 'Número de cambios',
            measure: 'Numero',
            type: 'column',
            data: NumeroCambios
        }, {
            name: 'Set Up promedio',
            measure: 'Tiempo',
            type: 'line',
            data: SetUpPromedio

        }, {
            name: 'Set Up objetivo',
            measure: 'Tiempo',
            type: 'line',
            data: SetUpObjetivo

        }],
        chart: {
            redrawOnParentResize: true,
            height: 350,
            type: 'line',
            zoom: {
                enabled: false
            },
            events: {
                mounted: (chart) => {
                    chart.windowResizeHandler();
                }
            }
        },
        stroke: {
            width: [0, 4, 4]
        },
        title: {
            text: 'Set Up promedio heptacromía '+ IdRecurso + ' (hr/cam)',
            align: 'center',
            style: {
                fontSize: '18px'
            },
        },
        colors: ['#1ec21b', '#FF4560', '#000000'],
        plotOptions: {
            bar: {
                borderRadius: 4,
                columnWidth: '40%',
                dataLabels: {
                    position: 'bottom',

                }
            },
            dataLabels: {
                enabled: true,
                offsetX: 30
            },
        },
        dataLabels: {
            enabled: true,
            enabledOnSeries: [0, 1],
            offsetY: -4,
            style: {
                colors: ['#1ec21b', '#B3B6B7']
            },
            background: {
                enabled: true,
                borderRadius: 2,
                foreColor: '#17202A',
                borderColor: '#17202A',
            },
            formatter: function (value, config) {



                if (config.w.config.series[config.seriesIndex].measure == "Numero") {
                    return parseInt(value, 10);
                } else {
                    return minTommss(value);
                }

            }

        },
        labels: Fechas,
        xaxis: {
            tickPlacement: 'on',
            labels: {
                show: true,
                rotate: -45,
                rotateAlways: true,
            }
        },
        legend: {
            position: 'bottom',
            offsetY: 10
        },
        yaxis: [{
            opposite: true,
            title: {
                text: 'Número de cambios',
                style: {
                    //color: '#1ec21b',
                }
            },
            labels: {
                show: true,
                formatter: function (value) {

                    return parseInt(value, 10);
                }
            }
        }, {
            title: {
                text: 'Set Up promedio (Horas)',
                style: {
                    color: '#343A40',
                }
            },
            seriesName: "Set Up promedio", // Time data
            tickAmount: 5, // number of lines
            min: 0, // minimum value allowed
            max: 3, // maximum value allowed
            labels: {
                show: true,
                formatter: function (value) {

                    return minTommss(value);
                }
            }
        }, {
            seriesName: "Set Up promedio", // Time data
            tickAmount: 5, // number of lines
            min: 0, // minimum value allowed
            max: 3, // maximum value allowed
            labels: {
                show: false,
                formatter: function (value) {

                    return minTommss(value);
                }
            }

        }],
        markers: {
            size: [0, 2],
        }

    };

    if (IdRecurso == 'FX09') {
        SetUpFx09 = new ApexCharts(document.querySelector("#SetUpFx09"), options);
        SetUpFx09.render();
    } else if (IdRecurso == 'FX10') {
        SetUpFx10 = new ApexCharts(document.querySelector("#SetUpFx10"), options);
        SetUpFx10.render();
    } else if (IdRecurso == 'FX07') {
        SetUpFx07 = new ApexCharts(document.querySelector("#SetUpFx07"), options);
        SetUpFx07.render();
    } else if (IdRecurso == 'FX08') {
        SetUpFx08 = new ApexCharts(document.querySelector("#SetUpFx08"), options);
        SetUpFx08.render();
    }

};

function AperturaGraficoSetUpPromedioSinHeptacromia(IdRecurso, Fechas, NumeroCambios, SetUpObjetivo, SetUpPromedio) {

    var options = {
        series: [{
            name: 'Número de Cambios',
            measure: 'Numero',
            type: 'column',
            data: NumeroCambios
        }, {
            name: 'Set Up promedio',
            measure: 'Tiempo',
            type: 'line',
            data: SetUpPromedio

        }, {
            name: 'Set Up objetivo',
            measure: 'Tiempo',
            type: 'line',
            data: SetUpObjetivo

        }],
        chart: {
            redrawOnParentResize: true,
            height: 350,
            type: 'line',
            zoom: {
                enabled: false
            },
            events: {
                mounted: (chart) => {
                    chart.windowResizeHandler();
                }
            }
        },
        stroke: {
            width: [0, 4, 4]
        },
        title: {
            text: 'Set Up promedio sin heptacromía '+ IdRecurso +' (hr/cam)',
            align: 'center',
            style: {
                fontSize: '18px'
            },
        },
        colors: ['#1ec21b', '#FF4560', '#000000'],
        plotOptions: {
            bar: {
                borderRadius: 4,
                columnWidth: '40%',
                dataLabels: {
                    position: 'bottom',

                }
            },
            dataLabels: {
                enabled: true,
                offsetX: 30
            },
        },
        dataLabels: {
            enabled: true,
            enabledOnSeries: [0, 1],
            offsetY: -4,
            style: {
                colors: ['#1ec21b', '#B3B6B7']
            },
            background: {
                enabled: true,
                borderRadius: 2,
                foreColor: '#17202A',
                borderColor: '#17202A',
            },
            formatter: function (value, config) {



                if (config.w.config.series[config.seriesIndex].measure == "Numero") {
                    return parseInt(value, 10);
                } else {
                    return minTommss(value);
                }

            }

        },
        labels: Fechas,
        xaxis: {
            tickPlacement: 'on',
            labels: {
                show: true,
                rotate: -45,
                rotateAlways: true,
            }
        },
        legend: {
            position: 'bottom',
            offsetY: 10
        },
        yaxis: [{
            opposite: true,
            title: {
                text: 'Número de cambios',
                style: {
                    //color: '#1ec21b',
                }
            },
            labels: {
                show: true,
                formatter: function (value) {

                    return parseInt(value, 10);
                }
            }
        }, {
            title: {
                text: 'Set Up promedio (Horas)',
                style: {
                    color: '#343A40',
                }
            },
            seriesName: "Set Up promedio", // Time data
            tickAmount: 5, // number of lines
            min: 0, // minimum value allowed
            max: 3, // maximum value allowed
            labels: {
                show: true,
                formatter: function (value) {

                    return minTommss(value);
                }
            }
        }, {
            seriesName: "Set Up promedio", // Time data
            tickAmount: 5, // number of lines
            min: 0, // minimum value allowed
            max: 3, // maximum value allowed
            labels: {
                show: false,
                formatter: function (value) {

                    return minTommss(value);
                }
            }

        }],
        markers: {
            size: [0, 2],
        }

    };

    if (IdRecurso == 'FX09') {
        SetUpFx09 = new ApexCharts(document.querySelector("#SetUpFx09"), options);
        SetUpFx09.render();
    } else if (IdRecurso == 'FX10') {
        SetUpFx10 = new ApexCharts(document.querySelector("#SetUpFx10"), options);
        SetUpFx10.render();
    }

};

function AperturaGraficoSetUpPromedioTotalSinHeptacromia(Fechas, NumeroCambios, SetUpObjetivo, SetUpPromedio) {

    var options = {
        series: [{
            name: 'Número de Cambios',
            measure: 'Numero',
            type: 'column',
            data: NumeroCambios
        }, {
            name: 'Set Up promedio',
            measure: 'Tiempo',
            type: 'line',
            data: SetUpPromedio

        }, {
            name: 'Set Up objetivo',
            measure: 'Tiempo',
            type: 'line',
            data: SetUpObjetivo

        }],
        chart: {
            redrawOnParentResize: true,
            height: 350,
            type: 'line',
            zoom: {
                enabled: false
            },
            events: {
                mounted: (chart) => {
                    chart.windowResizeHandler();
                }
            }
        },
        stroke: {
            width: [0, 4, 4]
        },
        title: {
            text: 'Set Up promedio impresoras sin heptacromía (hr/cam)',
            align: 'center',
            style: {
                fontSize: '18px'
            },
        },
        colors: ['#1ec21b', '#FF4560', '#000000'],
        plotOptions: {
            bar: {
                borderRadius: 4,
                columnWidth: '40%',
                dataLabels: {
                    position: 'bottom',

                }
            },
            dataLabels: {
                enabled: true,
                offsetX: 30
            },
        },
        dataLabels: {
            enabled: true,
            enabledOnSeries: [0, 1],
            offsetY: -4,
            style: {
                colors: ['#1ec21b', '#B3B6B7']
            },
            background: {
                enabled: true,
                borderRadius: 2,
                foreColor: '#17202A',
                borderColor: '#17202A',
            },
            formatter: function (value, config) {



                if (config.w.config.series[config.seriesIndex].measure == "Numero") {
                    return parseInt(value, 10);
                } else {
                    return minTommss(value);
                }

            }

        },
        labels: Fechas,
        xaxis: {
            tickPlacement: 'on',
            labels: {
                show: true,
                rotate: -45,
                rotateAlways: true,
            }
        },
        legend: {
            position: 'bottom',
            offsetY: 10
        },
        yaxis: [{
            opposite: true,
            title: {
                text: 'Número de cambios',
                style: {
                    //color: '#1ec21b',
                }
            },
            labels: {
                show: true,
                formatter: function (value) {

                    return parseInt(value, 10);
                }
            }
        }, {
            title: {
                text: 'Set Up promedio (Horas)',
                style: {
                    color: '#343A40',
                }
            },
            seriesName: "Set Up promedio", // Time data
            tickAmount: 5, // number of lines
            min: 0, // minimum value allowed
            max: 3, // maximum value allowed
            labels: {
                show: true,
                formatter: function (value) {

                    return minTommss(value);
                }
            }
        }, {
            seriesName: "Set Up promedio", // Time data
            tickAmount: 5, // number of lines
            min: 0, // minimum value allowed
            max: 3, // maximum value allowed
            labels: {
                show: false,
                formatter: function (value) {

                    return minTommss(value);
                }
            }

        }],
        markers: {
            size: [0, 2],
        }

    };

    SetUpGraficoTotal = new ApexCharts(document.querySelector("#SetUpGraficoTotal"), options);


    SetUpGraficoTotal.render();

};

function AperturaGraficoVelocidad(IdRecurso,Fechas, VelocidadTotal, VelocidadObjetivo, VelocidadPromedio) {

    var options = {
        series: [{
            name: 'Velocidad efectiva',
            measure: 'Numero',
            type: 'line',
            data: VelocidadTotal
        }, {
            name: 'Velocidad de producción',
            measure: 'Numero',
            type: 'line',
            data: VelocidadPromedio

        }, {
            name: 'Velocidad objetivo',
            measure: 'Numero',
            type: 'line',
            data: VelocidadObjetivo

        }],
        chart: {
            redrawOnParentResize: true,
            height: 350,
            type: 'line',
            zoom: {
                enabled: false
            },
            events: {
                mounted: (chart) => {
                    chart.windowResizeHandler();
                }
            }
        },
        stroke: {
            width: [4, 4, 4]
        },
        title: {
            text: 'Velocidad promedio ' + IdRecurso + ' (m/min)',
            align: 'center',
            style: {
                fontSize: '18px'
            },
        },
        colors: ['#1ec21b', '#FF4560', '#000000'],
        plotOptions: {
            bar: {
                borderRadius: 4,
                columnWidth: '40%',
                dataLabels: {
                    position: 'bottom',

                }
            },
            dataLabels: {
                enabled: true,
                offsetX: 30
            },
        },
        dataLabels: {
            enabled: true,
            enabledOnSeries: [0, 1],
            offsetY: -4,
            style: {
                colors: ['#1ec21b', '#B3B6B7']
            },
            background: {
                enabled: true,
                borderRadius: 2,
                foreColor: '#17202A',
                borderColor: '#17202A',
            },
            formatter: function (value, config) {



                if (config.w.config.series[config.seriesIndex].measure == "Numero") {
                    return parseInt(value, 10);
                } else {
                    return minTommss(value);
                }

            }

        },
        labels: Fechas,
        xaxis: {
            tickPlacement: 'on',
            labels: {
                show: true,
                rotate: -45,
                rotateAlways: true,
            }
        },
        legend: {
            position: 'bottom',
            offsetY: 10
        },
        yaxis: [{
            //opposite: true,
            title: {
                text: 'Velocidad promedio (m/min)',
                style: {
                    //color: '#1ec21b',
                }
            },
            min: 0, // minimum value allowed
            forceNiceScale: true,
            labels: {
                show: true,
                formatter: function (value) {

                    return parseInt(value, 10);
                }
            }
        }],
        markers: {
            size: [2, 2,0],
        }

    };

    if (IdRecurso == 'FX07') {
        VelocidadGraficoFx07 = new ApexCharts(document.querySelector("#VelocidadGraficoFx07"), options);
        VelocidadGraficoFx07.render();
    } else if (IdRecurso == 'FX08') {
        VelocidadGraficoFx08 = new ApexCharts(document.querySelector("#VelocidadGraficoFx08"), options);
        VelocidadGraficoFx08.render();

    } else if (IdRecurso == 'FX09') {
        VelocidadGraficoFx09 = new ApexCharts(document.querySelector("#VelocidadGraficoFx09"), options);
        VelocidadGraficoFx09.render();
    } else if (IdRecurso == 'FX10') {

        VelocidadGraficoFx10 = new ApexCharts(document.querySelector("#VelocidadGraficoFx10"), options);
        VelocidadGraficoFx10.render();
    }
    
};

function AperturaGraficoVelocidadTotal(Fechas, VelocidadTotal, VelocidadObjetivo, VelocidadPromedio) {

    var options = {
        series: [{
            name: 'Velocidad efectiva',
            measure: 'Numero',
            type: 'line',
            data: VelocidadTotal
        }, {
            name: 'Velocidad de producción',
            measure: 'Numero',
            type: 'line',
            data: VelocidadPromedio

        }, {
            name: 'Velocidad objetivo',
            measure: 'Numero',
            type: 'line',
            data: VelocidadObjetivo

        }],
        chart: {
            redrawOnParentResize: true,
            height: 350,
            type: 'line',
            zoom: {
                enabled: false
            },
            events: {
                mounted: (chart) => {
                    chart.windowResizeHandler();
                }
            }
        },
        stroke: {
            width: [4, 4, 4]
        },
        title: {
            text: 'Velocidad promedio impresoras (m/min)',
            align: 'center',
            style: {
                fontSize: '18px'
            },
        },
        colors: ['#1ec21b', '#FF4560', '#000000'],
        plotOptions: {
            bar: {
                borderRadius: 4,
                columnWidth: '40%',
                dataLabels: {
                    position: 'bottom',

                }
            },
            dataLabels: {
                enabled: true,
                offsetX: 30
            },
        },
        dataLabels: {
            enabled: true,
            enabledOnSeries: [0, 1],
            offsetY: -4,
            style: {
                colors: ['#1ec21b', '#B3B6B7']
            },
            background: {
                enabled: true,
                borderRadius: 2,
                foreColor: '#17202A',
                borderColor: '#17202A',
            },
            formatter: function (value, config) {



                if (config.w.config.series[config.seriesIndex].measure == "Numero") {
                    return parseInt(value, 10);
                } else {
                    return minTommss(value);
                }

            }

        },
        labels: Fechas,
        xaxis: {
            tickPlacement: 'on',
            labels: {
                show: true,
                rotate: -45,
                rotateAlways: true,
            }
        },
        legend: {
            position: 'bottom',
            offsetY: 10
        },
        yaxis: [{
            //opposite: true,
            title: {
                text: 'Velocidad promedio (m/min)',
                style: {
                    //color: '#1ec21b',
                }
            },
            min: 0, // minimum value allowed
            forceNiceScale: true,
            labels: {
                show: true,
                formatter: function (value) {

                    return parseInt(value, 10);
                }
            }
        }],
        markers: {
            size: [2, 2, 0],
        }

    };

    VelocidadGraficoTotal = new ApexCharts(document.querySelector("#VelocidadGraficoTotal"), options);




    VelocidadGraficoTotal.render();


};

function AperturaGraficoMetroDetalle(IdRecurso,Fechas, MetrosTotal, MetrosObjetivo, PorcentajeCumplimiento) {
    var options = {
        series: [{
            name: 'Prod. metros (miles)',
            measure: 'Numero',
            type: 'column',
            data: MetrosTotal
        }, {
            name: '% de cumplimiento',
            measure: 'Porcentaje',
            type: 'line',
            data: PorcentajeCumplimiento
        }, {
            name: 'Obj. metros (miles)',
            measure: 'Numero',
            type: 'line',
            data: MetrosObjetivo

        }],
        chart: {
            redrawOnParentResize: true,
            height: 350,
            type: 'line',
            zoom: {
                enabled: false
            },
            events: {
                mounted: (chart) => {
                    chart.windowResizeHandler();
                }
            }
        },
        stroke: {
            width: [0, 4, 4]
        },
        title: {
            text: 'Producción metros ' + IdRecurso + ' (en miles)',
            align: 'center',
            style: {
                fontSize: '18px'
            },
        },
        colors: ['#1ec21b', '#FF4560', '#000000'],
        plotOptions: {
            bar: {
                borderRadius: 4,
                columnWidth: '40%',
                dataLabels: {
                    position: 'bottom',

                }
            },
            dataLabels: {
                enabled: true,
                offsetX: 30
            },
        },
        dataLabels: {
            enabled: true,
            enabledOnSeries: [0, 1],
            offsetY: -4,
            style: {
                colors: ['#1ec21b', '#B3B6B7']
            },
            background: {
                enabled: true,
                borderRadius: 2,
                foreColor: '#17202A',
                borderColor: '#17202A',
            },
            formatter: function (value, config) {

                if (config.w.config.series[config.seriesIndex].measure == "Numero") {
                    return formatNumber(value);
                } else if (config.w.config.series[config.seriesIndex].measure == "Porcentaje") {
                    return value + "%";
                } else {
                    return minTommss(value);
                }

            }

        },
        labels: Fechas,
        xaxis: {
            tickPlacement: 'on',
            labels: {
                show: true,
                rotate: -45,
                rotateAlways: true,
            }
        },
        legend: {
            position: 'bottom',
            offsetY: 10
        },
        yaxis: [{
            title: {
                text: 'Producción metros (miles)',
                style: {
                    //color: '#1ec21b',
                }
            },
            forceNiceScale: true,
            seriesName: "Prod. metros (miles)",
            labels: {
                show: true,
                formatter: function (value) {
                    return formatNumber(value);
                }
            }
        }, {
            opposite: true,
            title: {
                text: '% de cumplimiento',
                style: {
                    color: '#343A40',
                }
            },
            seriesName: "% de cumplimiento", // Time data       
            min: 0, // minimum value allowed
            forceNiceScale: true,
            labels: {
                show: true,
                formatter: function (value) {
                    return value + "%";
                }
            }
        }, {

            seriesName: "Prod. metros (miles)", // Time data
            forceNiceScale: true,
            labels: {
                show: false,
                formatter: function (value) {

                    return formatNumber(value);
                }
            }

        }],
        markers: {
            size: 2,
        }

    };

    if (IdRecurso == 'FX07') {
        MetrosGraficaFx07 = new ApexCharts(document.querySelector("#MetrosGraficaFx07"), options);
        MetrosGraficaFx07.render();
    } else if (IdRecurso == 'FX08') {
        MetrosGraficaFx08 = new ApexCharts(document.querySelector("#MetrosGraficaFx08"), options);
        MetrosGraficaFx08.render();

    } else if (IdRecurso == 'FX09') {
        MetrosGraficaFx09 = new ApexCharts(document.querySelector("#MetrosGraficaFx09"), options);
        MetrosGraficaFx09.render();
    } else if (IdRecurso == 'FX10') {

        MetrosGraficaFx10 = new ApexCharts(document.querySelector("#MetrosGraficaFx10"), options);
        MetrosGraficaFx10.render();
    }




};

function AperturaGraficoMetroTotales(Fechas, MetrosTotal, MetrosObjetivo, PorcentajeCumplimiento) {

    var ContadorMetros = 0

    var options = {
        series: [{
            name: 'Producción real',
            measure: 'Numero',
            type: 'column',
            data: MetrosTotal
        }, {
            name: '% cumplimiento',
            measure: 'Porcentaje',
            type: 'line',
            data: PorcentajeCumplimiento
        }, {
            name: 'Objetivo mes',
            measure: 'Numero',
            type: 'line',
            data: MetrosObjetivo

        }],
        chart: {
            redrawOnParentResize: true,
            height: 350,
            type: 'line',
            zoom: {
                enabled: false
            },
            events: {
                mounted: (chart) => {
                    chart.windowResizeHandler();
                }
            }
        },
        stroke: {
            width: [0, 4, 4]
        },
        title: {
            text: 'Producción metros impresoras (en miles)',
            align: 'center',
            style: {
                fontSize: '18px'
            },
        },
        colors: ['#1ec21b', '#FF4560', '#000000'],
        plotOptions: {
            bar: {
                borderRadius: 4,
                columnWidth: '40%',
                dataLabels: {
                    position: 'bottom',

                }
            },
            dataLabels: {
                enabled: true,
                offsetX: 30
            },
        },
        dataLabels: {
            enabled: true,
            enabledOnSeries: [0, 1],
            offsetY: -4,
            style: {
                colors: ['#1ec21b', '#B3B6B7']
            },
            background: {
                enabled: true,
                borderRadius: 2,
                foreColor: '#17202A',
                borderColor: '#17202A',
            },
            formatter: function (value, config) {

                if (config.w.config.series[config.seriesIndex].measure == "Numero") {

                    return formatNumber(value);

                } else if (config.w.config.series[config.seriesIndex].measure == "Porcentaje") {

                    ContadorMetros = ContadorMetros + 1
                    return value + "%";

                } else {

                    ContadorMetros = ContadorMetros + 1
                    return minTommss(value);
                }



            }

        },
        labels: Fechas,
        xaxis: {
            tickPlacement: 'on',
            labels: {
                show: true,
                rotate: -45,
                rotateAlways: true,
            }
        },
        legend: {
            position: 'bottom',
            offsetY: 10
        },
        yaxis: [{
            opposite: true,
            title: {
                text: 'Producción real',
                style: {
                    //color: '#1ec21b',
                }
            },
            forceNiceScale: true,
            seriesName: "Producción real",
            min: '0',
            labels: {
                show: true,
                formatter: function (value) {
                    return formatNumber(value);
                }
            }
        }, {
            title: {
                text: '% de cumplimiento',
                style: {
                    color: '#343A40',
                }
            },
            seriesName: "% cumplimiento", // Time data
            //tickAmount: 5, // number of lines
            min: 0, // minimum value allowed
            forceNiceScale: true,
            //max: 100, // maximum value allowed
            labels: {
                show: true,
                formatter: function (value) {
                    return value + "%";
                }
            }
        }, {
            opposite: true,
            seriesName: "Producción real", // Time data
            min: '0',
            forceNiceScale: true,
            labels: {
                show: false,
                formatter: function (value) {

                    return formatNumber(value);
                }
            }

        }],
        markers: {
            size: 2,
        }

    };

    MetrosGraficaTotal = new ApexCharts(document.querySelector("#MetrosGraficaTotal"), options);

    MetrosGraficaTotal.render();

}

function AperturaGraficoScrapDetalle(IdRecurso,Fechas, ScrapResultante, ScrapObjetivo) {

    var options = {
        series: [{
            name: 'Merma (%)',
            measure: 'Porcentaje',
            type: 'line',
            data: ScrapResultante
        }, {
            name: 'Objetivo (%)',
            measure: 'Porcentaje',
            type: 'line',
            data: ScrapObjetivo

        }],
        chart: {
            redrawOnParentResize: true,
            height: 350,
            type: 'line',
            zoom: {
                enabled: false
            },
            events: {
                mounted: (chart) => {
                    chart.windowResizeHandler();
                }
            }
        },
        stroke: {
            width: [4, 4, 4]
        },
        title: {
            text: 'Porcentaje de merma (%) - ' + IdRecurso,
            align: 'center',
            style: {
                fontSize: '18px'
            },
        },
        colors: ['#FF4560', '#000000'],
        plotOptions: {
            bar: {
                borderRadius: 4,
                columnWidth: '40%',
                dataLabels: {
                    position: 'bottom',

                }
            },
            dataLabels: {
                enabled: true,
                offsetX: 30
            },
        },
        dataLabels: {
            enabled: true,
            enabledOnSeries: [0],
            offsetY: -4,
            style: {
                colors: ['#B3B6B7', '#B3B6B7']
            },
            background: {
                enabled: true,
                borderRadius: 2,
                foreColor: '#17202A',
                borderColor: '#17202A',
            },
            formatter: function (value, config) {



                if (config.w.config.series[config.seriesIndex].measure == "Numero") {
                    return parseInt(value, 10);
                } else if (config.w.config.series[config.seriesIndex].measure == "Porcentaje") {
                    return value + "%";
                } else {
                    return minTommss(value);
                }

            }

        },
        labels: Fechas,
        xaxis: {
            tickPlacement: 'on',
            labels: {
                show: true,
                rotate: -45,
                rotateAlways: true,
            }
        },
        legend: {
            position: 'bottom',
            offsetY: 10
        },
        yaxis: [{
            //opposite: true,
            title: {
                text: 'Porcentaje de merma',
                style: {
                    //color: '#1ec21b',
                }
            },
            min: 0, // minimum value allowed
            forceNiceScale: true,
            labels: {
                show: true,
                formatter: function (value) {

                    return value + "%";
                }
            }
        }],
        markers: {
            size: [2, 0],
        }

    };

    if (IdRecurso == 'FX07') {
        MermaGraficaFx07 = new ApexCharts(document.querySelector("#MermaGraficaFx07"), options);
        MermaGraficaFx07.render();
    } else if (IdRecurso == 'FX08') {
        MermaGraficaFx08 = new ApexCharts(document.querySelector("#MermaGraficaFx08"), options);
        MermaGraficaFx08.render();

    } else if (IdRecurso == 'FX09') {
        MermaGraficaFx09 = new ApexCharts(document.querySelector("#MermaGraficaFx09"), options);
        MermaGraficaFx09.render();
    } else if (IdRecurso == 'FX10') {

        MermaGraficaFx10 = new ApexCharts(document.querySelector("#MermaGraficaFx10"), options);
        MermaGraficaFx10.render();
    }
    
};

function AperturaGraficoScrapTotales(Fechas, ScrapResultante, ScrapObjetivo) {

    var options = {
        series: [{
            name: 'Merma (%)',
            measure: 'Porcentaje',
            type: 'line',
            data: ScrapResultante
        }, {
            name: 'Objetivo (%)',
            measure: 'Porcentaje',
            type: 'line',
            data: ScrapObjetivo

        }],
        chart: {
            redrawOnParentResize: true,
            height: 350,
            type: 'line',
            zoom: {
                enabled: false
            },
            events: {
                mounted: (chart) => {
                    chart.windowResizeHandler();
                }
            }
        },
        stroke: {
            width: [4, 4, 4]
        },
        title: {
            text: 'Porcentaje de merma (%)',
            align: 'center',
            style: {
                fontSize: '18px'
            },
        },
        colors: ['#FF4560', '#000000'],
        plotOptions: {
            bar: {
                borderRadius: 4,
                columnWidth: '40%',
                dataLabels: {
                    position: 'bottom',

                }
            },
            dataLabels: {
                enabled: true,
                offsetX: 30
            },
        },
        dataLabels: {
            enabled: true,
            enabledOnSeries: [0],
            offsetY: -4,
            style: {
                colors: ['#B3B6B7', '#B3B6B7']
            },
            background: {
                enabled: true,
                borderRadius: 2,
                foreColor: '#17202A',
                borderColor: '#17202A',
            },
            formatter: function (value, config) {



                if (config.w.config.series[config.seriesIndex].measure == "Numero") {
                    return parseInt(value, 10);
                } else if (config.w.config.series[config.seriesIndex].measure == "Porcentaje") {
                    return value + "%";
                } else {
                    return minTommss(value);
                }

            }

        },
        labels: Fechas,
        xaxis: {
            tickPlacement: 'on',
            labels: {
                show: true,
                rotate: -45,
                rotateAlways: true,
            }
        },
        legend: {
            position: 'bottom',
            offsetY: 10
        },
        yaxis: [{
            //opposite: true,
            title: {
                text: 'Porcentaje de merma',
                style: {
                    //color: '#1ec21b',
                }
            },
            min: 0, // minimum value allowed
            forceNiceScale: true,
            labels: {
                show: true,
                formatter: function (value) {

                    return value + "%";
                }
            }
        }],
        markers: {
            size: [2, 0],
        }

    };

    MermaGraficaTotal = new ApexCharts(document.querySelector("#MermaGraficaTotal"), options);


    MermaGraficaTotal.render();


};



function destruirGraficoSetUpHeptacromia() {
    try {
        SetUpGraficoTotal.destroy();
    } catch (ex) {
    }
    try {
        SetUpFx07.destroy();
    } catch (ex) {
    }
    try {
        SetUpFx08.destroy();
    } catch (ex) {
    }
    try {
        SetUpFx09.destroy();
    } catch (ex) {
    }
    try {
        SetUpFx10.destroy();
    } catch (ex) {
    }
}

function destruirGraficoSetUp() {
    try {
        SetUpGraficoTotal.destroy();
    } catch (ex) {
    }
    try {
        SetUpFx07.destroy();
    } catch (ex) {
    }
    try {
        SetUpFx08.destroy();
    } catch (ex) {
    }
    try {
        SetUpFx09.destroy();
    } catch (ex) {
    }
    try {
        SetUpFx10.destroy();
    } catch (ex) {
    }
}

function destruirGraficosGlobales() {
    //GRAFICOS SET UP
    try {
        SetUpGraficoTotal.destroy();
    } catch (ex) {
    }
    try {
        SetUpFx07.destroy();
    } catch (ex) {
    }
    try {
        SetUpFx08.destroy();
    } catch (ex) {
    }
    try {
        SetUpFx09.destroy();
    } catch (ex) {
    }
    try {
        SetUpFx10.destroy();
    } catch (ex) {
    }

    //GRAFICOS VELOCIDAD
    try {
        VelocidadGraficoTotal.destroy();
    } catch (ex) {
    }
    try {
        VelocidadGraficoFx07.destroy();
    } catch (ex) {
    }
    try {
        VelocidadGraficoFx08.destroy();
    } catch (ex) {
    }
    try {
        VelocidadGraficoFx09.destroy();
    } catch (ex) {
    }
    try {
        VelocidadGraficoFx10.destroy();
    } catch (ex) {
    }

    //GRAFICOS METROS
    try {
        MetrosGraficaTotal.destroy();
    } catch (ex) {
    }
    try {
        MetrosGraficaFx07.destroy();
    } catch (ex) {
    }
    try {
        MetrosGraficaFx08.destroy();
    } catch (ex) {
    }
    try {
        MetrosGraficaFx09.destroy();
    } catch (ex) {
    }
    try {
        MetrosGraficaFx10.destroy();
    } catch (ex) {
    }


    //GRAFICOS MERMA
    try {
        MermaGraficaTotal.destroy();
    } catch (ex) {
    }
    try {
        MermaGraficaFx07.destroy();
    } catch (ex) {
    }
    try {
        MermaGraficaFx08.destroy();
    } catch (ex) {
    }
    try {
        MermaGraficaFx09.destroy();
    } catch (ex) {
    }
    try {
        MermaGraficaFx10.destroy();
    } catch (ex) {
    }

}



function minTommss(minutes) {
    var sign = minutes < 0 ? "-" : "";
    var min = Math.floor(Math.abs(minutes));
    var sec = Math.floor((Math.abs(minutes) * 60) % 60);
    //return sign + (min < 10 ? "0" : "") + min + ":" + (sec < 10 ? "0" : "") + sec;
    return sign + (min < 10 ? "" : "") + min + ":" + (sec < 10 ? "0" : "") + sec;
}

// m:ss to minute decimal
function minDecimal(min, sec) {
  
    return (min + sec * 0.0168).toFixed(2);
}

function formatNumber(num) {
    if (!num || num == 'NaN') return '-';
    if (num == 'Infinity') return '&#x221e;';
    num = num.toString().replace(/\$|\,/g, '');
    if (isNaN(num))
        num = "0";
    sign = (num == (num = Math.abs(num)));
    num = Math.floor(num * 100 + 0.50000000001);
    cents = num % 100;
    num = Math.floor(num / 100).toString();
    if (cents < 10)
        cents = "0" + cents;
    for (var i = 0; i < Math.floor((num.length - (1 + i)) / 3) ; i++)
        num = num.substring(0, num.length - (4 * i + 3)) + ',' + num.substring(num.length - (4 * i + 3));
    //return (((sign) ? '' : '-') + num + '.' + cents);
    return (((sign) ? '' : '-') + num);
}

