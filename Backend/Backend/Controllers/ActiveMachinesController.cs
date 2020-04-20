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
        private readonly ILogger<ActiveMachinesController> _logger;

        public ActiveMachinesController(ILogger<ActiveMachinesController> logger) {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<ActiveMachine> Get() {
            LibraryContext con = new LibraryContext();
            return con.ActiveMachines;
        }
    }
}
