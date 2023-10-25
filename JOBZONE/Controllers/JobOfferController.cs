using JOBZONE.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace JOBZONE.Controllers
{
    public class JobOfferController : Controller
    {
        private readonly IJobOfferService _jobOfferServices;
        public JobOfferController(IJobOfferService jobOfferServices)
        {
            _jobOfferServices = jobOfferServices;
        }

        public IActionResult GetNewest()
        {
            var Offers = _jobOfferServices.GetNewest();
            return View(Offers);
        }
    }
}
