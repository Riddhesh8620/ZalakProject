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

        //public async Task<PaginatedResult<T>> GetProductsWithPagination<T>() where T : class 
        //{
        //    switch (typeof(T))
        //    {
        //        case typeof(BuyerProductViewModel):
        //            return new PaginatedResult<BuyerProductViewModel>
        //            {

        //            }
        //            break;
        //    }
        //    //return await _productDao.AsNoTracking().ToListAsync();
        //}
    }
}
