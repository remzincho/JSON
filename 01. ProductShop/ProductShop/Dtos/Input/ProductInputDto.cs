﻿using System.ComponentModel.DataAnnotations;

namespace ProductShop.Dtos.Input
{
    public class ProductInputDto
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int SellerId { get; set; }
        public int? BuyerId { get; set; }
    }
}