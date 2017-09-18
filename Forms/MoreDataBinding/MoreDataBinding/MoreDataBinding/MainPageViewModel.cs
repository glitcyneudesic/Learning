using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MoreDataBinding
{
    class MainPageViewModel:INotifyPropertyChanged
    {
        private string labelText="Hello";
        public string LabelText
        {
            get { return labelText; }
            set
            {
                labelText = value;
                RaisePropertChanged();
            }
        }

        private Command changeTextCommand;
        public Command ChangeTextCommand
        {
            get
            {
                return changeTextCommand ?? (changeTextCommand = new Command(() => { LabelText = "Good Bye"; }));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertChanged([CallerMemberName] string caller="")
        {
            if(PropertyChanged!=null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(caller));
            }
        }
    }
}
