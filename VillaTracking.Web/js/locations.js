var host_dir = window.location.protocol + '//' + window.location.host;
var locations = [];

$(document).ready(function () {
    //getLocations();
});

function getLocations() {
    $.ajax({
        async:true,
        type:"POST",
        url:host_dir + "/controller/c_location.php",
        data:{
            action:"getLocations"
        },
        success:function (response) {
            try {
                var data =  $.parseJSON(response);
                if (data.length > 0){
                    $('ul.vehicle').find('li').each(function (key, li) {
                        for (var i = 0; i < data.length; i++){
                            var imei = $(li).find('.imei');
                            var latitude = $(li).find('.latitude');
                            var longitude = $(li).find('.longitude');
                            var datetime = $(li).find('.datetime');
                            var speed = $(li).find('.speed');

                            var orientation = $(li).find('.orientation');
                            if (imei.html() === data[i].imei){
                                latitude.html(data[i].latitude);
                                longitude.html(data[i].longitude);
                                datetime.text(data[i].date_time).trigger('change');
                                speed.html(data[i].speed);
                                orientation.html(data[i].orientation);
                                break;
                            }
                        }
                    });

                }
            }catch (e){

            }
        },
        error:function () {

        }
    });

    setTimeout(function () {
        getLocations();
    }, 20000);
}