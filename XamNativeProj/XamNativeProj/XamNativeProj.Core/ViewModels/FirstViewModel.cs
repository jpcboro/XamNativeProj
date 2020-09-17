using MvvmCross.Core.ViewModels;

namespace XamNativeProj.Core.ViewModels
{
    public class FirstViewModel
        : MvxViewModel
    {
        string hello = "Xamarin Native Sample with MVVMCross";
        public string Hello
        {
            get { return hello; }
            set { SetProperty(ref hello, value); }
        }
    }
}
