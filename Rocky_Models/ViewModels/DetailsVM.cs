﻿namespace Rocky.Models
{
    public class DetailsVM
    {
        public DetailsVM()
        {
            Product = new Product();
        }
        public Product Product { get; set; }
        public bool ExistsINCart { get; set; }
    }
}
