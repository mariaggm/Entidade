﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade.Domain.Entities
{
    public class ProdutoEntities
    {
        public ProdutoEntities() { }
        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public string Descricao { get; set; }
        public string Categoria { get; set; }
        public bool DisponibilidadeAdocao { get; set; }
        public int EntidadeId { get; set; } 
    }
}
