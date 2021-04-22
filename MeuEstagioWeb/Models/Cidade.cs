using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MeuEstagioWeb.Models
{
    [Table("TB_CIDADE")]
    public class Cidade
    {
        public Cidade(string nome, string estado)
        {
            Nome = nome;
            Estado = estado;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Estado { get; set; }
    }
}
