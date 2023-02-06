namespace BlazorEcomerce.Server.Services.ProductServices
{
    public class ProductService : IProductService
    {
        private readonly DataContext _context;

        public ProductService(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<Product>> GetProductAsync(int productId)
        {
            var response = new ServiceResponse<Product>();
            var product = await _context.Products.FindAsync(productId);
            if (product == null)
            {
                response.Success= false;
                response.Message = "Sorry, but this product doesn't exist.";
            }
            else
            {
                response.Data= product;
            }
            return response;
        }

        public async Task<ServiceResponse<List<Product>>> GetProductsAsync()
        {
            var result = await _context.Products.ToListAsync();
            var response = new ServiceResponse<List<Product>>()
            {
                Data = result
            };
            return response;    
        }
    }
}
