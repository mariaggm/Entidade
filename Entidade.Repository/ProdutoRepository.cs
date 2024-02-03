using Dapper;
using Entidade.Domain.Command;
using Entidade.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        string conexao = @"Server=(localdb)\mssqllocaldb;Database=Entidade ;Trusted_Connection=True;MultipleActiveResultSets=true";
        public async Task<string> PostAsync(ProdutoCommand command)
        {
            string queryInsert = @"
            INSERT INTO ProdutoId(IdProduto, NomeProduto, Descricao, Categoria, DisponibilidadeAdocao, EntidadeId)
            VALUES(@IdProduto, @NomeProduto, @Descricao, @Categoria, @DisponibilidadeAdocao, @EntidadeId)";
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Execute(queryInsert, new
                {
                    IdProduto = command.IdProduto,
                    NomeProduto = command.NomeProduto,
                    Descricao = command.Descricao,
                    Categoria = command.Categoria,
                    DisponibilidadeAdocao = command.DisponibilidadeAdocao,
                    EntidadeId = command.EntidadeId,

                });

                return "Produto Cadastrado com sucesso";
            }
        }
        public void PostAsync()
        {
            throw new NotImplementedException();
        }
    }
}

