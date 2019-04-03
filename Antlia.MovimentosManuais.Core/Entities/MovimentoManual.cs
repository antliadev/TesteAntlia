using System;
using System.Collections.Generic;

namespace Antlia.MovimentosManuais.Core.Entities
{
    public class MovimentoManual
    {
        public int Mes { get; set; }
        public int Ano { get; set; }
        public int NrLancamento { get; set; }
        public string CodProduto { get; set; }
        public string CodCosif { get; set; }
        public string Descricao { get; set; }
        public DateTime DataMovimento { get; set; }
        public string CodUsuario { get; set; }
        public decimal Valor { get; set; }
    }
}
