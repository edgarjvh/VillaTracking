var dialog = null;

$(document).ready(function () {
    $('#txt-dni').focus();
});

function keyLogin(e) {
    if (e.keyCode === 13){
        login();
    }
}

function login() {
    var dni = $('#txt-dni');
    var pass = $('#txt-pass');
    var btn = $('#btn-login');
    var lbl = $('#lbl-forgot-pass');

    $('.message').hide();
    dni.prop('disabled',true);
    pass.prop('disabled',true);
    btn.addClass('is-Disabled');
    lbl.addClass('is-Disabled');

    if(dni.val().trim() === ""){
        $('.message').html("Debe ingresar su usuario, cédula o rif");
        $('.message').css("color","#DF3A01");
        $('.message').show();

        dni.prop('disabled',false);
        pass.prop('disabled',false);
        btn.removeClass('is-Disabled');
        lbl.removeClass('is-Disabled');

        dni.focus();
        return;
    }

    if(pass.val().trim() === ""){
        $('.message').html("Debe ingresar su contraseña");
        $('.message').css("color","#DF3A01");
        $('.message').show();

        dni.prop('disabled',false);
        pass.prop('disabled',false);
        btn.removeClass('is-Disabled');
        lbl.removeClass('is-Disabled');

        dni.focus();
        return;
    }

    $('.message').html('<p>Iniciando Sesión<i class="fa fa-spin fa-spinner"></i></p>');
    $('.message').css("color","#0101DF");
    $('.message').show();

    var data = JSON.stringify({ "dni": dni.val().trim(), "pass": pass.val().trim()});

    $.ajax({
        type: "POST",
        url: 'index.aspx/GetClient',      
        data: data,
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        success: function (response) {
            console.log(response);

            var r = response.d;
            
            if (r.Id > 0) {
                $('.message').html('<p>Bienvenido. Cargando aplicación<i class="fa fa-spin fa-spinner"></i></p>');
                $('.message').css("color", "#088A08");
                $('.message').show();

                setTimeout(function () {
                    window.location = "app.aspx";
                }, 3000);                        
            }else{
                $('.message').html("Cédula o contraseña inválida");
                $('.message').css("color", "#DF3A01");
                $('.message').show();

                dni.prop('disabled', false);
                pass.prop('disabled', false);
                btn.removeClass('is-Disabled');
                lbl.removeClass('is-Disabled');
            }
        },
        error: function (xhr, status, error) {
            var err = eval("(" + xhr.responseText + ")");
            console.log(err.Message);

            $('.message').html("Sin comunicación con el servidor");
            $('.message').css("color","#DF3A01");
            $('.message').show();

            dni.prop('disabled',false);
            pass.prop('disabled',false);
            btn.removeClass('is-Disabled');
            lbl.removeClass('is-Disabled');
        }
    });
}

