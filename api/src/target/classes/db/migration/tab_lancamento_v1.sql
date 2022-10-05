-- public.lancamento definition

-- Drop table

-- DROP TABLE public.lancamento;

CREATE TABLE public.tab_lancamento (
	id int8 NOT NULL GENERATED ALWAYS AS IDENTITY,
	des_lancamento varchar NULL,
	dta_trasaction_at timestamp NULL,
	dta_created_at timestamp NULL,
	dta_updated_at timestamp NULL,
	ind_entrada_saida int2 NULL,
	val_lancamento numeric NULL
);
CREATE UNIQUE INDEX lancamento__idx ON public.lancamento USING btree (id);