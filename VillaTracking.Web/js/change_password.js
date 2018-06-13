$(document).ready(function () {
    $('.pass-modal .modal-title i.btn-close').on('click',function () {
        var modal = $('.pass-modal');
        var form = modal.find('.modal-form');

        if (modal.hasClass('modal-shown')){
            form.animate({
                left:'-100%'
            },500,function () {
                modal.hide();
            });
            modal.removeClass('modal-shown');
        }else{
            modal.show();

            form.animate({
                left:'50%'
            });
            modal.addClass('modal-shown');
        }
    });

    $('.pass-modal').find('#modal-btn').on('click',function () {
       var curPass = $('#txt-current-pass');
       var newPass = $('#txt-new-pass');
       var conPass = $('#txt-confirm-pass');
       var btnSend = $('.pass-modal').find('#modal-btn');
       var btnClose = $('.pass-modal').find('.modal-form #btn-close');
       var msg = $('.pass-modal').find('.message');

       msg.hide();
        $('.pass-modal').find('input').prop('disabled',true);
        btnClose.addClass('is-Disabled');
        btnSend.addClass('is-Disabled');

        if(curPass.val().trim() === ""){
            msg.html("Debe ingresar su contraseña actual");
            msg.css("color","#DF3A01");
            msg.show();

            $('.pass-modal').find('input').prop('disabled',false);
            btnClose.removeClass('is-Disabled');
            btnSend.removeClass('is-Disabled');

            curPass.focus();
            return;
        }

        if(newPass.val().trim() === ""){
            msg.html("Debe ingresar su contraseña nueva");
            msg.css("color","#DF3A01");
            msg.show();

            $('.pass-modal').find('input').prop('disabled',false);
            btnClose.removeClass('is-Disabled');
            btnSend.removeClass('is-Disabled');

            newPass.focus();
            return;
        }

        if(conPass.val().trim() === ""){
            msg.html("Debe confirmar su contraseña");
            msg.css("color","#DF3A01");
            msg.show();

            $('.pass-modal').find('input').prop('disabled',false);
            btnClose.removeClass('is-Disabled');
            btnSend.removeClass('is-Disabled');

            conPass.focus();
            return;
        }

        if(newPass.val() !== conPass.val()){
            msg.html("la confirmación no coincide");
            msg.css("color","#DF3A01");
            msg.show();

            $('.pass-modal').find('input').prop('disabled',false);
            btnClose.removeClass('is-Disabled');
            btnSend.removeClass('is-Disabled');

            conPass.focus();
            return;
        }

        msg.html('<p>Cambiando contraseña<i class="fa fa-spin fa-spinner"></i></p>');
        msg.css("color","#0101DF");
        msg.show();

        $.ajax({
           type:'post',
           url:host_dir + '/controller/c_client.php',
           data:{
               action:'changePassword',
               curPass:curPass.val(),
               newPass:newPass.val()
           },
            success: function (response) {
                console.log(response);

                if (response === "OK"){
                    msg.html('<p>Contraseña cambiada exitósamente<i class="fa fa-check"></i></p>');
                    msg.css("color","#088A08");
                    msg.show();

                    setTimeout(function () {
                        var modal = $('.pass-modal');
                        var form = modal.find('.modal-form');

                        form.find('input').prop('disabled',false);
                        form.find('input').val('');
                        btnClose.removeClass('is-Disabled');
                        btnSend.removeClass('is-Disabled');

                        if (modal.hasClass('modal-shown')){
                            form.animate({
                                left:'-100%'
                            },500,function () {
                                modal.hide();
                            });
                            modal.removeClass('modal-shown');
                        }else{
                            modal.show();

                            form.animate({
                                left:'50%'
                            });
                            modal.addClass('modal-shown');
                        }
                    },2000);

                }else if (response === "WRONG PASS"){
                    msg.html("Contraseña actual inválida");
                    msg.css("color","#DF3A01");
                    msg.show();

                    $('.pass-modal').find('input').prop('disabled',false);
                    btnClose.removeClass('is-Disabled');
                    btnSend.removeClass('is-Disabled');
                    curPass.focus();
                }else {
                    msg.html("Sin comunicación con el servidor");
                    msg.css("color","#DF3A01");
                    msg.show();

                    $('.pass-modal').find('input').prop('disabled',false);
                    btnClose.removeClass('is-Disabled');
                    btnSend.removeClass('is-Disabled');
                    curPass.focus();
                }
            },
            error:function (a,b,c) {
                console.log(a + '; ' + b + '; ' + c);
            }
        });
    });
});