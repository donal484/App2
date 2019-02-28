using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarcenterWeb.Models;

namespace CarcenterWeb.Controllers
{
    public class AccesoController : Controller
    {
        // GET: Acceso
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Enter(int user, String pwd)
        {




            try
            {
                using (carcenterEntities db = new carcenterEntities())
                {
                    var lstPersonas = from p in db.PERSONAS where p.IDENTIFICACION == user && p.CONTRASENA == pwd select p; //LINQ

                    if (lstPersonas.Count() > 0)
                    {
                        PERSONAS oPersona = lstPersonas.First();
                        Session["User"] = oPersona;
                        return Content("1");
                    }
                    else
                    {
                        return Content("Usuario o Contraseña incorrecta");

                    }

                }

            }
            catch (Exception ex)
            {
                return Content("Error:" + ex.Message);
            }
        }
    }
}