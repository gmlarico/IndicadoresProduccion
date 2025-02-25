$(function () {

    $("#btnActualizar").click(function () {
        
        var Mensaje = new Resinplast.Indicadores.Web.Components.Message()
        

        var txtPassword_1 = $("#txtPassword_1").val();
        var txtPassword_2 = $("#txtPassword_2").val();
        var checkbox = document.getElementById('signup-terms');
         var txtPassword_3 = document.getElementById('signup-terms').checked;

         if (txtPassword_1 == "") {
             Mensaje.Warning({ message: '"Los campos no deben de estar vacíos.' });
            return
        } else {
            if (txtPassword_3) {

                if (txtPassword_1 == txtPassword_2) {

                    DatosSetUpTotales(txtPassword_1)
                } else {
                    Mensaje.Warning({ message: 'Las contraseñas deben ser iguales.' });
               
                    return
                }
            } else {
                Mensaje.Warning({ message: 'Aceptar los terminos y condiciones.' });
                return

            }
                      
        }
     
    });

});



function DatosSetUpTotales(Contrasena) { 
  
    $.ajax({
        type: 'POST',     
        data: { Contrasena: Contrasena },
        url: '/Mantenimiento/ActualizarContrasena',
        success: function (ActualizarContrasena) {
             
            if (ActualizarContrasena.CodigoError == "0") {
                    
                $(location).attr('href', '/Login/Index')
              
            }

        }
    })

}