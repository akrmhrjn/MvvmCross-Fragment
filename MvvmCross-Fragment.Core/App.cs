using System;
using MvvmCross.IoC;
using MvvmCross.ViewModels;
using MvvmCrossFragment.Core.ViewModels;

namespace MvvmCrossFragment.Core
{
    public class App: MvxApplication
    {

        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            //Mvx.RegisterSingleton<IMvxTextProvider>(new TextProviderBuilder().TextProvider);

            RegisterAppStart<RootViewModel>();
        }
        
    }
}
