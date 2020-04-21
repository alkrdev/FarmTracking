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
        public IEnumerable<ActiveMachine> Get() =>
            _libraryInterface.GetAllActiveMachines()
                             .OrderBy(x => x.TimeLeft);

        [HttpPost]
        public void Post (Machine machine)
        {
            _libraryInterface.CreateMachine(machine);
            _libraryInterface.Commit();
        }

        // Start Machine
        // Show All Machines

    }
}
