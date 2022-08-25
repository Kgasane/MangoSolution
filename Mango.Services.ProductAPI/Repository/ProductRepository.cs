using AutoMapper;
using Mango.Services.ProductAPI.DbContexts;
using Mango.Services.ProductAPI.Model;
using Mango.Services.ProductAPI.Model.Dto;
using Microsoft.EntityFrameworkCore;

namespace Mango.Services.ProductAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContexts DbContext;
        private IMapper mapper;

        public ProductRepository(AppDbContexts dbContext, IMapper _mapper)
        {
            DbContext = dbContext;
            mapper = _mapper;
        }

        public async Task<ProductDto> CreateUpdateProduct(ProductDto product)
        {
            Product MappedProduct = mapper.Map<ProductDto, Product>(product);
            
            if(MappedProduct.ProductId > 0)
            {
                DbContext.Products.Update(MappedProduct);
            }
            else
            {   
                DbContext.Products.Add(MappedProduct);
            }
            await DbContext.SaveChangesAsync();
            return mapper.Map<Product, ProductDto>(MappedProduct);
        }

        public async Task<bool> DeleteProduct(int Id)
        {
            try
            {
                Product product = await DbContext.Products.FirstOrDefaultAsync(x => x.ProductId == Id);

                if (product.Equals(null))
                {
                    return false;
                }
                DbContext.Products.Remove(product);
                DbContext.SaveChanges();
                return true;
            }
            catch (Exception e)
            {

                return false;

            }
        }

        public async Task<ProductDto> GetProductById(int Id)
        {
            Product product = await DbContext.Products.Where(x => x.ProductId == Id).FirstOrDefaultAsync();
            return mapper.Map<ProductDto>(product);
        }

        public async Task<IEnumerable<ProductDto>> GetProducts()
        {
            List<Product> AllProducts = await DbContext.Products.ToListAsync();
            return mapper.Map <List< ProductDto >> (AllProducts);
        }

        
    }
}
