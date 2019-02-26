namespace Generics.ViewModels
{
    public class ExampleViewModel : IViewModel
    {
        public string ExamplePageTitle { get; private set; }
        public ExampleViewModel(string examplePageTitle)
        {
            this.ExamplePageTitle = examplePageTitle;
        }
    }
}