using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using CrudMVC.Models;

namespace CrudMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

     
    }
    //public class CrudDbContext : IdentityDbContext
    //{
    //    public CrudDbContext(DbContextOptions<CrudDbContext> options)
    //        : base(options)
    //    {
    //    }

    //    public DbSet<Student> Student { get; set; }
    //}
}
