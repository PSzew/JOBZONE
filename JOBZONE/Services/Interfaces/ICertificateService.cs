using JOBZONE.Models;

namespace JOBZONE.Services.Interfaces
{
    public interface ICertificateService
    {
        public int Add(CertificateModel cm);
        public int Delete(int Id);
        public List<CertificateModel> GetAll();
        public CertificateModel GetById(int id);
        public int Edit(CertificateModel cm);
    }
}
