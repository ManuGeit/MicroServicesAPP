﻿using MicroServiceAppWeb.Models;

namespace MicroServiceAppWeb.Service.IService
{
    public interface ICouponService
    {
        Task<ResponseDto?> GetCouponAsync(string coupon);
        Task<ResponseDto?> GetAllCouponAsync();
        Task<ResponseDto?> GetCouponByIdAsync(int id);
        Task<ResponseDto?> CreateCouponAsync(CouponDto couponDto);
        Task<ResponseDto?> UpdateCouponAsync(CouponDto couponDto);
        Task<ResponseDto?> DeleteCouponAsync(int id);
    }
}
