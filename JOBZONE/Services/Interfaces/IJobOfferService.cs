using JOBZONE.Models;

namespace JOBZONE.Services.Interfaces
{
    public interface IJobOfferService
    {
        public int Add(JobOfferModel offer , int companyID);
        public int Delete(int Id);
        public List<JobOfferModel> GetAll();
        public List<JobOfferModel> GetNewest();
        public JobOfferModel GetById(int id);
        public JobOfferModel Edit(int id);

    }
}
