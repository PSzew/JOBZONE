using JOBZONE.Models;

namespace JOBZONE.Services.Interfaces
{
    public interface IEducationService
    {
        public int Add(EducationModel em);
        public int Delete(int Id);
        public List<EducationModel> GetAll();
        public EducationModel GetById(int id);
        public int Edit(EducationModel em);
    }
}
