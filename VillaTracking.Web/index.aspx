<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="VillaTracking.Web.index" %>

    <% 
    if (Session.Count > 0) {
        Response.Redirect("app.aspx");
    }
    %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<meta charset="UTF-8"/>
<meta name="viewport"
        content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0"/>
<meta http-equiv="X-UA-Compatible" content="ie=edge"/>
    
    <title>Villa Tracking | Iniciar Sesión</title>
    <link rel="shortcut icon" href="../img/favicon.png" type="image/png" />
    <link rel="stylesheet" href="../css/font-awesome.css"/>
    <link rel="stylesheet" href="../css/login.css"/>
    <script src="js/jquery-3.2.1.min.js"></script>
    <script src="js/popper.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <script src="js/bootbox.min.js"></script>
    
</head>
<body>
<div class="main-container">
    <div class="login">
        <div class="logo">
            <img src="../img/logo.png" alt=""/>
        </div>

        <h2>Iniciar Sesión</h2>

        <div class="inputs">
            <input type="text" id="txt-dni" title="Cedula" placeholder="Ingrese su nombre de usuario, cedula o rif" onkeyup="keyLogin(event)" maxlength="9"/>
            <input type="password" id="txt-pass" title="Contraseña" placeholder="Ingrese su contraseña" onkeyup="keyLogin(event)" maxlength="30"/>
        </div>

        <div id="btn-login" onclick="login();"><i class="fa fa-sign-in"></i>Acceder al Sistema</div>
        <div class="message"></div>
    </div>
</div>
<script src="js/header.js"></script>
<script src="js/login.js"></script>
</body>
</html>
