using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MiniCore_Backend.Data;
using MiniCore_Backend.Models;

namespace MiniCore_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GastoController : ControllerBase
    {
        private readonly AppDbContext _context;

        public GastoController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("filtrar")]
        public IActionResult FiltrarGastosPorFecha([FromQuery] DateTime inicio, [FromQuery] DateTime fin)
        {
            var resultado = _context.Departamentos
             .GroupJoin(
                 _context.Gastos.Where(g => g.Fecha >= inicio && g.Fecha <= fin),
                 dept => dept.ID,
                 gasto => gasto.IDDept,
                 (dept, gastos) => new
                 {
                     Departamento = dept.Nombre,
                     Total = gastos.Sum(g => (decimal?)g.Monto) ?? 0 
                 }
             )
             .ToList();


            return Ok(resultado);
        }



        //[HttpGet("verificar")]
        //public IActionResult VerificarDatos()
        //{
        //    var empleados = _context.Empleados.ToList();
        //    var departamentos = _context.Departamentos.ToList();
        //    var gastos = _context.Gastos.ToList();

        //    return Ok(new
        //    {
        //        Empleados = empleados,
        //        Departamentos = departamentos,
        //        Gastos = gastos
        //    });
        //}



        //[HttpPost("empleado")]
        //public IActionResult AddEmpleado([FromBody] Empleado empleado)
        //{
        //    _context.Empleados.Add(empleado);
        //    _context.SaveChanges();
        //    return Ok(empleado);
        //}

        //// POST endpoint to insert a new Departamento
        //[HttpPost("departamento")]
        //public IActionResult AddDepartamento([FromBody] Departamento departamento)
        //{
        //    _context.Departamentos.Add(departamento);
        //    _context.SaveChanges();
        //    return Ok(departamento);
        //}

        //// POST endpoint to insert a new Gasto
        //[HttpPost("gasto")]
        //public IActionResult AddGasto([FromBody] Gasto gasto)
        //{
        //    _context.Gastos.Add(gasto);
        //    _context.SaveChanges();
        //    return Ok(gasto);
        //}
    }


}
