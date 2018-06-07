using System;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace MvvmCrossFragment.Core.ViewModels
{
    public class RootViewModel: MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public RootViewModel(IMvxNavigationService navigationService){
            _navigationService = navigationService;

            ShowChild = new MvxAsyncCommand(async () => await _navigationService.Navigate<ChildViewModel>());
        }
      
        public IMvxAsyncCommand ShowChild { get; private set; }
    }
}
