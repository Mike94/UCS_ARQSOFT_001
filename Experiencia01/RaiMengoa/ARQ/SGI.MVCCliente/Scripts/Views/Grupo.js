$(function () {
    //BUSCAR GRUPOS POR DESCRIPCION
    $('#searchButton').click(function () {
        buscarGrupo();
    });

    //NUEVO
    $('#addButton').click(function () {
        NuevoGrupo();
    });
});

function GuardarGrupo() {
    Validate('#formEdit');

    var valid = IsValid('#formEdit');

    if (valid) {
        var url = $('#Url_Grupo_Guardar').val();

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

                    buscarGrupo();
                }
            },
            error: function (request, status, error) {
                console.log(error);
            }
        });
    }
}


function EditarGrupo(item) {
    var oKey = item;
    var url = $('#Url_Grupo_InnerEdit').val();

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

                ShowModal('Editar Grupo', data, opciones);
            }
        },
        error: function (request, status, error) {
            console.log(error);
        }
    });
}

function NuevoGrupo() {
    var url = $('#Url_Grupo_Add').val();
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

                ShowModal('Nuevo Grupo', data, opciones);
            }
        },
        error: function (request, status, error) {
            console.log(error);
        }
    });
}

var buscarGrupo = function () {
    var url = $('#Url_GrupoGridPV').val();
    var partialView = $('#GrupoGridPV');
    var index = ($('#GrupoPageIndex').val() != undefined) ? parseInt($('#GrupoPageIndex').val()) : 0;

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

                oPagination.Index = parseInt($('#GrupoPageIndex').val());
                oPagination.RowsPerPage = parseInt($('#GrupoRowsPerPage').val());
                oPagination.PageSize = parseInt($('#GrupoPageSize').val());
                oPagination.RowCount = parseInt($('#GrupoRowCount').val());

                oPagination.NombreComun = "Grupo";
                oPagination.Funcion = buscarGrupo;

                $('#pag_tblGrupo').paginacion(oPagination);
            }
        },
        error: function (request, status, error) {
            console.log(error);
        }
    });
}