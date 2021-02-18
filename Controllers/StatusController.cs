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
    public class StatusController : ControllerBase
    {
        private IStatusRepository _statusRepo;

        public StatusController(IStatusRepository statusRepos)
        {
            _statusRepo = statusRepos;
        }

        [HttpGet]
        public async Task<IActionResult> FetchStatusAsync()
        {
            var allStatus = await _statusRepo.FetchAllStatusAsync();
            var totalStatus = new List<StatusDto>();
            foreach (var status in allStatus)
            {
                var stats = new StatusDto() { Id = status.Id, Status = status.Name };
                totalStatus.Add(stats);
            }
            return Ok(totalStatus);
        }
    }
}
