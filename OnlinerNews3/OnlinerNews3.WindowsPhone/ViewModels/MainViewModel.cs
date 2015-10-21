using OnlinerNews3.DataModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace OnlinerNews3.ViewModels
{
   public class MainViewModel
    {
        public ObservableCollection<OnlinerServices.NewsItem> News { get; set; }
        
        public MainViewModel()
        {

            News = new ObservableCollection<OnlinerServices.NewsItem>(DataManager<OnlinerServices.DataManager>.Instance.GetNews());
        }

    }
}
