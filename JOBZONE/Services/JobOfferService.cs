using JOBZONE.Models;
using JOBZONE.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace JOBZONE.Services
{
    public class JobOfferService : IJobOfferService
    {
        private readonly DbJobZoneContext _context;

        public JobOfferService(DbJobZoneContext context)
        {
            _context = context;
        }

        public int Add(JobOfferModel offer , int CompanyID)
        {
            var company = _context.Companies.Include(b => b.JobOfferModel).Where(x => x.ID == CompanyID).First();
            company.JobOfferModel.Add(offer);
            return _context.SaveChanges();
        }

        public int Delete(int ID) 
        {
            _context.JobOffer.Remove(GetById(ID));
            return _context.SaveChanges();
        }
        public List<JobOfferModel> GetAll()
        {
            return _context.JobOffer.ToList();
        }
        public List<JobOfferModel> GetNewest()
        {
            var Offers = _context.JobOffer.OrderByDescending(e => e.ID).ToList();
            return Offers;
        }

        public JobOfferModel GetById(int id)
        {
            return _context.JobOffer.Where(x => x.ID == id).First();
        }

        public JobOfferModel Edit(int id)
        {
            throw new NotImplementedException();
        }
    }
}
