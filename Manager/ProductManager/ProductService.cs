using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using ZalakProject.Data;
using ZalakProject.Models;
using ZalakProject.ViewModels;
namespace ZalakProject.Manager.ProductManager
{
    public class ProductService:IProductService
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<Product> _productDao;

        public ProductService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Product>> GetAllProductsBySellerId(string sellerId)
        {
            return await _productDao.AsNoTracking().Where(q => q.SellerId == sellerId).ToListAsync();
        }
    }
}
