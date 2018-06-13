<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="app.aspx.cs" Inherits="VillaTracking.Web.views.app" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta charset="UTF-8"/>
    <meta name="viewport"
            content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0"/>
    <meta http-equiv="X-UA-Compatible" content="ie=edge"/>
    <title>Villa Tracking | Aplicación</title>

    <link rel="shortcut icon" href="img/favicon.png" type="image/png" />
    <link rel="stylesheet" href="css/bootstrap.css"/>
    <link rel="stylesheet" href="css/sidebar.css"/>
    <link rel="stylesheet" href="css/font-awesome.css"/>
    <link rel="stylesheet" href="css/app.css"/>
    <link rel="stylesheet" href="css/change_password.css"/>
    <link rel="stylesheet" href="css/suggestions.css"/>
    <link rel="stylesheet" href="css/logout.css"/>
    <link rel="stylesheet" href="css/travel.css"/>
    <script src="js/jquery-3.2.1.min.js"></script>
    <script src="js/popper.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
</head>
<body oncontextmenu="return false;">
<div class="main-container"> 

    <!-- ======================================= HEADER =========================================== -->
    <header id="header">
        <nav class="menu">
            <img src="../img/logo.png" alt="Logo Villa Soft Gps" onclick="window.location = 'app.aspx'"/>
            <input type="checkbox" id="cbox-menu-header" title="cbox-menu-header"/>
            <label for="cbox-menu-header"><i class="fa fa-bars"></i></label>
   
            <ul id="menu">
                <li id="mnu-suggestions"><a href="#"><i class="left fa fa-envelope"></i>Sugerencias</a></li>
                <li id="mnu-password"><a href="#"><i class="left fa fa-lock"></i>Cambiar Contraseña</a></li>                
                <li id="mnu-logout"><a href="#" class="logout" ><i class="left fa fa-sign-in"></i><% =Session.Count > 0 ? "Cerrar Sesión" : "Login" %></a></li>
            </ul>
        </nav>        
    </header>
    <!-- ======================================= HEADER =========================================== -->
       
    <!-- ======================================= SIDEBAR =========================================== -->
    <div class="sidebar">
        <input type="checkbox" id="cbox-toggle-sidebar" title="cbox-toggle-sidebar"/>
        <label for="cbox-toggle-sidebar"><i class="fa fa-chevron-left"></i></label>

        <ul id="main-list">
            <li id="mnu-clients" class="menu1">
                <p onclick="toggleMenu(this)">
                    <span class="client-name">
                        <span class="last">Cargando vehículos</span>
                        <span class="first">Por favor espere...</span>
                    </span>
                    <span class="vehicles-counter"><i class="fa fa-spin fa-spinner"></i></span>
                </p>

                <ul class="menu-item">
                    <li id="client-filter">
                        <input id="txt-client-filter" placeholder="nombre | vehículo | imei | simcard | ubicación"/>
                    </li>

                    <li id="client-list">
                        <ul id="clients"></ul>
                    </li>
                </ul>
            </li>
        </ul>
    </div>
    <!-- ======================================= SIDEBAR =========================================== -->

    <!-- ======================================= CHANGE PASSWORD =========================================== -->
    <div class="pass-modal">
        <div class="modal-form">
            <div class="modal-title">
                <p>Cambiar Contraseña <i class="fa fa-close btn-close" id="btn-close"></i></p>
            </div>

            <div class="modal-inputs">
                <input type="password" id="txt-current-pass" title="txt-current-pass" placeholder="Contraseña actual">
                <input type="password" id="txt-new-pass" title="txt-new-pass" placeholder="Contraseña nueva">
                <input type="password" id="txt-confirm-pass" title="txt-confirm-pass" placeholder="Confirmar contraseña">
                <div id="modal-btn">Enviar <i class="fa fa-send"></i></div>
                <div class="message"></div>
            </div>
        </div>
    </div>
    <!-- ======================================= CHANGE PASSWORD =========================================== -->

    <!-- ======================================= SUGGESTIONS =========================================== -->
    <div class="suggestion-modal">
        <div class="modal-form">
            <div class="modal-title">
                <p>Sugerencia <i class="fa fa-close btn-close" id="btn-close"></i></p>
            </div>

            <div class="modal-inputs">
                <input id="txt-suggestion-subject" title="txt-suggestion-subject" placeholder="Asunto" maxlength="50">
                <textarea id="txt-suggestion-message" title="txt-suggestion-message" placeholder="Mensaje"></textarea>
                <div id="modal-btn">Enviar <i class="fa fa-send"></i></div>
                <div class="message"></div>
            </div>
        </div>
    </div>
    <!-- ======================================= SUGGESTIONS =========================================== -->

    <!-- ======================================= LOGOUT =========================================== -->
    <div class="logout-modal">
        <div class="modal-form">
            <div class="modal-title">
                <p>Cerrar Sesión <i class="fa fa-close btn-close" id="btn-close"></i></p>
            </div>

            <div class="modal-message">
                ¿Está seguro que desea terminar la sesión?
            </div>

            <div class="modal-buttons">
                <div id="modal-btn">Aceptar</div>
            </div>
        </div>
    </div>
    <!-- ======================================= LOGOUT =========================================== -->

    <!-- ======================================= TRAVEL =========================================== -->
    <div class="travel-modal">
        <div class="modal-header">
            Vehículo: <span class="travel-selected-vehicle">ABC123</span>
            Fecha Desde: <input type="text" id="dtp-travel-from"/>
            Fecha Hasta: <input type="text" id="dtp-travel-to"/>
            <div class="btn-search-travel">Buscar</div>
            <div class="btn-exit-travel">Salir</div>
        </div>

        <div id="travel-map"></div>
    </div>
    <!-- ======================================= TRAVEL =========================================== -->

    <!-- ======================================= MAP =========================================== -->
    <div id="map"></div>
    <!-- ======================================= MAP =========================================== -->
</div>
    
<script src="https://maps.googleapis.com/maps/api/js?key=AIzaSyBiVju2pni4AmUxAYnpwn7r-r0FscUXY8M"></script>

<script src="js/app.js"></script>
<script src="js/header.js"></script>
<script src="js/sidebar.js"></script>
<script src="js/travel.js"></script>
<script src="js/change_password.js"></script>
<script src="js/suggestions.js"></script>
<script src="js/logout.js"></script>
</body>
</html>
