using ListViews.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using static System.Math;

namespace ListViews.ViewModel
{
    class MainPageViewModel:INotifyPropertyChanged
    {
        public ObservableCollection<Person> People { get; set; } = new ObservableCollection<Person>();
        public ICommand ItemSelectedCommand { get; private set; }
        private string selectedItemText;
        public string SelectedItemText
        {
            get { return selectedItemText; } set { selectedItemText = value; RaisePropertChanged();  }
        }

        public MainPageViewModel()
        {
            Random rand = new Random();
            for (int i = 0; i < 6; i++)
            {
                Person person = new Person();
                person.FirstName = "Glitcy";
                person.LastName = "Mary" + i.ToString();
                person.Address = "Mainstreat" + i.ToString();
                person.ImageSource = "man" + i.ToString() + ".jpg";
                person.Age = (decimal)(35 + rand.NextDouble());
                People.Add(person);
                ItemSelectedCommand = new Command<Person>(HandleItemSelected);
            }
        }

           public void HandleItemSelected(Person person)
            {
                SelectedItemText = string.Format("{0} is {1} years old.", person.FirstName, person.Age);
               // OnPropertyChanged("SelectedItemText");
            }
        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertChanged([CallerMemberName] string caller = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(caller));
            }
        }


    }
}
