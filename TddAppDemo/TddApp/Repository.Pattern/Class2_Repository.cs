using TddApp.Repository.Pattern.RepositoryModels;

namespace TddApp.Repository.Pattern
{
    public class Class2_Repository
    {
        private readonly IRepository _repository;

        public Class2_Repository(IRepository repository)
        {
            this._repository = repository;

            this._repository.SetSessionValue("MySecretValue","A");
            this._repository.SetSessionValue("MyOtherSecretValue", "B");            
        }


        public bool DoStuff()
        {

            if((this._repository.GetSessionValue("MySecretValue")=="A")
                && this._repository.GetSessionValue("MyOtherSecretValue")=="B")
                return true;


            return false;
        }
    }
}
