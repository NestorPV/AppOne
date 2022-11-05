using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiAppOne.Models
{
    public abstract partial class BasePageModel : ObservableObject
    {
        private readonly object _busyLockObject = new object();

        private bool _isBusy;

        protected BasePageModel()
        {
        }

        public bool IsBusy
        {
            get
            {
                lock (_busyLockObject)
                {
                    return _isBusy;
                }
            }
            set
            {
                lock (_busyLockObject)
                {
                    _isBusy = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}