using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace tespostgress.Controllers
{
    public class PromocionController : Controller
    {
        private readonly IDBContex _datacontext;
        public PromocionController(IDBContex datacontext) {

            _datacontext = datacontext;
        }
        

        public IActionResult Index()
        {
            Bussines.Promocion.Todas(_datacontext as DBContext);
            return View();
        }
        public IActionResult New() {

            return View(); //regresa el formulario para que se llene
        }

        public IActionResult Create(Bussines.PromocionBase acrear) {

          

            return View();

        }


    }
}