package com.administrativo.controllers;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import com.administrativo.Lancamento;
import com.administrativo.repositories.LancamentoRepository;

import java.util.List;

@RequestMapping("lancamento")
@RestController
public class LancamentoController {


    @Autowired
    LancamentoRepository lancamentoRepository;

    @GetMapping
    public List<Lancamento> getAllLancamento(){
        return lancamentoRepository.findAll();
    }
    
    @PostMapping
    public Lancamento saveLancamento(@RequestBody Lancamento lancamento){
        return lancamentoRepository.save(lancamento);
    }

}
