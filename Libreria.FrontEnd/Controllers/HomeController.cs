using Libreria.FrontEnd.LibreriaService;
using Libreria.FrontEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Libreria.FrontEnd.Controllers
{
    public class HomeController : Controller
    {
        LibreriaService.LibreriaServicioClient libreriaService = new LibreriaService.LibreriaServicioClient();
        /// <summary>
        /// Carga La vista del index, haciendo llamado a l base de datos para la tabla y combobox de editorial
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            List<EditorialModel> Model = new List<EditorialModel>();
            DTOEdiitorialRespuesta Respuesta = new DTOEdiitorialRespuesta();
            EditorialModel editorialModel;
            List<SelectListItem> lst = new List<SelectListItem>();
            Respuesta = libreriaService.ObtenerEditorial();
            if (Respuesta.Resultado.Codigo == EnumsCodigoRespuesta.OK)
            {
                foreach (DTOEditorialCuerpo res in Respuesta.Cuerpo)
                {
                    editorialModel = new EditorialModel();
                    
                    editorialModel.Id = res.Id;
                    editorialModel.Nombre = res.Nombre;
                    editorialModel.Sede = res.Sede;
                    Model.Add(editorialModel);
                    lst.Add(new SelectListItem() { Text = editorialModel.Nombre, Value = editorialModel.Id.ToString() });
                }
                ViewBag.Opciones = lst;
                return View(Model);

            }
            else
            {
                return Content("<script language='javascript' type='text/javascript'>alert('Error.'); window.location = '/Home/Index';</script>");
            }
        }
        /// <summary>
        /// ejecuta el llamado al servicio para enviar datos al agregar libros
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult AgregarLibro(LibroModel model)
        {
            List<LibroModel> Model = new List<LibroModel>();
            DTOResultado Respuesta = new DTOResultado();
            DTOLibroCuerpo libro = new DTOLibroCuerpo();

            libro.Npaginas = model.Npaginas;
            libro.Sinopsis = model.Sinopsis;
            libro.Titulo = model.Titulo;
            libro.EditorialesId = model.EditorialesId;

            Respuesta = libreriaService.AgregarLibro(libro);
            if (Respuesta.Codigo == EnumsCodigoRespuesta.OK)
            {

                return Content("<script language='javascript' type='text/javascript'>alert('Saved'); window.location = '/Home/Index';</script>");
            }
            else
            {
                return Content("<script language='javascript' type='text/javascript'>alert('Error.'); window.location = '/Home/Index';</script>");
            }

        }
        /// <summary>
        /// Retorna la pagina principal de crear editorial.
        /// </summary>
        /// <returns></returns>
        public ActionResult CrearEditorialView()
        {
            return View();
        }

        public ActionResult AgregarEditorial(EditorialModel model)
        {
            List<EditorialModel> Model = new List<EditorialModel>();
            DTOResultado Respuesta = new DTOResultado();
            DTOEditorialCuerpo editorial = new DTOEditorialCuerpo();

            editorial.Nombre = model.Nombre;
            editorial.Sede = model.Sede;

            Respuesta = libreriaService.AgregarEditorial(editorial);
            if (Respuesta.Codigo == EnumsCodigoRespuesta.OK)
            {

                return Content("<script language='javascript' type='text/javascript'>alert('Saved'); window.location = '/Home/Index';</script>");
            }
            else
            {
                return Content("<script language='javascript' type='text/javascript'>alert('Error.'); window.location = '/Home/Index';</script>");
            }

        }
        /// <summary>
        /// Retiorna la accion de crear libro, por defecto carga el combo box de editorial.
        /// </summary>
        /// <returns></returns>
        public ActionResult CrearLibroView()
        {
            List<EditorialModel> Model = new List<EditorialModel>();
            DTOEdiitorialRespuesta Respuesta = new DTOEdiitorialRespuesta();
            EditorialModel editorialModel;
            List<SelectListItem> lst = new List<SelectListItem>();
            Respuesta = libreriaService.ObtenerEditorial();
            if (Respuesta.Resultado.Codigo == EnumsCodigoRespuesta.OK)
            {
                foreach (DTOEditorialCuerpo res in Respuesta.Cuerpo)
                {
                    editorialModel = new EditorialModel();

                    editorialModel.Id = res.Id;
                    editorialModel.Nombre = res.Nombre;
                    lst.Add(new SelectListItem() { Text = editorialModel.Nombre, Value = editorialModel.Id.ToString() });
                }
                ViewBag.Opciones = lst;
                return View();

            }
            else
            {
                return Content("<script language='javascript' type='text/javascript'>alert('Error.'); window.location = '/Home/Index';</script>");
            }
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}