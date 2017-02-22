using System;
using System.Collections.Generic;

namespace Aulas.Models
{
    public class Orcamento
    {
        public List<Artigo> ArtigoList { get; set; }

        public static implicit operator Orcamento(Artigo v)
        {
            throw new NotImplementedException();
        }


        public static float ConsultaValor(List<Artigo> la)
        {
            float total = 0.0f;
            if (la.Count > 0)
            {
                foreach (var artigo in la)
                {
                    total += artigo.Preco * artigo.Quantidade;
                }
            }          
            return total;
        }
    }
}
