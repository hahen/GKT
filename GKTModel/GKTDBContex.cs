using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GKTModel
{
  public  class GKTDBContex : DbContext
    {
        public DbSet<Unit> Units { get; set; }
        public GKTDBContex()
        {
            Database.DefaultConnectionFactory = new SqlCeConnectionFactory("System.Data.SqlServerCe.4.0");
        }

    }
}
