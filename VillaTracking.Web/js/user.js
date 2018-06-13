var host_dir = window.location.protocol + '//' + window.location.host; 
var dialog = null;
$(document).ready(function () {
    getAll();
    console.log(window.location.protocol);
    console.log(window.location.host);
    console.log(window.location.pathname);
});

function getAll() {
    $.ajax({
        type:'POST',
        url: host_dir+'/controller/c_user.php',
        data:{
            action:'getAll'
        },
        success:function (response) {
            var result = $.parseJSON(response);

            $("#tbl-users > tbody").html("");

            $.each(result,function (key,value) {
                var row = document.createElement('tr');
                var col_id = document.createElement('td');
                var col_dni = document.createElement('td');
                var col_first = document.createElement('td');
                var col_last = document.createElement('td');
                var col_email = document.createElement('td');
                var col_phone1 = document.createElement('td');
                var col_phone2 = document.createElement('td');
                var col_address = document.createElement('td');
                var col_add = document.createElement('td');
                var plus = document.createElement('i');
                var col_edit = document.createElement('td');
                var pencil = document.createElement('i');
                var col_del = document.createElement('td');
                var trash = document.createElement('i');

                $(row).attr('id', value.user_id);
                $(col_id).html(value.user_id);
                $(col_id).addClass('hidden');
                $(col_id).addClass('td-user-id');
                $(col_dni).html(value.dni);
                $(col_dni).addClass('td-dni');
                $(col_first).html(value.first_name);
                $(col_first).addClass('td-first_name');
                $(col_last).html(value.last_name);
                $(col_last).addClass('td-last_name');
                $(col_email).html(value.email);
                $(col_email).addClass('td-email');
                $(col_phone1).html(value.phone_number1);
                $(col_phone1).addClass('td-phone1');
                $(col_phone2).html(value.phone_number2);
                $(col_phone2).addClass('hidden');
                $(col_phone2).addClass('td-phone2');
                $(col_address).html(value.address);
                $(col_address).addClass('td-address');
                $(plus).addClass('fa fa-plus td-new');
                $(plus).attr('onclick',"newUser();");
                $(col_add).append(plus);
                $(pencil).addClass('fa fa-pencil td-edit');
                $(pencil).attr('onclick',"editUser(this);");
                $(col_edit).append(pencil);
                $(trash).addClass('fa fa-trash td-delete');
                $(trash).attr('onclick',"deleteUser(this);");
                $(col_del).append(trash);

                $(row).append(col_id);
                $(row).append(col_dni);
                $(row).append(col_first);
                $(row).append(col_last);
                $(row).append(col_email);
                $(row).append(col_phone1);
                $(row).append(col_phone2);
                $(row).append(col_address);
                $(row).append(col_add);
                $(row).append(col_edit);
                $(row).append(col_del);

                $('#tbl-users').find('tbody').append(row);
            });
        },
        error:function () {

        }
    });
}

function newUser() {
    $('#tbl-users').hide();
    $(".new-user").animate({
        left:'0'
    });
}

function editUser(element) {
    var row = $(element).parent().parent();

    $('#edit-txt-id').val($(row).find('td.td-user-id').html());
    $('#edit-txt-dni').val($(row).find('td.td-dni').html());
    $('#edit-txt-first').val($(row).find('td.td-first_name').html());
    $('#edit-txt-last').val($(row).find('td.td-last_name').html());
    $('#edit-txt-email').val($(row).find('td.td-email').html());
    $('#edit-txt-phone1').val($(row).find('td.td-phone1').html());
    $('#edit-txt-phone2').val($(row).find('td.td-phone2').html());
    $('#edit-txt-address').val($(row).find('td.td-address').html());

    $('#tbl-users').hide();
    $(".edit-user").animate({
        left:'0'
    });
}

function deleteUser(element) {
    var id = $(element).parent().parent().attr('id');

    bootbox.confirm({
        message:"¿Está seguro de eliminar este usuario?",
        callback:function (result) {
            if(result){
                $.ajax({
                    type:"POST",
                    url:"controller/c_user.php",
                    data:{
                        action:"deleteUser",
                        user_id:id
                    },
                    success:function (response) {
                        console.log(response);
                        bootbox.hideAll();
                        if(response === "OK"){
                            bootbox.alert({
                                message: "El usuario ha sido eliminado exitosamente",
                                backdrop:true,
                                callback:function () {
                                    getAll();
                                }
                            });
                        }else{
                            bootbox.alert({
                                messasge: "Ocurrió un error al intentar eliminar el usuario",
                                backdrop:true
                            });
                        }
                    },
                    error:function () {
                        bootbox.alert({
                            messasge: "Ocurrió un error al intentar eliminar el usuario",
                            backdrop:true
                        });
                    }
                });
            }
        }
    })
}

function closeUserInput() {
    $(".user-inputs").animate({
        left:'-100%'
    },400,function () {
        $('#tbl-users').show();
        $(".user-inputs").find('input').val('');
    });
}

function saveUser(a){
    if (a === "0"){
        var dni = $('#new-txt-dni');
        var first = $('#new-txt-first');
        var last = $('#new-txt-last');
        var email = $('#new-txt-email');
        var phone1 = $('#new-txt-phone1');
        var phone2 = $('#new-txt-phone2');
        var address = $('#new-txt-address');
        
        if(dni.val().trim() === ""){
            bootbox.alert({
                message:"Debe ingresar la cédula del usuario",
                backdrop:true                
            });
            dni.focus();
            return;
        }
        
        if(first.val().trim() === ""){
            bootbox.alert({
                message:"Debe ingresar el nombre del usuario",
                backdrop:true
            });
            first.focus();
            return;
        }

        if(email.val().trim() === ""){
            bootbox.alert({
                message:"Debe ingresar el correo electrónico del usuario",
                backdrop:true
            });
            email.focus();
            return;
        }

        if(phone1.val().trim() === ""){
            bootbox.alert({
                message:"Debe ingresar el número telefónico principal del usuario",
                backdrop:true
            });
            phone1.focus();
            return;
        }

        if(address.val().trim() === ""){
            bootbox.alert({
                message:"Debe ingresar la dirección del usuario",
                backdrop:true
            });
            address.focus();
            return;
        }

        dialog = new bootbox.dialog({
            message:'<p><i class="fa fa-spin fa-spinner"></i> Guardando datos del usuario...</p>',
            backdrop:false,
            closeButton: false
        });
        
        $.ajax({
            type:'POST',
            url:'controller/c_user.php',
            data:{
                action:'addUser',
                dni:dni.val(),
                first:first.val(),
                last:last.val(),
                email:email.val(),
                phone1:phone1.val(),
                phone2:phone2.val().trim(),
                address:address.val()
            },
            success:function (response) {
                dialog.modal('hide');
                bootbox.hideAll();

                if(response === "OK"){
                    bootbox.alert({
                        message:'El usuario ha sido ingresado exitosamente',
                        backdrop:true,
                        callback:function () {
                            getAll();
                            closeUserInput();
                            dialog.modal('hide');
                            bootbox.hideAll();
                        }
                    });
                }else if(response === "EXISTS"){
                    bootbox.alert({
                        message:'Ya existe un usuario con la cédula que ha ingresado',
                        backdrop:true,
                        callback:function () {
                            dialog.modal('hide');
                            bootbox.hideAll();
                        }
                    });
                }else{
                    bootbox.alert({
                        message:'Ocurrió un error al intentar guardar los datos del usuario',
                        backdrop:true,
                        callback:function () {
                            dialog.modal('hide');
                            bootbox.hideAll();
                        }
                    });
                }
            },
            error:function () {
                dialog.modal('hide');
                bootbox.hideAll();

                bootbox.alert({
                    message:'Error inesperado',
                    backdrop:true
                });
            }
        });
    }else{
        var id = $('#edit-txt-id');
        dni = $('#edit-txt-dni');
        first = $('#edit-txt-first');
        last = $('#edit-txt-last');
        email = $('#edit-txt-email');
        phone1 = $('#edit-txt-phone1');
        phone2 = $('#edit-txt-phone2');
        address = $('#edit-txt-address');

        if(id.val().trim() === ""){
            bootbox.alert({
                message:"Debe seleccionar un usuario",
                backdrop:true
            });
            dni.focus();
            return;
        }

        if(dni.val().trim() === ""){
            bootbox.alert({
                message:"Debe ingresar la cédula del usuario",
                backdrop:true
            });
            dni.focus();
            return;
        }

        if(first.val().trim() === ""){
            bootbox.alert({
                message:"Debe ingresar el nombre del usuario",
                backdrop:true
            });
            first.focus();
            return;
        }

        if(email.val().trim() === ""){
            bootbox.alert({
                message:"Debe ingresar el correo electrónico del usuario",
                backdrop:true
            });
            email.focus();
            return;
        }

        if(phone1.val().trim() === ""){
            bootbox.alert({
                message:"Debe ingresar el número telefónico principal del usuario",
                backdrop:true
            });
            phone1.focus();
            return;
        }

        if(address.val().trim() === ""){
            bootbox.alert({
                message:"Debe ingresar la dirección del usuario",
                backdrop:true
            });
            address.focus();
            return;
        }

        dialog = new bootbox.dialog({
            message:'<p><i class="fa fa-spin fa-spinner"></i> Guardando datos del usuario...</p>',
            backdrop:false,
            closeButton: false
        });

        console.log(id.val());
        console.log(dni.val());
        console.log(first.val());
        console.log(last.val());
        console.log(email.val());
        console.log(phone1.val());
        console.log(phone2.val());
        console.log(address.val());

        $.ajax({
            type:'POST',
            url: host_dir + '/controller/c_user.php',
            data:{
                action:'editUser',
                id:id.val(),
                dni:dni.val(),
                first:first.val(),
                last:last.val(),
                email:email.val(),
                phone1:phone1.val(),
                phone2:phone2.val().trim(),
                address:address.val()
            },
            success:function (response) {
                dialog.modal('hide');
                bootbox.hideAll();

                if(response === "OK"){
                    bootbox.alert({
                        message:'El usuario ha sido modificado exitosamente',
                        backdrop:true,
                        callback:function () {
                            dialog.modal('hide');
                            bootbox.hideAll();
                            getAll();
                            closeUserInput();
                        }
                    });
                }else{
                    bootbox.alert({
                        message:'Ocurrió un error al intentar guardar los datos del usuario',
                        backdrop:true,
                        callback:function () {
                            dialog.modal('hide');
                            bootbox.hideAll();
                        }
                    });
                }
            },
            error:function () {
                dialog.modal('hide');
                bootbox.hideAll();

                bootbox.alert({
                    message:'Error inesperado',
                    backdrop:true,
                    callback:function () {
                        dialog.modal('hide');
                        bootbox.hideAll();
                    }
                });
            }
        });
    }
}