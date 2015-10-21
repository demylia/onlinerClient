using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using OnlinerServices;
using System.Collections.ObjectModel;
using OnlinerNews3.ViewModels;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace OnlinerNews3
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public ObservableCollection<NewsItem> News { get; set; }
        private int pageCounter = 2;
        private OnlinerServices.DataManager dm = DataManager<OnlinerServices.DataManager>.Instance;

        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;

           
            News = new MainViewModel().News;

        }

       
      
        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void listbox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Frame.Navigate(typeof(Page2), News.First(n => n.Title == ((NewsItem)listbox1.SelectedItem).Title));
        }


        private void ForwardButton_Click(object sender, RoutedEventArgs e)
        {
            //TODO: Implement correctly INotifyPropertyChanged
            //News = new ObservableCollection<NewsItem>(dm.GetNews(pageCounter++));
        }



        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            //TODO: Implement cash, instead the repeating requests
            //if (pageCounter == 2)
            //    News = new ObservableCollection<NewsItem>(dm.GetNews());
            //else
            //    News = new ObservableCollection<NewsItem>(dm.GetNews(--pageCounter));

        }
    }
}
