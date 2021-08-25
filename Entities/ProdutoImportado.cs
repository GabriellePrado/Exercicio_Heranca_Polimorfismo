using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Heranca_Polimorfismo.Entities
{
    class ProdutoImportado : Produto
    {
        public double TaxaImportacao { get; set; }

        public ProdutoImportado()
        {
        }

        public ProdutoImportado(string nome, double preco, double taxaImportacao)
            : base (nome, preco)
        {
            TaxaImportacao = taxaImportacao;
        }

        public override string Etiqueta()
        {
            // return Nome + "R$" + Preco + "(Taxa de importação: "+ TaxaImportacao + ")";

            return $"{Nome} R$ {TotalPreco()} (Taxa de Importação {TaxaImportacao})";

        }
        public double TotalPreco()
        {
            return Preco * TaxaImportacao; 
        }
    }
}
