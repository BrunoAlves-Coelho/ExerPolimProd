using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExerPolim.Entities
{
    class ProdutoUsado: Produto
    {
        public DateTime DataFabricacao { get; set; }

        public ProdutoUsado()
        {

        }

        public ProdutoUsado(string nome, double preco, DateTime dataFabricacao) : base(nome, preco)
        {
            DataFabricacao = dataFabricacao;
        }

        public override string PrecoTag()
        {
            return Nome
                + " $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + " Manufacture date: " + DataFabricacao.ToString("dd/MM/yyyy")
                + ")";
        
        }
    }
}
