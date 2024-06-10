namespace JOBZONE.Models
{
    public class CompanyAndOffer
    {
        public List<CompanyModel> Companies { get; set; }
        public List<JobOfferModel> JobOffer { get; set; }

        public CompanyAndOffer(List<CompanyModel> companies, List<JobOfferModel> jobOffer)
        {
            Companies = companies;
            JobOffer = jobOffer;
        }
    }
}
