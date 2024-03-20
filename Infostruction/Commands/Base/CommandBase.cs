using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RememberWPF.Infostruction.Commands.Base
{
    internal abstract class CommandBase: ICommand
    {
        public event EventHandler CanExecuteChanged // Выполнятется если поменялось на ложь метод CanExecute
        { 
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public abstract bool CanExecute(object? parameter); // Ложь - команду выполнить нельзя; Истина - можно (может включать и выключать работу определённых элементов

        public abstract void Execute(object? parameter); //Логика комманды
   
    }
}
