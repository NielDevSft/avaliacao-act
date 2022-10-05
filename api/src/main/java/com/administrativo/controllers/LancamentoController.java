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

    @GetMapping("/{id}")
	public Lancamento getById(@PathVariable Long id) {
		return lancamentoRepository.findById(id).get();
	}
    

    @PutMapping("/{id}")
    public Lancamento replace(@RequestBody Lancamento lancamentoNovo, @PathVariable Long id) {
      
      return lancamentoRepository.findById(id)
        .map(lancamento -> {
        	lancamento.setDesLancamento(lancamentoNovo.getDesLancamento());
        	lancamento.setDtaTrasactionAt(lancamentoNovo.getDtaTrasactionAt());
        	lancamento.setDtaCreatedAt(lancamentoNovo.getDtaCreatedAt());
        	lancamento.setDtaUpdatedAt(lancamentoNovo.getDtaUpdatedAt());
        	lancamento.setIndEntradaSaida(lancamentoNovo.getIndEntradaSaida());
        	lancamento.setValLancamento(lancamentoNovo.getIndEntradaSaida());
          return lancamentoRepository.save(lancamento);
        }).orElseGet(() -> {
        	lancamentoNovo.setId(id);
            return lancamentoRepository.save(lancamentoNovo);
          });
    }

    @DeleteMapping("/{id}")
    public void delete(@PathVariable Long id) {
    	lancamentoRepository.deleteById(id);
    }
}
