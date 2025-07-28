using Microsoft.EntityFrameworkCore;
using ZalakProject.Data;
using ZalakProject.Models;
namespace ZalakProject.Manager.ProductManager
{
    public class ProductService:IProductService
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<Product> _productDao;

        public ProductService(ApplicationDbContext context, DbSet<Product> productDao)
        {
            _context = context;
            _productDao = productDao;
        }

        public async Task<List<Product>> GetAllProductsBySellerId(string sellerId)
        {
            return await _productDao.AsNoTracking().Where(q => q.SellerId == sellerId).ToListAsync();
        }
    }
}
