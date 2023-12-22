using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module07_ADOEF
{
    public  class StudentContext:DbContext
    {
        //Create new table in db defined by connection string
        public DbSet<Student> Students{ get; set; }

        

        protected override void OnConfiguring(DbContextOptionsBuilder options)

        => options.UseSqlServer("database=StudentDB;server=Endurance;TrustServerCertificate=true;Persist Security Info=False;Integrated Security=SSPI;");

    }

}
