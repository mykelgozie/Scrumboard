using Modelslibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serviceslibrary.Interfaces
{
    public  interface ITaskRepository
    {
        public Task<IEnumerable<Tasks>> FindAllAsync();

        public Task<Tasks> FindTaskAsync(int id);

        public void AddTask(Tasks task);

        public  Task DeleteTaskAsync(int id);
        public Task<Tasks> FindTaskOne(int id);
    }
}
