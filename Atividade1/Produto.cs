using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade1
{
    class Produto
    {
        private string Nome { get; set; }
        private double Preco { get; set; }
        private int Quantidade { get; set; }
        public Produto(string Nome, double Preco, int Quantidade)
        {
            this.Nome = Nome;
            this.Preco = Preco;
            this.Quantidade = Quantidade;
        }
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void DadosAtualizados(int QuantidadeN)
        {
            Quantidade += QuantidadeN;
        }
        public void RemoverProdutos(int QuantidadeR)
        {
            Quantidade -= QuantidadeR;
        }
        public override string ToString()
        {
            return $"Dados atualizados do produto: {Nome}, R$ {Preco:F2}, {Quantidade} unidades, Total: R$ {ValorTotalEmEstoque():F2} ";
        }
    }
}
