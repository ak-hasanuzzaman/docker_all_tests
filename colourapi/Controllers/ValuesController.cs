using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Transactions;
using ColourAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ColourAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private ColourContext _colourContext;
        public ValuesController(ColourContext colourContext)
        {
            _colourContext = colourContext;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Colour>> GetColourItems()
        {
            return _colourContext.ColourItems;
        }

    }
}
