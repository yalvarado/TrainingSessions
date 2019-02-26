namespace Generics.Models
{
    public class ExampleModel : IModel
    {
        public string PageTitle { get; private set; }

        public ExampleModel(string pageTitle)
        {
            this.PageTitle = pageTitle;
        }
    }
}