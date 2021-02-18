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
    public class CartegoryRepository : ICartegoryRepository
    {
        private readonly AppDbContext _dataContext;

        public CartegoryRepository(AppDbContext dataContext)
        {
            _dataContext = dataContext;

        }

        public async Task<IEnumerable<Cartegory>> FetchAllCart()
        {
          return  await _dataContext.Cartegories.ToListAsync();
        }


    }
}
