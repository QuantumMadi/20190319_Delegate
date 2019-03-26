namespace StarWars.Services.Abstract
{
    public interface IRepository<T>
    {
        void Add(T entity);       
        T GetT(int index);
    }
}
