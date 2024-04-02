using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PracticaMVC2.Models;

namespace PracticaMVC2.Controllers
{
    public class EquiposController : Controller
    {
        private readonly EquiposContext _equiposContexto;

        public EquiposController(EquiposContext equiposContexto)
        {
            _equiposContexto = equiposContexto;
        }

        public IActionResult Index()
        {
            var listaDeMarcas = (from m in _equiposContexto.Marcas
                                 select m).ToList();

            ViewData["listaDeMarcas"] = new SelectList(listaDeMarcas, "IdMarcas", "NombreMarca");



            var listaDeEstadosEquipo = (from m in _equiposContexto.EstadosEquipos
                                        select m).ToList();

            ViewData["listadoDeEstadosEquipos"] = new SelectList(listaDeEstadosEquipo, "IdEstadosEquipo", "Descripcion");



            var listaDeTipos = (from m in _equiposContexto.TipoEquipos
                                select m).ToList();

            ViewData["listadoDeTipos"] = new SelectList(listaDeTipos, "IdTipoEquipo", "Descripcion");


            var listadoDeEquipos = (from e in _equiposContexto.Equipos
                                    join m in _equiposContexto.Marcas on e.MarcaId equals m.IdMarcas
                                    select new
                                    {
                                        nombre = e.Nombre,
                                        descripcion = e.Descripcion,
                                        marca_id = e.MarcaId,
                                        marca_nombre = m.NombreMarca
                                    }).ToList();
            ViewData["listadoEquipo"] = listadoDeEquipos;
        

            return View();
        }

       


        public IActionResult CrearEquipos(Equipo nuevoEquipo)
        {
            _equiposContexto.Add(nuevoEquipo);
            _equiposContexto.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
