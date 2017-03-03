using System;
using System.Diagnostics;
using Aulas.Controllers;
using Aulas.Models;
using Newtonsoft.Json;

namespace Aulas.View
{
    public class PlataformaView
    {
        private Menu _menuState;
        private ArtigoController _artigoController;
        private string _serilization;
        
        
        public PlataformaView()
        {
              _artigoController = new ArtigoController();
        }

        public void OpcaoGuardar()
        {
            _serilization = JsonConvert.SerializeObject(_artigoController.GetArtigos());
            Debug.WriteLine(_serilization);
        }
        public void InicializarPlataformaController()
        {
            
            while (_menuState != Menu.Sair)
            {
                Console.Clear();
                Console.WriteLine("Escolha uma opcao!");
                Console.WriteLine("1 - Para Inserir um Artigo");
                Console.WriteLine("2 - Para Listar os Artigos");
                Console.WriteLine("3 - Para Remover um Artigo");
                Console.WriteLine("4 - Para Guardar");
                Console.WriteLine((int)Menu.Sair+" - Para sair");
                string opcao = Console.ReadLine();

                if (! Menu.TryParse(opcao, out _menuState))
                {
                    _menuState = Menu.Invalido;
                    Console.WriteLine("Not OK!");
                    Console.WriteLine("Prima um número relativo às opções existentes!");
                    Console.ReadLine();
                }

                switch (_menuState)
                {
                        case Menu.InserirArtigo:
                            int quat;
                            float preco;
                            Console.WriteLine("Nome do Artigo");
                            string art = Console.ReadLine();
                            Console.WriteLine("Preço do Artigo");
                            string pre = Console.ReadLine();
                            while (!float.TryParse(pre,out preco))
                            {
                                Console.WriteLine("Escreva o preço com casas decimais!");
                                pre = Console.ReadLine();
                            }

                            //do
                            //{
                                
                            //} while (!float.TryParse(pre,out preco));
                        
                            Console.WriteLine("Quantidade");
                            string qt = Console.ReadLine();
                            while(!int.TryParse(qt, out quat))
                            {
                                Console.WriteLine("Escreva a quantidade em número!");
                                qt = Console.ReadLine();
                            }
                            
                            Artigo a = new Artigo(art,preco,quat);
                            
                            _artigoController.InserirArtigo(a);
                            Console.WriteLine("Sucesso!");
                            //Console.ReadKey();
                            break;

                        case Menu.ListarArtigo:
                            _artigoController.ListarArtigos();
                            Console.ReadKey();
                            break;

                        case Menu.RemoverArtigo:
                        
                            Console.WriteLine("Nome do Artigo");
                            string nome = Console.ReadLine();
                            while (!_artigoController.RemoverArtigo(nome))
                            {
                                Console.WriteLine("Escreva o nome do artigo que esteja na lista!");
                                nome = Console.ReadLine();
                            }
                            Console.WriteLine("O artigo foi removido com sucesso!");
                            //Console.ReadKey();
                            break;
                        case Menu.Sair:
                            break;

                        case Menu.Invalido:
                                default:
                            Console.WriteLine("Opção Inválida!");
                            
                            break;
                }
                Console.ReadKey();
            }
        }
    }
}
