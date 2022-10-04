package com.example.demo;

import lombok.AllArgsConstructor;
import lombok.Builder;
import lombok.Data;
import lombok.NoArgsConstructor;

import com.fasterxml.jackson.annotation.JsonFormat;
import java.util.Date;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;

@Data
@Builder
@Entity
@AllArgsConstructor
@NoArgsConstructor
public class Lancamento {
	
	@Id
    @GeneratedValue(strategy = GenerationType.AUTO, generator = "increment")
    private Long id;

    private String des_lancamento;
    
	@JsonFormat(pattern="dd/MM/yyyy")
	private Date dta_created_at;
	
	@JsonFormat(pattern="dd/MM/yyyy")
	private Date dta_updated_at;
	
    private Integer ind_entrada_saida;
    private Integer val_lancamento;

}
