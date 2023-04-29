using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using P2_2020PM606_2020TD601.Models;

namespace P2_2020PM606_2020TD601.Controllers
{
    public class casosReportadosController : Controller
    {
        public readonly covid2023DbContext _covid2023DbContext;

        public casosReportadosController(covid2023DbContext covid2023DbContext)
        {
            _covid2023DbContext = covid2023DbContext;
        }

        public IActionResult Index()
        {
            var listadoDepartamento = (from d in _covid2023DbContext.departamentos select d).ToList();
            var listadoGeneros = (from g in _covid2023DbContext.generos select g).ToList();
            ViewData["listadoDepartamento"] = new SelectList(listadoDepartamento, "id_departamento", "nombre");
            ViewData["listadoGeneros"] = new SelectList(listadoGeneros, "id_genero", "genero");


            var listadocasos = (from c in _covid2023DbContext.casosReportados
                                join d in _covid2023DbContext.departamentos on c.id_departamento equals d.id_departamento
                                join g in _covid2023DbContext.generos on c.id_genero equals g.id_genero
                                select new
                                {
                                    idcaso = c.id_caso,
                                    departamento = d.nombre,
                                    genero = g.genero,
                                    confirmados = c.confirmados,
                                    recuperados = c.recuperados,
                                    fallecidos = c.fallecidos
                                }).ToList();

            ViewData["ListaCasos"] = listadocasos;

            return View();
        }

        [HttpPost]
        [Route("Add")]
        public IActionResult CrearCasos(casosReportados nuevoCaso)
        {
            _covid2023DbContext.Add(nuevoCaso);
            _covid2023DbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
