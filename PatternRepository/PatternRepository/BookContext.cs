using Microsoft.EntityFrameworkCore;
using PatternRepository.Models;

namespace PatternRepository {
    public class BookContext : DbContext {
        public BookContext(DbContextOptions options) : base(options) { }
        public DbSet<Book> Books { get; set; }
    }
}
