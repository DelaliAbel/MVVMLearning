using MVVMLearning.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MVVMLearning.Repositories
{
    public class BaseRepository
    {

        //Le Events Handler represente le méthode qui gèrent un evenenement qui fourni des données.
        public event EventHandler<RepositoryEventArg> AddItemEventHandler;
        public event EventHandler<RepositoryEventArg> RemoveItemEventHandler;
        public ObservableCollection<BaseModel> _items;

        #region Properties
        public ObservableCollection<BaseModel> Items
        {
            get
            {
                if (_items == null)
                    return _items = new ObservableCollection<BaseModel>();

                return _items;
            }
            set { _items = value; }
        }

        #endregion

        #region Constructor
        public BaseRepository()
        {

        }

        #endregion

        #region Methods
        public void AddItem(BaseModel i_item)
        {
            Items.Add(i_item);
            AddItemEventHandler.Invoke(this, new RepositoryEventArg(i_item));
        }
        #endregion


    }
}
