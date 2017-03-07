<%@page contentType="text/html" pageEncoding="UTF-8"%>
<%@taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core"%>
<%@ taglib prefix="spring" uri="http://www.springframework.org/tags"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN"
    "http://www.w3.org/TR/html4/loose.dtd">

<html>
    <head>
        <spring:url value="/css/style.css" var="styleCSS" />
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Projeto Me Ajuda Francisco</title>
        <link href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js" rel="stylesheet"/>
        <link href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css" rel="stylesheet"/>
        <link href="${styleCSS}" rel="stylesheet" />
    </head>
    <body>
    <header id="header">
        <div class="container">
            <div class="logo">                  
                <h2>
                    <a href="index" class="Logo-Text"><img src="img/logo.png" /> Projeto: Me Ajuda Francisco</a>
                </h2>
            </div>
        </div>
    </header>
    <nav class="navbar navbar-inverse">
        <div class="container">
            <div class="navbar-header">

                <ul class="nav navbar-nav ">
                    <li class="active"><a href="index">Inicio<span class="sr-only">(current)</span></a></li>
                    <li><a href="denunciar">Denuncie</a></li>
                    <li><a href="instituicao">Instituições</a></li>
                    <li><a href="resgate">Animais para ser Resgatados</a></li>
                    <li><a href="adocao">Animais para Adoção</a></li>
                    <li><a href="sobre">Sobre</a></li>
                </ul>
            </div>
        </div>
    </nav>
    <div class="container" id="content-container">
        <section>
            <div class="page-header">
                <h1>Inicio</h1>
                <p></p>
            </div>
            <div class="row"> 

                <div class="col-sm-6 col-md-5 col-lg-6"> 
                    <div class="thumbnail"> 
                        <img alt="Foto de Animal que precisa ser resgatado" src="img/images (1).jpg" style="height: 200px; width: 100%; display: block;"> 
                        <div class="caption"> 
                            <h3>Lista de Animais que Necessitam ser Resgatados</h3> 
                            <p>Veja os Animais que necessitam de ajuda e estão nas ruas.</p>
                            <a href="resgate" class="btn btn-primary" role="button">Vamos Lá</a> 
                        </div> 
                    </div> 
                </div>
                <div class="col-sm-6 col-md-5 col-lg-6"> 
                    <div class="thumbnail"> 
                        <img alt="Foto de Animais disponiveis para Adoção" src="img/pit-bull-dog-breed-picture-10.jpg" style="height: 200px; width: 100%; display: block;"> 
                        <div class="caption"> 
                            <h3>Lista de Animais disponiveis para Adoção</h3> 
                            <p>Veja os Animais que estão querendo um lar.</p> 
                            <a href="adocao" class="btn btn-primary" role="button">Vamos Lá</a> 
                        </div> 
                    </div> 
                </div>
            </div>  
        </section>
        <footer>
            <p>Projeto: Me Ajuda Francisco- © Raysa Dutra, desenvolvedora.</p>
        </footer>
    </div>
</body>
</html>
