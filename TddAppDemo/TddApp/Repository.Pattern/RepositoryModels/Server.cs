namespace TddApp.Repository.Pattern.RepositoryModels
{
    public interface IServer
    {
        IRequest Request { get; }
    }
    
    public class Server : IServer
    {
        public IRequest Request { get; } = new Request();
    }

}
