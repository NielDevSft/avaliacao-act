package com.administrativo.controllers;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import com.administrativo.models.Lancamento;
import com.administrativo.repositories.LancamentoRepository;

import java.util.Date;
import java.util.List;
import java.util.Optional;

import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.RequestBody;

@RequestMapping("lancamento")
@RestController
public class LancamentoController {


    @Autowired
    LancamentoRepository lancamentoRepository;

    @CrossOrigin
    @GetMapping
    public ResponseEntity<List<Lancamento>> getAllLancamento(){
        try {
            List<Lancamento> lancamentos = lancamentoRepository.findAll();
            return new ResponseEntity<List<Lancamento>>(lancamentos, HttpStatus.OK);
        } catch (Exception ex ) {
            throw ex;
        }
    }
    
    @CrossOrigin
    @PostMapping
    public ResponseEntity<Lancamento> saveLancamento(@RequestBody Lancamento lancamento){
        try {
            Lancamento lacSaved = lancamentoRepository.save(lancamento);
            return new ResponseEntity<Lancamento>(lacSaved, HttpStatus.OK);
        } catch (Exception ex ) {
            throw ex;
        }
    }
    
    @CrossOrigin
    @PutMapping
    public ResponseEntity<Lancamento> updateLancamento(@RequestBody Lancamento lancamento) {
        try {
            lancamento.setDtaUpdatedAt(new Date());
            Lancamento lacUpdated = lancamentoRepository.save(lancamento);
            return new ResponseEntity<Lancamento>(lacUpdated, HttpStatus.OK);
        } catch (Exception ex ) {
            throw ex;
        }
    	
    }

    @CrossOrigin
    @DeleteMapping
    public ResponseEntity<Lancamento> deleteLancamento(@RequestBody Long id) throws Exception {
        try {
            Optional<Lancamento> lacamento = lancamentoRepository.findById(id);
            if(!lacamento.isEmpty()) {
                lancamentoRepository.delete(lacamento.get());
                return new ResponseEntity<Lancamento>(HttpStatus.OK);
            }
            return new ResponseEntity<Lancamento>(HttpStatus.BAD_REQUEST);
        } catch (Exception ex ) {
            throw ex;
        }
    }
    
}
