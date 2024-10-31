﻿using System.ComponentModel;
using System.Text.Json.Serialization;

namespace HPlusport.Models
{
    public class Product
    {

        public int ID { get; set; }
        public string Sku { get; set; } = string.Empty;
        public string Name { get; set; } =string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
        public int CategoryId { get; set; }

        [JsonIgnore]

        public virtual Category Category { get; set; }

    }
}