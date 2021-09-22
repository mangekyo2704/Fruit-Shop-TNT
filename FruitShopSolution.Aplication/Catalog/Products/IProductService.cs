﻿using FruitShopSolution.ViewModel.Catalog.Cart;
using FruitShopSolution.ViewModel.Catalog.Categories;
using FruitShopSolution.ViewModel.Catalog.Order;
using FruitShopSolution.ViewModel.Catalog.Products;
using FruitShopSolution.ViewModel.Catalog.Products.Manage;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FruitShopSolution.Application.Catalog.Products
{
    public interface IProductService
    {
        public List<ProductInfoViewModel> GetAllProduct();
        public ProductInfoViewModel GetProductById(int proId);
        public Task<List<ProductInfoViewModel>> Searching(string keyword);
        public Task AddToCart(ProductInfoViewModel pro, int quantity);
        public List<CartViewModel> GetProductsInCart();
        public Task<List<ProductViewModel>> GetAllPaging(GetManageProductPagingRequest request);
        public List<ProductImageViewModel> GetListProductImages(int productId);
        public Task<bool> FindProductInCart(int proId);
        public Task<int> CreateOrder(CreateOrderRequest request);
        public Task<List<CommentViewModel>> GetComment(int ProductId);
        public Task<CommentViewModel> Comment(int ProductId, string text, int UserId);
        Task<List<ProductInfoViewModel>> GetByCategory(int categoryId);
        Task<List<CategoriesViewModel>> GetCategoryId(int ProductId);
    }
}
