using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KitapSatisSayfasi.Areas.Admin.Controllers
{
    [Authorize(Roles ="Admin")]//sadece admin olan girebilir demek
    [Area("Admin")]
    public class PanelController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
