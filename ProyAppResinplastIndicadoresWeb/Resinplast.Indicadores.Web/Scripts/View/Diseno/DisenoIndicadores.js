$(function () {

    $('.INDDISEÑ').css('background', '#3E7C17');
    $("#menuDiseño").addClass("open");
    //$("#page-container").removeClass("sidebar-o");

    //alert('PAGINA DE PRUEBA');
    var GrafLineaAperturaDia
    var GrafBarHoriTrabajosApertCliente
    var GrafMixAperturaSemanas
    var GrafLineaPreprensaDia
    var GrafBarHoriTrabajosPreprenCliente
    var GrafMixPreprensaSemanas
    var GrafMixAperturaSemanaCompacion
    var GrafMixPreprensaSemanaCompacion
    var dia;
    var fecha = new Date();
    var ano = fecha.getFullYear();
    var mes = (fecha.getMonth() + 1);
    if (mes < 10) {
        mes = '0' + mes
    };


    $("#SelectAños option[value='" + ano + "']").attr("selected", true);
    $("#SelectMes option[value='" + mes + "']").attr("selected", true);

    for (var i = ano + 1; i < 2050; i++) {
        $("#Inicial" + i).remove();
    }

    DatosApertura(ano, mes);
    DatosAperturaSemana(ano, mes);
    DatosPreprensa(ano, mes);
    DatosPreprensaSemana(ano, mes);
    DatosAperturaCompletadasSemana(ano, mes);
    DatosPreprensaCompletadasSemana(ano, mes);

    //setTimeout(
    //  function () {          
    //  }, 700);

});

$(document).on('click', '#btnBuscar', function () {
    try {

        Destruir();



        ano = document.getElementById("SelectAños").value;
        mes = document.getElementById("SelectMes").value;
        DatosApertura(ano, mes);
        DatosPreprensa(ano, mes);
        DatosAperturaSemana(ano, mes);
        DatosPreprensaSemana(ano, mes);
        DatosAperturaCompletadasSemana(ano, mes);
        DatosPreprensaCompletadasSemana(ano, mes);

    } catch (ex) {

    }
});


function Destruir() {

    try {
        GrafLineaAperturaDia.destroy();
    } catch (ex) {
    }
    try {
        GrafLineaPreprensaDia.destroy();
    } catch (ex) {
    }
    try {
        GrafMixAperturaSemanas.destroy();
    } catch (ex) {
    }
    try {
        GrafMixPreprensaSemanas.destroy();
    } catch (ex) {
    }
    try {
        GrafMixAperturaSemanaCompacion.destroy();
    } catch (ex) {
    }
    try {
        GrafMixPreprensaSemanaCompacion.destroy();
    } catch (ex) {
    }


}

function DatosApertura(anio, mes) {

    let Trabajos = [];
    let Fechas = [];
    let DiseñoIndicadoresAperturaRequest = [{
        FechaEnAprobacionCliente: anio + "/" + mes + "/" + '01',
        Año: anio + mes + '01'
    }];

    $.ajax({
        type: 'POST',
        dataType: "JSON",
        contentType: 'application/json; charset=utf-8',
        data: JSON.stringify(DiseñoIndicadoresAperturaRequest),
        url: '/Diseno/ListarAperturasDia',
        success: function (ListaAperturaDiarias) {


            //alert(JSON.stringify(ListaAperturaDiarias));


            if (ListaAperturaDiarias.length > 0) {

                for (var i = 0; i < ListaAperturaDiarias.length; i++) {

                    Fechas.push(ListaAperturaDiarias[i].DescripcionFecha)
                    Trabajos.push(ListaAperturaDiarias[i].TotalTrabajos)


                }

                DatosAperturaEtiquetas(ListaAperturaDiarias[i - 1].TotalTrabajosAño, ListaAperturaDiarias[i - 1].TotalTrabajosmes, ListaAperturaDiarias[i - 1].TrabajosPromedio)
                CargarGraficoApertura(Fechas, Trabajos, mes, anio)

            }

        }
    })
}

function DatosAperturaSemana(anio, mes) {

    let Trabajos = [];
    let TrabajosSinCompletar = [];
    let Fechas = [];
    let TiempoPromedios = [];
    let DiseñoIndicadoresAperturaRequest = [{
        FechaEnAprobacionCliente: anio + "/" + mes + "/" + '01',
        Año: anio + mes + '01'
    }];

    $.ajax({
        type: 'POST',
        dataType: "JSON",
        contentType: 'application/json; charset=utf-8',
        data: JSON.stringify(DiseñoIndicadoresAperturaRequest),
        url: '/Diseno/ListarAperturasSemana',
        success: function (ListaAperturaSemana) {

            //alert(JSON.stringify(ListaAperturaSemana));

            if (ListaAperturaSemana.length > 0) {

                for (var i = 0; i < ListaAperturaSemana.length; i++) {

                    Fechas.push(ListaAperturaSemana[i].DescripcionFecha)
                    TiempoPromedios.push(ListaAperturaSemana[i].PromedioSem)
                    Trabajos.push(ListaAperturaSemana[i].TotalTrabajos)
                    TrabajosSinCompletar.push(ListaAperturaSemana[i].TrabajosSinCompletar)

                }

                CargarGraficoAperturaComparacionSemana(Fechas, Trabajos, TrabajosSinCompletar, TiempoPromedios, mes, anio)


            }

        }
    })
}

function DatosAperturaCompletadasSemana(anio, mes) {

    let Trabajos = [];
    let TrabajosSinCompletar = [];
    let Fechas = [];
    let TiempoPromedios = [];
    let DiseñoIndicadoresAperturaRequest = [{
        FechaEnAprobacionCliente: anio + "/" + mes + "/" + '01',
        Año: anio + mes + '01'
    }];

    $.ajax({
        type: 'POST',
        dataType: "JSON",
        contentType: 'application/json; charset=utf-8',
        data: JSON.stringify(DiseñoIndicadoresAperturaRequest),
        url: '/Diseno/ListarAperturasCompletadasSemana',
        success: function (ListaAperturaSemana) {

            if (ListaAperturaSemana.length > 0) {

                for (var i = 0; i < ListaAperturaSemana.length; i++) {

                    Fechas.push(ListaAperturaSemana[i].DescripcionFecha)
                    TiempoPromedios.push(ListaAperturaSemana[i].PromedioSem)
                    Trabajos.push(ListaAperturaSemana[i].TotalTrabajos)
                    TrabajosSinCompletar.push(ListaAperturaSemana[i].TrabajosSinCompletar)

                }

                CargarGraficoAperturaSemana(Fechas, Trabajos, TrabajosSinCompletar, TiempoPromedios, mes, anio)
            }

        }
    })
}

function DatosPreprensa(anio, mes) {

    let TrabajosConPC = [];
    let TrabajosSinPC = [];
    let Fechas = [];
    let DiseñoIndicadoresPreprensasRequest = [{
        FechaEnviadoProceso: anio + "/" + mes + "/" + '01',
        Año: anio + mes + '01'
    }];

    $.ajax({
        type: 'POST',
        dataType: "JSON",
        contentType: 'application/json; charset=utf-8',
        data: JSON.stringify(DiseñoIndicadoresPreprensasRequest),
        url: '/Diseno/ListarPrepensaDia',
        success: function (ListaPreprensaDiarias) {

            if (ListaPreprensaDiarias.length > 0) {

                for (var i = 0; i < ListaPreprensaDiarias.length; i++) {

                    Fechas.push(ListaPreprensaDiarias[i].DescripcionFecha)
                    TrabajosSinPC.push(ListaPreprensaDiarias[i].TrabajosSinPC)
                    TrabajosConPC.push(ListaPreprensaDiarias[i].TrabajosConPC)
                    //if (i == ListaPreprensaDiarias.length - 1) {
                    //    DatosPreprensaEtiquetas(ListaPreprensaDiarias[i].TotalTrabajosAño, ListaPreprensaDiarias[i].TotalTrabajosmes, ListaPreprensaDiarias[i].TotalTrabajos)
                    //}
                }
                DatosPreprensaEtiquetas(ListaPreprensaDiarias[i - 1].TotalTrabajosAño, ListaPreprensaDiarias[i - 1].TotalTrabajosmes, ListaPreprensaDiarias[i - 1].TrabajosPromedio)
                CargarGraficoPreprensa(Fechas, TrabajosSinPC, TrabajosConPC, mes, anio)

            }
        }
    })
}

function DatosPreprensaSemana(anio, mes) {

    let Trabajos = [];
    let Fechas = [];
    let TiempoPromedios = [];
    let TrabajosSinCompletar = [];
    let DiseñoIndicadoresPreprensasRequest = [{
        FechaEnviadoProceso: anio + "/" + mes + "/" + '01',
        Año: anio + mes + '01'
    }];

    $.ajax({
        type: 'POST',
        dataType: "JSON",
        contentType: 'application/json; charset=utf-8',
        data: JSON.stringify(DiseñoIndicadoresPreprensasRequest),
        url: '/Diseno/ListarPreprensasSemana',
        success: function (ListaPreprensaSemana) {

            if (ListaPreprensaSemana.length > 0) {

                for (var i = 0; i < ListaPreprensaSemana.length; i++) {

                    Fechas.push(ListaPreprensaSemana[i].DescripcionFecha)
                    TiempoPromedios.push(ListaPreprensaSemana[i].PromedioSem)
                    Trabajos.push(ListaPreprensaSemana[i].TotalTrabajos)
                    TrabajosSinCompletar.push(ListaPreprensaSemana[i].TrabajosSinCompletar)
                }

                CargarGraficoPreprensaComparacionSemana(Fechas, Trabajos, TrabajosSinCompletar, TiempoPromedios, mes, anio)
            }

        }
    })
}

function DatosPreprensaCompletadasSemana(anio, mes) {

    let Trabajos = [];
    let Fechas = [];
    let TiempoPromedios = [];
    let TrabajosSinCompletar = [];
    let DiseñoIndicadoresPreprensasRequest = [{
        FechaEnviadoProceso: anio + "/" + mes + "/" + '01',
        Año: anio + mes + '01'
    }];

    $.ajax({
        type: 'POST',
        dataType: "JSON",
        contentType: 'application/json; charset=utf-8',
        data: JSON.stringify(DiseñoIndicadoresPreprensasRequest),
        url: '/Diseno/ListarPreprensasCompletadasSemana',
        success: function (ListaPreprensaSemana) {

            if (ListaPreprensaSemana.length > 0) {

                for (var i = 0; i < ListaPreprensaSemana.length; i++) {

                    Fechas.push(ListaPreprensaSemana[i].DescripcionFecha)
                    TiempoPromedios.push(ListaPreprensaSemana[i].PromedioSem)
                    Trabajos.push(ListaPreprensaSemana[i].TotalTrabajos)
                    TrabajosSinCompletar.push(ListaPreprensaSemana[i].TrabajosSinCompletar)
                }

                CargarGraficoPreprensaSemana(Fechas, Trabajos, TiempoPromedios, mes, anio)
            }

        }
    })
}



function CargarGraficoApertura(Fechas, Trabajos, mes, ano) {

    var line_column_options = {
        series: [{
            name: 'Trabajos aperturados',
            data: Trabajos
        }],
        chart: {
            redrawOnParentResize: true,
            height: 350,
            type: 'line',
            zoom: {
                enabled: false
            },
            events: {
                dataPointSelection: function (event, chartContext, config) {
                    //
                    //alert(config.w.config.series[0].data[config.dataPointIndex] + " fecha " + config.w.globals.categoryLabels[config.dataPointIndex]);
                    let DiaSelect = config.w.globals.categoryLabels[config.dataPointIndex]

                    if (DiaSelect.substring(0, 2).trim().length == 2) {
                        dia = parseInt(DiaSelect.substring(0, 2).trim())
                    } else {
                        dia = "0" + (parseInt(DiaSelect.substring(0, 2).trim()))
                    }



                    AperturaDiaDetalle((ano + "-" + mes + "-" + dia))
                    $('#ModalAperturas').modal('toggle')
                },
                mounted: (chart) => {
                    chart.windowResizeHandler();
                }
            }
        },
        title: {
            text: 'Aperturas por día',
            align: 'left',
            style: {
                fontSize: '18px'
            },
        },
        colors: ['#1ec21b'],
        dataLabels: {
            enabled: true
        },
        stroke: {
            curve: 'straight'
        },

        grid: {
            row: {
                colors: ['#f3f3f3', 'transparent'], // takes an array which will be repeated on columns
                opacity: 0.5
            },
        },
        xaxis: {
            categories: Fechas,
            labels: {
                show: true,
                rotate: -45,
                rotateAlways: true,
            },
            title: {
                offsetY: -20,
                text: 'Fecha cierre de Aperturas',
            }
        },
        yaxis: [{
            title: {
                text: 'N° Trabajos aperturados',
                //style: {
                //    color: '#1ec21b',
                //}
            },
            //axisBorder: {
            //    show: true,
            //    color: '#1ec21b'
            //},
            //axisTicks: {
            //    show: true,
            //},
            labels: {
                formatter: function (val) {
                    return Math.floor(val)
                }
            },
            min: 0,
            forceNiceScale: true
        }],
        tooltip: {
            intersect: true,
            shared: false
        },
        markers: {
            size: 6,
        }
    };

    GrafLineaAperturaDia = new ApexCharts(document.querySelector("#GrafLineaAperturaDia"), line_column_options);
    GrafLineaAperturaDia.render();
}

function CargarGraficoAperturaSemana(Fechas, Trabajos, TrabajosSinCompletar, TiempoPromedios, mes, ano) {

    var options = {
        series: [{
            name: 'Trabajos de Apertura',
            type: 'column',
            data: Trabajos
        }, {
            name: 'Tiempo promedio',
            type: 'line',
            data: TiempoPromedios
        }],
        chart: {
            redrawOnParentResize: true,
            height: 350,
            type: 'line',
            zoom: {
                enabled: false
            },
            events: {
                dataPointSelection: function (event, chartContext, config) {

                    //
                    let EstadoTrabajo = 'COMPLETO'
                    //alert(config.w.config.series[0].data[config.dataPointIndex] + " fecha " + config.w.globals.categoryLabels[config.dataPointIndex]);
                    let DiaSelect = config.w.globals.categoryLabels[config.dataPointIndex]

                    if (DiaSelect.substring(0, 2).trim().length == 2) {
                        dia = DiaSelect.substring(0, 2).trim()
                    } else {
                        dia = "0" + DiaSelect.substring(0, 2).trim()
                    }

                    AperturaDiaDetalle((ano + "-" + ConvertMes(DiaSelect.substring(2, 6).trim()) + "-" + dia), mes, EstadoTrabajo)
                    $('#ModalAperturas').modal('toggle')
                },
                mounted: (chart) => {
                    chart.windowResizeHandler();
                }
            }
        },
        stroke: {
            width: [0, 4]
        },
        title: {
            text: 'Tiempo promedio por semana',
            align: 'left',
            style: {
                fontSize: '18px'
            },
        },
        colors: ['#1ec21b', '#343A40'],
        plotOptions: {
            bar: {
                borderRadius: 10,
                columnWidth: '40%',
                dataLabels: {
                    position: 'center',

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
            }

        },
        labels: Fechas,
        xaxis: {
            tickPlacement: 'on',
        },
        legend: {
            position: 'bottom',
            offsetY: 10
        },
        yaxis: [{
            title: {
                text: 'N° de Aperturas (completas) ',
                style: {
                    //color: '#1ec21b',
                }
            },
            forceNiceScale: true,
            labels: {
                show: true,
                formatter: function (val) {
                    return Math.floor(val)
                },
                style: {
                    //colors: '#1ec21b',
                }
            }

        }, {
            opposite: true,
            title: {
                text: 'Tiempo promedio (Días)',
                style: {
                    color: '#343A40',
                }
            },
            labels: {
                show: true,
                formatter: function (val) {
                    return val
                },
                style: {
                    //colors: '#343A40',
                },
                min: 0,
                forceNiceScale: true
            },

        }],
        markers: {
            size: 2,
        }


    };

    GrafMixAperturaSemanas = new ApexCharts(document.querySelector("#GrafMixAperturaSemana"), options);
    GrafMixAperturaSemanas.render();

}

function CargarGraficoAperturaComparacionSemana(Fechas, Trabajos, TrabajosSinCompletar, TiempoPromedios, mes, ano) {

    var options = {
        series: [{
            name: 'Trabajos completados',
            data: Trabajos
        }, {
            name: 'Trabajos sin completar',
            data: TrabajosSinCompletar
        }],
        chart: {
            redrawOnParentResize: true,
            type: 'bar',
            height: 350,
            stacked: true,
            toolbar: {
                show: true
            },
            zoom: {
                enabled: false
            },
            events: {
                dataPointSelection: function (event, chartContext, config) {

                    //
                    let EstadoTrabajo = config.seriesIndex
                    //alert(config.w.config.series[0].data[config.dataPointIndex] + " fecha " + config.w.globals.categoryLabels[config.dataPointIndex]);
                    let DiaSelect = config.w.globals.categoryLabels[config.dataPointIndex]

                    if (DiaSelect.substring(0, 2).trim().length == 2) {
                        dia = DiaSelect.substring(0, 2).trim()
                    } else {
                        dia = "0" + DiaSelect.substring(0, 2).trim()
                    }

                    AperturaDiaDetalle((ano + "-" + ConvertMes(DiaSelect.substring(2, 6).trim()) + "-" + dia), mes, EstadoTrabajo)
                    $('#ModalAperturas').modal('toggle')
                },
                mounted: (chart) => {
                    chart.windowResizeHandler();
                }
            }
        },
        dataLabels: {
            enabled: true,
            style: {
                fontSize: '11px',
                fontWeight: 'bold',
                colors: undefined
            },
            background: {
                enabled: true,
                borderRadius: 2,
                foreColor: '#17202A',
                borderColor: '#17202A',
            }
        },
        title: {
            text: 'Trabajos ingresados por semana',
            align: 'left',
            style: {
                fontSize: '18px'
            },
        },
        colors: ['#1ec21b', '#FF4560'],
        responsive: [{
            breakpoint: 480,
            options: {
                legend: {
                    position: 'bottom',
                    offsetX: -10,
                    offsetY: 0
                }
            }
        }],
        plotOptions: {
            bar: {
                horizontal: false,
                borderRadius: 10,
                columnWidth: '35%',
                dataLabels: {
                    total: {
                        enabled: true,
                        offsetY: -5,
                        style: {
                            color: '#B3B6B7',
                            fontSize: '14px',
                            fontWeight: 600
                        }
                    }
                }
            },
        },
        labels: Fechas,
        xaxis: {
            //categories: Fechas,
            tickPlacement: 'on',
        },
        yaxis: [{
            title: {
                text: 'N° de Aperturas',
                style: {
                    //color: '#1ec21b',
                }
            },
            //axisBorder: {
            //    show: true,
            //    color: '#1ec21b'
            //},
            //axisTicks: {
            //    show: true,
            //},
            labels: {
                formatter: function (val) {
                    return Math.floor(val)
                },
                style: {
                    //colors: '#1ec21b',
                }
            }

        }],
        legend: {
            position: 'bottom',
            offsetY: 10,
            markers: {
                radius: 10,
            }
        },
        fill: {
            opacity: 1
        }

    };

    GrafMixAperturaSemanaCompacion = new ApexCharts(document.querySelector("#GrafMixAperturaSemanaCompacion"), options);
    GrafMixAperturaSemanaCompacion.render();

}

function CargarGraficoPreprensa(Fechas, TrabajosSinPC, TrabajosConPC, mes, ano) {

    var line_column_options = {
        series: [{
            name: 'Pre Prensas',
            data: TrabajosSinPC
        }, {
            name: 'Pruebas de color',
            data: TrabajosConPC
        }],
        chart: {
            redrawOnParentResize: true,
            type: 'bar',
            height: 350,
            stacked: true,
            toolbar: {
                show: true
            },
            zoom: {
                enabled: false
            },
            events: {
                dataPointSelection: function (event, chartContext, config) {

                    //
                    let EstadoTrabajo = config.seriesIndex
                    //alert(config.w.config.series[0].data[config.dataPointIndex] + " fecha " + config.w.globals.categoryLabels[config.dataPointIndex]);
                    //alert(config.seriesIndex)
                    let DiaSelect = config.w.globals.categoryLabels[config.dataPointIndex]

                    if (DiaSelect.substring(0, 2).trim().length == 2) {
                        dia = DiaSelect.substring(0, 2).trim()
                    } else {
                        dia = "0" + DiaSelect.substring(0, 2).trim()
                    }

                    if (EstadoTrabajo == 1) {
                        EstadoTrabajo = 'CON PC'
                    } else {
                        EstadoTrabajo = 'SIN PC'
                    }

                    PreprensaDiaDetalle((ano + "-" + ConvertMes(DiaSelect.substring(2, 6).trim()) + "-" + dia), mes, EstadoTrabajo)

                    if (EstadoTrabajo == 'CON PC') {

                        $('#ModalPreprensaPruebaColor').modal('toggle')

                    } else if (EstadoTrabajo == 'SIN PC') {

                        $('#ModalPreprensaSinPruebaColor').modal('toggle')

                    } else {

                        $('#ModalPreprensa').modal('toggle')

                    }

                },
                mounted: (chart) => {
                    chart.windowResizeHandler();
                }
            }
        },
        dataLabels: {
            enabled: true,
            style: {
                fontSize: '11px',
                fontWeight: 'bold',
                colors: undefined
            },
            background: {
                enabled: true,
                borderRadius: 2,
                foreColor: '#17202A',
                borderColor: '#17202A',
            }
        },
        title: {
            text: 'Pre Prensas por día',
            align: 'left',
            style: {
                fontSize: '18px'
            },
        },
        colors: ['#1ec21b', '#FF4560'],
        responsive: [{
            breakpoint: 480,
            options: {
                legend: {
                    position: 'bottom',
                    offsetX: -10,
                    offsetY: 0
                }
            }
        }],
        plotOptions: {
            bar: {
                horizontal: false,
                borderRadius: 4,
                columnWidth: '35%',
                dataLabels: {
                    total: {
                        enabled: true,
                        offsetY: -5,
                        style: {
                            color: '#B3B6B7',
                            fontSize: '14px',
                            fontWeight: 600
                        }
                    }
                }
            },
        },
        labels: Fechas,
        xaxis: {
            tickPlacement: 'on',
            categories: Fechas,
            labels: {
                show: true,
                rotate: -45,
                rotateAlways: true,
            },
            title: {
                offsetY: -20,
                text: 'Fecha cierre de Pre Prensas',
            }
        },
        yaxis: [{
            title: {

                text: 'Número de Pre Prensas',
                style: {
                    //color: '#1ec21b',
                }
            },

            labels: {
                formatter: function (val) {
                    return Math.floor(val)
                }
            },
            min: 0,
            forceNiceScale: true
        }],
        legend: {
            position: 'bottom',
            offsetY: 10,
            markers: {
                radius: 10,
            }

        },
        fill: {
            opacity: 1
        }
    };



    GrafLineaPreprensaDia = new ApexCharts(document.querySelector("#GrafLineaPreprensaDia"), line_column_options);
    GrafLineaPreprensaDia.render();
}

function CargarGraficoPreprensaSemana(Fechas, Trabajos, TiempoPromedios, mes, ano) {

    var options = {
        series: [{
            name: 'Trabajos de Pre Prensa',
            type: 'column',
            data: Trabajos
        }, {
            name: 'Tiempo promedio',
            type: 'line',
            data: TiempoPromedios
        }],
        chart: {
            redrawOnParentResize: true,
            height: 350,
            type: 'line',
            zoom: {
                enabled: false
            },
            events: {
                dataPointSelection: function (event, chartContext, config) {

                    //
                    let EstadoTrabajo = 'COMPLETO'
                    //alert(config.w.config.series[0].data[config.dataPointIndex] + " fecha " + config.w.globals.categoryLabels[config.dataPointIndex]);
                    let DiaSelect = config.w.globals.categoryLabels[config.dataPointIndex]

                    if (DiaSelect.substring(0, 2).trim().length == 2) {
                        dia = DiaSelect.substring(0, 2).trim()
                    } else {
                        dia = "0" + DiaSelect.substring(0, 2).trim()
                    }
                    PreprensaDiaDetalle((ano + "-" + ConvertMes(DiaSelect.substring(2, 6).trim()) + "-" + dia), mes, EstadoTrabajo)

                    $('#ModalPreprensa').modal('toggle')
                },
                mounted: (chart) => {
                    chart.windowResizeHandler();
                }
            }
        },
        stroke: {
            width: [0, 4]
        },
        title: {
            text: 'Tiempo promedio por semana',
            align: 'left',
            style: {
                fontSize: '18px'
            },
        },
        colors: ['#1ec21b', '#343A40'],
        plotOptions: {
            bar: {
                borderRadius: 10,
                columnWidth: '40%',
                dataLabels: {
                    position: 'center',

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
            }

        },
        labels: Fechas,
        xaxis: {
            tickPlacement: 'on',
        },
        legend: {
            position: 'bottom',
            offsetY: 10
        },
        yaxis: [{
            title: {
                text: 'N° de Pre Prensas (completas) ',
                style: {
                    //color: '#1ec21b',
                }
            },
            //axisBorder: {
            //    show: true,
            //    color: '#1ec21b'
            //},
            //axisTicks: {
            //    show: true,
            //},
            labels: {
                formatter: function (val) {
                    return Math.floor(val)
                },
                style: {
                    //colors: '#1ec21b',
                }
            }

        }, {
            opposite: true,
            title: {
                text: 'Tiempo promedio (días)',
                style: {
                    color: '#343A40',
                }
            },
            //axisBorder: {
            //    show: true,
            //    color: '#343A40'
            //},
            //axisTicks: {
            //    show: true,
            //},
            labels: {
                formatter: function (val) {
                    return val
                },
                style: {
                    //colors: '#343A40',
                },
                min: 0,
                forceNiceScale: true
            }
        }],
        markers: {
            size: 2,
        }

    };

    GrafMixPreprensaSemanas = new ApexCharts(document.querySelector("#GrafMixPreprensaSemana"), options);
    GrafMixPreprensaSemanas.render();

}

function CargarGraficoPreprensaComparacionSemana(Fechas, Trabajos, TrabajosSinCompletar, TiempoPromedios, mes, ano) {

    var options = {
        series: [{
            name: 'Trabajos completados',
            data: Trabajos
        }, {
            name: 'Trabajos sin completar',
            data: TrabajosSinCompletar
        }],
        chart: {
            redrawOnParentResize: true,
            type: 'bar',
            height: 350,
            stacked: true,
            toolbar: {
                show: true
            },
            zoom: {
                enabled: false
            },
            events: {
                dataPointSelection: function (event, chartContext, config) {

                    //
                    let EstadoTrabajo = config.seriesIndex
                    //alert(config.w.config.series[0].data[config.dataPointIndex] + " fecha " + config.w.globals.categoryLabels[config.dataPointIndex]);
                    let DiaSelect = config.w.globals.categoryLabels[config.dataPointIndex]

                    if (DiaSelect.substring(0, 2).trim().length == 2) {
                        dia = DiaSelect.substring(0, 2).trim()
                    } else {
                        dia = "0" + DiaSelect.substring(0, 2).trim()
                    }
                    PreprensaDiaDetalle((ano + "-" + ConvertMes(DiaSelect.substring(2, 6).trim()) + "-" + dia), mes, EstadoTrabajo)
                    $('#ModalPreprensa').modal('toggle')
                },
                mounted: (chart) => {
                    chart.windowResizeHandler();
                }
            }
        },
        dataLabels: {
            enabled: true,
            style: {
                fontSize: '11px',
                fontWeight: 'bold',
                colors: undefined
            },
            background: {
                enabled: true,
                borderRadius: 2,
                foreColor: '#17202A',
                borderColor: '#17202A',
            }
        },
        title: {
            text: 'Trabajos ingresados por semana',
            align: 'left',
            style: {
                fontSize: '18px'
            },
        },
        colors: ['#1ec21b', '#FF4560'],
        responsive: [{
            breakpoint: 480,
            options: {
                legend: {
                    position: 'bottom',
                    offsetX: -10,
                    offsetY: 0
                }
            }
        }],
        plotOptions: {
            bar: {
                horizontal: false,
                borderRadius: 10,
                columnWidth: '35%',
                dataLabels: {
                    total: {
                        enabled: true,
                        offsetY: -5,
                        style: {
                            color: '#B3B6B7',
                            fontSize: '14px',
                            fontWeight: 600
                        }
                    }
                }
            },
        },
        labels: Fechas,
        xaxis: {
            //categories: Fechas,
            tickPlacement: 'on',
        },
        yaxis: [{
            title: {
                text: 'Número de Pre Prensas',
                style: {
                    //color: '#1ec21b',
                }
            },
            //axisBorder: {
            //    show: true,
            //    color: '#1ec21b'
            //},
            //axisTicks: {
            //    show: true,
            //},
            labels: {
                formatter: function (val) {
                    return Math.floor(val)
                },
                style: {
                    //colors: '#1ec21b',
                }
            }
        }],
        legend: {
            position: 'bottom',
            offsetY: 10,
            markers: {
                radius: 10,
            }
        },
        fill: {
            opacity: 1
        }
    };


    GrafMixPreprensaSemanaCompacion = new ApexCharts(document.querySelector("#GrafMixPreprensaSemanaCompacion"), options);
    GrafMixPreprensaSemanaCompacion.render();

}

function AperturaDiaDetalle(fecha, mes, EstadoTrabajo) {
    //
    let DiseñoIndicadoresAperturaRequest = [{
        FechaEnAprobacionCliente: new Date(fecha + "T00:00:00"),
        FechaIniSemEnAprobacionCliente: new Date(fecha + "T00:00:00"),
        FechaIniSemEnviadoDiseno: new Date(fecha + "T00:00:00"),
        mes: parseInt(mes),
        EstadoTrabajo: EstadoTrabajo
    }];

    $.ajax({
        type: 'POST',
        dataType: "JSON",
        contentType: 'application/json; charset=utf-8',
        data: JSON.stringify(DiseñoIndicadoresAperturaRequest),
        url: '/Diseno/ConsultarAperturasDiasDetalle2',
        success: function (ListaAperturaDiariasDetalle) {

            $("#BodyTablaDatosApertura").empty();

            if (ListaAperturaDiariasDetalle.length > 0) {


                for (var i = 0; i < ListaAperturaDiariasDetalle.length; i++) {

                    var tr = '<tr><td class="text-center"  style="font-size: 11px">' + ListaAperturaDiariasDetalle[i].NroLegalOrdenTrabajo + '</td>' +
                      '<td class="text-center"  style="font-size: 11px">' + ListaAperturaDiariasDetalle[i].NombreCliente + '</td>' +
                      '<td class="text-center"  style="font-size: 11px">' + ListaAperturaDiariasDetalle[i].NombreProducto + '</td>' +
                      '<td class="text-center"  style="font-size: 11px">' + ConvertFecha(ListaAperturaDiariasDetalle[i].FechaEnviadoDiseno, 'Apertura') + '</td>' +
                      '<td class="text-center"  style="font-size: 11px">' + ConvertFecha(ListaAperturaDiariasDetalle[i].FechaEnAprobacionCliente, 'Apertura') + '</td>' +
                      '<td class="text-center"  style="font-size: 11px">' + ListaAperturaDiariasDetalle[i].TiempoDeApertura + ' días' + '</td></tr>'
                    '</td></tr>'

                    $("#BodyTablaDatosApertura").append(tr);
                }
            }
        }
    })
}

function PreprensaDiaDetalle(fecha, mes, EstadoTrabajo) {

    let DiseñoIndicadoresPreprensasRequest = [{
        FechaEnviadoCliche: new Date(fecha + "T00:00:00"),
        FechaIniSemEnviadoProceso: new Date(fecha + "T00:00:00"),
        FechaIniSemEnviadoCliche: new Date(fecha + "T00:00:00"),
        mes: parseInt(mes),
        EstadoTrabajo: EstadoTrabajo

    }];

    $.ajax({
        type: 'POST',
        dataType: "JSON",
        contentType: 'application/json; charset=utf-8',
        data: JSON.stringify(DiseñoIndicadoresPreprensasRequest),
        url: '/Diseno/ConsultarPreprensaDiasDetalle2',
        success: function (ListaPreprensaDiariasDetalle) {

            //alert(JSON.stringify(ListaPreprensaDiariasDetalle));

            $("#BodyTablaDatosPreprensa").empty();
            $("#BodyTablaDatosPreprensaPruebaColor").empty();
            $("#BodyTablaDatosPreprensaSinPruebaColor").empty();

            if (ListaPreprensaDiariasDetalle.length > 0) {


                for (var i = 0; i < ListaPreprensaDiariasDetalle.length; i++) {

                    //alert(ConvertFecha(ListaPreprensaDiariasDetalle[i].FechaEnviadoProceso));
                    //alert(ConvertFecha(ListaPreprensaDiariasDetalle[i].FechaEnviadoCliche));
                    var tr = '<tr><td class="text-center"  style="font-size: 11px">' + ListaPreprensaDiariasDetalle[i].NroLegalOrdenTrabajo + '</td>' +
                      '<td class="text-center"  style="font-size: 11px">' + ListaPreprensaDiariasDetalle[i].NombreCliente + '</td>' +
                      '<td class="text-center"  style="font-size: 11px">' + ListaPreprensaDiariasDetalle[i].NombreProducto + '</td>' +
                      '<td class="text-center"  style="font-size: 11px">' + ConvertFecha(ListaPreprensaDiariasDetalle[i].FechaEnviadoProceso, 'Apertura') + '</td>' +
                      '<td class="text-center"  style="font-size: 11px">' + ConvertFecha(ListaPreprensaDiariasDetalle[i].FechaEnviadoCliche, 'Apertura') + '</td>' +
                    '<td class="text-center"  style="font-size: 11px">' + ListaPreprensaDiariasDetalle[i].TiempoPreprensa + ' días' + '</td></tr>'

                    if (EstadoTrabajo == 'CON PC') {

                        $("#BodyTablaDatosPreprensaPruebaColor").append(tr);

                    } else if (EstadoTrabajo == 'SIN PC') {

                        $("#BodyTablaDatosPreprensaSinPruebaColor").append(tr);

                    } else {

                        $("#BodyTablaDatosPreprensa").append(tr);

                    }


                }

            }

        }
    })
}

function DatosAperturaEtiquetas(TrabCompletadoAño, TrabCompletadoMes, TrabPromedioDia) {


    $("#txtCantTrabajosAperturaAño").empty();
    $("#txtCantTrabajosAperturaAño").append(TrabCompletadoAño);


    $("#txtCantTrabajosAperturaMes").empty();
    $("#txtCantTrabajosAperturaMes").append(TrabCompletadoMes);


    $("#txtCantTrabajosAperturaDias").empty();
    $("#txtCantTrabajosAperturaDias").append(parseInt(TrabPromedioDia, 10));

}

function DatosPreprensaEtiquetas(TrabCompletadoAño, TrabCompletadoMes, TrabPromedioDia) {

    $("#txtCantTrabajosPreprensaAño").empty();
    $("#txtCantTrabajosPreprensaAño").append(TrabCompletadoAño);

    $("#txtCantTrabajosPreprensaMes").empty();
    $("#txtCantTrabajosPreprensaMes").append(TrabCompletadoMes);

    $("#txtCantTrabajosPreprensaDias").empty();
    $("#txtCantTrabajosPreprensaDias").append(parseInt(TrabPromedioDia, 10));

}

function ConvertFecha(Fecha, TipoIndicador) {

    var FechaCompleta
    var fechaConvert = new Date(parseInt(Fecha.substr(6)));
    var fechaReducida = new Date(fechaConvert);
    var diaConvert = fechaReducida.getDate();
    if (diaConvert < 10) {
        diaConvert = '0' + diaConvert;
    }
    var mesConvert = fechaReducida.getMonth() + 1;
    if (mesConvert < 10) {
        mesConvert = '0' + mesConvert;
    }
    var anoConvert = fechaReducida.getFullYear();

    var hora = fechaReducida.getHours();
    if (hora < 10) {
        hora = '0' + hora;
    }
    var minuto = fechaReducida.getUTCMinutes();
    if (minuto < 10) {
        minuto = '0' + minuto;
    }

    var segundos = fechaReducida.getUTCSeconds();
    if (segundos < 10) {
        segundos = '0' + segundos;
    }

    var HoraCompleta = hora + ':' + minuto + ':' + segundos

    if (anoConvert == 0) {
        FechaCompleta = 'EN PROCESO';
    } else {
        if (TipoIndicador == 'Apertura') {
            FechaCompleta = diaConvert + '/' + mesConvert + '/' + anoConvert + '<br>' + HoraCompleta;
        }
        else {
            FechaCompleta = diaConvert + '/' + mesConvert + '/' + anoConvert;
        }
    }




    return FechaCompleta
}

function ConvertMes(Mes) {

    switch (Mes) {
        case 'Ene':
            return '01'
            break;
        case 'Feb':
            return '02'
            break;
        case 'Mar':
            return '03'
            break;
        case 'Abr':
            return '04'
            break;
        case 'May':
            return '05'
            break;
        case 'Jun':
            return '06'
            break;
        case 'Jul':
            return '07'
            break;
        case 'Ago':
            return '08'
            break;
        case 'Set':
            return '09'
            break;
        case 'Oct':
            return '10'
            break;
        case 'Nov':
            return '11'
            break;
        case 'Dic':
            return '12'
            break;
    }
}

function GraficoPie() {

    var options = {
        series: [25, 15, 44, 55, 41, 17],
        chart: {

            toolbar: {
                show: true
            },
            type: 'pie',
            height: 350
        },
        labels: ["Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"],
        theme: {
            monochrome: {
                enabled: false
            }
        },
        plotOptions: {
            pie: {
                dataLabels: {
                    offset: -5
                },
                expandOnClick: false,
            }
        },
        title: {
            text: 'Trabajos mensuales por usuario ',
            align: 'left',
            style: {
                fontSize: '18px'
            },
        },
        colors: ['#1ec21b', '#FF4560'],
        dataLabels: {
            formatter(val, opts) {
                const name = opts.w.globals.labels[opts.seriesIndex]
                return [name, val.toFixed(1) + '%']
            }
        },
        legend: {
            show: true,
            floating: true,
            position: "bottom",
            fontSize: 12,
            offsetX: -29,
            offsetY: 13,
            //itemMargin: {
            //    horizontal: 9,
            //    vertical: 0
            //}
        }
    };

    var chart = new ApexCharts(document.querySelector("#GraficoPie"), options);
    chart.render();

}