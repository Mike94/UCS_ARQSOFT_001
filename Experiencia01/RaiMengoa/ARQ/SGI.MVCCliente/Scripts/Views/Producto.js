$(function () {

    $('#btnAgregar').click(function () {
        NuevoProducto();
    });

    //BUSCAR PRODUCTO POR NOMBRE
    $('#searchButton').click(function () {
       buscarProducto();
    });
});

function NuevoProducto() {
    var url = $('#Url_Producto_Add').val();
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

                ShowModal('Nuevo Producto', data, opciones);
            }
        },
        error: function (request, status, error) {
            
            console.log(error);
        }
    });
}

function EditarProducto(item) {
    var oKey = item;
    var url = $('#Url_Producto_InnerEdit').val();
    debugger;
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

                ShowModal('Editar Producto', data, opciones);
            }
        },
        error: function (request, status, error) {
            console.log(error);
        }
    });
}

function GuardarProducto() {
    Validate('#formEdit');
    var valid = IsValid('#formEdit');

    if (valid) {

    var url = $('#Url_Producto_Insertar').val();

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
                buscarProducto();
            }
        },
        error: function (request, status, error) {
            console.log(error);
        }
    });
    }
}

var buscarProducto = function () {
    var url = $('#Url_Producto_GridPV').val();
    var partialView = $('#ProductoGridPV');
    var index = ($('#ProductoPageIndex').val() != undefined) ? parseInt($('#ProductoPageIndex').val()) : 0;

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