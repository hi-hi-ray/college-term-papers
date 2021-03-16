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
                    <li class="active"><a href="denunciar">Denuncie</a></li>
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
                <h1>Denuncie</h1>
                <p></p>
            </div>
            <div>
                <h2>Saiba como denunciar maus-tratos ou crueldade contra animais - <small>World Animal Protection</small></h2>
                <p>Quando o assunto é denúncia de maus-tratos ou crueldade contra animais, o Brasil possui legislação pertinente e autoridades competentes que são responsáveis pela manutenção da lei e punição de crimes.</p>
                <p>Caso você presencie maus-tratos a animais de quaisquer espécies, sejam domésticos, domesticados, silvestres ou exóticos – como abandono, envenenamento, presos constantemente em correntes ou cordas muito curtas, manutenção em lugar anti-higiênico, mutilação, presos em espaço incompatível ao porte do animal ou em local sem iluminação e ventilação, utilização em shows que possam lhes causar lesão, pânico ou estresse, agressão física, exposição a esforço excessivo e animais debilitados (tração), rinhas, etc. –, <b>vá à delegacia de polícia mais próxima para levrar o Boletim de Ocorrência (BO), ou compareça à Promotoria de Justiça do Meio Ambiente</b>.</p>
                <p>A denúncia de maus-tratos é legitimada pelo Art. 32, da Lei Federal nº. 9.605, de 12.02.1998 (Lei de Crimes Ambientais) e pela Constituição Federal Brasileira, de 05 de outubro de 1988.</p>
                <p>É possível denunciar também ao órgão público competente de seu município, para o setor que responde aos trabalhos de vigilância sanitária, zoonoses ou meio ambiente. Lembrando que cada município tem legislação diferente, portanto caso esta não contemple o tema maus tratos pode utilizar a Lei Estadual ou ainda recorrer a Lei Federal.</p>
                <h3>Lei de Crimes Ambientais</h3>
                <p>“Art. 32. Praticar ato de abuso, maus-tratos, ferir ou mutilar animais silvestres, domésticos ou domesticados, nativos ou exóticos:
                    Pena - detenção, de três meses a um ano, e multa.</p>
                <p>§ 1º. Incorre nas mesmas penas quem realiza experiência dolorosa ou cruel em animal vivo, ainda que para fins didáticos ou científicos, quando existirem recursos alternativos.</p>
                <p> § 2º. “A pena é aumentada de um sexto a um terço, se ocorre morte do animal.”</p>
                <h3>Constituição Federal Brasileira</h3>

                <p>Art. 23. É competência comum da União, dos Estados, do Distrito Federal e dos Municípios:</p>
                <p>VI – proteger o meio ambiente e combater a poluição em qualquer de suas formas;</p>
                <p>VII – preservar as florestas, a fauna e a flora;</p>
                <p>Art. 225. Todos têm o direito ao meio ambiente ecologicamente equilibrado, bem de uso comum do povo e essencial à sadia qualidade de vida, impondo-se ao poder público e à coletividade o dever de defendê-lo e preservá-lo para os presentes e futuras gerações.</p>
                <p>§ 1.º Para assegurar a efetividade desse direito, incumbe ao poder público:</p>
                <p> VII – “proteger o Meio Ambiente adotando iniciativas como: proteger a fauna e a flora, vedadas, na forma da lei, as práticas que coloquem em risco sua função ecológica, provoque a extinção de espécies ou submetam os animais à crueldade.”</p>
                <p>A denúncia pode ser feita nas delegacias comuns ou nas especializadas em meio-ambiente ou animais*. Também se pode denunciar diretamente no Ministério Público ou no IBAMA.</p>
                <h3>Como proceder nas delegacias</h3>
                <p>Cumpre à autoridade policial receber a denúncia e fazer o boletim de ocorrência. O policial que se negar a agir estará cometendo crime de prevaricação (retardar ou deixar de praticar, indevidamente, ato de ofício, ou praticá-lo contra disposição expressa de lei, para satisfazer interesse ou sentimento pessoal - art. 319 do Código Penal). Caso isso aconteça, há como queixar-se ao Ministério Público ou à Corregedoria da Polícia Civil.</p>
                <p>Assim que o escrivão ouvir seu relato sobre o crime, a ele cumpre instaurar inquérito policial ou lavrar Termo Circunstanciado de Ocorrência (TCO). Negando-se a fazê-lo, sob qualquer pretexto, lembre-o de que ele pode ser responsabilizado por crime de prevaricação, previsto no Art. 329 do Código Penal Brasileiro (retardar ou deixar de praticar indevidamente, ato de ofício, ou praticá-lo contra disposição expressa de lei para satisfazer interesse ou sentimento pessoal). (Leve esse artigo por escrito.)</p>
                <p>Tente descrever com exatidão os fatos ocorridos, o local e, se possível, o nome e endereço do(s) responsável(s).</p>
                <p>Também procure levar, caso haja possibilidade, alguma evidência, como fotos, vídeos, notícias de jornais, mapas, laudo ou atestado veterinário, nome de testemunhas e endereço das mesmas. Quanto mais detalhada a denúncia, melhor.</p>
                <p><b>Dica:</b> ao ir à delegacia, procure levar por escrito o art.32 da Lei de Crimes Ambientais (Lei Federal n.º 9.605 de 1998) que esta descrito acima, uma vez que, infelizmente, há policiais que não estão cientes do conteúdo dessa lei.</p>
                <p>Saiba que você não será o autor do Processo Judicial que for aberto a pedido do delegado. O Decreto 24645/1934 reza em seu artigo 1º - “Todos os animais existentes no país são tutelados do estado”, Logo, uma vez concluído o inquérito para apuração do crime, ou elaborado TCO, o Delegado o encaminhará ao juízo para abertura da competente ação penal onde o Autor da ação será o Estado.</p>
                <h3>Como proceder no Ministério Público</h3>
                <p>O Ministério Público é quem tem a autoridade para propor ação contra os que desrespeitam a Lei de Crimes Ambientais. Sendo assim, pode-se fazer a denúncia diretamente no MP, o que agiliza muito o processo.</p>
                <p><a href="http://www.mpsp.mp.br/portal/page/portal/Cartilhas/defesa_animal_2015_06_11_dg.pdf">Veja a cartilha de denúncias do Ministério Público.</a></p>
                <p>Tente descrever com exatidão os fatos ocorridos, o local e, se possível, o nome e endereço do(s) responsável(s).</p>
                <p>Também procure levar, caso haja possibilidade, alguma evidência, como fotos, vídeos, notícias de jornais, mapas, nome de testemunhas e endereço das mesmas. Quanto mais detalhada a denúncia, melhor.</p>
                <h3>IBAMA</h3>
                <p>As denúncias podem ser feitas pelo telefone 0800 61 8080 (gratuitamente) ou pelo email para linhaverde.sede@ibama.gov.br. O IBAMA (Instituto Brasileiro do Meio Ambiente e dos Recursos Naturais Renováveis) as encaminhará para a delegacia mais próxima do local da agressão.</p>
                <h3>Endereços úteis</h3>
                <p>Note que o autor do processo judicial será o estado e não você. Sendo assim, não tema denunciar. As organizações não governamentais possuem um papel importante e insubstituível na sociedade. Porém, exerça a sua cidadania. Não se cale frente aos crimes contra os animais e o meio ambiente, e exija das autoridades responsáveis às providências previstas por lei.</p>
                <p>Em São Paulo, você pode realizar a denuncia através da Divisão de investigações sobre Infrações de Maus Tratos a Animais e demais Infrações contra o Meio Ambiente. Endereço: Av. São João, 1247 - 7º andar - Centro, das 9 às 19h. Tel.: (11) 3224-8208, (11) 3224-8480 e (11) 3331-8969.</p>
                <p>No Rio de Janeiro, você pode realizar a denuncia através da DEMA - Delegacia de Proteção ao Meio Ambiente. Endereço: Rua S. Luiz, 265 - São Cristóvão. Tel.: (21) 3399-3290, (21) 3399-3298 e (21) 2589-3133. Fax.: (21) 3860-9030 e (21) 3860-3293.</p>
                <cite> FONTE: <a href="https://www.worldanimalprotection.org.br/saiba-como-denunciar-maus-tratos-ou-crueldade-contra-animais">World Animal Protection</a></cite>
            </div>       
        </section>
        <footer>
            <p></p>
            <p>Projeto: Me Ajuda Francisco- © Raysa Dutra, desenvolvedora.</p>
        </footer>
    </div>
</body>
</html>
