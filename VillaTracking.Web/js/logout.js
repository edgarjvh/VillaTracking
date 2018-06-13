$(document).ready(function () {
    var logout_modal = $('.logout-modal');

    logout_modal.find('i#btn-close').on('click',function () {

        var form = logout_modal.find('.modal-form');

        if (logout_modal.hasClass('modal-shown')){
            form.animate({
                left:'-100%'
            },500,function () {
                logout_modal.hide();
            });
            logout_modal.removeClass('modal-shown');
        }else{
            logout_modal.show();

            form.animate({
                left:'50%'
            });
            logout_modal.addClass('modal-shown');
        }
    });

    logout_modal.find('#modal-btn').on('click',function () {
        $.ajax({
            type:'post',
            url:host_dir + '/controller/c_login.php',
            data:{
                action:'logout'
            },
            success: function (response) {
                window.location.reload();
            },
            error:function (a,b,c) {
                console.log(a + '; ' + b + '; ' + c);

                var form = logout_modal.find('.modal-form');

                if (logout_modal.hasClass('modal-shown')){
                    form.animate({
                        left:'-100%'
                    },500,function () {
                        logout_modal.hide();
                    });
                    logout_modal.removeClass('modal-shown');
                }else{
                    logout_modal.show();

                    form.animate({
                        left:'50%'
                    });
                    logout_modal.addClass('modal-shown');
                }
            }
        });
    });
});