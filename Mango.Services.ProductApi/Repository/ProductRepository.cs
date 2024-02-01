using AutoMapper;
using Mango.Services.ProductApi.DBContexts;
using Mango.Services.ProductApi.Models;
using Mango.Services.ProductApi.Models.Dto;
using Microsoft.EntityFrameworkCore;

namespace Mango.Services.ProductApi.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _appDb;
        private IMapper _mapper;

        public ProductRepository(ApplicationDbContext appDb, IMapper mapper)
        {
            _appDb = appDb;
            _mapper = mapper;
        }

        public async Task<ProductDto> CreateUpdateProduct(ProductDto productDto)
        {
            Product product = _mapper.Map<Product>(productDto);
            if (product.ProductId > 0)
            {
                _appDb.Products.Update(product);
            }
            else
            {
                _appDb.Products.Add(product);
            }
            await _appDb.SaveChangesAsync();
            return _mapper.Map<ProductDto>(product);
        }

        public async Task<bool> DeleteProduct(int productId)
        {
            try
            {
                Product product = await _appDb.Products.FirstOrDefaultAsync(u => u.ProductId == productId);
                if (product == null)
                {
                    return false;
                }
                _appDb.Products.Remove(product);
                await _appDb.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<ProductDto> GetProductById(int productId)
        {
            Product product = await _appDb.Products.FirstOrDefaultAsync(product => product.ProductId == productId);
            return _mapper.Map<ProductDto>(product);
        }

        public async Task<IEnumerable<ProductDto>> GetProducts()
        {
            List<Product> productLIst = await _appDb.Products.ToListAsync();
            return _mapper.Map<List<ProductDto>>(productLIst);
        }
    }
}
