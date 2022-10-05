package com.administrativo;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("lancamento")
public class LancamentoController {


    @Autowired
    LancamentoRepository lancamentoRepository;

    @GetMapping("api/lancamento")
    public List<Lancamento> getAllLancamento(){
        return lancamentoRepository.findAll();
    }
    
    @PostMapping("api/lancamento")
    public Lancamento saveLancamento(@RequestBody Lancamento lancamento){
        return lancamentoRepository.save(lancamento);
    }

}
