﻿namespace MultiShop.Discount.Dtos
{
    public class UpdateDiscountCouponDto
    {
        public int CouponId { get; set; }
        public string Code { get; set; }
        public int Rate { get; set; }
        public bool isActive { get; set; }
        public DateTime ValidDate { get; set; }
    }
}

