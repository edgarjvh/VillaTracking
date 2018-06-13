$(document).ready(function () {
    $('#cbox-menu-header').prop('checked',false);

    $('#cbox-menu-header').on('change',function () {
        $('#header nav.menu ul ul').slideUp();

        if($('#cbox-menu-header').is(':checked')) {
            $('#header nav.menu ul#menu').animate({
                top:'50px'
            });
        }else{
            $('#header nav.menu ul#menu').animate({
                top:'-100%'
            });
        }
    });

    $('li.submenu').on('click',function () {
        if($(this).hasClass('active')){
            $(this).find('ul').slideUp();
            $(this).removeClass('active');
        }else{
            $('#header nav.menu ul ul').slideUp();
            $('li.submenu').removeClass('active');
            $(this).find('ul').slideDown();
            $(this).addClass('active');
        }
    });

    $('li#mnu-suggestions').on('click',function () {
        var modal = $('.suggestion-modal');
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

            form.find('input').val('');
            form.find('.message').html('');
            form.find('.message').hide();

            form.animate({
                left:'50%'
            });
            modal.addClass('modal-shown');
            form.find('#txt-current-pass').focus();
        }
    });

    $('li#mnu-password').on('click',function () {
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

            form.find('input').val('');
            form.find('.message').html('');
            form.find('.message').hide();

            form.animate({
                left:'50%'
            });
            modal.addClass('modal-shown');
            form.find('#txt-current-pass').focus();
        }
    });

    $('li#mnu-logout').on('click',function () {
        var modal = $('.logout-modal');
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
});