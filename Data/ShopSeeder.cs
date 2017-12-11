using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreTodo.Data
{
    public class ShopSeeder
    {
        private readonly ApplicationDbContext _ctx;

        public ShopSeeder(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public void Seed()
        {
            _ctx.Database.EnsureCreated();

            if (!_ctx.Products.Any())
            {
                //Need to create sample data

            }
        }
    }
}
