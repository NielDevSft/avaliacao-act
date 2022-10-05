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

	
	public void setId(Long id) {
		this.id = id;
	}
	
	public void setDesLancamento(String desLancamento) {
		this.desLancamento = desLancamento;
	}
	
	public void setDtaTrasactionAt(Date dtaTrasactionAt) {
		this.dtaTrasactionAt = dtaTrasactionAt;
	}
	
	public void setDtaCreatedAt(Date dtaCreatedAt) {
		this.dtaCreatedAt = dtaCreatedAt;
	}
	
	public void setDtaUpdatedAt(Date dtaUpdatedAt) {
		this.dtaUpdatedAt = dtaUpdatedAt;
	}
	
	public void setIndEntradaSaida(Integer indEntradaSaida) {
		this.indEntradaSaida = indEntradaSaida;
	}
	
	public void setValLancamento(Integer valLancamento) {
		this.valLancamento = valLancamento;
	}

	public Long getId() {
		return id;
	}

	public String getDesLancamento() {
		return desLancamento;
	}

	public Date getDtaTrasactionAt() {
		return dtaTrasactionAt;
	}

	public Date getDtaCreatedAt() {
		return dtaCreatedAt;
	}

	public Date getDtaUpdatedAt() {
		return dtaUpdatedAt;
	}

	public Integer getIndEntradaSaida() {
		return indEntradaSaida;
	}

	public Integer getValLancamento() {
		return valLancamento;
	}
}
