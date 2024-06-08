using JOBZONE.Models;
using JOBZONE.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace JOBZONE.Services
{
    public class CertificateService : ICertificateService
    {
        private readonly DbJobZoneContext _context;
        private readonly UserManager<UserModel> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CertificateService(DbJobZoneContext context, UserManager<UserModel> userManager, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
        }

        public int Add(CertificateModel cm)
        {
            var userId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _context.Users.Include(b => b.Certificates).Where(x => x.Id == userId).First();
            user.Certificates.Add(cm);
            return _context.SaveChanges();
        }

        public int Delete(int Id)
        {
            _context.Certificates.Remove(GetById(Id));
            return _context.SaveChanges();
        }

        public int Edit(CertificateModel cm)
        {
            _context.Update(cm);
            return _context.SaveChanges();
        }

        public List<CertificateModel> GetAll()
        {
            var userId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            return _context.Certificates.Where(x => x.UserModel.Id == userId).ToList();
        }

        public CertificateModel GetById(int id)
        {
            return _context.Certificates.Where(x => x.ID == id).First();
        }
    }
}
