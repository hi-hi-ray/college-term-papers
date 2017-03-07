/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.projetomeajudafrancisco.model;

import java.io.Serializable;
import java.util.Date;
import java.util.Objects;
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
@Table(name = "resgate")
public class CadastroResgate implements Serializable {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private int idresgate;

    @Column(name = "local")
    private String local;

    @Column(name = "estadoAnimal")
    private String estadoAnimal;

    @Column(name = "telefone")
    private String telefone;

    @Column(name = "tipodeanimal")
    private String tipodeanimal;

    @Column(name = "dataDeEntrada")
    private Date dataDeEntrada;
    
    public int getIdresgate() {
        return idresgate;
    }

    public void setIdresgate(int idresgate) {
        this.idresgate = idresgate;
    }

    public String getLocal() {
        return local;
    }

    public void setLocal(String local) {
        this.local = local;
    }

    public String getEstadoAnimal() {
        return estadoAnimal;
    }

    public void setEstadoAnimal(String estadoAnimal) {
        this.estadoAnimal = estadoAnimal;
    }

    public String getTelefone() {
        return telefone;
    }

    public void setTelefone(String telefone) {
        this.telefone = telefone;
    }

    public String getTipodeanimal() {
        return tipodeanimal;
    }

    public void setTipodeanimal(String tipodeanimal) {
        this.tipodeanimal = tipodeanimal;
    }

    public Date getDataDeEntrada() {
        return dataDeEntrada;
    }

    public void setDataDeEntrada(Date dataDeEntrada) {
        this.dataDeEntrada = dataDeEntrada;
    }

    @Override
    public int hashCode() {
        int hash = 7;
        hash = 41 * hash + this.idresgate;
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
        final CadastroResgate other = (CadastroResgate) obj;
        if (this.idresgate != other.idresgate) {
            return false;
        }
        return true;
    }

    @Override
    public String toString() {
        return "CadastroResgate{" + "idresgate=" + idresgate + ", local=" + local + ", estadoAnimal=" + estadoAnimal + ", telefone=" + telefone + ", tipodeanimal=" + tipodeanimal + ", dataDeEntrada=" + dataDeEntrada + '}';
    }

 
    
    

}
