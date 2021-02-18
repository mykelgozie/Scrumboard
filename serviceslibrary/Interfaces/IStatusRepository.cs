using Modelslibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serviceslibrary.Interfaces
{
    public  interface IStatusRepository
    {
        public Task<IEnumerable<Status>> FetchAllStatusAsync();

    }
}
