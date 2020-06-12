namespace TddApp.Repository.Pattern.RepositoryModels
{
    public interface IRequest
    {
        ISession Session { get; }
    }
    public class Request : IRequest
    {
        public ISession Session { get; } = new Session();
    }
    
}
