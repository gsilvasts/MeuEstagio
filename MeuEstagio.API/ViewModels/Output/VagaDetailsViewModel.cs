using MeuEstagio.API.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeuEstagio.API.ViewModels.Output
{
    public class VagaDetailsViewModel
    {
        public VagaDetailsViewModel(string titulo, string descricao, string funcao, string salario, string requisitos, string desejaveis, EnumStatus status, string estado, string cidade, DateTime dataCadastro, DateTime dataAlteracao)
        {
            Titulo = titulo;
            Descricao = descricao;
            Funcao = funcao;
            Salario = salario;
            Requisitos = requisitos;
            Desejaveis = desejaveis;          
            Status = status;
            Estado = estado;
            Cidade = cidade;
            DataCadastro = dataCadastro;
            DataAlteracao = dataAlteracao;
        }

        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Funcao { get; set; }
        public string Salario { get; set; }
        public string Requisitos { get; set; }
        public string Desejaveis { get; set; }       
        public EnumStatus Status { get; set; }
        public string Estado { get; set; }       
        public string Cidade { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
    }
}
