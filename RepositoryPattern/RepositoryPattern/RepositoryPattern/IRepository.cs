namespace RepositoryPattern
{
    public interface IRepository
    {
        void Load();
        void Save(string newdata);
        void SearchData(string name);
    }
}