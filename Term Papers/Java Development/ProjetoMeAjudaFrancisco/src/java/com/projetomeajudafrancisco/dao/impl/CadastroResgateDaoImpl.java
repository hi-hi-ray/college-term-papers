/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.projetomeajudafrancisco.dao.impl;

import com.projetomeajudafrancisco.dao.CadastroResgateDao;
import com.projetomeajudafrancisco.model.CadastroResgate;
import com.projetomeajudafrancisco.util.EntityFactory;
import java.util.List;
import javax.persistence.EntityManager;
import javax.persistence.Query;

/**
 *
 * @author raysa
 */
public class CadastroResgateDaoImpl implements CadastroResgateDao {

    EntityFactory em = new EntityFactory();

    @Override
    public CadastroResgate adicionarResgate(CadastroResgate resgate) {
        System.out.println("cheguei entrar no cadastro");
        EntityManager daoEM = em.getEm();
        System.out.println(em);
        try {
            daoEM.getTransaction().begin();
            System.out.println("Cadastro novo");
            daoEM.persist(resgate);
            daoEM.getTransaction().commit();
        } catch (Exception e) {
            System.out.println("Deu ruim: " + e);
            daoEM.getTransaction().rollback();
        } finally {
            daoEM.close();
        }
        return resgate;
    }

    @Override
    public CadastroResgate editarResgate(CadastroResgate resgate) {
        System.out.println("cheguei entrar no editar/cadastrar");
        EntityManager daoEM = em.getEm();
        try {
            daoEM.getTransaction().begin();
            if (resgate.getIdresgate() == 000) {
                System.out.println("Cadastro novo");
                daoEM.persist(resgate);
            } else {
                if (!daoEM.contains(resgate)) {
                    if (daoEM.find(CadastroResgate.class, resgate.getIdresgate()) == null) {
                        throw new Exception("Não foi possivel atualaizar o local");
                    }
                }
                resgate = daoEM.merge(resgate);
            }
            daoEM.getTransaction().commit();
        } catch (Exception e) {
            System.out.println("Deu ruim: " + e);
            daoEM.getTransaction().rollback();
        } finally {
            daoEM.close();
        }
        return resgate;
    }

    @Override
    public void deletarResgateById(int idresgate) {
        EntityManager daoEM = em.getEm();
        CadastroResgate resgate = daoEM.find(CadastroResgate.class, idresgate);
        try {
            daoEM.getTransaction().begin();
            daoEM.remove(resgate);
            daoEM.getTransaction().commit();
        } finally {
            daoEM.close();
        }
    }

    @Override
    public CadastroResgate getResgate(int idresgate) {
        EntityManager daoEM = em.getEm();
        CadastroResgate resgate = null;
        try {
            daoEM.getTransaction().begin();
            resgate = daoEM.find(CadastroResgate.class, idresgate);
            daoEM.getTransaction().commit();
        } catch (Exception e) {
            System.out.println("Deu ruim na exclusão: " + e);
        } finally {
            daoEM.close();
        }
        return resgate;
    }

    @Override
    public List<CadastroResgate> getAllResgates() {
        EntityManager daoEM = em.getEm();
        Query selectQuery = daoEM.createQuery("SELECT t FROM CadastroResgate t");
        return (List<CadastroResgate>) selectQuery.getResultList();
    }

}
