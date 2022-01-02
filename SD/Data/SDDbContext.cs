using Microsoft.EntityFrameworkCore;
using SD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SD.Data
{
    public class SDDbContext:DbContext
    {
        public SDDbContext(DbContextOptions<SDDbContext> options) : base(options)
        {

        }
        public DbSet<EmployeeModel> EmployeeModels { get; set; }
     
        public DbSet<ClientModel> ClientModels { get; set; }
        public DbSet<ProductModel> ProductModels{ get; set; }

        //public static implicit operator SDDbContext(ProductModel v)
        //{
        //    throw new NotImplementedException();
        //}
        //public object ProductModel { get; internal set; }
    }
}
