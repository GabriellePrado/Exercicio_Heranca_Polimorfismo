using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Heranca_Polimorfismo.Entities
{
    class ProdutoUsado : Produto
    {
        public DateTime DataDeFabricacao { get; set; }

        public ProdutoUsado()
        {
        }

        public ProdutoUsado(string nome, double preco, DateTime dataDeFabricacao)
            : base(nome, preco)
        {
            DataDeFabricacao = dataDeFabricacao;
        }

        public override string Etiqueta()
        {
            // return Nome + " (usado) " + "R$ " + Preco + "Data de Fabricação (DD/MM/YYYY): " + DataDeFabricacao;
            return $"{Nome} (usado) R${Preco} Data de Fabricação(DD/MM/YYYY): {DataDeFabricacao}";
        }
    }
}
