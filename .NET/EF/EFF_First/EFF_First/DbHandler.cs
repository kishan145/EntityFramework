using EFF_First;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class DbHandler:DbContext
    {
        public DbHandler():base("Name=SqlCon")
        {
            

        }

        public virtual DbSet<Batch> Batches { get; set; }

    }

