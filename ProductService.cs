using MiPrimeraApi.Repositories;

namespace MiPrimeraApi.Services
{
    public interface IProductService
    {
        // métodos que vas a usar
    }

    public class ProductService : IProductService
    {
        private readonly IProductRepository _repo;

        public ProductService(IProductRepository repo)
        {
            _repo = repo;
        }

        // Implementación de métodos
    }
}
