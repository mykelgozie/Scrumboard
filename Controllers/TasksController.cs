using Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modelslibrary;
using serviceslibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sampleTodo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private ITaskRepository _task;

        public TasksController(ITaskRepository task)
        {
            _task = task;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTasksAsync()
        {

            var allTask = await _task.FindAllAsync();
            var newAllTask = new List<TaskDto>();

            foreach (var task in allTask)
            {
                var newTask = new TaskDto() { Id = task.Id, Title = task.Title, Cartegory = task.Cartegory.Name, Description = task.Description, Status = task.Status.Name, DueDate = task.DueDate };
                newAllTask.Add(newTask);
            }
            return Ok(newAllTask);

           
        }

         [HttpGet("{id}")]
        public async Task<IActionResult> FindTaskAsync(int id )
        {
            var task = await _task.FindTaskAsync(id);
            var newtask = new TaskDto() { Id = task.Id, Title = task.Title, Cartegory = task.Cartegory.Name, Description = task.Description, Status = task.Status.Name };
            return Ok(task);


        }




        [HttpPost]
        public IActionResult AddTask(AddTaskDto task)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var newTask = new Tasks() { Title = task.Title, Description = task.Description, CartegoryId = task.Cartegory, StatusId = task.Status, DueDate = DateTime.Now };
            _task.AddTask(newTask);

            return Created("Task created", task);



        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> DeleteTaskAsync(int id)
        {
            var task = await _task.FindTaskOne(id);
            if (task != null)
            {

                await _task.DeleteTaskAsync(id);
                return Ok(new { message = "Task deleted" });

            }

            return BadRequest();

          

        }
    }
}
