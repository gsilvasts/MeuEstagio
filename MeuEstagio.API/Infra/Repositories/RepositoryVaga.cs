using MeuEstagio.API.Data;
using MeuEstagio.API.Interface;
using MeuEstagio.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeuEstagio.API.Infra.Repositories
{
    public class RepositoryVaga : IVaga
    {
        private readonly ApplicationDbContext _dbContext;
       
        public RepositoryVaga(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Add(Vaga Objeto)
        {
            await _dbContext.Set<Vaga>().AddAsync(Objeto);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var vaga = _dbContext.Vagas.Find(id);      
            _dbContext.Remove(vaga);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Vaga> GetById(int id)
        {
            return await _dbContext.Set<Vaga>().FindAsync(id);
        }

        public async Task<List<Vaga>> List()
        {
            return await _dbContext.Set<Vaga>().ToListAsync();
        }

        public async Task Update(Vaga Objeto)
        {
            _dbContext.Set<Vaga>().Update(Objeto);
            await _dbContext.SaveChangesAsync();
        }
    }
}
