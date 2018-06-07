using System;
using Android.OS;
using Android.Runtime;
using Android.Views;
using MvvmCross.Droid.Support.V4;
using MvvmCross.Platforms.Android.Binding.BindingContext;
using MvvmCross.Platforms.Android.Presenters.Attributes;
using MvvmCrossFragment.Core.ViewModels;

namespace MvvmCrossFragment.Droid.Views
{
    [MvxFragmentPresentation(typeof(RootViewModel), Resource.Id.content_frame, true)]
    [Register(nameof(ChildView))]
    public class ChildView: MvxFragment<ChildViewModel>
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            var view = this.BindingInflate(Resource.Layout.ChildView, null);

            return view;
        }
    }
}
