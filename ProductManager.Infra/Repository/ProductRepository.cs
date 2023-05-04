using ProductManager.Core.Models;
using ProductManager.Infra.Interfaces;

namespace ProductManager.Infra.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> _products;

        public ProductRepository()
        {
            _products = new List<Product>()
            {
                new Product { Id = 1, Nome = "Produto 1", Preco = 10 },
                new Product { Id = 2, Nome = "Produto 2", Preco = 20 },
                new Product { Id = 3, Nome = "Produto 3", Preco = 20 },
            };
        }

        public Task<Product> AtualizarProdutoAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<Product> CriarProdutoAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public Task DeletarProdutosAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Product> ObterProdutoPorIdAsync(int id)
        {
            return await Task.FromResult(_products.FirstOrDefault(p => p.Id == id));
        }

        public async Task<IEnumerable<Product>> ObterProdutosAsync()
        {
            return await Task.FromResult(_products);
        }
    }
}
