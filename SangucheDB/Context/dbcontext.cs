using Microsoft.EntityFrameworkCore;
using SangucheDB.Context.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SangucheDB.Context
{
    public class dbcontext : DbContext
    {
        public DbSet<Pedidos> pedidos { get; set; }
        public dbcontext(DbContextOptions<dbcontext> options) : base(options) 
        {
            
        }
       
    }
}
