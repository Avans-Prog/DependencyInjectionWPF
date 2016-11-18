using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;

namespace DependencyInjectionWPF.ViewModel
{

    public class MainViewModel : ViewModelBase
    {
        public ObservableCollection<ProductVM> Products { get; set; }

        public MainViewModel()
        {
            Products = new ObservableCollection<ProductVM>();
        }
    }
}