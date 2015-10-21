using OnlinerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OnlinerNews3.DataModel
{
    class NewsItemViewModel : INotifyPropertyChanged
    {

        string title;
        string link;
        string imagePath;
        string content;

        public NewsItem NewsItem { get; set; }

        public NewsItemViewModel()
        {
            NewsItem = new NewsItem();
        }

        public event PropertyChangedEventHandler PropertyChanged;


        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                OnPropertyChanged(Title);

            }
        }

        public string Link
        {
            get { return link; }
            set
            {
                link = value;
                OnPropertyChanged(Link);

            }
        }

        public string ImagePath
        {
            get { return imagePath; }
            set
            {
                imagePath = value;
                OnPropertyChanged(ImagePath);

            }
        }

        public string Content
        {
            get { return content; }
            set
            {
                content = value;
                OnPropertyChanged(Content);

            }
        }
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        public override string ToString()
        {
            return this.Title;
        }
    }
}
