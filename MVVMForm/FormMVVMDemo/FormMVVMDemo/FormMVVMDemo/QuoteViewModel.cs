using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FormMVVMDemo
{
    public class QuoteViewModel:INotifyPropertyChanged
    {
        public QuoteViewModel()
        {
            QuoteName = "Glitcy";
        }
        string _quoteName;

        public event PropertyChangedEventHandler PropertyChanged;

        public string QuoteName
        {
            get
            {
                return _quoteName;
            }
            set
            {
                _quoteName = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("QuoteName"));
                }
            }
        }
            public Command  ResetQuoteName
        {
            get
            {
                return new Command(() =>
                {
                    QuoteName = "Glitcy";
                });
            }
        
        }
    }
}
