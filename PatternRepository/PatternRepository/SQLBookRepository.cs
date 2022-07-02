using Microsoft.EntityFrameworkCore;
using PatternRepository.Interfaces;
using PatternRepository.Models;

namespace PatternRepository {
    public class SQLBookRepository : IRepository<Book> {
        private BookContext db;

        public SQLBookRepository(DbContextOptions options) {
            db = new BookContext(options);
        }

        public IEnumerable<Book> GetBookList() {
            return db.Books;
        }

        public Book GetBook(int id) {
            return db.Books.Find(id);
        }

        public void Create(Book book) {
            db.Books.Add(book);
        }

        public void Update(Book book) {
            db.Entry(book).State = EntityState.Modified;
        }

        public void Delete(int id) {
            Book book = db.Books.Find(id);
            if (book != null)
                db.Books.Remove(book);
        }

        public void Save() {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing) {
            if (!this.disposed) {
                if (disposing) {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose() {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
