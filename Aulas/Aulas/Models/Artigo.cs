using System;

[assembly: CLSCompliant(true)]
namespace Aulas.Models
{  
    public class Artigo
    {
        /// <summary>
        /// Construtor da Classe Artigo
        /// </summary>
        /// <param name="nome">Nome do artigo</param>
        /// <param name="preco">Preço do artigo</param>
        /// <param name="quant">Quantidade do artigo</param>
        public Artigo(string nome, float preco, int quant)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quant;
        }

        public string Nome{ get; set; }

        public float Preco { get; set; }

        private string _descricao;

        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }
        public int Quantidade { get; set; }
    }
}
