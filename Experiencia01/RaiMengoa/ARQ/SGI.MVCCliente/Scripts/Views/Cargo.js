$(function () {
    //BUSCAR CARGOS POR NOMBRE
    $('#searchButton').click(function () {
        buscarCargo();
    });

    //NUEVO
    $('#addButton').click(function () {
        NuevoCargo();
    });
});

function GuardarCargo() {
    Validate('#formEdit');

    var valid = IsValid('#formEdit');

    if (valid) {
        var url = $('#Url_Cargo_Guardar').val();

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

                    buscarCargo();
                }
            },
            error: function (request, status, error) {
                console.log(error);
            }
        });
    }
}


function EditarCargo(item) {
    var oKey = item;
    var url = $('#Url_Cargo_InnerEdit').val();

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

                ShowModal('Editar Cargo', data, opciones);
            }
        },
        error: function (request, status, error) {
            console.log(error);
        }
    });
}

function NuevoCargo() {
    var url = $('#Url_Cargo_Add').val();
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

                ShowModal('Nueva Cargo', data, opciones);
            }
        },
        error: function (request, status, error) {
            console.log(error);
        }
    });
}

var buscarCargo = function () {
    var url = $('#Url_CargoGridPV').val();
    var partialView = $('#CargoGridPV');
    var index = ($('#CargoPageIndex').val() != undefined) ? parseInt($('#CargoPageIndex').val()) : 0;

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

                oPagination.Index = parseInt($('#CargoPageIndex').val());
                oPagination.RowsPerPage = parseInt($('#CargoRowsPerPage').val());
                oPagination.PageSize = parseInt($('#CargoPageSize').val());
                oPagination.RowCount = parseInt($('#CargoRowCount').val());

                oPagination.NombreComun = "Cargo";
                oPagination.Funcion = buscarCargo;

                $('#pag_tblCargo').paginacion(oPagination);
            }
        },
        error: function (request, status, error) {
            console.log(error);
        }
    });
}