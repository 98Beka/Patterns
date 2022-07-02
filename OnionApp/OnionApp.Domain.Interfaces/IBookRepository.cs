using OnionApp.Domain.Core;

namespace OnionApp.Domain.Interfaces {
    public interface IBookRepository : IDisposable {
        IEnumerable<Book> GetBookList();
        Book GetBook(int id);
        void Create(Book item);
        void Update(Book item);
        void Delete(int id);
        void Save();
    }
}