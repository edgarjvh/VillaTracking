var host_dir = window.location.protocol + '//' + window.location.host;
var markers = [];
var selectedMarker = null;
var devices = "";

$(document).ready(function () {
    getAllClients();

    $('#txt-client-filter').on('input',function () {
        var text = $(this).val().trim();
        text = text.toLowerCase();
        var num = text.substring(1);
        var oper = text.substring(1,2);

        $.each($('li.root-client'),function () {
            var last = $(this).find('.last').html();
            var first = $(this).find('.first').html();
            var brand = $(this).find('.brand').html();
            var model = $(this).find('.model').html();
            var license = $(this).find('.license-plate').html();
            var color = $(this).find('.color').html();
            var year = $(this).find('.year').html();
            var imei = $(this).find('.imei').html();
            var simcard = $(this).find('.simcard').html();
            var speed = $(this).find('.speed').html();
            var datetime = $(this).find('.datetime').html();
            var counter = $(this).find('.counter').html();

            if (last !== "Cargando Clientes"){

                switch (text.substring(0,1)){
                    case ">":
                        num = num === "" ? 0 : num;
                        $(this).css('display',(
                        parseInt(counter) > parseInt(num)) ? "block":"none");
                        break;
                    case "<":
                        num = num === "" ? 0 : num;
                        $(this).css('display',(
                        parseInt(counter) < parseInt(num)) ? "block":"none");
                        break;
                    case "=":
                        num = num === "" ? 0 : num;
                        $(this).css('display',(
                        parseInt(counter) === parseInt(num)) ? "block":"none");
                        break;
                    case "@":
                        num = text.substring(2);
                        num = num === "" ? 0 : num;
                        speed = speed === "" ? 0 : speed;

                        if(oper === ">"){
                            $(this).css('display',(
                            parseInt(speed) > parseInt(num)) ? "block":"none");
                        }else if(oper === "<"){
                            $(this).css('display',(
                            parseInt(speed) < parseInt(num)) ? "block":"none");
                        }else if(oper === "="){
                            $(this).css('display',(
                            parseInt(speed) === parseInt(num)) ? "block":"none");
                        }else{
                            $(this).css('display','block');
                        }
                        break;
                    case "#":
                        if (datetime.length === 19){
                            num = text.substring(2);
                            num = num === "" ? 0 : num;
                            var minutes = 1000*60;
                            var hours = minutes*60;
                            var days = hours*24;
                            var now = null;
                            var date_time = new Date(datetime);

                            console.log("Antes: " + datetime + ", Despues: " + date_time.getTime());
                            if (oper === "m"){
                                now = new Date(new Date().getTime() - minutes*parseInt(num));
                                $(this).css('display',(
                                date_time.getTime() < now.getTime()) ? "block":"none");
                            }else if (oper === "h"){
                                now = new Date(new Date().getTime() - hours*parseInt(num));
                                $(this).css('display',(
                                date_time.getTime() < now.getTime()) ? "block":"none");
                            }else if (oper === "d"){
                                now = new Date(new Date().getTime() - days*parseInt(num));
                                $(this).css('display',(
                                date_time.getTime() < now.getTime()) ? "block":"none");
                            }else{
                                $(this).css('display','block');
                            }
                        }
                        break;
                    case "*":
                        $(this).css('display',(
                            $(this).find('input.cbox-select-vehicle').is(':checked')) ? "block":"none");
                        break;
                    default:
                        $(this).css('display',(
                        last.toLowerCase().indexOf(text) > -1 |
                        first.toLowerCase().indexOf(text) > -1 |
                        brand.toLowerCase().indexOf(text) > -1 |
                        model.toLowerCase().indexOf(text) > -1 |
                        license.toLowerCase().indexOf(text) > -1 |
                        color.toLowerCase().indexOf(text) > -1 |
                        year.toLowerCase().indexOf(text) > -1 |
                        imei.toLowerCase().indexOf(text) > -1 ||
                        simcard.toLowerCase().indexOf(text) > -1) ? "block":"none");
                        break;
                }
            }
        });
    });

    $('.menu1').find('p ul.menu-item').slideToggle();

    $('#cbox-toggle-sidebar').prop('checked',true);

    $('#cbox-toggle-sidebar').on('change',function () {
        if($('#cbox-toggle-sidebar').is(':checked')) {
            $('#cbox-toggle-sidebar+label').find('i').css('transform','rotate(0deg)');
            $('.sidebar').animate({
               left:'0'
            },600);
        }else{
            $('#cbox-toggle-sidebar+label').find('i').css('transform','rotate(180deg)');
            $('.sidebar').animate({
                left:'-300px'
            },600);
        }
    });

    $(document).on('change', 'span.datetime' ,function () {
        var parent = $(this).parent();
        var client = $(this).parent().parent().parent().parent();
        var first_name = $(client).find('span.first').text();
        var last_name = $(client).find('span.last').text();
        var imei = parent.find('.imei').html();
        var license_plate = parent.find('.license-plate').html();
        var brand = parent.find('.brand').html();
        var model = parent.find('.model').html();
        var year = parent.find('.year').html();
        var color = parent.find('.color').html();
        var datetime = $(this).html();
        var latitude = parent.find('.latitude').html();
        var longitude = parent.find('.longitude').html();
        var speed = parent.find('.speed').html();
        var orientation = parent.find('.orientation').html();

        if(latitude !== null || latitude !== "null"){
            addOrUpdateMarker(
                first_name,
                last_name,
                imei,
                license_plate,
                brand,
                model,
                year,
                color,
                latitude,
                longitude,
                datetime,
                speed,
                orientation
            );
        }
    });

    $(document).on('click', '.sidebar ul ul li.client ul li.info .btn-travel', function () {
        var parent = $(this).parent().parent();

        if(parent.hasClass('expired')){
            alert("Vehículo Suspendido!\nPara mayor información por favor comuníquese con nuestro Departamento de Administración");
            return;
        }

        if(parent.find('span.latitude').text().trim() === "null"){
            alert("Aún no hemos recibido reportes de este vehículo");
            return;
        }

        var imei = parent.find('.imei').text().trim();
        var license_plate = parent.find('.license-plate').text().trim();
        var travel_modal = $('.travel-modal');

        travel_modal.find('span.travel-selected-vehicle').html(license_plate);
        travel_modal.find('input').val('');

        initTravelMap();
        travel_modal.fadeIn("slow");

        google.maps.event.trigger(travel_map, 'resize');
    });

    $(document).on('click', '.sidebar ul ul li.client ul li.info .btn-on-map', function () {
        var parent = $(this).parent().parent();

        if(parent.hasClass('expired')){
            alert("Vehículo Suspendido!\nPara mayor información por favor comuníquese con nuestro Departamento de Administración");
            return;
        }

        if(parent.hasClass('no-location')){
            alert("Aún no hemos recibido reportes de este vehículo");
            return;
        }

        $(this).hasClass('vehicle-on-map') ? $(this).removeClass('vehicle-on-map') : $(this).addClass('vehicle-on-map')

        var isOnMap = $(this).hasClass('vehicle-on-map');

        var client = $('ul#main-list span.client-name');

        $(this).css('background-color', isOnMap ? '#27ae60' : '#1a5276');
        $(this).css('color', isOnMap ? '#000' : '#fff');
        $(this).html(isOnMap ? '<i class="fa fa-map"></i> Ocultar' : '<i class="fa fa-map"></i> Mostrar');

        var selected = 0;

        parent.parent().find('li').each(function (key, li) {
            var onmap = $(li).find('.btn-vehicle .btn-on-map').hasClass('vehicle-on-map');
            if(onmap){
                selected++;
            }
        });

        client.find('span.last').css('color',selected > 0 ? 'rgba(0,255,0,1)' : '#fff');
        client.find('span.first').css('color',selected > 0 ? 'rgba(0,255,0,1)' : '#fff');

        var imei = parent.find('span.imei').text();

        if (markers.length > 0){
            for (var i = 0; i < markers.length; i++){
                if (markers[i].imei === imei){
                    if (isOnMap){
                        markers[i].setMap(map);
                        selectedMarker = imei;
                        map.setCenter(markers[i].getPosition());
                    }else{
                        markers[i].setMap(null);
                        selectedMarker = "";
                        for (var x = markers.length - 1; x >= 0; x--){
                            if (markers[x].getMap() !== null){
                                selectedMarker = markers[x].imei;
                                break;
                            }
                        }
                    }
                    break;
                }
            }
        }
    });
});

function getLocations() {
    devices = '';

    if (markers.length > 0){
        for (var x = 0; x < markers.length; x++){
            devices += '{"imei":"' + markers[x].imei + '", "date_time":"' + markers[x].date + '"},';
        }
    }

    devices = devices.slice(0,-1);
    devices = insert(devices,0,'[');
    devices = insert(devices,devices.length,']');

    $.ajax({
        type:'post',
        url:host_dir + '/controller/c_location.php',
        data:{
            action:'getLocations',
            devices:devices
        },
        success:function (response) {
            try{
                var data = $.parseJSON(response);

                for (var i = 0; i < data.length; i++){
                    for (var y = 0; y < markers.length; y++){
                        if (data[i].imei === markers[y].imei && data[i].latitude !== "null"){
                            addOrUpdateMarker(
                                data[i].imei,
                                data[i].latitude,
                                data[i].longitude,
                                data[i].date_time,
                                data[i].speed,
                                data[i].orientation
                            );

                            var btn_on_map = $('.sidebar').find('div[name='+ data[i].imei +']');

                            var parent = btn_on_map.parent().parent();

                            if (!parent.hasClass('expired')){
                                parent.removeClass('moving');
                                parent.removeClass('stop');
                                parent.removeClass('no-location');

                                parent.addClass(data[i].speed > 0 ? 'moving':'stop');
                            }
                            break;
                        }
                    }
                }

                getLocations();
            }catch(e){
                getLocations();
            }
        },
        error:function (a,b,c) {
            getLocations();
        }
    });
}

function setCenterMap(element, event) {
    if(event.which === 3)
    {
        var cbox = $(element).parent().find('.cbox-select-vehicle');
        var imei = cbox.attr('id');

        if(cbox.is(':checked')){
            for(var i = 0; i < markers.length; i++){
                if(markers[i].imei === imei){
                    map.setCenter(markers[i].getPosition());
                    selectedMarker = imei;
                    break;
                }
            }
        }
    }
}

function addOrUpdateMarker(imei,lat,lng,date,speed,orientation) {
    if (lat !== "null"){
        var point = new google.maps.LatLng(parseFloat(lat), parseFloat(lng));

        var icon = {
            path: speed > 0 ? google.maps.SymbolPath.FORWARD_CLOSED_ARROW : google.maps.SymbolPath.CIRCLE,
            fillColor: speed > 0 ? "#01DF01" : "#3498db",
            fillOpacity:1,
            scale: speed > 0 ? 3 : 7,
            rotation: Number(orientation),
            strokeWeight:1,
            strokeColor:speed > 0 ? "#008C00" : "#2874a6"
        };

        var exist = false;

        for (var i = 0; i < markers.length; i++){
            if (markers[i].imei === imei){
                markers[i].setIcon(icon);
                markers[i].setPosition(point);
                markers[i].speed = speed;
                markers[i].date = date;
                markers[i].info.setContent('<div><span class="infoTitle">'+ markers[i].client +'</span><br>' +
                    '<span class="infoSubTitle">Imei:</span><span class="infoText">'+ markers[i].imei +'</span><br>' +
                    '<span class="infoSubTitle">Matrícula:</span><span class="infoText">'+ markers[i].license + '</span><br>' +
                    '<span class="infoSubTitle">Marca:</span><span class="infoText">'+ markers[i].brand + '</span><br>' +
                    '<span class="infoSubTitle">Modelo:</span><span class="infoText">'+ markers[i].model + '</span><br>' +
                    '<span class="infoSubTitle">Año:</span><span class="infoText">'+ markers[i].year + '</span><br>' +
                    '<span class="infoSubTitle">Color:</span><span class="infoText">'+ markers[i].color + '</span><br>' +
                    '<span class="infoSubTitle">Velocidad:</span><span class="infoText">'+ markers[i].speed + ' Km/H</span><br>' +
                    '<span class="infoSubTitle">Fecha:</span><span class="infoText">'+ markers[i].date +'</span><br></div>');

                map.setCenter(selectedMarker === imei && markers[i].getMap() !== null ? point : map.getCenter());
                exist = true;
                break;
            }
        }
    }
}

function showHideMarker(show,first_name,last_name,imei,license_plate,brand,model,year,color,lat,lng,date,speed,orientation){
    if (lat !== "null"){

        var point = new google.maps.LatLng(parseFloat(lat), parseFloat(lng));

        var icon = {
            path: speed > 0 ? google.maps.SymbolPath.FORWARD_CLOSED_ARROW : google.maps.SymbolPath.CIRCLE,
            fillColor: speed > 0 ? "#01DF01" : "#3498db",
            fillOpacity:1,
            scale: speed > 0 ? 3 : 7,
            rotation: Number(orientation),
            strokeWeight:1,
            strokeColor:speed > 0 ? "#008C00" : "#2874a6"
        };

        var exist = false;

        for (i = 0;i < markers.length; i++){
            if(markers[i].imei === imei){
                markers[i].setIcon(icon);
                markers[i].setPosition(point);
                markers[i].client = first_name + " " + last_name;
                markers[i].license = license_plate;
                markers[i].brand = brand;
                markers[i].model = model;
                markers[i].year = year;
                markers[i].color = color;
                markers[i].speed = speed;
                markers[i].date = date;
                markers[i].info.setContent('<div><span class="infoTitle">'+ markers[i].client +'</span><br>' +
                    '<span class="infoSubTitle">Imei:</span><span class="infoText">'+ markers[i].imei +'</span><br>' +
                    '<span class="infoSubTitle">Matrícula:</span><span class="infoText">'+ markers[i].license + '</span><br>' +
                    '<span class="infoSubTitle">Marca:</span><span class="infoText">'+ markers[i].brand + '</span><br>' +
                    '<span class="infoSubTitle">Modelo:</span><span class="infoText">'+ markers[i].model + '</span><br>' +
                    '<span class="infoSubTitle">Año:</span><span class="infoText">'+ markers[i].year + '</span><br>' +
                    '<span class="infoSubTitle">Color:</span><span class="infoText">'+ markers[i].color + '</span><br>' +
                    '<span class="infoSubTitle">Velocidad:</span><span class="infoText">'+ markers[i].speed + ' Km/H</span><br>' +
                    '<span class="infoSubTitle">Fecha:</span><span class="infoText">'+ markers[i].date +'</span><br></div>');
                markers[i].setMap(show ? map : null);

                map.setCenter(show ? point : map.getCenter());

                exist = true;
                break;
            }
        }

        if(!exist){
            var marker = new google.maps.Marker({
                map: show ? map : null,
                position:point,
                icon:icon,
                client:first_name + " " + last_name,
                imei:imei,
                license:license_plate,
                brand:brand,
                model:model,
                year:year,
                color:color,
                speed:speed,
                date:date,
                info:new google.maps.InfoWindow
            });

            marker.addListener('click', function() {
                marker.info.setContent('<div><span class="infoTitle">'+ marker.client +'</span><br>' +
                    '<span class="infoSubTitle">Imei:</span><span class="infoText">'+ marker.imei +'</span><br>' +
                    '<span class="infoSubTitle">Matrícula:</span><span class="infoText">'+ marker.license + '</span><br>' +
                    '<span class="infoSubTitle">Marca:</span><span class="infoText">'+ marker.brand + '</span><br>' +
                    '<span class="infoSubTitle">Modelo:</span><span class="infoText">'+ marker.model + '</span><br>' +
                    '<span class="infoSubTitle">Año:</span><span class="infoText">'+ marker.year + '</span><br>' +
                    '<span class="infoSubTitle">Color:</span><span class="infoText">'+ marker.color + '</span><br>' +
                    '<span class="infoSubTitle">Velocidad:</span><span class="infoText">'+ marker.speed + ' Km/H</span><br>' +
                    '<span class="infoSubTitle">Fecha:</span><span class="infoText">'+ marker.date +'</span><br></div>');

                marker.info.open(map, marker);
            });

            markers.push(marker);

            map.setCenter(show ? point : map.getCenter());
            selectedMarker = show ? imei : null;
        }else{
            for (var x = markers.length - 1; x >= 0; x--){
                selectedMarker = null;

                if (markers[x].getMap() !== null){
                    selectedMarker = markers[x].imei;
                    break;
                }
            }
        }
    }
}

function filterClients() {
    var text = $('#txt-client-filter').val();
    text = text.toLowerCase();
    $('li.root-client').each(function () {
        var last = $(this).find('.last').html();
        var first = $(this).find('.first').html();
        var brand = $(this).find('.brand').html();
        var model = $(this).find('.model').html();
        var license = $(this).find('.license-plate').html();
        var color = $(this).find('.color').html();
        var year = $(this).find('.year').html();
        var imei = $(this).find('.imei').html();
        var simcard = $(this).find('.simcard').html();

        $(this).css('display',(
        last.toLowerCase().indexOf(text) > -1 |
        first.toLowerCase().indexOf(text) > -1 |
        brand.toLowerCase().indexOf(text) > -1 |
        model.toLowerCase().indexOf(text) > -1 |
        license.toLowerCase().indexOf(text) > -1 |
        color.toLowerCase().indexOf(text) > -1 |
        year.toLowerCase().indexOf(text) > -1 |
        imei.toLowerCase().indexOf(text) > -1 ||
        simcard.toLowerCase().indexOf(text) > -1) ? "block":"none");
    });
}

function getAllClients() {
    $('ul#clients').html('');

    $('.clients-counter').text(0);
    $('.vehicles-counter').text(0);

    if (markers.length > 0){
        for(var i = 0; i < markers.length; i++){
            markers[i].setMap(null);
        }
    }

    $.ajax({
        async:true,
        type:"POST",
        url:host_dir+ "/controller/c_client.php",
        data:{
            action:"getAll"
        },
        success:function (response) {
            var clientCounter = 0;
            var vehicleCounter = 0;

            if(response !== ""){
                try{
                    var data = $.parseJSON(response);
                    var client_id = 0;
                    var counter = 0;
                    var client_list = "";
                    var counters = [];
                    var iteration = 1;

                    $.each(data,function (key,value) {
                        if(client_id === 0){
                            counter = 0;

                            $('span.client-name').find('.last').html(value.last_name);
                            $('span.client-name').find('.first').html(value.first_name);

                            client_list += '' +
                                '<li class="root-client">' +
                                '<ul class="client">' +
                                '<li class="client" id="'+ value.client_id +'">' +
                                '<i class="client-row" onclick="toggleVehicles(this)">' +
                                /*'<span class="name">' +
                                    '<span class="last">'+ value.last_name +'</span>' +
                                    '<span class="first">'+ value.first_name +'</span>' +
                                '</span>' +*/
                                '</i>' +
                                '<ul class="vehicle">' +
                                '<li class="info ' + (value.vehicle_status === '0' ? 'expired' : value.latitude === null ? 'no-location' : value.speed > 0 ? 'moving' : 'stop') + '">' +
                                '<input type="checkbox" class="hidden cbox-select-vehicle" id="'+ value.imei +'">' +
                                '<label for="'+ value.imei +'" onmousedown="setCenterMap(this,event);">' +
                                '<span class="vehicle-id">'+ value.vehicle_id +'</span>' +
                                'Marca: <span class="brand">'+ value.brand +'</span>' +
                                ' Modelo: <span class="model">'+ value.model +'</span>' +
                                ' Color: <span class="color">'+ value.color +'</span>' +
                                ' Año: <span class="year">'+ value.year +'</span>' +
                                ' Matrícula: <span class="license-plate">'+ value.license_plate +'</span>' +
                                '<span class="expiration-date">'+ value.expiration_date +'</span>' +
                                '<span class="imei">'+ value.imei +'</span>' +
                                '<span class="simcard">'+ value.phone_number +'</span>' +
                                '<span class="device-id">'+ value.device_id +'</span>' +
                                '<span class="latitude">'+ value.latitude +'</span>' +
                                '<span class="longitude">'+ value.longitude +'</span>' +
                                '<span class="datetime">'+ value.date_time +'</span>' +
                                '<span class="speed">'+ value.speed +'</span>' +
                                '<span class="orientation">'+ value.orientation +'</span>' +
                                '</label>' +
                                '<div class="btn-vehicle">'+
                                '<div class="btn-travel" id="' + value.imei + '"><i class="fa fa-road"></i> Ver Recorrido</div>'+
                                '<div class="btn-on-map" id="' + value.imei + '" name="' + value.imei + '"><i class="fa fa-map"></i> Mostrar</div>'+
                                '</div>'+
                                '</li>';
                            counter++;

                            client_id = value.client_id;

                        }else{
                            if(value.client_id === client_id){
                                client_list += '' +
                                    '<li class="info ' + (value.vehicle_status === '0' ? 'expired' : value.latitude === null ? 'no-location' : value.speed > 0 ? 'moving' : 'stop') + '">' +
                                    '<input type="checkbox" class="hidden cbox-select-vehicle" id="'+ value.imei +'">' +
                                    '<label for="'+ value.imei +'" onmousedown="setCenterMap(this,event);">' +
                                    '<span class="vehicle-id">'+ value.vehicle_id +'</span>' +
                                    'Marca: <span class="brand">'+ value.brand +'</span>' +
                                    ' Modelo: <span class="model">'+ value.model +'</span>' +
                                    ' Color: <span class="color">'+ value.color +'</span>' +
                                    ' Año: <span class="year">'+ value.year +'</span>' +
                                    ' Matrícula: <span class="license-plate">'+ value.license_plate +'</span>' +
                                    '<span class="expiration-date">'+ value.expiration_date +'</span>' +
                                    '<span class="imei">'+ value.imei +'</span>' +
                                    '<span class="simcard">'+ value.phone_number +'</span>' +
                                    '<span class="device-id">'+ value.device_id +'</span>' +
                                    '<span class="latitude">'+ value.latitude +'</span>' +
                                    '<span class="longitude">'+ value.longitude +'</span>' +
                                    '<span class="datetime">'+ value.date_time +'</span>' +
                                    '<span class="speed">'+ value.speed +'</span>' +
                                    '<span class="orientation">'+ value.orientation +'</span>' +
                                    '</label>' +
                                    '<div class="btn-vehicle">'+
                                    '<div class="btn-travel" id="' + value.imei + '"><i class="fa fa-road"></i> Ver Recorrido</div>'+
                                    '<div class="btn-on-map" id="' + value.imei + '" name="' + value.imei + '"><i class="fa fa-map"></i> Mostrar</div>'+
                                    '</div>'+
                                    '</li>';
                                counter++;
                            }else{
                                client_list += '' +
                                    '</ul>' +
                                    '</li>' +
                                    '</ul>' +
                                    '</li>';
                                counters.push({client_id:client_id, vehicles:counter});
                                vehicleCounter += counter;

                                counter = 0;

                                client_list += '' +
                                    '<li class="root-client">' +
                                    '<ul class="client">' +
                                    '<li class="client" id="'+ value.client_id +'">' +
                                    '<i class="client-row" onclick="toggleVehicles(this)">' +
                                    '<span class="name">' +
                                    '<span class="last">'+ value.last_name +'</span>' +
                                    '<span class="first">'+ value.first_name +'</span>' +
                                    '</span>' +
                                    '</i>' +
                                    '<ul class="vehicle">' +
                                    '<li class="info ' + (value.vehicle_status === '0' ? 'expired' : value.latitude === null ? 'no-location' : value.speed > 0 ? 'moving' : 'stop') + '">' +
                                    '<input type="checkbox" class="hidden cbox-select-vehicle" id="'+ value.imei +'">' +
                                    '<label for="'+ value.imei +'" onmousedown="setCenterMap(this,event);">' +
                                    '<span class="vehicle-id">'+ value.vehicle_id +'</span>' +
                                    'Marca: <span class="brand">'+ value.brand +'</span>' +
                                    ' Modelo: <span class="model">'+ value.model +'</span>' +
                                    ' Color: <span class="color">'+ value.color +'</span>' +
                                    ' Año: <span class="year">'+ value.year +'</span>' +
                                    ' Matrícula: <span class="license-plate">'+ value.license_plate +'</span>' +
                                    '<span class="expiration-date">'+ value.expiration_date +'</span>' +
                                    '<span class="imei">'+ value.imei +'</span>' +
                                    '<span class="simcard">'+ value.phone_number +'</span>' +
                                    '<span class="device-id">'+ value.device_id +'</span>' +
                                    '<span class="latitude">'+ value.latitude +'</span>' +
                                    '<span class="longitude">'+ value.longitude +'</span>' +
                                    '<span class="datetime">'+ value.date_time +'</span>' +
                                    '<span class="speed">'+ value.speed +'</span>' +
                                    '<span class="orientation">'+ value.orientation +'</span>' +
                                    '</label>' +
                                    '<div class="btn-vehicle">'+
                                    '<div class="btn-travel" id="' + value.imei + '"><i class="fa fa-road"></i> Ver Recorrido</div>'+
                                    '<div class="btn-on-map" id="' + value.imei + '" name="' + value.imei + '"><i class="fa fa-map"></i> Mostrar</div>'+
                                    '</div>'+
                                    '</li>';
                                counter++;

                                client_id = value.client_id;
                            }
                        }

                        if(iteration === data.length){
                            client_list += '' +
                                '</ul>' +
                                '</li>' +
                                '</ul>' +
                                '</li>';

                            counters.push({client_id:client_id, vehicles:counter});
                            vehicleCounter += counter;
                        }

                        iteration++;

                        showHideMarker(
                            false,
                            value.first_name,
                            value.last_name,
                            value.imei,
                            value.license_plate,
                            value.brand,
                            value.model,
                            value.year,
                            value.color,
                            value.latitude,
                            value.longitude,
                            value.date_time,
                            value.speed,
                            value.orientation);

                    });


                    $('ul#clients').html(client_list);

                    for (var i = 0; i < counters.length; i++){
                        $('ul#clients').find('span#'+counters[i].client_id).html(counters[i].vehicles);
                    }

                    getLocations();
                }catch(e){

                }
            }else{
                $('ul#clients').html('');
            }

            $('.clients-counter').text($('ul#clients').find('li.root-client').length);
            $('.vehicles-counter').text(vehicleCounter);
        }
    });

    filterClients();
}

function insert(str, index, value) {
    return str.substr(0, index) + value + str.substr(index);
}

function getClientsByDealer() {
    getAllClients();
}

function toggleVehicles(element){
    var parent = $(element).parent();
    parent.find('ul.vehicle').slideToggle();
}

function toggleMenu(element){

    var parent = $(element).parent();

    if($(element).parent().find('ul.menu-item').hasClass('collapsed')){
        $(element).parent().find('ul.menu-item').slideDown();
        $(element).parent().find('ul.menu-item').removeClass('collapsed');

        if($(parent).attr('id') === "mnu-dealers"){
            $('li#client-list').css('height','calc(100% - 167px)');
        }
    }else{
        $(element).parent().find('ul.menu-item').slideUp();
        $(element).parent().find('ul.menu-item').addClass('collapsed');

        if($(parent).attr('id') === "mnu-dealers"){
            $('li#client-list').css('height','calc(100% - 117px)');
        }
    }
}

function getCookie(cname) {
    var name = cname + "=";
    var decodedCookie = decodeURIComponent(document.cookie);
    var ca = decodedCookie.split(';');
    for(var i = 0; i <ca.length; i++) {
        var c = ca[i];
        while (c.charAt(0) == ' ') {
            c = c.substring(1);
        }
        if (c.indexOf(name) == 0) {
            return c.substring(name.length, c.length);
        }
    }
    return "";
}