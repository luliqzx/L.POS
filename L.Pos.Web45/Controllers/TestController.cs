using L.Pos.DataAccess.Common;
using L.Pos.DataAccess.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace L.Pos.Web45.Controllers
{
    public class TestController : Controller
    {
        // GET: Test

        protected IUserRepo UserRepo;
        protected ICurrencyRepo CurrencyRepo;

        public TestController(IUserRepo _UserRepo, ICurrencyRepo _CurrencyRepo)
        {
            UserRepo = _UserRepo;
            CurrencyRepo = _CurrencyRepo;
        }

        public ActionResult Index()
        {
            var a = UserRepo.GetAll();
            var b = CurrencyRepo.GetAll();
            return View();
        }
    }
}