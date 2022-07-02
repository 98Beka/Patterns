using Microsoft.EntityFrameworkCore;
using OnionApp.Domain.Core;

namespace OnionApp.Infrastructure.Data {
    public class OrderContext : DbContext {
        public DbSet<Book> Books { get; set; }
    }
}