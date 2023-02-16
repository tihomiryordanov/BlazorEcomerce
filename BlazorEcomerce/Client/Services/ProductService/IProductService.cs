namespace BlazorEcomerce.Client.Services.ProductService
{
    public interface IProductService
    {
        event Action ProductsChanged;
        List<Product> Products { get; set; }
        int CurrentPage { get; set; }
        int PageCount { get; set; }
        string LastSearchText { get; set; }
        string Message { get; set; }
        Task GetProductsAsync(string? categoryUrl = null);
        Task<ServiceResponse<Product>> GetProduct(int productId);
        Task SearchProductsAsync(string searchText, int page);

        Task<List<string>> GetProductSearchSuggestionsAsync( string searchText);
       
    }
}
