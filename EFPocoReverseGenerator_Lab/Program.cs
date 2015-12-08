using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFPocoReverseGenerator_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = new Product
            {
                Id = Guid.NewGuid(),
                Name = "Test",
                Price = 100
            };

            using (var context = new PocoReverseDBContext())
            {
                context.Product.Add(product);
                context.SaveChanges();
            }
        }
    }
}
