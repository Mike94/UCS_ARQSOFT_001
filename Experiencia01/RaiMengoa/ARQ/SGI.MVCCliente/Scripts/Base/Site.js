//Function ready
$(function () {
    InitLoad();
});


// FUNCIONES AL CARGAR LA PAGINA
function InitLoad() {
    DatePicker();
    AddMethodDate();
    AddRadioMethod();
    MascaraTienda();
    KeyValidate();
    ScrollBar();
}

function KeyValidate() {
    $('.key-integer').keypress(function (evt) {
        key = (evt.keyCode != 0) ? evt.keyCode : evt.which;
        return KeyInteger(key);
    });

    $('.key-decimal').keypress(function (evt) {
        key = (evt.keyCode != 0) ? evt.keyCode : evt.which;
        return KeyDecimal(this.value, key);
    });

    $('.key-decimal').focusout(function (evt) {
        KeyDecimalFocusout(this);
    });
}

function ScrollBar() {
    try {
        $('#left-panel').perfectScrollbar();
    } catch (e) {
        console.log('Not enabled perfectScrollbar');
    }
    
}

function ResponsiveTable() {
    $('.webGrid tbody tr').each(function (index) {
        $(this).find('td').each(function (index) {
            var len = index + 1;
            var value = $(".webGrid thead th:nth-child(" + len + ")").html();
            $(this).attr('data-title', value);
        });
    });
}

// FUNCIONES DE DATEPICKER
function DatePicker() {
    $(".datepicker").mask("99/99/9999");

    var datepicker = $.fn.datepicker.noConflict();
    $.fn.bootstrapDP = datepicker;
    $(".datepicker").bootstrapDP({
        format: "dd/mm/yyyy",
        language: "es",
        autoclose: true,
        todayHighlight: true
    });

    //$(".datepicker").datepicker({ showOn: "" });
    //$(".datepicker").datepicker("option", "dateFormat", 'dd/mm/yy');
    //$(".datepicker").datepicker("option", "gotoCurrent", true);
    //$(".selector").datepicker("option", "defaultDate", +0);

    //var ini = $(".datepicker").parent().children('span.input-group-addon').children('.glyphicon.glyphicon-calendar');
    //ini.click(function () {
    //    var id = "#" + $(this).parent().parent().children(".datepicker").prop('id');

    //    var visible = $(id).datepicker("widget").is(":visible");

    //    if (visible) {
    //        $(id).datepicker('hide');
    //    } else {
    //        $(id).datepicker('show');
    //        $('#ui-datepicker-div').css('z-index', 10000);
    //    }
    //});
}

function MascaraTienda() {
    $(".cod-tienda").mask("CT999");
}

// VALIDACIÓN

function AddMethodDate() {
    jQuery.validator.addMethod("date-pe", function (value, element) {
        return this.optional(element) || ValidateDatime(value);
    }, "Por favor ingrese un formato de fecha valido");
}

function ValidateDatime(value) {
    return /^(?=\d)(?:(?!(?:(?:0?[5-9]|1[0-4])(?:\.|-|\/)10(?:\.|-|\/)(?:1582))|(?:(?:0?[3-9]|1[0-3])(?:\.|-|\/)0?9(?:\.|-|\/)(?:1752)))(31(?!(?:\.|-|\/)(?:0?[2469]|11))|30(?!(?:\.|-|\/)0?2)|(?:29(?:(?!(?:\.|-|\/)0?2(?:\.|-|\/))|(?=\D0?2\D(?:(?!000[04]|(?:(?:1[^0-6]|[2468][^048]|[3579][^26])00))(?:(?:(?:\d\d)(?:[02468][048]|[13579][26])(?!\x20BC))|(?:00(?:42|3[0369]|2[147]|1[258]|09)\x20BC))))))|2[0-8]|1\d|0?[1-9])([-.\/])(1[012]|(?:0?[1-9]))\2((?=(?:00(?:4[0-5]|[0-3]?\d)\x20BC)|(?:\d{4}(?:$|(?=\x20\d)\x20)))\d{4}(?:\x20BC)?)(?:$|(?=\x20\d)\x20))?((?:(?:0?[1-9]|1[012])(?::[0-5]\d){0,2}(?:\x20[aApP][mM]))|(?:[01]\d|2[0-3])(?::[0-5]\d){1,2})?$/.test(value);
}

function AddRadioMethod() {
    jQuery.validator.addMethod("radio-custom", function (value, element, params) {
        return ValidateChecked(element);
    }, "Por favor seleccione una de la opciones");
}

function ValidateChecked(element) {
    name = $(element).prop('name');
    var value = false;
    $('input[name="' + name + '"]').each(function (index, element) {
        var $element = $(element);
        var checked = $element.prop("checked");
        if (checked === true) {
            value = checked;
        }
    });
    return value;
}

function Validate(selector) {
    $(selector).validate({
        showErrors: function (errorMap, errorList) {
            $.each(this.validElements(), function (index, element) {
                var $element = $(element);

                if ($element.attr('data-rule-radio-custom') != undefined) {
                    $element = $($element.attr('data-rule-radio-custom'));
                }

                $element.data("title", "")
                    .removeClass("error")
                    .addClass('success')
                    .tooltip("destroy");
            });

            $.each(errorList, function (index, error) {
                var $element = $(error.element);

                if (error.method == 'radio-custom') {
                    $element = $($element.attr('data-rule-radio-custom'));
                }

                $element.tooltip("destroy")
                .data("title", error.message)
                .removeClass('success')
                .addClass("error")
                .tooltip();
            });
        }
    });
}

function IsValid(selector) {
    return $(selector).valid();
}

//FIN VALIDACION

// MODAL
function ShowModal(title, content, pieModal) {
    var $modal =  $('#ModalPlantilla');
    $($modal).modal('show');

    $modal.find('#titulo').html(title);
    $modal.find('#contenido').html(content);

    if (pieModal != undefined) {
        $modal.find('#pieModal').html(pieModal.html());
        $('#' + pieModal.prop('id')).hide();
    } else {
        $modal.find('#pieModal').html(CreateButtonCerrar());
    }

    InitLoad();
}

function HideModal() {
    $('#ModalPlantilla').modal('hide');
}

function ShowModalShort(title, content, pieModal) {
    var $modal = $('#ModalShort');
    $($modal).modal('show');

    $modal.find('#titulo').html(title);
    $modal.find('#contenido').html(content);

    if (pieModal != undefined) {
        $modal.find('#pieModal').html(pieModal.html());
        $('#' + pieModal.prop('id')).hide();
    } else {
        $modal.find('#pieModal').html(CreateButtonCerrar());
    }

    InitLoad();
}

function HideModalShort() {
    $('#ModalShort').modal('hide');
}

function ShowModalError(title, content) {
    var $modal = $('#ModalError');
    $($modal).modal('show');

    $modal.find('#titulo').html(title);
    $modal.find('#contenido').html(content);
}

function HideModalError() {
    $('#ModalError').modal('hide');
}

function ShowModalSuccess(title, content) {
    var $modal = $('#ModalSuccess');
    $($modal).modal('show');

    $modal.find('#titulo').html(title);
    $modal.find('#contenido').html(content);
}

function HideModalSuccess() {
    $('#ModalSuccess').modal('hide');
}

function CreateButtonCerrar() {
    var item = '<button type="button" class="btn btn-default" data-dismiss="modal">' +
                '<span class="glyphicon glyphicon-trash"></span>&nbsp;Cerrar' +
                '</button>';
    return item;
}

// FIN MODAL

// PAGINACION

(function ($) {
  $.fn.paginacion = function (oPaginacion) {
        var $paginado = $(this);

        $paginado.addClass('table-footer');

        var nro_actual = oPaginacion.Index + 1;

        var nro_total = 1;
        if (oPaginacion.RowCount > oPaginacion.RowsPerPage) {
            var nro_total = oPaginacion.RowCount / oPaginacion.RowsPerPage;
            var res = oPaginacion.RowCount % oPaginacion.RowsPerPage;
            if (res > 0) {
                var nro_total = nro_total + 1;
                var nro_total = parseInt(nro_total);
            }
        }

        var nombre = oPaginacion.NombreComun;

        for (var i = 0; i < 2; i++) {
            switch (i) {
                //CANTIDAD DE REGISTROS
                case 0:
                    var del = (oPaginacion.RowsPerPage * oPaginacion.Index) + 1;
                    var al = (oPaginacion.RowsPerPage * oPaginacion.Index) + oPaginacion.PageSize;
                    var elemento = '(' + del + " - " + al + ') de (' + oPaginacion.RowCount + ') registros encontrados ';

                    var ele = $(CreateElement(4, elemento));
                    break;
                    //PAGINACION BOTONES Y TEXTO
                case 1:
                    var botones1ro = CreateButtonPrimero(nombre) + CreateButtonIzquierda(nombre);

                    pagina = CreateSpan(' Pagina ');
                    txt_pagina = CreateTextBoxPag(nombre, nro_actual);
                    de = CreateSpan(' de ' + nro_total + ' ');
                    var botones2do = CreateButtonDerecha(nombre) + CreateButtonUltimo(nombre);
                    var elemento = botones1ro + pagina + txt_pagina + de + botones2do;

                    var ele = $(CreateElement(8, elemento));
                    break;
            }

            $paginado.append(ele);
        }       

        $('#txtPaginacion' + nombre).keypress(function (evt) {
            key = (evt.keyCode != 0) ? evt.keyCode : evt.which;

            if (key == '13') {
                value = parseInt($(this).val());
                if (value >= 1 && value <= nro_total) {
                    value = value - 1;
                    $('#' + nombre + 'PageIndex').val(value);
                    oPaginacion.Funcion();
                }
            }

            KeyInteger(key);
        });

        $('#btnPaginacion1' + nombre).click(function () {
            var primero = 0;

            $('#' + nombre + 'PageIndex').val(primero);
            return oPaginacion.Funcion();
        });

        $('#btnPaginacion2' + nombre).click(function () {
            var anterior = oPaginacion.Index - 1;

            if (anterior >= 0) {
                $('#' + nombre + 'PageIndex').val(anterior);
                return oPaginacion.Funcion();
            }
        });

        $('#btnPaginacion3' + nombre).click(function () {
            var siguiente = oPaginacion.Index + 1;
            var total = nro_total - 1;

            if (total >= siguiente) {
                $('#' + nombre + 'PageIndex').val(siguiente);
                return oPaginacion.Funcion();
            }
        });

        $('#btnPaginacion4' + nombre).click(function () {
            var total = nro_total - 1;

            $('#' + nombre + 'PageIndex').val(total);
            return oPaginacion.Funcion();
        });
    };
})(jQuery);

function CreateElement(numero, contenido) {
    return '<div class="col-sm-' + numero + '" >' + contenido + '</div>';
}

function CreateSpan(contenido) {
    return '<span>' + contenido + '</span>';
}

function CreateTextBoxPag(nombre, valor) {
    return '<input id="txtPaginacion' + nombre + '" type="text" value="' + valor + '" class="control-pag" maxlength="4" />'
}

function CreateButtonPrimero(nombre) {
    boton = '<button id="btnPaginacion1' + nombre + '" type="button" class="btn btn-default control-pag" >';
    boton += '<span class="glyphicon glyphicon-step-backward"></span>';
    boton += '</button>';

    return boton;
}

function CreateButtonIzquierda(nombre) {
    boton = '<button id="btnPaginacion2' + nombre + '" type="button" class="btn btn-default control-pag" >';
    boton += '<span class="glyphicon glyphicon-chevron-left"></span>';
    boton += '</button>';

    return boton;
}

function CreateButtonDerecha(nombre) {
    boton = '<button id="btnPaginacion3' + nombre + '" type="button" class="btn btn-default control-pag" >';
    boton += '<span class="glyphicon glyphicon-chevron-right"></span>';
    boton += '</button>';

    return boton;
}

function CreateButtonUltimo(nombre) {
    boton = '<button id="btnPaginacion4' + nombre + '" type="button" class="btn btn-default control-pag" >';
    boton += '<span class="glyphicon glyphicon-step-forward"></span>';
    boton += '</button>';

    return boton;
}

//FIN PAGINACION

//KEY VALIDATE

function KeyInteger(key) {
    try {
        if (key == 8 || key == 46 || key == 9 ||
                (key >= 48 && key <= 57)) {
            return true;
        } else {
            return false;
        }
    } catch (e) {
        return false;
    }
    
}

function KeyDecimal(value, key) {
    try {
        ichar = String.fromCharCode(key);
        char = String.fromCharCode(key);
        ichar = parseInt(ichar);
        if ((char == "." && value.indexOf(".") == -1) || key == 8 || key == 9 || key == 13) {
            return true;
        } else if (char == ".") { return false; }

        if ($.isNumeric(ichar) == false) {
            return false;
        }
    } catch (e) {
        return false;
    }
}

// SE AGREGAR LA PROPIEDAD data-decimal PARA PRECISAR LA CIFRA DECIMAL
function KeyDecimalFocusout(element) {
    value = $(element).val();
    len = value.length;

    itwo = 0;
    cut = value.indexOf(".");
    val = value.split("");
    cut2 = cut + 1;
    predec = '';
    prodec = value.substring(cut2, len);

    if (cut == -1) { cut = parseInt(len) - 1; prodec = ''; }
    var mut = 1;
    for (var i = cut; i >= 0; i--) {
        char = value.charAt(i);
        ichar = parseInt(char);
        if (char == '.' && mut == 1) { mut--; }
        if (char == '.' || $.isNumeric(ichar) == true) {
            if (mut % 3 == 0) { char = char + ','; }
            predec = predec + char;
            mut++;
        }
    }

    len = predec.length - 1;
    auxlen = len;
    var val2 = '';
    while (len >= 0) {
        char2 = predec.charAt(len);
        if ((char2 == ',' && len == auxlen) || (char2 == ',' && len == 1))
        { char2 = ''; }
        val2 = val2 + char2;
        len--;
    }
    predec = val2;

    var newval = predec + prodec;
    var newcut = newval.indexOf(".");
    if (newcut != -1) {
        decimal = 2;
        if ($(element).attr('data-decimal') != undefined) {
            decimal = $(element).attr('data-decimal');
        }
        antdecimal = parseInt(decimal) - 1;
        newdecimal = parseInt(decimal) + 1;

        newval = newval.split('.');
        auxnewval1 = newval[1];
        newval[1] = '0.' + auxnewval1;
        auxnewval1 = auxnewval1.substring(antdecimal, newdecimal);
        if (auxnewval1.charAt(1) != 0) {
            auxnewval1 = '' + Math.round(auxnewval1 / 10) * 10;
        }
        newval1 = '' + newval[1];
        newval1 = newval1.substring(1, newdecimal) + auxnewval1.substring(0, 1);
        if (newval1.length < newdecimal) {
            while (newval1.length < newdecimal) {
                newval1 = newval1 + '0';
            }
        }
        newval = newval[0] + newval1;
    }

    $(element).val(newval);
}

//FIN KEY VALIDATE