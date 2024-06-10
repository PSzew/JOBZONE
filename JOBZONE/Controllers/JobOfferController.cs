using JOBZONE.Models;
using JOBZONE.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace JOBZONE.Controllers
{
    public class JobOfferController : Controller
    {
        private readonly IJobOfferService _jobOfferServices;
        private readonly ICompanySerivce _companyServices;
        public JobOfferController(IJobOfferService jobOfferServices, ICompanySerivce companyServices)
        {
            _jobOfferServices = jobOfferServices;
            _companyServices = companyServices;
        }

        public IActionResult GetNewest()
        {
            CompanyAndOffer CAO = new CompanyAndOffer(_companyServices.GetAll(),_jobOfferServices.GetNewest());
            return View(CAO);
        }
    }
}
