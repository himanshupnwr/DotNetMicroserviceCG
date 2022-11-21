using ProductAPI.Models.DTO;
using ProductAPI.Repository;

internal class ProductRepository : IProductRepository
{
    public Task<ProductDto> CreateUpdateProduct(ProductDto productDto)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteProduct(int productId)
    {
        throw new NotImplementedException();
    }

    public Task<ProductDto> GetProductById(int productId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<ProductDto>> GetProducts()
    {
        throw new NotImplementedException();
    }
}