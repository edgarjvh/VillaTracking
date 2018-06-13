$(document).ready(function () {
    $('.suggestion-modal .modal-title i.btn-close').on('click',function () {
        var suggestion_modal = $('.suggestion-modal');
        var form = suggestion_modal.find('.modal-form');

        if (suggestion_modal.hasClass('modal-shown')){
            form.animate({
                left:'-100%'
            },500,function () {
                suggestion_modal.hide();
            });
            suggestion_modal.removeClass('modal-shown');
        }else{
            suggestion_modal.show();

            form.animate({
                left:'50%'
            });
            suggestion_modal.addClass('modal-shown');
        }
    });

    $('.suggestion-modal').find('#modal-btn').on('click',function () {
        var suggestion_modal = $('.suggestion-modal');
        var subject = $('#txt-suggestion-subject');
        var message = $('#txt-suggestion-message');
        var btnSend = suggestion_modal.find('#modal-btn');
        var btnClose = suggestion_modal.find('.modal-form #btn-close');
        var msg = suggestion_modal.find('.message');

        msg.hide();
        suggestion_modal.find('input').prop('disabled',true);
        suggestion_modal.find('textarea').prop('disabled',true);
        btnClose.addClass('is-Disabled');
        btnSend.addClass('is-Disabled');

        if(subject.val().trim() === ""){
            msg.html("Debe ingresar el asunto del mensaje");
            msg.css("color","#DF3A01");
            msg.show();

            suggestion_modal.find('input').prop('disabled',false);
            suggestion_modal.find('textarea').prop('disabled',false);
            btnClose.removeClass('is-Disabled');
            btnSend.removeClass('is-Disabled');

            subject.focus();
            return;
        }

        if(message.val().trim() === ""){
            msg.html("Debe ingresar su mensaje");
            msg.css("color","#DF3A01");
            msg.show();

            suggestion_modal.find('input').prop('disabled',false);
            suggestion_modal.find('textarea').prop('disabled',false);
            btnClose.removeClass('is-Disabled');
            btnSend.removeClass('is-Disabled');

            message.focus();
            return;
        }

        msg.html('<p>Enviando sugerencia<i class="fa fa-spin fa-spinner"></i></p>');
        msg.css("color","#0101DF");
        msg.show();

        $.ajax({
            type:'post',
            url:host_dir + '/controller/c_client.php',
            data:{
                action:'newSuggestion',
                subject:subject.val(),
                message:message.val()
            },
            success: function (response) {
                console.log(response);

                if (response === "OK"){
                    msg.html('<p>Sugerencia enviada exitósamente<i class="fa fa-check"></i></p>');
                    msg.css("color","#088A08");
                    msg.show();

                    setTimeout(function () {
                        var form = suggestion_modal.find('.modal-form');

                        form.find('input').prop('disabled',false);
                        form.find('input').val('');
                        form.find('textarea').prop('disabled',false);
                        form.find('textarea').val('');
                        btnClose.removeClass('is-Disabled');
                        btnSend.removeClass('is-Disabled');

                        if (suggestion_modal.hasClass('modal-shown')){
                            form.animate({
                                left:'-100%'
                            },500,function () {
                                suggestion_modal.hide();
                            });
                            suggestion_modal.removeClass('modal-shown');
                        }else{
                            suggestion_modal.show();

                            form.animate({
                                left:'50%'
                            });
                            suggestion_modal.addClass('modal-shown');
                        }
                    },2000);                
                }else {
                    msg.html("Sin comunicación con el servidor");
                    msg.css("color","#DF3A01");
                    msg.show();

                    suggestion_modal.find('input').prop('disabled',false);
                    suggestion_modal.find('textarea').prop('disabled',false);
                    btnClose.removeClass('is-Disabled');
                    btnSend.removeClass('is-Disabled');
                    subject.focus();
                }
            },
            error:function (a,b,c) {
                console.log(a + '; ' + b + '; ' + c);
            }
        });
    });
});