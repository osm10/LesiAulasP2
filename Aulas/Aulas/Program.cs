using System.Diagnostics;
using Aulas.Controllers;

namespace Aulas
{
    class Program
    {
        static void Main(string[] args)
        {
            PlataformaController plataforma = new PlataformaController();
            plataforma.InicializarPlataformaController();
            Debug.WriteLine("Teste");
        }
    }
}
