$(function () {
    //AGREGAR PRODUCTO A PEDIDO POR NOMBRE
    $('#generarButton').click(function () {
        generarCabeceraPedido();
    });

    $('#preVistaButton').click(function () {
        GenerarPDF();
    });

    // GUARDAR TODO EL PEDIDO
    $('#guardarButton').click(function () {
        guardarPedidoCompleto();
    });

});

function generarCabeceraPedido() {
    Validate('#formEditCabecera');
    var valid = IsValid('#formEditCabecera');

    if (valid) {
        var url = $('#Url_CabeceraGenerarPV').val();
        var partialView = $('#formEditCabecera'); //PedidoCabeceraPV');

        $.ajax({
            type: "POST",
            url: url,
            data: $('#formEditCabecera').serialize(),
            async: true,
            success: function (data, textStatus) {
                if (textStatus == "success") {
                    var element = $.parseHTML(data);

                    //partialView.html(data);

                    // Muestra la cabecera
                    var txtCodigoPedido = $(element).find("#txtCodigoPedido");
                    var txtCodigoPedidoPV = partialView.find('#txtCodigoPedido');

                    txtCodigoPedidoPV.val(txtCodigoPedido.val() );

                    // Muestra la grilla
                    buscarProducto();
                }
            },
            error: function (request, status, error) {
                console.log(error);
            }
        });
    }
}

function GenerarPDF() {
    debugger
    var url = $('#Url_GenerarPDF').val();

    // Descargar vista previa
    location =  url + "";
}

var buscarProducto = function () {
    var url = $('#Url_Pedido_GridPV').val();
    var partialView = $('#PedidoGridPV');
    var idGrupo = ($('#cboIDGrupo').val() != undefined) ? parseInt($('#cboIDGrupo').val()) : -1;
    idGrupo = ( isNaN(idGrupo) ) ? -1 : idGrupo;
    var index = ($('#ProductoPageIndex').val() != undefined) ? parseInt($('#ProductoPageIndex').val()) : 0;

    $.ajax({
        type: "POST",
        url: url,
        data: $('form').serialize() + '&' + $.param({ idGrupo: idGrupo }) + '&' + $.param({ pageIndex: index }),
        async: true,
        success: function (data, textStatus) {
            
            if (textStatus == "success") {
                partialView.html(data);
                ResponsiveTable();

                var oPagination = new Object();

                oPagination.Index = parseInt($('#ProductoPageIndex').val());
                oPagination.RowsPerPage = parseInt($('#ProductoRowsPerPage').val());
                oPagination.PageSize = parseInt($('#ProductoPageSize').val());
                oPagination.RowCount = parseInt($('#ProductoRowCount').val());

                oPagination.NombreComun = "Producto";
                oPagination.Funcion = buscarProducto;

                $('#pag_tblProducto').paginacion(oPagination);
            }
        },
        error: function (request, status, error) {
           
            console.log(error);
        }
    });
}

function AgregarProductoPedido(item) {
    var oKey = item;
    var url = $('#Url_EditProductoPV').val();

    $.ajax({
        type: "GET",
        url: url,
        data: $.param({ oIDProducto: oKey.IDProducto }) + '&' + $.param({ opcion: 1 }),
        async: true,
        success: function (data, textStatus) {
            if (textStatus == "success") {
                console.log(textStatus);
                var element = $.parseHTML(data);

                var opciones = $(element).find("#opciones");

                ShowModalShort('Agregar cantidad de Producto', data, opciones);
            }
        },
        error: function (request, status, error) {
            console.log(error);
        }
    });
}

function QuitarProductoPedido(item) {
    var oKey = item;
    var url = $('#Url_EditProductoPV').val();

    $.ajax({
        type: "GET",
        url: url,
        data: $.param({ oIDProducto: oKey.IDProducto }) + '&' + $.param({ opcion: 2 }),
        async: true,
        success: function (data, textStatus) {
            if (textStatus == "success") {
                console.log(textStatus);
                var element = $.parseHTML(data);

                var opciones = $(element).find("#opciones");

                ShowModalShort('Quitar cantidad de Productos', data, opciones);
            }
        },
        error: function (request, status, error) {
            console.log(error);
        }
    });
}

function GuardarProductoPedido()
{
    Validate('#formEdit');

    var valid = IsValid('#formEdit');

    if (valid) {
        var url = $('#Url_PedidoProducto_Guardar').val();

        $.ajax({
            type: "GET",
            url: url,
            data: $('#formEdit').serialize(),
            async: true,
            success: function (data, textStatus) {
                if (textStatus == "success") {
                    console.log(textStatus);

                    HideModalShort();

                    var arr = data;
                    if (arr[0] == 'true') {
                        ShowModalSuccess('Mensaje', arr[1]);
                    } else {
                        ShowModalError('Error', arr[1]);
                    }
                }
            },
            error: function (request, status, error) {
                console.log(error);
            }
        });
    }
}

function guardarPedidoCompleto() {
    var url = $('#Url_PedidoCompleto_Guardar').val();
    debugger

    $.ajax({
        type: "GET",
        url: url,
        data: {},
        async: true,
        success: function (data, textStatus) {
            if (textStatus == "success") {
                console.log(textStatus);

                HideModalShort();

                var arr = data;
                if (arr[0] == 'true') {
                    ShowModalSuccess('Mensaje', arr[1]);

                    setTimeout(function () {
                        location.reload();
                    }, 5000);
                } else {
                    ShowModalError('Error', arr[1]);
                }
            }
        },
        error: function (request, status, error) {
            console.log(error);
        }
    });
}