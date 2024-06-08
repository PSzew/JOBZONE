using JOBZONE.Models;
using JOBZONE.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Claims;
using Microsoft.CodeAnalysis.Differencing;

namespace JOBZONE.Services
{

    public class EducationService : IEducationService
    {
        private readonly DbJobZoneContext _context;
        private readonly UserManager<UserModel> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public EducationService(DbJobZoneContext context,UserManager<UserModel> userManager, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
        }

        public int Add(EducationModel em)
        {
            var userId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _context.Users.Include(b => b.Education).Where(x => x.Id == userId).First();
            user.Education.Add(em);
            return _context.SaveChanges();
        }

        public int Delete(int Id)
        {
            _context.Education.Remove(GetById(Id));
            return _context.SaveChanges();
        }

        public List<EducationModel> GetAll()
        {
            var userId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            return _context.Education.Where(x => x.UserModel.Id == userId).ToList();
        }

        public EducationModel GetById(int id)
        {
            return _context.Education.Where(x => x.ID == id).First();           
        }

        public int Edit(EducationModel model)
        {
            _context.Update(model);
            return _context.SaveChanges();
        }
    }
}
