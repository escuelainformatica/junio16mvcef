using Junio16MVCEF.Models;
using Junio16MVCEF.repo;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Junio16MVCEF.controlador
{
    public class ComentarioController : Controller
    {


        // http://localhost:xxxx/Comentario/Index
        public IActionResult Index()
        {
            return View();
        }

        // http://localhost:51853/Comentario/Comentar
        [HttpGet]
        public IActionResult Comentar()
        {
            var nuevoCom=new Comentario();
            ViewBag.resultado="";
            return View(nuevoCom);
        }

        // http://localhost:51853/Comentario/Comentar
        [HttpPost]
        public IActionResult Comentar(Comentario nuevoCom)
        {
            // Request <-- puedo leer los datos que envia el usuario.
            //string nombre= Request.Form["Nombre"]; // leer los datos por post
            //string nombre2= Request.Query["Nombre"]; // leer los datos por get (por la url)
      
            ComentarioBaseDeDatos.Insertar(nuevoCom);
            ViewBag.resultado="Dato ingresado correctamente";

            // Request <-- los valores que envia el usuario.
            // Response <-- los valores que c# envia al usuario.
            return Redirect("/Comentario/Listar");
   
            //return View(nuevoCom);
        }
        public IActionResult Listar()
        {
            List<Comentario> lista =ComentarioBaseDeDatos.ListarTodo();

            return View(lista);

        }
    }
}
