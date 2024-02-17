using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMLearning.Command
{
    internal class RelayCommand : ICommand
    {
        private Action<object> _execute;
        private Predicate<object> _canExecute;

        public RelayCommand(Action<object> execute, Predicate<object> canExecute)
        {
            if (execute == null)
                throw new NullReferenceException("Execute");

            _execute = execute;
            _canExecute = canExecute;   
        }

        public RelayCommand(Action<object> execute) : this (execute, null)
        {

        }

        public RelayCommand()
        {

        }

        
        //Proprété de gestion d'evenement à déclencher
        //qui a pour get et set, add et remove
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            //Si il est null envoi vrai parce que il n'a rien donné en parametre et on soncidère que l'execution sera faite,
            //en cas de valeur on respect le bool envoyé par la méthode
            return (_canExecute == null) ? true : _canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            _execute.Invoke(parameter);
        }
    }
}
