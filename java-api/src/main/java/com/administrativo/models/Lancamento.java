package com.administrativo.models;

import lombok.AllArgsConstructor;
import lombok.Builder;
import lombok.Data;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

import com.fasterxml.jackson.annotation.JsonFormat;
import java.util.Date;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;

@Data
@Builder
@Entity
@Getter
@Setter
@AllArgsConstructor
@NoArgsConstructor
public class Lancamento {
	
	@Id
    @GeneratedValue(strategy = GenerationType.AUTO, generator = "increment")
	@JsonFormat
    private Long id;

	
	@JsonFormat
    private String desLancamento;
    
	@JsonFormat
	private TipoTransacao indEntradaSaida;
	
	@JsonFormat
    private Double valLancamento;
	
    @JsonFormat(pattern="yyyy-MM-dd")
	private Date dtaLancamento;

	@JsonFormat(pattern="yyyy-MM-dd")
	private Date dtaCreatedAt;
	
	@JsonFormat(pattern="yyyy-MM-dd")
	private Date dtaUpdatedAt;
}

