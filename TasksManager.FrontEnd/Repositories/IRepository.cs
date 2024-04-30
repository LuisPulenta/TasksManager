using TasksManager.Shared.Models;

namespace TasksManager.FrontEnd.Repository
{
    public interface IRepository
    {
        Task<Response<T>> GetAsync<T>(string url);
    }
}
