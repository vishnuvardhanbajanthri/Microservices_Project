using Mango.Web.Models;
using Mango.Web.Service.IService;

namespace Mango.Web.Service
{
    public class CouponService :ICouponService
    {
        private readonly IBaseService _baseService;
        public CouponService(IBaseService baseService)
        {
            _baseService = baseService;
        }

        public async Task<ResponseDto?> CreateCoupnsAsync(CouponDTO couponDTO)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = Utility.StaticDetails.ApiType.POST,
                Data =couponDTO,
                Url = Utility.StaticDetails.CouponAPIBase + "/api/coupon/"
            });
        }

        public async Task<ResponseDto?> DeleteCoupnsAsync(int id)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = Utility.StaticDetails.ApiType.DELETE,
                Url = Utility.StaticDetails.CouponAPIBase + "/api/coupon/" + id
            });
        }

        public async Task<ResponseDto?> GetAllCoupnsAsync()
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = Utility.StaticDetails.ApiType.GET,
                Url = Utility.StaticDetails.CouponAPIBase + "/api/coupon"
            });
                
        }

        public async Task<ResponseDto?> GetCoupnsByIdAsync(int id)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = Utility.StaticDetails.ApiType.GET,
                Url = Utility.StaticDetails.CouponAPIBase + "/api/coupon/" + id
            });
        }

        public async Task<ResponseDto?> GetCouponAsync(string CouponCode)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = Utility.StaticDetails.ApiType.GET,
                Url = Utility.StaticDetails.CouponAPIBase + "/api/coupon/GetByCode/"+CouponCode
            });
        }

        public async Task<ResponseDto?> UpdateCoupnsAsync(CouponDTO couponDTO)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = Utility.StaticDetails.ApiType.PUT,
                Data = couponDTO,
                Url = Utility.StaticDetails.CouponAPIBase + "/api/coupon/"
            });
        }
    }
}
