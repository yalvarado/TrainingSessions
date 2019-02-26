using System;
using Generics.Models;
using Generics.ViewModelBuilders;
using Generics.ViewModels;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeModel homeModel = new HomeModel("Home Page","Perico Palotes");
            ExampleModel exampleModel = new ExampleModel("Example Page");

            ViewModelBuilderBase<HomeViewModel> homeViewModelBuilder = new HomeViewModelBuilder(homeModel);
            var homeViewModel = homeViewModelBuilder.Build();

            ViewModelBuilderBase<ExampleViewModel> exampleViewModelBuilder = new ExampleViewModelBuilder(exampleModel);
            var exampleViewModel = exampleViewModelBuilder.Build();

            Console.WriteLine(homeViewModel.Title);
            Console.WriteLine(exampleViewModel.ExamplePageTitle);

            Console.WriteLine();

            // EXAMPLE 2
            // =========
            ShowValue2(10);
            ShowValue("15");
            ShowValue2(3.25);
            ShowValue(homeViewModel);

            ShowValue3(10);
            //ShowValue3("15");
            ShowValue3(3.25);
            //ShowValue3(homeViewModel);


            Console.ReadLine();
        }

        private static void ShowValue<T>(T myObject) where T : class
        {
            Console.WriteLine(myObject.ToString());
        }

        private static void ShowValue2<T>(T myObject) where T : struct
        {
            Console.WriteLine(myObject.ToString());
        }

        private static void ShowValue3<T>(T myObject) where T : new()
        {
            Console.WriteLine(myObject.ToString());
        }
    }
}
