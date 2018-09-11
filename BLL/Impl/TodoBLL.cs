using BLL.Interfaces;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Impl
{
    public class TodoBLL : IEntityBase<Todo>
    {
        public void Add(Todo item)
        {
            using (WebApiContext db = new WebApiContext())
            {
                db.Todo.Add(item);
                db.SaveChanges();
            }
        }

        public void Delete(Todo item)
        {
            using (WebApiContext db = new WebApiContext())
            {
                db.Entry<Todo>(item).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Edit(Todo item)
        {
            using (WebApiContext db = new WebApiContext())
            {
                db.Entry<Todo>(item).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public IList<Todo> GetAll()
        {
            using (WebApiContext db = new WebApiContext())
            {
                return db.Todo.AsNoTracking().ToList();
            }
        }

        public Todo GetByID(int id)
        {
            using (WebApiContext db = new WebApiContext())
            {
                return db.Todo.Find(id);
            }
        }
    }
}
