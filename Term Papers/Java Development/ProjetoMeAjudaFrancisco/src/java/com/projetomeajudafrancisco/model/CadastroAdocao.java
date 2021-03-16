/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.projetomeajudafrancisco.model;

import java.util.Date;
import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.Table;

/**
 *
 * @author raysa
 */
@Entity
@Table(name = "adocao")
public class CadastroAdocao {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private int idadocao;

    @Column(name = "endereco")
    private String endereco;

    @Column(name = "sexo")
    private String sexo;

    @Column(name = "telefone")
    private String telefone;

    @Column(name = "idade")
    private int idade;
    
    @Column(name = "temperamento")
    private String temperamento;
    
    @Column(name = "tipodeanimal")
    private String tipodeanimal;
    
    @Column(name = "historiaanimal")
    private String historiaanimal;

    @Column(name = "dataDeEntrada")
    private Date dataDeEntrada;

    public int getIdadocao() {
        return idadocao;
    }

    public void setIdadocao(int idadocao) {
        this.idadocao = idadocao;
    }

    public String getEndereco() {
        return endereco;
    }

    public void setEndereco(String endereco) {
        this.endereco = endereco;
    }

    public String getSexo() {
        return sexo;
    }

    public void setSexo(String sexo) {
        this.sexo = sexo;
    }

    public String getTelefone() {
        return telefone;
    }

    public void setTelefone(String telefone) {
        this.telefone = telefone;
    }

    public int getIdade() {
        return idade;
    }

    public void setIdade(int idade) {
        this.idade = idade;
    }

    public String getTemperamento() {
        return temperamento;
    }

    public void setTemperamento(String temperamento) {
        this.temperamento = temperamento;
    }

    public String getTipodeanimal() {
        return tipodeanimal;
    }

    public void setTipodeanimal(String tipodeanimal) {
        this.tipodeanimal = tipodeanimal;
    }

    public String getHistoriaanimal() {
        return historiaanimal;
    }

    public void setHistoriaanimal(String historiaanimal) {
        this.historiaanimal = historiaanimal;
    }

    public Date getDataDeEntrada() {
        return dataDeEntrada;
    }

    public void setDataDeEntrada(Date dataDeEntrada) {
        this.dataDeEntrada = dataDeEntrada;
    }

    @Override
    public int hashCode() {
        int hash = 3;
        hash = 47 * hash + this.idadocao;
        return hash;
    }

    @Override
    public boolean equals(Object obj) {
        if (obj == null) {
            return false;
        }
        if (getClass() != obj.getClass()) {
            return false;
        }
        final CadastroAdocao other = (CadastroAdocao) obj;
        if (this.idadocao != other.idadocao) {
            return false;
        }
        return true;
    }

    @Override
    public String toString() {
        return "CadastroAdocao{" + "idadocao=" + idadocao + ", endereco=" + endereco + ", sexo=" + sexo + ", telefone=" + telefone + ", idade=" + idade + ", temperamento=" + temperamento + ", tipodeanimal=" + tipodeanimal + ", historiaanimal=" + historiaanimal + ", dataDeEntrada=" + dataDeEntrada + '}';
    }
    
    
}
