using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ScaffoldView.Models;

namespace ScaffoldView.Data
{
    public class ScaffoldViewContext : DbContext
    {
        public ScaffoldViewContext(DbContextOptions<ScaffoldViewContext> options)
            : base(options)
        {
        }

        public DbSet<Account> Account { get; set; }
    }
}