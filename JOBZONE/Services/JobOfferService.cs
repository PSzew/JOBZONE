using JOBZONE.Models;
using JOBZONE.Services.Interfaces;

namespace JOBZONE.Services
{
    public class JobOfferService : IJobOfferService
    {
        private readonly DbJobZoneContext _context;

        public JobOfferService(DbJobZoneContext context)
        {
            _context = context;
        }

        public int Add()
        {
            throw new NotImplementedException();
        }

        public int Delete(int ID) 
        {
            throw new NotImplementedException();
        }
        public List<JobOfferModel> GetAll()
        {
            var Offers = _context.JobOffer.ToList();
            return Offers;
        }
        public List<JobOfferModel> GetNewest()
        {
            //var Offers = _context.JobOffer.OrderByDescending(e => e.ID).ToList();
            throw new NotImplementedException();
        }

        public JobOfferModel GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
