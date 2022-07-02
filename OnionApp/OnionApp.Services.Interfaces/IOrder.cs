using OnionApp.Domain.Core;
namespace OnionApp.Services.Interfaces {
    public interface IOrder {
        void MakeOrder(Book book);
    }
}