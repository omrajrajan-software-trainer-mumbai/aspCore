﻿namespace LanguageFeatures_01.Models
{
    public class Product
    {
        // public required string Name { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal? Price { get; set; }
        public static Product?[] GetProducts()
        {
            Product kayak = new Product
            {
                Name = "Kayak",
                Price = 275M
            };
            Product lifejacket = new Product
            {
                Name = "Lifejacket",
                Price = 48.95M
            };
            return new Product?[] { kayak, lifejacket, null };
        }
    }
}
