using System;
using System.Collections.Generic;
using Aulas.Models;

namespace Aulas.Controller
{
    public class ArtigoController
    {
        private List<Artigo> _artigoList = new List<Artigo>();
        public void InserirArtigo(Artigo a)
        {
            _artigoList.Add(a);
        }

        public bool RemoverArtigo(string nome)
        {
            if (_artigoList.Count > 0)
            {
                foreach (var artigo in _artigoList)
                {
                    if (artigo.Nome == nome)
                    {
                        _artigoList.Remove(artigo);
                        return true;
                    }
                }
            }
            return false;
        }

        public void ListarArtigos()
        {
            if (_artigoList.Count > 0)
            {
                foreach (var art in _artigoList)
                {
                    Console.WriteLine("Nome do artigo: "+art.Nome+" Preço: "+art.Preco);
                }
            }
            else Console.WriteLine("Não existem artigos!!!");
        }
    }
}
