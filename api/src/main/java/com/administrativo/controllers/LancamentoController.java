package com.administrativo.controllers;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import com.administrativo.Lancamento;
import com.administrativo.repositories.LancamentoRepository;

import java.util.List;

@RestController
@RequestMapping("lancamento")
public class LancamentoController {


    @Autowired
    LancamentoRepository lancamentoRepository;

    public List<Lancamento> getAllLancamento(){
        return lancamentoRepository.findAll();
    }
    
    public Lancamento saveLancamento(@RequestBody Lancamento lancamento){
        return lancamentoRepository.save(lancamento);
    }

}
