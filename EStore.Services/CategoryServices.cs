using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EStore.Entities;
using EStore.Database;

namespace EStore.Services
{
    public class CategoryServices
    {

          public void Savecategory(Category category)
            {
            using ( var db=  new EStoreContext() )
            {
                db.categories.Add(category);
                db.SaveChanges();
            }           
            }


        public List<Category> Getcategory()
        {
            using (var db = new EStoreContext())
            {
               return db.categories.ToList();            
            }
        }

        public Category Editcategory(int catID)
        {
            using (var db = new EStoreContext())
            {
                return db.categories.Find(catID);
            }
        }


        public void Updatecategory(Category category)
        {
            using (var db = new EStoreContext())
            {
                db.Entry(category).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void Deletecategory(int ID)
        {
            using (var db = new EStoreContext())
            {
               var catData= db.categories.Find(ID);
                db.categories.Remove(catData);
                db.SaveChanges();
            }
        }

    }
}
