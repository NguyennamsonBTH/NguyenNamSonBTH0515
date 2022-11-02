using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NguyenNamSonBTH515.Data;
using NguyenNamSonBTH515.Models;
using NguyenNamSonBTH515.Models.Process;
using System.Diagnostics;

namespace NguyenNamSonBTH515.Controllers;

public class EmployeeController : Controller
{
    private readonly ILogger<EmployeeController> _logger;

    private ExcelProcess _excelProcess = new ExcelProcess();

    public EmployeeController(ILogger<EmployeeController> logger)
    {
        _logger = logger;
    }
    private readonly ApplicationDbcontext _context;

        public EmployeeController(ApplicationDbcontext context)
        {
            _context = context;
        }
    public async Task<IActionResult> Index()
        {
              return View(await _context.Employee.ToListAsync());
        }

    private bool EmployeeExists(string id)
    {
            return _context.Employee.Any(e => e.EmpID == id);
    }
    public async Task<IActionResult> Upload()
        {
              return View();
        }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Upload(IFormFile file)
        {
            if(file!=null)
            {
                string fileExtension = Path.GetExtension(file.FileName);
                if(fileExtension != ".xls" && fileExtension != "xlsx")
                {
                    ModelState.AddModelError("", "Please choose excel file to upload!:");
                }
                else
                {
                    //rename file when upload to server
                    var fileName = DateTime.Now.ToShortTimeString() + fileExtension;
                    var filePath = Path.Combine(Directory.GetCurrentDirectory() + "./Uploads/Excels", fileName);
                    var fileLocation = new FileInfo(filePath).ToString();
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        // save file to server
                        await file.CopyToAsync(stream);
                    }
                }
            }
              return View();
        }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}