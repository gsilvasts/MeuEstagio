using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MeuEstagio.API.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string CEP { get; set; }
        public string Endereco { get; set; }     
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string CidadeId { get; set; }
        public virtual Cidade Cidade { get; set; }
        public string Perfil { get; set; }

    }
}
