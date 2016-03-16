function GuardarUsuario() {
    Validate('#usuario #formEdit');

    var valid = IsValid('#usuario #formEdit');

    if (valid) {
        var url = $('#Url_Usuario_Guardar').val();

        $.ajax({
            type: "GET",
            url: url,
            data: $('#usuario #formEdit').serialize(),
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

                    buscarUsuario();
                }
            },
            error: function (request, status, error) {
                console.log(error);
            }
        });
    }
}