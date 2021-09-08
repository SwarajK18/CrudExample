using CrudMVCEx.Data.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrudMVCEx.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
    public class CrudMVCExDbContext : DbContext
    {
        public CrudMVCExDbContext(DbContextOptions<CrudMVCExDbContext> options)
            : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
    }
}
