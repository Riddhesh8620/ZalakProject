using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using ZalakProject.Data;
using ZalakProject.Models;
using ZalakProject.ViewModels;
namespace ZalakProject.Manager.ProductManager
{
	public class ProductService : IProductService
	{
		private readonly ApplicationDbContext _context;
		private readonly DbSet<Product> _productDao;

        public ProductService(ApplicationDbContext context)
        {
            _context = context;
        }

		public async Task<List<ProductListViewModel>> GetAllProductsBySellerId(string sellerId)
		{
			List<ProductListViewModel> dtolist = new List<ProductListViewModel>();
			var dbResult = await _productDao.AsNoTracking().Include(q => q.Category).Where(q => q.SellerId == sellerId).ToListAsync();
            dtolist = dbResult.Select(Create).ToList();
			return dtolist;
		}

		private ProductListViewModel Create(Product product)
		{
			return new ProductListViewModel
			{
				CategoryId = product.CategoryId,
				CategoryName = product.Category.Name,
				Description = product.Description,
				Price = product.Price,
				ProductId = product.Id,
				ProductName = product.Name,
				ProductImage = product.ProductImages.ToList(),
				SellerId = product.SellerId,
				StockQuantity = product.StockQuantity,
			};
		}
	}
}
