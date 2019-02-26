using System;
using System.Collections.Generic;
using System.Text;
using Generics.Models;
using Generics.ViewModels;

namespace Generics.ViewModelBuilders
{
    public class HomeViewModelBuilder : ViewModelBuilderBase<HomeViewModel>
    {
        public HomeViewModelBuilder(HomeModel model)
        {
            if(string.IsNullOrEmpty(model.FullName))
                throw new ArgumentNullException(nameof(model.FullName),"Invalid Fullname");

            string[] fullname = model.FullName.Split(' ');
            if(fullname.Length<2)
                throw new ArgumentNullException(nameof(model.FullName), "Invalid Fullname");

            base._viewModel = new HomeViewModel(model.PageName,fullname[0],fullname[1]);
        }

    }
}
