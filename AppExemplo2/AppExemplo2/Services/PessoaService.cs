using AppExemplo2.Context;
using AppExemplo2.Model;
using Microsoft.AspNetCore.Mvc;

namespace AppExemplo2.Services
{
    public class PessoaService
    {
        private readonly ContextBD _context;

        public PessoaService(ContextBD con)
        {
            _context = con;
        }

        public async Task<List<Pessoa>>? Pessoas()
        {
            var pessoas =   _context.Pessoas?.ToList();
            return pessoas;
        }

        public async Task<Pessoa>? GetPessoa(int id)
        {
            var pessoa = _context.Pessoas?.Where(p => p.Id == id).FirstOrDefault();
            return pessoa;
        }

        public async Task<Pessoa> GetPessoa(string cpf)
        {
            var pessoa = _context.Pessoas?.Where(p => p.Cpf == cpf).FirstOrDefault();
            return pessoa;
        }

        public async Task Add(Pessoa pessoa)
        {
            _context.Pessoas?.Add(pessoa);
        }

    }
}
