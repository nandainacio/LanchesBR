using LanchesBR.Models;

namespace LanchesBR.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        //Coleção de categoria
        IEnumerable<Categoria> Categorias { get; }
    }
}
