using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PrograVISem1.Models;

namespace PrograVISem1.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(string usuario, string password)
        {
          try {
                using (PrograVIEntities db = new PrograVIEntities()) {
                    /* var lista = from u in db.user
                                where u.usuario == usuario && u.password == password
                                 && u.activo == "A"
                                select u;*/

                    var lista = db.getuserBylogin(usuario, password).ToList();
                    if (lista.Count() > 0)
                    {
                        var myUser = lista.First();
                        Session["Usuario"] = myUser.usuario;
                        return Content("ok");
                    }
                    else
                        return Content("usuario invalido");
                }
                
            }
            catch(Exception ex)
            {
                return Content("Ocurrió un error :" + ex.Message);
            }
        }
    }
}