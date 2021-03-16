/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.projetomeajudafrancisco.dao.impl;

import com.projetomeajudafrancisco.dao.CadastroAdocaoDao;
import com.projetomeajudafrancisco.model.CadastroAdocao;
import com.projetomeajudafrancisco.util.EntityFactory;
import java.util.List;
import javax.persistence.EntityManager;
import javax.persistence.Query;

/**
 *
 * @author raysa
 */
public class CadastroAdocaoDaoImpl implements CadastroAdocaoDao {

    EntityFactory em = new EntityFactory();

    @Override
    public CadastroAdocao adicionarAdocao(CadastroAdocao adocao) {
        System.out.println("cheguei entrar no cadastro");
        EntityManager daoEM = em.getEm();
        System.out.println(em);
        try {
            daoEM.getTransaction().begin();
            System.out.println("Cadastro novo");
            daoEM.persist(adocao);
            daoEM.getTransaction().commit();
        } catch (Exception e) {
            System.out.println("Deu ruim: " + e);
            daoEM.getTransaction().rollback();
        } finally {
            daoEM.close();
        }
        return adocao;

    }

    @Override
    public CadastroAdocao editarAdocao(CadastroAdocao adocao) {
        System.out.println("cheguei entrar no editar/cadastrar");
        EntityManager daoEM = em.getEm();
        try {
            daoEM.getTransaction().begin();
            if (adocao.getIdadocao()== 000) {
                System.out.println("Cadastro novo");
                daoEM.persist(adocao);
            } else {
                if (!daoEM.contains(adocao)) {
                    if (daoEM.find(CadastroAdocao.class, adocao.getIdadocao()) == null) {
                        throw new Exception("Não foi possivel atualaizar o local");
                    }
                }
                adocao = daoEM.merge(adocao);
            }
            daoEM.getTransaction().commit();
        } catch (Exception e) {
            System.out.println("Deu ruim: " + e);
            daoEM.getTransaction().rollback();
        } finally {
            daoEM.close();
        }
        return adocao;
    }

    @Override
    public void deletarAdocaoById(int idadocao) {
        EntityManager daoEM = em.getEm();
        CadastroAdocao adocao = daoEM.find(CadastroAdocao.class, idadocao);
        try {
            daoEM.getTransaction().begin();
            daoEM.remove(adocao);
            daoEM.getTransaction().commit();
        } finally {
            daoEM.close();
        }
    }

    @Override
    public CadastroAdocao getAdocao(int idadocao) {
        EntityManager daoEM = em.getEm();
        CadastroAdocao adocao = null;
        try {
            daoEM.getTransaction().begin();
            adocao = daoEM.find(CadastroAdocao.class, idadocao);
            daoEM.getTransaction().commit();
        } catch (Exception e) {
            System.out.println("Deu ruim na exclusão: " + e);
        } finally {
            daoEM.close();
        }
        return adocao;
    }

    @Override
    public List<CadastroAdocao> getAllAdocao() {
        EntityManager daoEM = em.getEm();
        Query selectQuery = daoEM.createQuery("SELECT t FROM CadastroAdocao t");
        return (List<CadastroAdocao>) selectQuery.getResultList();

    }

}
