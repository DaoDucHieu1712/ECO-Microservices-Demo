﻿using System.Text.Json.Serialization;

namespace ECO.Service.Product.DTOs.Product
{
    public class ProductCommandDTO
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
