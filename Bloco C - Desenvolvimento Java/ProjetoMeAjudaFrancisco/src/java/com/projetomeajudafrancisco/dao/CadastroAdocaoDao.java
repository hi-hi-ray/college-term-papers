/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.projetomeajudafrancisco.dao;

import com.projetomeajudafrancisco.model.CadastroAdocao;
import java.util.List;

/**
 *
 * @author raysa
 */
public interface CadastroAdocaoDao {
    public CadastroAdocao adicionarAdocao(CadastroAdocao adocao);
    public CadastroAdocao editarAdocao(CadastroAdocao adocao);
    public void deletarAdocaoById(int idadocao);
    public CadastroAdocao getAdocao(int idadocao);
    public List<CadastroAdocao> getAllAdocao();
}
