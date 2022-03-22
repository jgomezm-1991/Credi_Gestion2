$("#btnGuardaC").click(function () {
    var IDPRESTAMO = $("#IdPrestamo").val();
    var Montopagado = $(".Montopagado").val();
    var saldo = $(".SALDO").val();

    if (Montopagado == "" || IDPRESTAMO == "" || saldo == "") {


        notif({

            msg: "Todos los campos son requeridos",

            type: "error"

        });

        return;
    }
    else if (Montopagado > saldo)
         {

             notif({

                msg: "El monto a pagar no puede ser mayor que el saldo de la cuenta",

                 type: "error"

             });

        return;
    }
    else {
                var xhr = $.ajax({
                      url: "GuardarPago",
                     type: "POST",
                  data: {
                    "IdPrestamo": IDPRESTAMO,
                    "MontoPagado": Montopagado,
                    "Saldo": saldo
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

            $("Montopagado").val("");

            setTimeout(function () {
                location.href = "../Cliente/Pagos"
            }, 600)

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
})