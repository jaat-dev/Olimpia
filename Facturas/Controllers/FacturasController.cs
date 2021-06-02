using Facturas.Data;
using Facturas.Models;
using Facturas.Utils;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Facturas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturasController : ControllerBase
    {
        [HttpGet]
        [Route("Todas")]
        public IActionResult Get()
        {
            List<ErrorModel> listErrors = new List<ErrorModel>();
            List<FacturaModel> facturas = ListadoFacturas.ListFacturas();
            decimal totalFacturas = 0;
            foreach (FacturaModel factura in facturas)
            {
                totalFacturas += factura.ValorTotal;

                List<ValidationResult> listValidations = ValidarFacturaModel(factura);
                if (listValidations.Any())
                {
                    foreach (var validation in listValidations)
                    {
                        listErrors.Add(new ErrorModel
                        {
                            FacturaId = factura.Id,
                            Message = validation.ErrorMessage.ToString()
                        });
                    }

                }

                int cantidadId = facturas.FindAll(f => f.Id == factura.Id).Count();
                if (cantidadId > 1)
                {
                    listErrors.Add(new ErrorModel
                    {
                        FacturaId = factura.Id,
                        Message = "Esta factura se encuentra mas de una vez"
                    });
                }
            }

            if (listErrors.Any())
            {
                return BadRequest(listErrors);
            }

            return Ok(new ResultModel { Total = totalFacturas});
        }

        [HttpGet]
        [Route("ValidarManual/{id}")]
        public IActionResult ValidarFacturaManual(int id)
        {
            List<ErrorModel> listErrors = new List<ErrorModel>();
            List<FacturaModel> facturas = ListadoFacturas.ListFacturas();
            FacturaModel factura = facturas.Find(f => f.Id == id);
            List<ValidationResult> listValidations = ValidarFacturaModel(factura);
            if (listValidations.Any())
            {
                foreach (var validation in listValidations)
                {
                    listErrors.Add(new ErrorModel
                    {
                        FacturaId = factura.Id,
                        Message = validation.ErrorMessage.ToString()
                    });
                }

            }

            if (listErrors.Any())
            {
                return BadRequest(listErrors);
            }

            return Ok(factura);

        }

        [HttpPost]
        [Route("Validar")]
        public IActionResult ValidarFactura([FromBody] FacturaModel factura)
        {
            return Ok(factura);
        }

        [HttpPost]
        [Route("CalcularIva")]
        public IActionResult CalcularIva([FromBody] FacturaModel factura)
        {
            decimal totalIva = factura.ValorTotal * (factura.Porcentaje / Convert.ToDecimal(100));
            return Ok(new ResultModel { Total = totalIva });
        }

        private List<ValidationResult> ValidarFacturaModel(FacturaModel factura)
        {
            FacturaModel model = new FacturaModel
            {
                Id = factura.Id,
                Nit = factura.Nit,
                Descripcion = factura.Descripcion,
                ValorTotal = factura.ValorTotal,
                Porcentaje = factura.Porcentaje
            };

            return Extensions.ValidateModel(model);
        }
    }
}
