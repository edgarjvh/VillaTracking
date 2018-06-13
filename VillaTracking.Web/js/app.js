var map = null;
var travel_map = null;

$(document).ready(function () {
    initMap();
});

function initMap() {
    map = new google.maps.Map(document.getElementById('map'), {
        center: new google.maps.LatLng(10.404971, -71.448464),
        zoom: 12,
        disableDefaultUI: true,
        mapTypeControl:true,
        zoomControl:true,
        mapTypeControlOptions:{
            position: google.maps.ControlPosition.RIGHT_CENTER
        },
        zoomControlOptions:{
            position: google.maps.ControlPosition.RIGHT_CENTER
        },
        gestureHandling: 'greedy'
    });
    var infoWindow = new google.maps.InfoWindow;
}

function initTravelMap() {
    travel_map = new google.maps.Map(document.getElementById('travel-map'), {
        center: new google.maps.LatLng(10.491455, -71.682780),
        zoom: 12,
        disableDefaultUI: true,
        mapTypeControl:true,
        zoomControl:true,
        mapTypeControlOptions:{
            position: google.maps.ControlPosition.RIGHT_CENTER
        },
        zoomControlOptions:{
            position: google.maps.ControlPosition.RIGHT_CENTER
        },
        gestureHandling: 'greedy'
    });
}