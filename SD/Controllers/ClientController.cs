using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SD.Models;
using SD.Data;

namespace SD.Controllers
{
    public class ClientController : Controller
    {
        private readonly SDDbContext _context;
        public ClientController(SDDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<ClientModel> clientModels;
            clientModels = _context.ClientModels.ToList();
            return View(clientModels);
        }

        [httpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(ClientModel clientModel)
        {
            _context.Add(clientModel);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
