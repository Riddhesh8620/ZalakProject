using ZalakProject.ViewModels;

namespace ZalakProject.Manager.Buyer
{
    public interface IBuyerService
    {
        Task<PaginatedResult<BuyerProductViewModel>> GetProductList(int pageNumber);
    }
}
