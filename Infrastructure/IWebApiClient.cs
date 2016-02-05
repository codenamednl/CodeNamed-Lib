namespace CodeNamed.Infrastructure
{
    public interface IWebApiClient
    {
        T Post<T>(string apiRoute, T entity) where T : class, new();
        T Get<T>(string apiRoute, string key);
        T Put<T>(string apiRoute, T entity) where T : new();
        TResult Post<T, TResult>(string apiRoute, T entity) where T : class, new();
    }
}