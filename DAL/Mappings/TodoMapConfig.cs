using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL.Mappings
{
    public class TodoMapConfig : EntityTypeConfiguration<Todo>
    {
        public TodoMapConfig()
        {
            this.ToTable("TASK");
            this.Property(p => p.Title).IsRequired().HasMaxLength(100);
            this.Property(p => p.Status).IsRequired();
        }
    }
}
