using System;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace MvvmCrossFragment.Core.ViewModels
{

    public class ChildViewModel: MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;
        public ChildViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
            CloseCommand = new MvxAsyncCommand(async () => await _navigationService.Close(this));
        }

        public IMvxAsyncCommand CloseCommand { get; private set; }

    }
}
