using MeuEstagio.API.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeuEstagio.API.ViewModels.Input
{
    public class UpdateVagaInputModel
    {
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Funcao { get; set; }
        public string Salario { get; set; }
        public string Requisitos { get; set; }
        public string Desejaveis { get; set; }       
        public DateTime DataAlteracao { get; set; }

    }
}
