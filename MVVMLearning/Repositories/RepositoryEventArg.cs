using MVVMLearning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMLearning.Repositories
{
    public class RepositoryEventArg : EventArgs
    {
        public BaseModel Items { get; set; }

        public RepositoryEventArg(BaseModel items)
        {
            Items = items;
        }
    }
}
