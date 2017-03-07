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
        <script src='http://code.jquery.com/jquery-2.1.3.min.js'></script>
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
                    <li><a href="index">Inicio<span class="sr-only">(current)</span></a></li>
                    <li><a href="denunciar">Denuncie</a></li>
                    <li><a href="instituicao">Instituições</a></li>
                    <li class="active"><a href="resgate">Animais para ser Resgatados</a></li>
                    <li><a href="adocao">Animais para Adoção</a></li>
                    <li><a href="sobre">Sobre</a></li>
                </ul>
            </div>
        </div>
    </nav>
    <div class="container" id="content-container">
        <section>
            <div class="page-header">
                <h1>Resgate</h1>
                <p></p>
            </div>
            
            <div class="panel panel-warning"> 
                <div class="panel-heading">Animais para serem resgatadados</div>
                <table class="table"> 
                    <thead> 
                        <tr> 
                            <th>ID</th> 
                            <th>Local</th>
                            <th>Tipo de Animal</th>
                            <th>Estado Animal</th>
                            <th>Telefone para contato</th>
                            <th>Data de Cadastro</th>
                            <th>Opção</th> 
                        </tr> 
                    </thead> 
                    <tbody> 


                        <c:forEach items="${resgates}" var="resgate">
                            <tr>
                                <td>${resgate.idresgate}</td>
                                <td>${resgate.local}</td>
                                <td>${resgate.tipodeanimal}</td>
                                <td>${resgate.estadoAnimal}</td> 
                                <td>${resgate.telefone}</td> 
                                <td>${resgate.dataDeEntrada}</td> 
                                <td><p><a class="btn btn-primary" href="editResgate?id=${resgate.idresgate}" role="button"><span class="glyphicon glyphicon-list-alt"></span> Modificar</a>
                                        <a class="btn btn-warning " href="excluirAnimal?id=${resgate.idresgate}" role="button"><span class="glyphicon glyphicon-trash"></span> Excluir</a></p>
                                </td> 
                            </tr>
                        </c:forEach>
                    </tbody> 
                </table> 
            </div>
            <td><p><a class="btn btn-warning btn-block" href="termos1" role="button"><span class="glyphicon glyphicon-plus"></span> Adicionar um Animal</a></p>
        </section>
        <footer>
            <p>Projeto: Me Ajuda Francisco- © Raysa Dutra, desenvolvedora.</p>
        </footer>
    </div>
</body>
</html>
