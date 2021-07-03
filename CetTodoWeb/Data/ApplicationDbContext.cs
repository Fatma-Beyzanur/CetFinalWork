using CetTodoWeb.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CetTodoWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext<CetUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
          

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
