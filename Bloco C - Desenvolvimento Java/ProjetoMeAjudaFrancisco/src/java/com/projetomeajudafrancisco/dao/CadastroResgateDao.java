/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.projetomeajudafrancisco.dao;

import com.projetomeajudafrancisco.model.CadastroResgate;
import java.util.List;

/**
 *
 * @author raysa
 */
public interface CadastroResgateDao {
    public CadastroResgate adicionarResgate(CadastroResgate resgate);
    public CadastroResgate editarResgate(CadastroResgate resgate);
    public void deletarResgateById(int idresgate);
    public CadastroResgate getResgate(int idresgate);
    public List<CadastroResgate> getAllResgates();
}
