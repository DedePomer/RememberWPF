using RememberWPF.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RememberWPF.ViewModel
{
    class MainWindowVM : ViewModelBase
    {
        private int _Click;
        public int Click
        {  get { return _Click; }
           set 
           {
               _Click = value;
               OnPropertyChanged();
           }
        }
    }
}
