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
                <h1>Pedido de resgate</h1>
                <p>Atualize o seu pedido abaixo.</p>
            </div>
            <div id="div-form">
                <form method="POST" name="formUser" role="form" action="modificarResgate">
                    <div class="input-group">
                        <label path="local" for="local" class="input-group-addon"><span class="glyphicon glyphicon-road"></span> Local: </label>
                        <input path="local" type="text" class="form-control" name="local" placeholder="Insira o endereco de onde o animal se encontra." required/>
                    </div>
                    <div class="input-group">
                        <label path="telefone" for="telefone" class="input-group-addon"><span class="glyphicon glyphicon-earphone"></span> Telefone: </label>
                        <input path="telefone" type="text" class="form-control" name="telefone" placeholder="Insira o seu telefone pra que a pessoa que deseja realizar o resgate entre em contato com você." required/>
                    </div>
                    <div class="input-group">
                        <label path="estadoAnimal" for="estadoAnimal" class="input-group-addon"><span class="glyphicon glyphicon-plus"></span> Estado do animal: </label>
                        <textarea path="estadoAnimal" cols="125" rows="5" class="form-control" name="estadoAnimal" placeholder="Insira o estado do animal, em quais condiçoes ele está." required></textarea>
                    </div>                    
                    <div class="input-group">
                        <label path="tipodeanimal" for="tipodeanimal" class="input-group-addon"><span class="glyphicon glyphicon-asterisk"></span> Tipo de Animal: </label>
                        <input path="tipodeanimal" type="text" class="form-control" name="tipodeanimal" placeholder="Insira que tipo de animal é." required/>
                    </div>

                    <input type="submit" value="Finalizar Cadastro" name="btn" class="btn btn-primary btn-block"/>
                </form>
            </div> 

        </section>
        <footer>
            <p>Projeto: Me Ajuda Francisco- © Raysa Dutra, desenvolvedora.</p>
        </footer>
    </div>
</body>
</html>
