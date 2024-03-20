using RememberWPF.Infostruction.Commands.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RememberWPF.Infostruction.Commands
{
    internal class RelateC : CommandBase
    {
        private Action<object> _Execute;
        private Func<object?, bool> _CanExecute;

        public RelateC(Action<object> Execute, Func<object, bool> Canexecute = null) 
        {
            _Execute = Execute ?? throw new ArgumentNullException(nameof(Execute));
            _CanExecute = CanExecute;
        }

        public override bool CanExecute(object? parameter) => _CanExecute?.Invoke(parameter) ?? true;


        public override void Execute(object? parameter)
        {
            _Execute(parameter);
        }
    }
}
