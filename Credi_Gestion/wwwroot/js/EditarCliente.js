$("#btnEditar").click(function () {
    var EditarId = $(".EditarID").val();
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
                "IdCliente": EditarId,
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

                msg: "Datos actualizados Exitosamente",

                type: "success"
            });


            setTimeout(function () {
                location.href = "../Cliente/Clientes"
            },600)

            

       });
        //xhr.fail(function () {
        //    Swal.fire({
        //        title: 'Sweet!',
        //        text: 'Modal with a custom image.',
        //        imageUrl: 'https://unsplash.it/400/200',
        //        imageWidth: 400,
        //        imageHeight: 200,
        //        imageAlt: 'Custom image',
        //    })
        //});
    }
});