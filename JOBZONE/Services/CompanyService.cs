using JOBZONE.Models;
using JOBZONE.Services.Interfaces;

namespace JOBZONE.Services
{
    public class CompanyService : ICompanySerivce
    {
        private readonly DbJobZoneContext _context;
        public CompanyService(DbJobZoneContext context)
        {
            _context = context;
        }

        public int Add(CompanyModel cm)
        {
            _context.Add(cm);
            return _context.SaveChanges();
        }

        public int Delete(int Id)
        {
            _context.Companies.Remove(GetById(Id));
            return _context.SaveChanges();
        }

        public int Edit(CompanyModel cm)
        {
            _context.Update(cm);
            return _context.SaveChanges();
        }

        public List<CompanyModel> GetAll()
        {
            return _context.Companies.ToList();
        }

        public CompanyModel GetById(int id)
        {
            return _context.Companies.Where(x => x.ID == id).First();
        }
    }
}
