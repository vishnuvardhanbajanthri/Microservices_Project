using Mango.Web.Models;

namespace Mango.Web.Service.IService
{
    public interface ICouponService
    {
        Task<ResponseDto?> GetCouponAsync(string CouponCode);
        Task<ResponseDto?> GetAllCoupnsAsync();
        Task<ResponseDto?> GetCoupnsByIdAsync(int id);
        Task<ResponseDto?> CreateCoupnsAsync(CouponDTO couponDTO);
        Task<ResponseDto?> UpdateCoupnsAsync(CouponDTO couponDTO);
        Task<ResponseDto?> DeleteCoupnsAsync(int id);

    }
}
