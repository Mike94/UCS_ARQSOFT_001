$(function () {
    //BUSCAR EMPLEADOS POR NOMBRE
    $('#searchButton').click(function () {
        buscarEmpleado();
    });

    //NUEVO
    $('#addButton').click(function () {
        NuevoEmpleado();
    });
});

function GuardarEmpleado() {
    Validate('#formEdit');

    var valid = IsValid('#formEdit');
    
    if (valid) {
        var url = $('#Url_Empleado_Guardar').val();
        
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
                    
                    buscarEmpleado();
                }
            },
            error: function (request, status, error) {
                console.log(error);
            }
        });
    }
}

function EditarEmpleado(item) {
    var oKey = item;
    var url = $('#Url_Empleado_InnerEdit').val();

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

                ShowModal('Editar Empleado', data, opciones);

                $('#tab-master li a').click(function (e) {
                    e.preventDefault();

                    var value = $(this).attr('href');
                    var $opcion = $(value).find("#opciones");
                    $opcion.hide();

                    $('#pieModal').html($opcion.html());

                    $(this).tab('show');
                })
            }
        },
        error: function (request, status, error) {
            console.log(error);
        }
    });
}

function NuevoEmpleado() {
    var url = $('#Url_Empleado_Add').val();
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

                ShowModal('Nuevo Empleado', data, opciones);
            }
        },
        error: function (request, status, error) {
            console.log(error);
        }
    });
}

var buscarEmpleado = function () {
    var url = $('#Url_EmpleadoGridPV').val();
    var partialView = $('#EmpleadoGridPV');
    var index = ($('#EmpleadoPageIndex').val() != undefined) ? parseInt($('#EmpleadoPageIndex').val()) : 0;

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

                oPagination.Index = parseInt($('#EmpleadoPageIndex').val());
                oPagination.RowsPerPage = parseInt($('#EmpleadoRowsPerPage').val());
                oPagination.PageSize = parseInt($('#EmpleadoPageSize').val());
                oPagination.RowCount = parseInt($('#EmpleadoRowCount').val());

                oPagination.NombreComun = "Empleado";
                oPagination.Funcion = buscarEmpleado;

                $('#pag_tblEmpleado').paginacion(oPagination);
            }
        },
        error: function (request, status, error) {
            console.log(error);
        }
    });
}