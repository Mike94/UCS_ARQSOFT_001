$(function () {
    //BUSCAR TIENDAS POR CODIGO
    $('#searchButton').click(function () {
        buscarTienda();
    });

    //NUEVO
    $('#addButton').click(function () {
        NuevoTienda();
    });
});

function GuardarTienda() {
    Validate('#formEdit');

    var valid = IsValid('#formEdit');

    if (valid) {
        var url = $('#Url_Tienda_Guardar').val();

        $.ajax({
            type: "GET",
            url: url,
            data: $('#formEdit').serialize(),
            async: true,
            success: function (data, textStatus) {
                if (textStatus == "success") {
                    console.log(textStatus);

                    HideModal();
                    var arr = data;
                    if (arr[0] == 'true') {
                        ShowModalSuccess('Mensaje', arr[1]);
                    } else {
                        ShowModalError('Error', arr[1]);
                    }

                    buscarTienda();
                }
            },
            error: function (request, status, error) {
                console.log(error);
            }
        });
    }
}


function EditarTienda(item) {
    var oKey = item;
    var url = $('#Url_Tienda_InnerEdit').val();

    $.ajax({
        type: "GET",
        url: url,
        data: oKey,
        async: true,
        success: function (data, textStatus) {
            if (textStatus == "success") {
                console.log(textStatus);
                var element = $.parseHTML(data);

                var opciones = $(element).find("#opciones");

                ShowModal('Editar Tienda', data, opciones);
            }
        },
        error: function (request, status, error) {
            console.log(error);
        }
    });
}

function NuevoTienda() {
    var url = $('#Url_Tienda_Add').val();
    var oKey = new Object();

    $.ajax({
        type: "GET",
        url: url,
        data: oKey,
        async: true,
        success: function (data, textStatus) {
            if (textStatus == "success") {
                console.log(textStatus);
                var element = $.parseHTML(data);

                var opciones = $(element).find("#opciones");

                ShowModal('Nueva Tienda', data, opciones);
            }
        },
        error: function (request, status, error) {
            console.log(error);
        }
    });
}

function BuscarUbigeoTienda() {
    var url = $('#Url_Tienda_UbigeoPV').val();

    $.ajax({
        type: "GET",
        url: url,
        data: $('#formEdit').serialize(),
        async: true,
        success: function (data, textStatus) {
            if (textStatus == "success") {
                console.log(textStatus);
                //var element = $.parseHTML(data);

                $('#FormUbigeoPV').html(data);
                //var opciones = $(element).find("#opciones");

                //ShowModal('Editar Tienda', data, opciones);
            }
        },
        error: function (request, status, error) {
            console.log(error);
        }
    });
}


var buscarTienda = function () {
    var url = $('#Url_TiendaGridPV').val();
    var partialView = $('#TiendaGridPV');
    var index = ($('#TiendaPageIndex').val() != undefined) ? parseInt($('#TiendaPageIndex').val()) : 0;

    $.ajax({
        type: "POST",
        url: url,
        data: $('form').serialize() + '&' + $.param({ pageIndex: index }),
        async: true,
        success: function (data, textStatus) {
            if (textStatus == "success") {
                partialView.html(data);
                ResponsiveTable();

                var oPagination = new Object();

                oPagination.Index = parseInt($('#TiendaPageIndex').val());
                oPagination.RowsPerPage = parseInt($('#TiendaRowsPerPage').val());
                oPagination.PageSize = parseInt($('#TiendaPageSize').val());
                oPagination.RowCount = parseInt($('#TiendaRowCount').val());

                oPagination.NombreComun = "Tienda";
                oPagination.Funcion = buscarTienda;

                $('#pag_tblTienda').paginacion(oPagination);
            }
        },
        error: function (request, status, error) {
            console.log(error);
        }
    });
}