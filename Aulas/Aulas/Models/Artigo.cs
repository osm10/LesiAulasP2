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
        /// <param name="id">Identificador do artigo</param>
        public Artigo(string nome, float preco, int id)
        {
            Nome = nome;
            Preco = preco;
            Identificador = id;
        }

        public string Nome{ get; set; }

        public float Preco { get; set; }

        public int Identificador { get; set; }

        private string _descricao;

        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }
        public int Quantidade { get; set; }
    }
}
