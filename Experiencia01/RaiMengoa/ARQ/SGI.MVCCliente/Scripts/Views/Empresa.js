$(function () {
    //BUSCAR EMPRESAS POR CODIGO
    $('#searchButton').click(function () {
        buscarEmpresa();
    });

    //NUEVO
    $('#addButton').click(function () {
        NuevoEmpresa();
    });
});

function GuardarEmpresa() {
    Validate('#formEdit');

    var valid = IsValid('#formEdit');

    if (valid) {
        var url = $('#Url_Empresa_Guardar').val();

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

                    buscarEmpresa();
                }
            },
            error: function (request, status, error) {
                console.log(error);
            }
        });
    }
}


function EditarEmpresa(item) {
    var oKey = item;
    var url = $('#Url_Empresa_InnerEdit').val();

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

                ShowModal('Editar Empresa', data, opciones);
            }
        },
        error: function (request, status, error) {
            console.log(error);
        }
    });
}

function NuevoEmpresa() {
    var url = $('#Url_Empresa_Add').val();
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

                ShowModal('Nueva Empresa', data, opciones);
            }
        },
        error: function (request, status, error) {
            console.log(error);
        }
    });
}

var buscarEmpresa = function () {
    var url = $('#Url_EmpresaGridPV').val();
    var partialView = $('#EmpresaGridPV');
    var index = ($('#EmpresaPageIndex').val() != undefined) ? parseInt($('#EmpresaPageIndex').val()) : 0;

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

                oPagination.Index = parseInt($('#EmpresaPageIndex').val());
                oPagination.RowsPerPage = parseInt($('#EmpresaRowsPerPage').val());
                oPagination.PageSize = parseInt($('#EmpresaPageSize').val());
                oPagination.RowCount = parseInt($('#EmpresaRowCount').val());

                oPagination.NombreComun = "Empresa";
                oPagination.Funcion = buscarEmpresa;

                $('#pag_tblEmpresa').paginacion(oPagination);
            }
        },
        error: function (request, status, error) {
            console.log(error);
        }
    });
}