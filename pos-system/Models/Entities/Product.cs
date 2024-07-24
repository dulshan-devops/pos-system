﻿using Microsoft.EntityFrameworkCore;

namespace pos_system.Models.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public required string ProductCode { get; set; }
        public required int DepartmentId { get; set; }
        public required int CategoryId { get; set; }
        public required int SupplierId { get; set; }
        [Precision(18, 2)]
        public required string CostPrice { get; set; }
        [Precision(18, 2)]
        public required string SellingPrice { get; set; }
        [Precision(18, 2)]
        public string? WholesalePrice { get; set; }
        [Precision(18, 2)]
        public string? MarkedPrice { get; set; }
        public required string Warranty { get; set; }
        public string? Desc { get; set; }
        public string? Unit { get; set; }

        public Department Department { get; set; } = null!;
        public Category Category { get; set; } = null!;
        public Supplier Supplier { get; set; } = null!;
    }
}
