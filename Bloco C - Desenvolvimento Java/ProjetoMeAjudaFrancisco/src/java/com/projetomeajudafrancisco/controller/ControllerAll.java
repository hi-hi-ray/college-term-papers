/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.projetomeajudafrancisco.controller;

import com.projetomeajudafrancisco.dao.impl.CadastroAdocaoDaoImpl;
import com.projetomeajudafrancisco.dao.impl.CadastroResgateDaoImpl;
import com.projetomeajudafrancisco.model.CadastroAdocao;
import com.projetomeajudafrancisco.model.CadastroResgate;
import com.sun.javafx.binding.StringFormatter;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.List;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;

/**
 *
 * @author raysa
 */
@Controller
public class ControllerAll {

    int tempId;

    @RequestMapping("/index")
    public String primeiraPagina() {
        return "index";
    }

    @RequestMapping("/denunciar")
    public String denunciarPagina() {
        return "denunciar";
    }

    @RequestMapping("/sobre")
    public String sobrePagina() {
        return "sobre";
    }

    @RequestMapping("/termos")
    public String termosPagina() {
        return "termos";
    }

    @RequestMapping("/termos1")
    public String termos1Pagina() {
        return "termos1";
    }

    @RequestMapping("/editResgate")
    public String mudarCadastro(int id) {
        tempId = id;
        System.out.println("temp" + tempId);
        return "redirect:modificarResgate";
    }

    @RequestMapping("/editaAdocao")
    public String mudarCadastroAdocao(int id) {
        tempId = id;
        System.out.println("temp" + tempId);
        return "redirect:modificarAdocao";
    }

    @RequestMapping("/instituicao")
    public String instituicaoPagina() {
        return "instituicao";
    }

    @RequestMapping("/aceito")
    public String aceitoAdocaoPagina() {
        return "cadastroAdocao";
    }

    @RequestMapping("/cadastroAdocao")
    public String cadastroAdocaoPagina() {

        return "cadastroAdocao";
    }

    @RequestMapping(value = "/cadastroAdocao", method = RequestMethod.POST)
    public String cadastroAdocaoFormPagina(HttpServletRequest request, HttpServletResponse response) throws ParseException {
        CadastroAdocao adocao = new CadastroAdocao();
        CadastroAdocaoDaoImpl dao = new CadastroAdocaoDaoImpl();
        int inteiro = Integer.parseInt(request.getParameter("idade"));
        String data = "dd/MM/yyyy";
        String data1;
        java.util.Date agora = new java.util.Date();;
        SimpleDateFormat formata = new SimpleDateFormat(data);
        data1 = formata.format(agora);
        Date datae = formata.parse(data1);
        adocao.setEndereco(request.getParameter("endereco"));
        adocao.setSexo(request.getParameter("sexo"));
        adocao.setTelefone(request.getParameter("telefone"));
        adocao.setIdade(inteiro);
        adocao.setTemperamento(request.getParameter("temperamento"));
        adocao.setHistoriaanimal(request.getParameter("historiaanimal"));
        adocao.setTipodeanimal(request.getParameter("tipodeanimal"));
        adocao.setDataDeEntrada(datae);
        dao.adicionarAdocao(adocao);
        return "redirect:adocao";
    }

    @RequestMapping("/resgate")
    public String resgatePagina(HttpServletRequest request, HttpServletResponse response) {
        CadastroResgateDaoImpl dao = new CadastroResgateDaoImpl();
        List<CadastroResgate> resgates = dao.getAllResgates();
        request.setAttribute("resgates", resgates);
        return "resgate";
    }

    @RequestMapping("/adocao")
    public String adocaoPagina(HttpServletRequest request, HttpServletResponse response) {
        CadastroAdocaoDaoImpl dao = new CadastroAdocaoDaoImpl();
        List<CadastroAdocao> adocoes = dao.getAllAdocao();
        request.setAttribute("adocoes", adocoes);
        return "adocao";
    }

    @RequestMapping(value = "/modificarAdocao", method = RequestMethod.POST)
    public String editarcadastroAdocaoFormPagina(HttpServletRequest request, HttpServletResponse response) throws ParseException {
        CadastroAdocao adocao = new CadastroAdocao();
        CadastroAdocaoDaoImpl dao = new CadastroAdocaoDaoImpl();

        String data = "dd/MM/yyyy";
        String data1;
        java.util.Date agora = new java.util.Date();;
        SimpleDateFormat formata = new SimpleDateFormat(data);
        data1 = formata.format(agora);
        Date datae = formata.parse(data1);
        int inteiro = Integer.parseInt(request.getParameter("idade"));
        adocao.setIdadocao(tempId);
        System.out.println("oi" + tempId);
        System.out.println("OI3" + adocao.getIdadocao());
        adocao.setEndereco(request.getParameter("endereco"));
        adocao.setSexo(request.getParameter("sexo"));
        adocao.setTelefone(request.getParameter("telefone"));
        adocao.setIdade(inteiro);
        adocao.setTemperamento(request.getParameter("temperamento"));
        adocao.setHistoriaanimal(request.getParameter("historiaanimal"));
        adocao.setTipodeanimal(request.getParameter("tipodeanimal"));
        adocao.setDataDeEntrada(datae);
        dao.editarAdocao(adocao);
        return "redirect:adocao";
    }

    @RequestMapping("/excluiradocao")
    public String excluirAdocao(int id) {
        CadastroAdocaoDaoImpl dao = new CadastroAdocaoDaoImpl();
        dao.deletarAdocaoById(id);
        return "redirect:adocao";
    }

    @RequestMapping("/excluirAnimal")
    public String excluirResgate(int id) {
        CadastroResgateDaoImpl dao = new CadastroResgateDaoImpl();
        dao.deletarResgateById(id);
        return "redirect:resgate";
    }

    @RequestMapping("/aceito1")
    public String aceitoResgatePagina() {

        return "cadastroResgate";
    }

    @RequestMapping("/cadastroResgate")
    public String cadastroResgatePagina() {

        return "cadastroResgate";
    }

    @RequestMapping(value = "/cadastroResgate", method = RequestMethod.POST)
    public String cadastroResgateFormPagina(HttpServletRequest request, HttpServletResponse response) throws ParseException {
        CadastroResgate resgate = new CadastroResgate();
        CadastroResgateDaoImpl dao = new CadastroResgateDaoImpl();

        String data = "dd/MM/yyyy";
        String data1;
        java.util.Date agora = new java.util.Date();;
        SimpleDateFormat formata = new SimpleDateFormat(data);
        data1 = formata.format(agora);
        Date datae = formata.parse(data1);
        resgate.setEstadoAnimal(request.getParameter("estadoAnimal"));
        resgate.setLocal(request.getParameter("local"));
        resgate.setTelefone(request.getParameter("telefone"));
        resgate.setTipodeanimal(request.getParameter("tipodeanimal"));
        resgate.setDataDeEntrada(datae);
        dao.adicionarResgate(resgate);
        return "redirect:resgate";
    }

    @RequestMapping(value = "/modificarResgate", method = RequestMethod.POST)
    public String editarcadastroResgateFormPagina(HttpServletRequest request, HttpServletResponse response) throws ParseException {
        CadastroResgate resgate = new CadastroResgate();
        CadastroResgateDaoImpl dao = new CadastroResgateDaoImpl();

        String data = "dd/MM/yyyy";
        String data1;
        java.util.Date agora = new java.util.Date();;
        SimpleDateFormat formata = new SimpleDateFormat(data);
        data1 = formata.format(agora);
        Date datae = formata.parse(data1);
        resgate.setIdresgate(tempId);
        resgate.setEstadoAnimal(request.getParameter("estadoAnimal"));
        resgate.setLocal(request.getParameter("local"));
        resgate.setTelefone(request.getParameter("telefone"));
        resgate.setTipodeanimal(request.getParameter("tipodeanimal"));
        resgate.setDataDeEntrada(datae);
        dao.editarResgate(resgate);
        return "redirect:resgate";
    }

    @RequestMapping("/modificarResgate")
    public String modificaResgatePagina() {

        return "modificarResgate";
    }

    @RequestMapping("/modificarAdocao")
    public String modificaAdocaoPagina() {

        return "modificarAdocao";
    }

}
