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
    internal class MainWindowVM : ViewModelBase
    {
        #region Число в Скримере
        private int _ScreamNum = 0;           
        public int ScreamNum
        { 
            get { return _ScreamNum; }
            set 
            {
                if (Equals(_ScreamNum, value)) return;
                _ScreamNum = value;
                OnPropertyChanged();
            }
        }
        #endregion



        #region Команды

        #region CloseAppCommand
        public ICommand CloseAppCommand { get; }
        private bool CanCloseAppCommandExecute(object p) => true;
        private void OnCloseAppCommandExecuted(object p) 
        {
            Application.Current.Shutdown();
        }
        #endregion
        #region ClickScreamCommand
        public ICommand ClickScreamCommand { get; }
        private bool CanClickScreamCommandExecute(object p) => true;
        private void OnClickScreamCommandExecuted(object p)
        {
            if (ScreamNum<11) ScreamNum += 1;
        }
        #endregion



        #endregion


        public MainWindowVM()
        {
            #region Комманды
            CloseAppCommand = new RelateC(OnCloseAppCommandExecuted, CanCloseAppCommandExecute);

            #endregion
        }

    }
}
