namespace TddApp.Repository.Pattern.RepositoryModels
{
    public interface IRepository
    {
        string GetSessionValue(string key);
        void SetSessionValue(string key, string value);
    }
    public class Repository : IRepository
    {
        private readonly IServer _server;

        public Repository(IServer server)
        {
            this._server = server;
        }
        public string GetSessionValue(string key)
        {
            return this._server.Request.Session[key];
        }

        public void SetSessionValue(string key, string value)
        {
            this._server.Request.Session[key] = value;
        }
    }
}
