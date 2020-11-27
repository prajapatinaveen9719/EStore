using EStore.Database;
using EStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStore.Services
{
    public class ProductServices
    {
        EStoreContext db = new EStoreContext();
        public void Saveproducts(Product product)
        {
            db.products.Add(product);
            db.SaveChanges();
        }

        public List<Product> Getproducts()
        {
          return  db.products.ToList();
          
        }

        public Product EditProducts(int productID)
        {
            return db.products.Find(productID);
        }

        public void UpdateProducts(Product product)
        {
            db.Entry(product).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public void DeleteProducts(int ID)
        {
           var dltproduct=  db.products.Find(ID);
            db.products.Remove(dltproduct);
            db.SaveChanges();
        }



    }
}
