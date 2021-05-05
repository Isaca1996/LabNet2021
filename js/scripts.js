$(document).ready(function() {

    $("#nombre").blur(function(){
        if(!$(this).val() != ''){
            $("#span-nombre").text("Ingrese su nombre.");
        }
    });

    $("#apellido").blur(function(){
        if(!$(this).val() != ''){
            $("#span-apellido").text("Ingrese su apellido.");
        }
    });

    $("#edad").keypress(function(e){
        var keyCode = e.which;
        if ( (keyCode != 8 || keyCode ==32 ) && (keyCode < 48 || keyCode > 57)) { 
          return false;
        }
    });

    $("#borrar").click(function(){
        $("input").empty();
    });

    $("#enviar").click(function(){
        if(!$("input").val() != ''){
            alert("Existen campos vacíos, por favor revise de nuevo.");
        }
    });

});