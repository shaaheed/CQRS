using CQRS.Interfaces.Query;

namespace CQRS.Interfaces.Repository
{
    public interface IRepository<TModel>
        where TModel : class
    {
        IDataContext DataContext { get; }

    }
}
