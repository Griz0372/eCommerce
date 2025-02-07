﻿using Library.eCommerce.Services;
using Spring2025_Samples.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maui.eCommerce.ViewModels
{
    public class InventoryManagementViewModel
    {
        public Product? SelectedProduct { get; set; }
        private ProductServiceProxy _svc = ProductServiceProxy.Current;
        public List<Product?> Products
        {
            get
            {
                return _svc.Products;
            }
        }

        public Product? Delete()
        {
            return _svc.Delete(SelectedProduct?.Id ?? 0);
        }
    }
}
