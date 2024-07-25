using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BooksTry.Models;

namespace BooksTry.Data
{
    public class BooksTryContext : DbContext
    {
        public BooksTryContext (DbContextOptions<BooksTryContext> options)
            : base(options)
        {
        }

        public DbSet<BooksTry.Models.Books> Books { get; set; } = default!;
    }
}
