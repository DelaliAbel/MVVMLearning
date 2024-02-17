using MVVMLearning.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMLearning.Repositories
{
    public class ClientRepository : BaseRepository
    {
        
        public ClientRepository()
        {
            base.Items = LoadClientData();
        }

        public ObservableCollection<BaseModel> LoadClientData()
        {
            ObservableCollection<BaseModel> clients = new ObservableCollection<BaseModel>(){
                new ClientModel() { Id="1", Name="John", Description="Developpeur de formation", ClientAge="25 ans", ClientAdresse="Rue Balafon", ClientNationalite="Nigerienne", ClientMail="John@Gmail.com", ClientNumber="153654321555" },
                new ClientModel() { Id = "2", Name = "John", Description = "Developpeur de formation", ClientAge = "25 ans", ClientAdresse = "Rue Balafon", ClientNationalite = "Nigerienne", ClientMail = "John@Gmail.com", ClientNumber = "153654321555" },
                new ClientModel() { Id = "3", Name = "John", Description = "Developpeur de formation", ClientAge = "25 ans", ClientAdresse = "Rue Balafon", ClientNationalite = "Nigerienne", ClientMail = "John@Gmail.com", ClientNumber = "153654321555" },
                new ClientModel() { Id = "4", Name = "John", Description = "Developpeur de formation", ClientAge = "25 ans", ClientAdresse = "Rue Balafon", ClientNationalite = "Nigerienne", ClientMail = "John@Gmail.com", ClientNumber = "153654321555" },
                new ClientModel() { Id = "5", Name = "John", Description = "Developpeur de formation", ClientAge = "25 ans", ClientAdresse = "Rue Balafon", ClientNationalite = "Nigerienne", ClientMail = "John@Gmail.com", ClientNumber = "153654321555" }
            };

            return clients;
        }
    }
}
