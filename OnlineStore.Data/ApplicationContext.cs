namespace OnlineStore.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using OnlineStore.Models;

    public class ApplicationContext : DbContext
    {

        public ApplicationContext()
            : base("name=ApplicationContext")
        {
        }


        public virtual DbSet <User> Users { get; set; }
        public virtual DbSet <Item> Items { get; set; }
        public virtual DbSet<Basket> Basket { get; set; }
    }

}