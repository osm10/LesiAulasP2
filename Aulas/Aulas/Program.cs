using System.Diagnostics;
using Aulas.Controllers;
using Aulas.View;

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
