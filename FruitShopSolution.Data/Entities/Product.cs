﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FruitShopSolution.Data.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Origin { get; set; }
        public string Title { get; set; }
        public decimal InputCount { get; set; }
        public decimal OutputCount { get; set; }
        public int Quantity { get; set; }
        public string Content { get; set; }
        public string Unit { get; set; }
        public DateTime DateCreated { get; set; }
        public List<ProductImage> ProductImages { get; set; }
        public List<ProductInCategory> ProductInCategories { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public List<Cart> Carts { get; set; }
    }
}
