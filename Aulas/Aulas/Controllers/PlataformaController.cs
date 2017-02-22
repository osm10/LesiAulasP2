using System;
using System.Collections.Generic;
using Aulas.Models;

namespace Aulas.Controller
{
    /// <summary>
    /// 
    /// </summary>
    public class PlataformaController
    {
        private Menu _menuState;
        //private int _opcao;
        //float pi = 3.14f;

        //private List<Artigo> artigos;
        ArtigoController ac = new ArtigoController();
        
        public PlataformaController()
        {
            //_menuState = Menu.Idle;
            //_opcao = -1;
        }

        // TODO: 
        // Hack:
        public void InicializarPlataformaController()
        {
            float f; //= 3.14f;
            //int a = f as float;

            while (_menuState != Menu.Sair)
            {
                Console.Clear();
                Console.WriteLine("Escolha uma opcao!");
                Console.WriteLine("O - Para não fazer nada");
                Console.WriteLine("1 - Para Inserir um Artigo");
                Console.WriteLine("2 - Para Listar os Artigos");
                Console.WriteLine("3 - Para Remover um Artigo");
                Console.WriteLine((int)Menu.Sair+" - Para sair");
                string opcao = Console.ReadLine();

                if (Menu.TryParse(opcao, out _menuState))
                {
                    //_menuState = (Menu) _opcao;
                    Console.WriteLine("OK");
                    Console.WriteLine("Prima Qualquer tecla para continuar");
                    Console.ReadLine();
                }
                else
                {
                    _menuState = Menu.Invalido;
                    Console.WriteLine("Not OK!");
                    Console.WriteLine("Prima Qualquer tecla para continuar");
                    Console.ReadLine();
                }

                switch (_menuState)
                {
                        case Menu.InserirArtigo:
                            int _quat;
                            Console.WriteLine("Nome do Artigo");
                            string art = Console.ReadLine();
                            Console.WriteLine("Preço do Artigo");
                            string pre = Console.ReadLine();
                            while (!float.TryParse(pre,out f))
                            {
                                Console.WriteLine("Escreva o preço com casas decimais!");
                                pre = Console.ReadLine();
                            }
                        
                            Console.WriteLine("Quantidade");
                            string qt = Console.ReadLine();
                            while(!int.TryParse(qt, out _quat))
                            {
                                Console.WriteLine("Escreva a quantidade em número!");
                                qt = Console.ReadLine();
                            }
                            
                            Artigo a = new Artigo(art,f,_quat);
                            ac.InserirArtigo(a);
                            Console.WriteLine("Sucesso!");
                            Console.ReadKey();
                            break;

                        case Menu.ListarArtigo:
                            ac.ListarArtigos();
                            Console.ReadKey();
                            break;

                        case Menu.RemoverArtigo:
                            Console.WriteLine("Nome do Artigo");
                            string nome = Console.ReadLine();
                            if (ac.RemoverArtigo(nome))
                            {
                                Console.WriteLine("O artigo foi removido com sucesso!");
                            }
                            else
                            {
                                while (!ac.RemoverArtigo(nome))
                                {
                                    Console.WriteLine("Escreva o nome do artigo que esteja na lista!");
                                    nome = Console.ReadLine();
                            }                                
                            }                         
                            Console.ReadKey();
                            break;

                        case Menu.Sair:
                            //_opcao = 0;
                            break;
                        default:
                            Console.WriteLine("Opção Inválida!");
                            break;
                }
            }
        }
    }
}
