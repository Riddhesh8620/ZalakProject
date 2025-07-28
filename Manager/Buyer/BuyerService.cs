using Microsoft.EntityFrameworkCore;
using System.Drawing.Printing;
using ZalakProject.Data;
using ZalakProject.Manager.ProductManager;
using ZalakProject.Models;
using ZalakProject.ViewModels;

namespace ZalakProject.Manager.Buyer
{
    public class BuyerService:IBuyerService
    {
        private readonly ApplicationDbContext _context;
        private readonly IProductService _productService;
        private readonly DbSet<Product> _productsDao;

        public BuyerService(ApplicationDbContext context,IProductService productService)
        {
            _context = context;
            _productService = productService;
            _productsDao = _context.Products;
        }

        public async Task<PaginatedResult<BuyerProductViewModel>> GetProductList(int pageNumber)
        {
            int pageSize = 9;
            var query = _productsDao.Include(p => p.ProductImages).AsQueryable();

            int totalRecords = await query.CountAsync();
            int totalPages = (int)Math.Ceiling(totalRecords / (double)pageSize);

            var products = await query
                .OrderByDescending(p => p.CreatedAt)
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .Select(p => new BuyerProductViewModel
                {
                    ProductId = p.Id,
                    ProductName = p.Name,
                    Price = p.Price,
                    ProductImage = p.ProductImages
                                    .OrderBy(img => img.Id)
                                    .ToList()
                })
                .ToListAsync();

            return new PaginatedResult<BuyerProductViewModel>
            {
                Items = products,
                CurrentPage = pageNumber,
                TotalPages = totalPages
            };
        }
    }
}
