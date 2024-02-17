using MVVMLearning.BaseNotifyProperty;
using MVVMLearning.Command;
using MVVMLearning.Models;
using MVVMLearning.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Remoting.Proxies;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MVVMLearning.ViewModel
{
    internal class BaseViewModel : BaseOnPropertyChanged
    {

        #region Fields
        public ObservableCollection<BaseModel> _items;
        public ObservableCollection<ObservableCollection<BaseModel>> AllItemsList { get; set; }

        protected RelayCommand _addCommand;
        protected RelayCommand _deleteCommand;
        protected RelayCommand _saveCommand;
        protected RelayCommand _closeCommand;
        protected BaseModel _selectedItem;

        protected UserControl _activeUserControl;

        protected RelayCommand _clientNavCommand;
        protected RelayCommand _productNavCommand;
        private Visibility _formVisibleState;

        #endregion

        #region Properties
        protected ClientView ClientV;
        protected ProductView ProductV;
        private Visibility FormVisibleState
        {
            get { if(_formVisibleState == null)
                    _formVisibleState = Visibility.Collapsed;

                    return _formVisibleState; }
            set { _formVisibleState = value; OnPropertyChanged(); }
        }

        public RelayCommand AddCommand { 
            get {
                if (_deleteCommand == null)
                    _deleteCommand = new RelayCommand(DoExe =>
                    {
                        SelectedItem = new ClientModel();
                        FormVisibleState = Visibility.Visible;
                    });
                return _deleteCommand; }
            set { _saveCommand = value; OnPropertyChanged(); }
        }
        public RelayCommand DeleteCommand { 
            get {
                if (_deleteCommand == null)
                    _deleteCommand = new RelayCommand(DoExe =>
                    {
                        this.Items.Remove(SelectedItem);
                    });
                return _deleteCommand; }
            set { _saveCommand = value; OnPropertyChanged(); }
        }

        public RelayCommand SaveCommand {
            get 
            { if (_saveCommand == null)
                    _saveCommand = new RelayCommand(DoExe =>
                    {
                        Items.Add(SelectedItem);
                        SelectedItem = null;
                    });
                return _saveCommand;
            }
            set { _saveCommand = value; OnPropertyChanged(); }
        }

        public RelayCommand CloseCommand
        {
            get
            {
                if (_closeCommand == null)
                    _closeCommand = new RelayCommand(DoExe => { 
                        FormVisibleState = Visibility.Hidden;
                        MessageBox.Show("Close Command Executed");
                    });
                return _closeCommand;
            }
            set { _addCommand = value; OnPropertyChanged(); }
        }

        public ObservableCollection<BaseModel> Items
        {
            get
            {
                if(_items == null)
                    _items = new ObservableCollection<BaseModel>();
                return _items;
            }
            set
            {
                _items = value; OnPropertyChanged();
            }
        }

        public BaseModel SelectedItem { 
            get { return _selectedItem; } 
            set { _selectedItem = value; OnPropertyChanged(); }
        }

        public UserControl ActiveUserControl
        {
            get { return _activeUserControl; }
            set { _activeUserControl = value; 
                   OnPropertyChanged(); }
        }
        
        public RelayCommand ClientNavCommand
        {
            get {
                if (_clientNavCommand == null)
                    _clientNavCommand = new RelayCommand(DoExe => { ActiveUserControl = ClientV; });
                return _clientNavCommand; }
            set { _clientNavCommand = value; OnPropertyChanged(); }
        }
        
        public RelayCommand ProductNavCommand
        {
            get { if (_productNavCommand == null)
                    _productNavCommand = new RelayCommand(DoExe => { ActiveUserControl = ProductV; MessageBox.Show("Product Navigation commande !");
                    });
                return _productNavCommand;
            }
            set { _productNavCommand = value; OnPropertyChanged(); }
        }
        #endregion

        #region Constructor
        public BaseViewModel()
        {
            ClientV = new ClientView();
            ProductV = new ProductView();
            ActiveUserControl = ClientV;

            //Items.Add(new ClientModel() { Id="1", Name="John", Description="Developpeur de formation", ClientAge="25 ans", ClientAdresse="Rue Balafon", ClientNationalite="Nigerienne", ClientMail="John@Gmail.com", ClientNumber="153654321555" });
            //Items.Add(new ClientModel() { Id = "2", Name = "John", Description = "Developpeur de formation", ClientAge = "25 ans", ClientAdresse = "Rue Balafon", ClientNationalite = "Nigerienne", ClientMail = "John@Gmail.com", ClientNumber = "153654321555" });
            //Items.Add(new ClientModel() { Id = "3", Name = "John", Description = "Developpeur de formation", ClientAge = "25 ans", ClientAdresse = "Rue Balafon", ClientNationalite = "Nigerienne", ClientMail = "John@Gmail.com", ClientNumber = "153654321555" });
            //Items.Add(new ClientModel() { Id = "4", Name = "John", Description = "Developpeur de formation", ClientAge = "25 ans", ClientAdresse = "Rue Balafon", ClientNationalite = "Nigerienne", ClientMail = "John@Gmail.com", ClientNumber = "153654321555" });
            //Items.Add(new ClientModel() { Id = "5", Name = "John", Description = "Developpeur de formation", ClientAge = "25 ans", ClientAdresse = "Rue Balafon", ClientNationalite = "Nigerienne", ClientMail = "John@Gmail.com", ClientNumber = "153654321555" });


        }

        #endregion




    }
}
