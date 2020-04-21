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
        private readonly ILibraryInterface libraryInterface;

        public ActiveMachinesController(ILibraryInterface libraryInterface)
        {
            this.libraryInterface = libraryInterface;
        }


        [HttpGet]
        public IEnumerable<ActiveMachine> Get() =>
            libraryInterface.GetAllActiveMachines()
                            .OrderBy(x => x.TimeLeft);

        // Start Machine
        // Show All Machines

    }
}
