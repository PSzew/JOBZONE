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
        private readonly IJobOfferService _jobOfferService;
        public AdminController(ICompanySerivce companyService, IJobOfferService jobOfferService)
        {
            _companyService = companyService;
            _jobOfferService = jobOfferService;
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
            CompanyAndOffer CAO = new CompanyAndOffer(_companyService.GetAll(),_jobOfferService.GetAll());
            return View(CAO);
        }

        [HttpGet]
        public IActionResult AddOffer()
        {
            var item = new ExtenndedOffer();
            item.companyList = _companyService.GetAll();
            return View(item);
        }
        [HttpPost]
        public IActionResult AddOffer(ExtenndedOffer userData)
        {
            if (!ModelState.IsValid)
            {
                userData.companyList = _companyService.GetAll();
                return View(userData);
            }
            else
            {
                int id = int.Parse(userData.JobOffer.CompanyInfo);
                _jobOfferService.Add(userData.JobOffer, id);
                return RedirectToAction("ManageOffers", "Admin");
            }
        }
        public IActionResult DeleteOffer(string id)
        {
            _jobOfferService.Delete(int.Parse(id));
            return RedirectToAction("ManageOffers");
        }
    }
}
