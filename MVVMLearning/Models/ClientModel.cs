using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMLearning.Models
{
    public class ClientModel : BaseModel
    {
        public string ClientAge { get; set; }
        public string ClientAdresse { get; set; }
        public string ClientNationalite { get; set; }
        public string ClientNumber { get; set; }
        public string ClientMail { get; set; }

        public ClientModel()
        {

        }

        public ClientModel(string clientAge, string clientAdresse, string clientNationalité, string clientNumber, string clientMail)
        {
            ClientAge = clientAge;
            ClientAdresse = clientAdresse;
            ClientNationalite = clientNationalité;
            ClientNumber = clientNumber;
            ClientMail = clientMail;
        }
    }
}
