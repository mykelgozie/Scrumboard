using Microsoft.EntityFrameworkCore;
using Modelslibrary;
using serviceslibrary.data;
using serviceslibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serviceslibrary.Repositories
{
    public class StatusRepository : IStatusRepository
    {
        private AppDbContext _datacontext;

        public StatusRepository(AppDbContext datacontext)
        {

            _datacontext = datacontext;
        }

        public async Task<IEnumerable<Status>> FetchAllStatusAsync()
        {
           return await _datacontext.Status.ToListAsync();
        }

    }
}
