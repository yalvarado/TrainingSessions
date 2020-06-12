using System.Collections.Generic;

namespace TddApp.Repository.Pattern.RepositoryModels
{
    public interface ISession
    {
        string Id { get; }
        string this[string key] { get; set;}
    }
    public class Session : ISession
    {
        private readonly Dictionary<string,string> _sessionValues = new Dictionary<string,string>();
        public string Id => "12345678";

        public string this[string key]
        {
            get => this._sessionValues[key];
            set
            {
                if(this._sessionValues.ContainsKey(key))
                    this._sessionValues[key] = value;
                else
                    this._sessionValues.Add(key,value);
            }
        }
    }
}
