var host_dir = window.location.protocol + '//' + window.location.host;
var selectedVoice = null;

$(document).ready(function () {

    var voices = window.speechSynthesis.getVoices();
    $(voices).each(function (key,voice) {
        if (voice.lang === "es-MX"){
            selectedVoice = voice;
            return false;
        }

        if (voice.lang === "es-ES"){
            selectedVoice = voice;
            return false;
        }
    });

    $(".tabs").find('p').on('click',function () {
      var id = $(this).attr('id');

      $('.console').find('section').removeClass('active');
       $('.console').find('p').removeClass('active');

      $('.console').find('section#'+id).addClass('active');
       $(this).addClass('active');
   });

    $('#cbox-toggle-console').prop('checked',true);

    $('#cbox-toggle-console').on('change',function () {
        if($('#cbox-toggle-console').is(':checked')) {
            $('#cbox-toggle-console+label').find('i').css('transform','rotate(0deg)');
            $('.console').animate({
                bottom:'0'
            },600);
        }else{
            $('#cbox-toggle-console+label').find('i').css('transform','rotate(180deg)');
            $('.console').animate({
                bottom:'-250px'
            },600);
        }
    });

    pushEvents();
});

var date_time = null;

function pushEvents() {
    var pushCounter = 0;

    $.ajax({
        async:true,
        type:"POST",
        url: host_dir + "/controller/push_events.php",
        data:{
            date_time : date_time
        },
        success:function (response) {
            pushCounter = date_time === null ? 0 : 1;

            if (response !== ""){
                var data = $.parseJSON(response);
                if(data.length > 0){
                    var count = 0;

                    $.each(data,function (key, value) {
                        var tr = document.createElement('tr');
                        $(tr).addClass(value.reviewed === "1" ? 'reviewed' : '');
                        $(tr).attr('id',value.event_id);

                        var td_event_id = document.createElement('td');
                        $(td_event_id).addClass('td-event-id');
                        $(td_event_id).addClass('hidden');
                        $(td_event_id).html(value.event_id);
                        $(tr).append(td_event_id);

                        var td_client = document.createElement('td');
                        $(td_client).addClass('td-client');
                        $(td_client).html(value.first_name + " " + value.last_name);
                        $(tr).append(td_client);

                        var td_vehicle = document.createElement('td');
                        $(td_vehicle).addClass('td-vehicle');
                        $(td_vehicle).html(value.license_plate +
                            " <span>(" +
                            value.brand + " " +
                            value.model + " " +
                            value.color + " " +
                            value.year +
                            ")</span>");
                        $(tr).append(td_vehicle);

                        var td_device = document.createElement('td');
                        $(td_device).addClass('td-device');
                        $(td_device).html(value.imei +
                            " <span>(" +
                            value.phone_number +
                            ")</span>");
                        $(tr).append(td_device);

                        var td_date_time = document.createElement('td');
                        $(td_date_time).addClass('td-datetime');
                        $(td_date_time).html(value.date_time);
                        $(tr).append(td_date_time);

                        var td_event = document.createElement('td');
                        $(td_event).addClass('td-event');
                        var event = "";
                        var speech = value.first_name + " " + value.last_name;

                        switch (value.event_name){
                            case "speed":
                                event = "EXCESO DE VELOCIDAD (" + value.speed_limit + " Km/H => " + value.current_speed + " Km/H)";
                                speech += ", exceso de velocidad";
                                break;
                            case "low battery":
                                event = "BATERÍA BAJA";
                                speech += ", alerta de batería";
                                break;
                            case "ac alarm":
                                event = "DESCONEXIÓN DE BATERÍA";
                                speech += ", alerta de batería";
                                break;
                            case "entrada geocerca":
                                event = "ENTRADA A GEOCERCA (" + value.geofence_name + ")";
                                speech += ", entrada a geocerca";
                                break;
                            case "salida geocerca":
                                event = "SALIDA DE GEOCERCA (" + value.geofence_name + ")";
                                speech += ", salida de geocerca";
                                break;
                            default:
                                event = "";
                                speech = "";
                        }

                        $(td_event).html(event);
                        $(tr).append(td_event);

                        var td_report = document.createElement('td');
                        $(td_report).addClass('td-report');
                        var file_text = document.createElement('i');
                        $(file_text).addClass('fa fa-file-text');
                        $(td_report).append(file_text);
                        $(tr).append(td_report);

                        var td_map = document.createElement('td');
                        $(td_map).addClass('td-map');
                        var maps = document.createElement('i');
                        $(maps).addClass('fa fa-map');
                        $(td_map).append(maps);
                        $(tr).append(td_map);

                        var td_latitude = document.createElement('td');
                        $(td_latitude).addClass('td-latitude');
                        $(td_latitude).addClass('hidden');
                        $(td_latitude).html(value.latitude);
                        $(tr).append(td_latitude);

                        var td_longitude = document.createElement('td');
                        $(td_longitude).addClass('td-longitude');
                        $(td_longitude).addClass('hidden');
                        $(td_longitude).html(value.longitude);
                        $(tr).append(td_longitude);

                        var td_client_id = document.createElement('td');
                        $(td_client_id).addClass('td-client-id');
                        $(td_client_id).addClass('hidden');
                        $(td_client_id).html(value.client_id);
                        $(tr).append(td_client_id);

                        var td_vehicle_id = document.createElement('td');
                        $(td_vehicle_id).addClass('td-vehicle-id');
                        $(td_vehicle_id).addClass('hidden');
                        $(td_vehicle_id).html(value.vehicle_id);
                        $(tr).append(td_vehicle_id);

                        var td_device_id = document.createElement('td');
                        $(td_device_id).addClass('td-device-id');
                        $(td_device_id).addClass('hidden');
                        $(td_device_id).html(value.device_id);
                        $(tr).append(td_device_id);

                        var td_geofence_id = document.createElement('td');
                        $(td_geofence_id).addClass('td-geofence-id');
                        $(td_geofence_id).addClass('hidden');
                        $(td_geofence_id).html(value.geofence_id);
                        $(tr).append(td_geofence_id);

                        $(tr).prependTo('#tbl-events-body > tbody');
                        count++;
                        date_time = value.date_time;

                        if(selectedVoice !== null && pushCounter > 0 && speech !== ""){

                            var msg = new SpeechSynthesisUtterance();
                            msg.voice = selectedVoice;
                            msg.voiceURI = 'native';
                            msg.volume = 1; // 0 to 1
                            msg.rate = 1; // 0.1 to 10
                            msg.pitch = 2; //0 to 2
                            msg.text = speech;
                            msg.lang = 'es-ES';
                            speechSynthesis.speak(msg);
                        }

                        if (pushCounter > 0){

                            $(document).find("ul.vehicle li").each(function (key, li) {
                                var imei = $(li).find('.imei');
                                var latitude = $(li).find('.latitude');
                                var longitude = $(li).find('.longitude');
                                var datetime = $(li).find('.datetime');
                                var speed = $(li).find('.speed');
                                var orientation = $(li).find('.orientation');

                                if (imei.html() === value.imei){
                                    latitude.html(value.latitude);
                                    longitude.html(value.longitude);
                                    datetime.text(value.date_time).trigger('change');
                                    speed.html(value.current_speed);
                                    orientation.html(value.orientation);
                                }
                            });
                        }
                    });
                }
            }

            $('#events-counter').html($('#tbl-events-body > tbody > tr').length);
            setTimeout(pushEvents(),1000);
        }
    });
}