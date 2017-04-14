namespace CodeNamed.Infrastructure.Web
{
    public interface IWebApiClient
    {
        T Post<T>(string apiRoute, T entity) where T : class, new();
        T Get<T>(string apiRoute, string queryString);
        T Put<T>(string apiRoute, T entity) where T : new();
        TResult Post<T, TResult>(string apiRoute, T entity) where T : class, new();
    }
}