using MeuEstagio.API.Models.Enums;
using MeuEstagio.API.Models.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Threading.Tasks;

namespace MeuEstagio.API.Models
{
    public class Vaga
    {
        public Vaga()
        {

        }
        public Vaga(string titulo, string descricao, string funcao, string salario, string requisitos, string desejaveis, int idCidade)
        {
            Titulo = titulo;
            Descricao = descricao;
            Funcao = funcao;
            Salario = salario;
            Requisitos = requisitos;
            Desejaveis = desejaveis;           
            Status = EnumStatus.Ativo;           
            IdCidade = idCidade;            
            DataCadastro = DateTime.Now;
            DataAlteracao = DateTime.Now;
        }

        public int Id { get; private set; }
        public string Titulo { get; private set; }
        public string Descricao { get; private set; }
        public string Funcao { get; private set; }
        public string Salario { get; private set; }
        public string Requisitos { get; private set; }
        public string Desejaveis { get; private set; }       
        public EnumStatus Status { get; private set; }
        //public string Estado { get; private set; }
        public int IdCidade { get; private set; }
        public Cidade Cidade { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public DateTime DataAlteracao { get; private set; }
    }
}