$("#btnGuardar").click(function () {

    var IdCliente= $(".cliente").val();
    var Monto = $(".monto").val();
    var Moneda = $(".moneda").val();
    var Interes = $(".interes").val();
    var Plazo = $(".plazo").val();

    if (IdCliente == "" || Monto == "" || Moneda == "" || Interes == "" || Plazo == "") {
        notif({

            msg: "Todos los campos son requeridos",

            type: "error"

        });

        return;

    }
    else {
        var xhr = $.ajax({
            url: "GuardarPrestamo",
            type: "POST",
            data: {
                "IdCliente": IdCliente,
                "Monto": Monto,
                "Moneda": Moneda,
                "Interes": Interes,
                "Plazo": Plazo,

            }



        });
        xhr.done(function (data) {



            notif({

                msg: "Datos guardados Exitosamente",

                type: "success"

                 

            });

            setTimeout(function () {
                location.href = "../Cliente/Prestamos"
            },600)

            //Swal.fire({
            //    position: 'top-end',
            //    icon: 'succes',
            //    title: 'Datos Guardados Correctamente',
            //    showConfirmButton: false,
            //    timer: 1500
            //})
            //alert("Datos guardados correctamente");
            $(".cliente").val("");
            $(".monto").val("");
            $(".moneda").val("");
            $(".interes").val("");
            $(".plazo").val("");





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