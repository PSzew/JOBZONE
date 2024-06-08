using JOBZONE.Models;

namespace JOBZONE.Services.Interfaces
{
    public interface ICompanySerivce
    {
        public int Add(CompanyModel cm);
        public int Delete(int Id);
        public int Edit(CompanyModel cm);
        public List<CompanyModel> GetAll();
        public CompanyModel GetById(int id);
    }
}
