using BookLibrary.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Data
{
    public class BookDataContext:DbContext
    {
        public BookDataContext(DbContextOptions<BookDataContext> options) : base(options) 
        { 

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Writer> Writers { get; set; }
    }
}
