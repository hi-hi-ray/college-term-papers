using System.Web.Mvc;
using KeepEverything.RaysaDutra.Domain.Interfaces.Repositories;

namespace KeepEverything.RaysaDutra.Presentation.Controllers
{
    [Authorize]
    public class UsersController : Controller
    {
        private readonly IUserRepository _userRepository;

        public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        // GET: Users
        public ActionResult Index()
        {
            return View(_userRepository.GetAll());
        }

        // GET: Users/Details/5
        public ActionResult Details(string id)
        {
            return View(_userRepository.GetById(id));
        }

        public ActionResult RemoveLock(string id)
        {
            _userRepository.RemoveLock(id);
            return RedirectToAction("Index");
        }
    }
}
