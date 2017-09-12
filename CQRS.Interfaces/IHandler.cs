namespace CQRS.Interfaces
{
    public interface IHandler<T>
    {
        void Execute(T command);
    }
}
