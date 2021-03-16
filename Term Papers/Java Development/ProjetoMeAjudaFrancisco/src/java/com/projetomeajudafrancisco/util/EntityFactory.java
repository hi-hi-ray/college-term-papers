/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.projetomeajudafrancisco.util;

import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.Persistence;

/**
 *
 * @author raysa
 */
public class EntityFactory {

    public EntityManager getEm() {
        System.out.println("Cheguei entrar no factory");
        EntityManagerFactory emFactory = Persistence.createEntityManagerFactory("ProjetoMeAjudaFranciscoPU");
        return emFactory.createEntityManager();
    }

}
