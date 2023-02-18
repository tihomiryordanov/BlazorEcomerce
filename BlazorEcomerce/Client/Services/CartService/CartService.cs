using BlazorEcomerce.Client.Shared;
using BlazorEcomerce.Shared;
using Blazored.LocalStorage;

namespace BlazorEcomerce.Client.Services.CartService
{
    public class CartService : ICartService
    {
        private readonly ILocalStorageService _localStorage;
        private readonly HttpClient _http;

        public CartService(ILocalStorageService localStorage, HttpClient http)
        {
            _localStorage = localStorage;
            _http = http;
        }

        public event Action? OnChange;

        public async Task AddToCart(CartItem cartItem)
        {
            List<CartItem>? cart = await GetCart();
            var sameItem = cart.Find(i => i.ProductId == cartItem.ProductId && 
            i.ProductTypeId == cartItem.ProductTypeId);
            if (sameItem==null)
            {
                cart.Add(cartItem);
            }
            else
            {
                sameItem.Quantity += cartItem.Quantity;
            }
            
            await _localStorage.SetItemAsync("cart", cart);

            OnChange?.Invoke();
        }

        private async Task<List<CartItem>> GetCart()
        {
            var cart = await _localStorage.GetItemAsync<List<CartItem>>("cart");
            if (cart == null)
            {
                cart = new List<CartItem>();
            }
            
            return cart;
        }

        public async Task<List<CartItem>> GetCartItems()
        {
            var cart = await GetCart();
            return cart;
        }

        public async Task<List<CartProductResponseDTO>> GetCartProducts()
        {
            var cartItems = await _localStorage.GetItemAsync<List<CartItem>>("cart");
            var response = await _http.PostAsJsonAsync("api/cart/products", cartItems);
            var cartProducts =
                await response.Content
                .ReadFromJsonAsync<ServiceResponse<List<CartProductResponseDTO>>>();
            return cartProducts.Data;
        }

        public async Task RemoveProductFromCart(int productId, int productTypeId)
        {
            var cart = await _localStorage.GetItemAsync<List<CartItem>>("cart");
            if (cart==null)
            {
                return;
            }
            var cartItem = cart.Find(x=>x.ProductId== productId && x.ProductTypeId==productTypeId);
            if (cartItem != null)
            {
                cart.Remove(cartItem);
                await _localStorage.SetItemAsync<List<CartItem>>("cart", cart);
                OnChange.Invoke();
            }
            
        }

        public async Task UpdateQuantity(CartProductResponseDTO product)
        {
            var cart = await _localStorage.GetItemAsync<List<CartItem>>("cart");
            if (cart == null)
            {
                return;
            }
            var cartItem = cart.Find(x => x.ProductId == product.ProductId && 
            x.ProductTypeId == product.ProductTypeId);
            if (cartItem != null)
            {
                cartItem.Quantity= product.Quantity;
                await _localStorage.SetItemAsync<List<CartItem>>("cart", cart);

            }
        }
    }
}
