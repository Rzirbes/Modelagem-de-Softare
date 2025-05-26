using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIDOJO.Interfaces;
using APIDOJO.Models;
using Microsoft.AspNetCore.Mvc;



namespace APIDOJO.Controllers
{
    public class LivroController : BaseController<Livro, ILivroService>
    {
        public LivroController(ILivroService service) : base(service)
        {
        }
    }
}