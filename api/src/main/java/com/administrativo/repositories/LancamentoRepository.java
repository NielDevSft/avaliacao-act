package com.administrativo.repositories;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import com.administrativo.Lancamento;

@Repository
public interface LancamentoRepository extends JpaRepository<Lancamento, Long> {
	
}
