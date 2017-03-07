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
                <h1>Dicas</h1>
                <p></p>
            </div>
            <p>Nós, do Projeto Me Ajuda Francisco, tomamos especial cuidado com as informações fornecidas por vocês, essa coleta de informações se resume apenas a aquelas fornecidas no momento do cadastro em nosso site relativas a identificação pessoal como nome, telefone e email. </p>
            <p>Não nos responsabilizamos pelos anúncios de animais que por ventura sejam exibidos no site, a proposta do site é unicamente ajudar animais abandonados e facilitar seu procedimento de adoção.</p>
            <p> Da mesma forma, é terminantemente proibido utilizar os anúncios como local de venda de animais, apesar de respeitarmos vendedores e compradores, essa não é a proposta do site e pedimos encarecidamente que em caso de visualização de tais conteúdos nos anúncios informem por gentileza no email me.ajuda.francisco@gmail.com.</p>
            <p> Por fim, informamos que todas as instituições e ONGS envolvidas na adoção e auxílio aos animais abandonados e ou feridos passam previamente por uma minuciosa avaliação realizada pelos idealizadores do site.</p>
            <p><a href="achado" class="btn btn-primary" role="button">Estou de acordo com os termos e aceito realizar o cadastro</a></p>
        </section>
        <footer>
            <p>Projeto: Me Ajuda Francisco- © Raysa Dutra, desenvolvedora.</p>
        </footer>
    </div>
</body>
</html>
