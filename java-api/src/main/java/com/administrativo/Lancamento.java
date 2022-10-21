package com.administrativo;

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

	@JsonFormat
    private String desLancamento;
    
    @JsonFormat(pattern="dd/MM/yyyy")
	private Date dtaTrasactionAt;

	@JsonFormat(pattern="dd/MM/yyyy")
	private Date dtaCreatedAt;
	
	@JsonFormat(pattern="dd/MM/yyyy")
	private Date dtaUpdatedAt;
	
	@JsonFormat
    private Integer indEntradaSaida;
	
	@JsonFormat
    private Integer valLancamento;

}
