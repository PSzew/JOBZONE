using Microsoft.AspNetCore.Mvc;
using JOBZONE.Models;
using JOBZONE.Services;
using JOBZONE.Services.Interfaces;
namespace JOBZONE.Controllers
{
    [AdminAuthorize]
    public class AdminController : Controller
    {
        private readonly ICompanySerivce _companyService;
        public AdminController(ICompanySerivce companyService)
        {
            _companyService = companyService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ManageCompanies()
        {
            return View(_companyService.GetAll());
        }
        public IActionResult AddCompany()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCompany(CompanyModel userData)
        {
            if(!ModelState.IsValid)
                return View(userData);
            else
            {
                _companyService.Add(userData);
                return RedirectToAction("ManageCompanies");
            }
                    
        }

        [HttpGet]
        public IActionResult EditCompany(string id)
        {            
            return View(_companyService.GetById(int.Parse(id)));
        }

        [HttpPost]
        public IActionResult EditCompany(CompanyModel userData)
        {
            if(!ModelState.IsValid)
                return View(userData);
            else
            {
                _companyService.Edit(userData);
                return RedirectToAction("ManageCompanies");
            }
            
        }
        public IActionResult DeleteCompany(string id)
        {
            _companyService.Delete(int.Parse(id));
            return RedirectToAction("ManageCompanies");
        }
        public IActionResult ManageOffers()
        {
            return View();
        }
    }
}
