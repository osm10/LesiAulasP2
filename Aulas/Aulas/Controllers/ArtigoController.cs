﻿using System;
using System.Collections.Generic;
using System.Linq;
using Aulas.Models;

namespace Aulas.Controllers
{
    public class ArtigoController
    {
        private List<Artigo> _artigoList; 

        public ArtigoController(string listarArtigos = "")
        {
                //_artigoList = new List<Artigo>();
        }
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


        /// <summary>
        /// Remove um artigo da lista pelo id do artigo
        /// </summary>
        /// <param name="idArtigo">Id do artigo</param>
        /// <returns>Devolve true se encontrar e remover artigo</returns>
        public bool RemoverArtigo(int idArtigo)
        {
            Artigo artigoRemover = null;
            foreach (Artigo artigo in _artigoList)
            {
                if (artigo.Identificador == idArtigo)
                {
                    artigoRemover = artigo;
                    break;
                }
            }
            if (artigoRemover != null)
            {
                _artigoList.Remove(artigoRemover);
                return true;
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
        public Artigo GetArtigo(string nome)
        {
            return _artigoList.FirstOrDefault(artigo => artigo.Nome == nome);
        }
        public Artigo GetArtigo(int id)
        {
            foreach (Artigo artigo in _artigoList)
            {
                if (artigo.Identificador == id)
                {
                    return artigo;
                }
            }
            return null;
        }

        public List<Artigo> GetArtigos()
        {
            return _artigoList;
        }

        public void LimparLista()
        {
            _artigoList.Clear();
        }
    }
}
