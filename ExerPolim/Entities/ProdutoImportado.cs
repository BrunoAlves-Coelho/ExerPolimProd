using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExerPolim.Entities
{
    class ProdutoImportado : Produto 
    {
        public double TaxaAlfadegaria { get; set; }

        public ProdutoImportado()
        {
        }

        public ProdutoImportado(string nome, double preco, double taxaAlfadegaria) : base(nome, preco)
        {
            TaxaAlfadegaria = taxaAlfadegaria;
        }

        public double PrecoTotal()
        {
            return base.Preco + TaxaAlfadegaria;
        }

        public override string PrecoTag()
        {
            return Nome
                + " $ "
                + PrecoTotal().ToString("F2", CultureInfo.InvariantCulture)
                + " (Customs fee: $" + TaxaAlfadegaria.ToString("F2", CultureInfo.InvariantCulture) 
                + ")";
        }

    }
    

}
