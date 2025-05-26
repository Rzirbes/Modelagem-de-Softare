using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIDOJO.Interfaces;
using APIDOJO.Models;
using Microsoft.AspNetCore.Mvc;

namespace APIDOJO.Controllers
{
    public class AutorController : BaseController<Autor, IAutorService>
    {
        public AutorController(IAutorService service) : base(service)
        {
        }
    }
}