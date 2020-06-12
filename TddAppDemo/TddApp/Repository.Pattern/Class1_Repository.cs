using TddApp.Repository.Pattern.RepositoryModels;

namespace TddApp.Repository.Pattern
{
    public class Class1_Repository
    {
        private readonly IServer _server;

        public Class1_Repository(IServer server)
        {
            this._server = server;
            this._server.Request.Session["MySecretValue"] = "A";
            this._server.Request.Session["MyOtherSecretValue"] = "B";

        }

        public bool DoStuff()
        {

            if ((this._server.Request.Session["MySecretValue"] == "A") 
                && (this._server.Request.Session["MyOtherSecretValue"] == "B"))
                return true;


            return false;
        }
    }
}
