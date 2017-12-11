using MyShop.Core.Models;
namespace MyShop.Core.Contracts
{
    public interface IRepository<T> where T : BaseEntity
    {
        System.Linq.IQueryable<T> Collection();
        void Commit();
        void Delete(string Id);
        T Find(string Id);
        void Insert(T item);
        void Update(T item);
    }
}
