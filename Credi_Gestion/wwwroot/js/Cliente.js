$("#btnGuardar").click(function () {
    var nombrecliente = $(".NombreCliente").val();
    var apellidos = $(".ClienteApellidos").val();
    var cedula = $(".ClienteCedula").val();
    var generos = $(".ClienteGenero").val();
    var direccion = $(".ClienteDireccion").val();
    var telefono = $(".ClienteTelefono").val();
    var estado = $(".ClienteEstado").val();


    if (nombrecliente == "" || apellidos == "" || cedula == "" || generos == "" || direccion == "" || telefono == "" || estado=="") {
     

        notif({

            msg: "Todos los campos son requeridos",

            type: "error"

        });

        return;
    }
    else {
        var xhr = $.ajax({
            url: "NuevosCliente",
            type: "POST",
            data: {
                "NombreCliente": nombrecliente,
                "Apellidos": apellidos,
                "Cedula": cedula,
                "Direccion": direccion,
                "Telefono": telefono,
                "Genero": generos,
                "Estado": estado
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
            $(".NombreCliente").val("");
            $(".ClienteApellidos").val("");
            $(".ClienteCedula").val("");
            $(".ClienteDireccion").val("");
            $(".ClienteTelefono").val("");
            $("ClienteGenero").val("");
            $("ClienteEstado").val("");

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