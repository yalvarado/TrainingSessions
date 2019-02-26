using Generics.Models;
using Generics.ViewModels;

namespace Generics.ViewModelBuilders
{
    public class ExampleViewModelBuilder : ViewModelBuilderBase<ExampleViewModel>
    {
        public ExampleViewModelBuilder(ExampleModel model)
        {
            base._viewModel = new ExampleViewModel(model.PageTitle);
        }
    }
}
