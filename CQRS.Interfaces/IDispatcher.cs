namespace CQRS.Interfaces
{
    public interface IDispatcher
    {
        void Dispatch<T>(T dispatch);
    }
}
