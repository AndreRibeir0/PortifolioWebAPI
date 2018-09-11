using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class WebApiContext : DbContext
    {
        public WebApiContext() : base("WebApiDB")
        {
            //A linha abaixo é descomentada para deletar e criar todas as tabelas quando necessário 
            //Database.SetInitializer(new WebApiStrategy());
        }

        public DbSet<Todo> Todo { get; set; }


        public class WebApiStrategy : DropCreateDatabaseAlways<WebApiContext>
        {

        }

    }
}
