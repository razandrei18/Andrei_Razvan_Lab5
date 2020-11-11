using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Andrei_Razvan_Lab5.Models;

namespace Andrei_Razvan_Lab5.Models
{
    public class ExpenseContext : DbContext
    {
        public ExpenseContext(DbContextOptions<ExpenseContext> options)
        : base(options)
        {
        }
        public DbSet<ExpenseDTO> ExpenseDTO { get; set; }
        public DbSet<Expense> Expense { get; set; }
        public DbSet<Andrei_Razvan_Lab5.Models.Budget> Budget { get; set; }

    }
}
