namespace OnlineStore.Models
{
    using System;
    using System.Collections.Generic;
    public class Basket
    {
        public int  Id { get; set; }
        public string UserId { get; set; }
        public List<Item> Items { get; set; }
        
    }
}