namespace CQRS.Interfaces.Repository
{
    public interface IUnitOfWork
    {
        IRepository<TModel> GetRepository<TModel>() where TModel : class;
    }
}
