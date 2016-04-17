namespace OnlineStore.Models
{
    using System;
    using System.Collections.Generic;
    public class Item
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public string Picture { get; set; }

    }
}