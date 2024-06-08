using JOBZONE.Models;
using JOBZONE.Services;
using JOBZONE.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Transactions;

namespace JOBZONE.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        private readonly IEducationService _educationService;
        private readonly ICertificateService _certificateService;
        
        public UserController(IEducationService educationService,ICertificateService certificateService)
        {
           _educationService = educationService;
            _certificateService = certificateService;
        }

        public IActionResult Index()
        {            
            return View();            
        }
        public IActionResult ModifyEducation()
        {
            return View(_educationService.GetAll());
        }        

        [HttpPost]
        public IActionResult AddEducation(EducationModel userData)
        {
            if(userData.EducationLevel == null)
            {
                ModelState.Clear();
                return View();
            }
            if (userData.EndDate != DateTime.MinValue)
            {
                if (userData.StartDate > userData.EndDate)
                {
                    ModelState.AddModelError("StartDate", "Data rozpoczęcia musi być wcześniejsza niż data zakończenia.");
                }
                
            }
            if (!ModelState.IsValid)
            {
                return View(userData);
            }
            else
            {
                _educationService.Add(userData);
                return RedirectToAction("ModifyEducation");
            }                
        }

        [HttpGet]
        public IActionResult EditEducation(string id)
        {
            if (_educationService.GetById(int.Parse(id)).EndDate == DateTime.MinValue)
                ViewData["isChecked"] = true;            
            return View(_educationService.GetById(int.Parse(id)));
        }
        [HttpPost]
        public IActionResult EditEducation(EducationModel em)
        {
            if(!ModelState.IsValid) 
            {
                return View(em);
            }
            else
            {
                _educationService.Edit(em);
                return RedirectToAction("ModifyEducation");
            }
        }
        [HttpPost]
        public IActionResult Delete(string id)
        {
            _educationService.Delete(int.Parse(id));
            return RedirectToAction("ModifyEducation");
        }

        public IActionResult ModifyCertificate()
        {
            return View(_certificateService.GetAll());
        }

        [HttpPost]
        public IActionResult AddCertificate(CertificateModel cm)
        {
            if (cm.TrainingEndDate == null)
            {
                ModelState.Clear();
                return View();
            }
            if (ModelState.IsValid)
            {                
                _certificateService.Add(cm);
                return RedirectToAction("ModifyCertificate");
            }
            else
            {
                return View(cm);
            }            
        }

        public IActionResult DeleteCertificate(string id)
        {
            _certificateService.Delete(int.Parse(id));
            return RedirectToAction("ModifyCertificate");
        }
        [HttpGet]
        public IActionResult EditCertificate(string id)
        {
            if (_certificateService.GetById(int.Parse(id)).TrainingEndDate == DateTime.MinValue)
                ViewData["isChecked"] = true;
            return View(_certificateService.GetById(int.Parse(id)));
        }
        [HttpPost]
        public IActionResult EditCertificate(CertificateModel cm)
        {
            if (!ModelState.IsValid)
            {
                return View(cm);
            }
            else
            {
                _certificateService.Edit(cm);
                return RedirectToAction("ModifyCertificate");
            }
        }
    }
}
