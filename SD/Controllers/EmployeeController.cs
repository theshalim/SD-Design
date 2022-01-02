using Microsoft.AspNetCore.Mvc;
using SD.Data;
using SD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SD.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly SDDbContext _context;

        public EmployeeController(SDDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<EmployeeModel> employeeModels;
            employeeModels = _context.EmployeeModels.ToList();
            return View(employeeModels);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(EmployeeModel employeeModel)
        {
            _context.Add(employeeModel);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
