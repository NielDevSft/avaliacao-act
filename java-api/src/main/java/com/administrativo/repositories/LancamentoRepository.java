package com.administrativo.repositories;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.rest.core.annotation.RepositoryRestResource;
import org.springframework.stereotype.Repository;

import com.administrativo.models.Lancamento;

@Repository
@RepositoryRestResource
public interface LancamentoRepository extends JpaRepository<Lancamento, Long> {
	
}
