using MeuEstagio.API.Data;
using MeuEstagio.API.Interface;
using MeuEstagio.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeuEstagio.API.Infra.Repositories
{
    public class RepositoryCidade : RepositoryGeneric<Cidade>, ICidade
    {
        private readonly ApplicationDbContext _dbContext;

        public RepositoryCidade()
        {

        }
        public RepositoryCidade(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
