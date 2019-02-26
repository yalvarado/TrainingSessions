namespace Generics.ViewModels
{
    public class HomeViewModel : IViewModel
    {
        public string Title { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public HomeViewModel(string title,string firstName,string lastname)
        {
            this.Title = title;
            this.FirstName = firstName;
            this.LastName = lastname;
        }
    }
}