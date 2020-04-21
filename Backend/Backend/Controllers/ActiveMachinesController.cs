using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BackendLibrary;
using BackendLibrary.Models;

namespace Backend.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class ActiveMachinesController : ControllerBase {
        private readonly ILibraryInterface _libraryInterface;

        public ActiveMachinesController(ILibraryInterface libraryInterface)
        {
            _libraryInterface = libraryInterface;
        }

        // Localhost/ActiveMachines/
        [HttpGet]
        public IOrderedQueryable Get()
        {
            var query = from field in _libraryInterface.GetAllFields()
                        join machine in _libraryInterface.GetAllMachines()
                            on field.ActiveMachine.MachineId equals machine.Id
                        join activemachine in _libraryInterface.GetAllActiveMachines()
                            on machine.Id equals activemachine.MachineId
                        select new { id = activemachine.Id, fieldname = field.Name, machinename = machine.Name, timeleft = activemachine.TimeLeft };



            return query.OrderBy(x => x.timeleft);
        }

        [HttpPost]
        public void Post(Machine machine) {
            _libraryInterface.CreateMachine(machine);
            _libraryInterface.Commit();
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _libraryInterface.DeleteActiveMachine(id);
            _libraryInterface.Commit();
            
        }

        // Start Machine
        // Show All Machines

    }
}
