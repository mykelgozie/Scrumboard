using Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using serviceslibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sampleTodo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartegoryController : ControllerBase
    {
        private ICartegoryRepository _cartegoryRepo;

        public CartegoryController(ICartegoryRepository cartegoryRepo)
        {
            _cartegoryRepo = cartegoryRepo;
        }

        [HttpGet]
        public async Task<IActionResult> FetchCartegoryAsync()
        {

         var allCart = await _cartegoryRepo.FetchAllCart();
          var allCartList = new List<CartegoryDto>();

            foreach (var item in allCart)
            {
                var cart = new CartegoryDto() { Id = item.Id, Cartegory = item.Name };
                allCartList.Add(cart);

            }
          return Ok(allCartList);
        }
    }
}
