using System;
using System.Collections.Generic;
using System.Text;
using Generics.ViewModels;

namespace Generics.ViewModelBuilders
{
    public abstract class ViewModelBuilderBase<TViewModel>  where TViewModel : IViewModel
    {
        protected TViewModel _viewModel;

        public TViewModel Build()
        {
            return this._viewModel;
        }
    }
}
