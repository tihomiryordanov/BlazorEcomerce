using Microsoft.EntityFrameworkCore;

namespace BlazorEcomerce.Server.Services.ProductServices
{
    public class ProductService : IProductService
    {
        private readonly DataContext _context;

        public ProductService(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<List<Product>>> GetFeaturedProductsAsync()
        {
            var response = new ServiceResponse<List<Product>>
            {
                 Data = await _context.Products
                 .Where(p=>p.Featured)
                 .Include(p=>p.Variants)
                 .ToListAsync(),
            };
            return response;
        }

        public async Task<ServiceResponse<Product>> GetProductAsync(int productId)
        {
            var response = new ServiceResponse<Product>();
            var product = await _context.Products
                .Include(pv=>pv.Variants)
                .ThenInclude(v=>v.ProductType)
                .FirstOrDefaultAsync(p=>p.Id== productId);
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
            var result = await _context.Products
                .Include(p=>p.Variants)
                .ToListAsync();
            var response = new ServiceResponse<List<Product>>()
            {
                Data = result
            };
            return response;    
        }

        public async Task<ServiceResponse<List<Product>>> GetProductsByCategoryAsync(string categoryUrl)
        {
            var response = new ServiceResponse<List<Product>>()
            {
                Data = await _context.Products
                .Include(p=>p.Variants)
                .Where(p => p.Category.Url.ToLower().Equals(categoryUrl)).ToListAsync()
            };
            return response;
        }

        public async Task<ServiceResponse<List<string>>> GetProductSearchSuggestionsAsync(string searchText)
        {
            var products = await FindProductsBySearchText(searchText);
            var result = new List<string>();

            foreach (var product in products)
            {
                if (product.Title.ToLower().Contains(searchText.ToLower()))
                {
                    result.Add(product.Title);
                }
                if (product.Description!=null)
                {
                    var punctuation = product.Description
                        .Where(char.IsPunctuation)
                        .Distinct()
                        .ToArray();
                    var words = product.Description.Split()
                        .Select(p=>p.Trim(punctuation));

                    foreach (var word in words)
                    {
                        if (word.Contains(searchText, StringComparison.OrdinalIgnoreCase) &&
                            !result.Contains(word))
                        {
                            result.Add(word);
                        }
                    }
                }


            }

            var response = new ServiceResponse<List<string>>() { Data = result };

            return response;
        }

        public async Task<ServiceResponse<ProductSearchResultDTO>> SearchProductsAsync(string searchText, int page)
        {
            var pageResults = 2f;
            var result = await FindProductsBySearchText(searchText);
            var resultCount = (float)result.Count;
            var floatCount = resultCount / pageResults;
            var pageCount = Math.Ceiling(floatCount);
            var products =  result
                            .Skip((page - 1)*(int)pageResults)
                            .Take((int)pageResults)
                            .ToList();
            var response = new ServiceResponse<ProductSearchResultDTO>
            {
                Data = new ProductSearchResultDTO
                {
                    Products = products,
                    CurrentPage = page,
                    Pages = (int)pageCount
                }
            };
            return response;
        }

        private async Task<List<Product>> FindProductsBySearchText(string searchText)
        {
            var result = await _context.Products
                            .Where(pr => pr.Title.ToLower().Contains(searchText.ToLower()) ||
                            pr.Description.ToLower().Contains(searchText.ToLower()))
                            .Include(p => p.Variants)
                            .ToListAsync();
            return result;
        }
    }
}
