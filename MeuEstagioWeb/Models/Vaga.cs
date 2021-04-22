using MeuEstagioWeb.Models.Enums;
using MeuEstagioWeb.Models.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Threading.Tasks;

namespace MeuEstagioWeb.Models
{   
    public class Vaga : Notifies
    {
        public Vaga(string titulo, string descricao, string funcao, string salario, string requisitos, string desejaveis, EnumNivelExperiencia experiencia, EnumTipoContrato tipoContrato, EnumPeriodoTrabalho periodoTrabalho, EnumStatus status, string estado, string idCidade, Cidade cidade, DateTime dataCadastro, DateTime dataAlteracao)
        {
            Titulo = titulo;
            Descricao = descricao;
            Funcao = funcao;
            Salario = salario;
            Requisitos = requisitos;
            Desejaveis = desejaveis;
            Experiencia = experiencia;
            TipoContrato = tipoContrato;
            PeriodoTrabalho = periodoTrabalho;
            Status = status;
            Estado = estado;
            IdCidade = idCidade;
            Cidade = cidade;
            DataCadastro = dataCadastro;
            DataAlteracao = dataAlteracao;
        }

        public int Id { get; set; }               
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Funcao { get; set; }
        public string Salario { get; set; }
        public string Requisitos { get; set; }
        public string Desejaveis { get; set; }
        public EnumNivelExperiencia Experiencia { get; set; }
        public EnumTipoContrato TipoContrato { get; set; }
        public EnumPeriodoTrabalho PeriodoTrabalho { get; set; }
        public EnumStatus Status { get; set; }
        public string Estado { get; set; }
        public string IdCidade { get; set; }
        public virtual Cidade Cidade { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }       
    }
}