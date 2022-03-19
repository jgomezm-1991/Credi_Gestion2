$("#btnEditar").click(function () {
    var EditarNombreclientes= $(".EditarNombreCliente").val();
    var Editarapellidos = $(".EditarApellidos").val();
    var Editarcedula = $(".EditarCedula").val();
    var Editargeneros = $(".EditarGeneros").val();
    var Editardireccion = $(".EditarDireccion").val();
    var Editartelefono = $(".EditarTelefono").val();
    var Editarestado = $(".EditarEstado").val();


    if (EditarNombreclientes == "" || Editarapellidos == "" || Editarcedula == "" || Editargeneros == "" || Editardireccion == "" || Editartelefono == "" || Editarestado == "") {


        notif({

            msg: "Todos los campos son requeridos",

            type: "error"

        });

        return;
    }
    else {
        var xhr = $.ajax({
            url: "EditarValorCliente",
            type: "POST",
            data: {
                "NombreCliente": EditarNombreclientes,
                "Apellidos": Editarapellidos,
                "Cedula": Editarcedula,
                "Genero": Editargeneros,
                "Direccion": Editardireccion,
                "Telefono": Editartelefono,
                "Estado": Editarestado
            }



        });
        xhr.done(function (data) {



            notif({

                msg: "Datos guardados Exitosamente",

                type: "success"

            });
            //Swal.fire({
            //    position: 'top-end',
            //    icon: 'succes',
            //    title: 'Datos Guardados Correctamente',
            //    showConfirmButton: false,
            //    timer: 1500
            //})
            //alert("Datos guardados correctamente");
            //$(".NombreCliente").val("");
            //$(".ClienteApellidos").val("");
            //$(".ClienteCedula").val("");
            //$(".ClienteDireccion").val("");
            //$(".ClienteTelefono").val("");
            //$("ClienteGenero").val("");
            //$("ClienteEstado").val("");

        });
        xhr.fail(function () {
            Swal.fire({
                title: 'Sweet!',
                text: 'Modal with a custom image.',
                imageUrl: 'https://unsplash.it/400/200',
                imageWidth: 400,
                imageHeight: 200,
                imageAlt: 'Custom image',
            })
        });
    }
});