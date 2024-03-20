using RememberWPF.Infostruction.Commands;
using RememberWPF.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace RememberWPF.ViewModel
{
    class MainWindowVM : ViewModelBase
    {
        #region Команды

        #region CloseAppCommand
        public ICommand CloseAppCommand { get; }

        private bool CanCloseAppCommandExecute(object p) => true;
        private void OnCloseAppCommandExecuted(object p) 
        {
            Application.Current.Shutdown();
        }
        #endregion




        #endregion


        public MainWindowVM()
        {
            #region Комманды
            CloseAppCommand = new RelateC(OnCloseAppCommandExecuted, CanCloseAppCommandExecute);

            #endregion
        }

        //private int _Click;
        //public int Click
        //{  get { return _Click; }
        //   set 
        //   {
        //       _Click = value;
        //       OnPropertyChanged();
        //   }
        //}
    }
}
