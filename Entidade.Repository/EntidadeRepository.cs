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
    public class EntidadeRepository : IEntidadeRepository
    {
        string conexao = @"Server=(localdb)\mssqllocaldb;Database=Entidade ;Trusted_Connection=True;MultipleActiveResultSets=true";
        public async Task<string> PostAsync(EntidadeCommand command)
        {
            string queryInsert = @"
            INSERT INTO Entidade(Nome, Cidade, Estado, Cep, Email, Telefone, EntidadeId,NomeResponsalvel,CNPJ)
            VALUES(@Nome, @Cidade, @Estado, @Cep, @Email, @Telefone, @EntidadeId, @NomeResponsalvel,@CNPJ)";
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Execute(queryInsert, new
                {
                    Nome = command.Nome,
                    Cidade = command.Cidade,
                    EntidadeId = command.EntidadeId,
                    Estado = command.estado,
                    Cep = command.Cep,
                    Email = command.Email,
                    Telefone = command.Telefone,
                    NomeResponsalvel = command.NomeResponsalvel,
                    CNPJ = command.CNPJ,
                });

                return "Entidade Cadastrado com sucesso";
            }
        }
        public void PostAsync()
        {
            throw new NotImplementedException();
        }
    }
}
