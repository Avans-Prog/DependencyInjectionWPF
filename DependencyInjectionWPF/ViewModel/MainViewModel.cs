using DependencyInjectionWPF.Model;
using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;

namespace DependencyInjectionWPF.ViewModel
{

    public class MainViewModel : ViewModelBase
    {
        public ObservableCollection<ProductVM> Products { get; set; }

        private IProductRepository _productRepo;

        public MainViewModel(IProductRepository productRepo)
        {
            this._productRepo = productRepo;
            Products = new ObservableCollection<ProductVM>(_productRepo.GetAll());
        }
    }
}