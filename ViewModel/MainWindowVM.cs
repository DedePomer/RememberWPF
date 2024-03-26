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
        private Visibility _visibilityImg = Visibility.Collapsed; // Видимость картинки
        public Visibility VisibilityImg
        {
            get { return _visibilityImg; }
            set => Set(ref _visibilityImg, value);
        }
        private int _screamNum = 0;  // Счётчик         
        public int ScreamNum
        { 
            get { return _screamNum; }
            set => Set(ref _screamNum, value);
        }




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
            if (ScreamNum < 10)
            { 
                ScreamNum += 1;
                VisibilityImg = Visibility.Collapsed;
            }
            else
            {
                VisibilityImg = Visibility.Visible;
                ScreamNum = -1;                     
            }       
        }
        #endregion

        public MainWindowVM()
        {

            CloseAppCommand = new RelateC(OnCloseAppCommandExecuted, CanCloseAppCommandExecute);
            ClickScreamCommand = new RelateC(OnClickScreamCommandExecuted, CanClickScreamCommandExecute);
        }




    }
}
