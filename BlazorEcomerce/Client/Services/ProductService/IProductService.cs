namespace BlazorEcomerce.Client.Services.ProductService
{
    public interface IProductService
    {
        List<Product> Products { get; set; }
        Task GetProductsAsync();
        Task<ServiceResponse<Product>> GetProduct(int productId);
    }
}
