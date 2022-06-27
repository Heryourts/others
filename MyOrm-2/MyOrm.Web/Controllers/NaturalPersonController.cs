using Microsoft.AspNetCore.Mvc;

namespace MyOrm.Web.Controllers
{
    public class NaturalPersonController : Controller
    {
        private readonly MyOrmContext _myOrmContext;
        public NaturalPersonController()
        {
            _myOrmContext = new MyOrmContext();
        }


        public IActionResult Index()
        {
            var allNaturalPerson = _myOrmContext.Set<NaturalPerson>().ToList();
            return View(allNaturalPerson);
        }

        public IActionResult ParaFrontEnd()
        {
            var allNaturalPerson = _myOrmContext.Set<NaturalPerson>().ToList();
            return new JsonResult(allNaturalPerson);
        }

    }
}
