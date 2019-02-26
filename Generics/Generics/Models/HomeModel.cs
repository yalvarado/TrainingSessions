namespace Generics.Models
{
    public class HomeModel : IModel
    {
        public string PageName { get; private set; }
        public string FullName { get; private set; }

        public HomeModel(string pagename, string fullname)
        {
            this.PageName = pagename;
            this.FullName = fullname;
        }
    }
}