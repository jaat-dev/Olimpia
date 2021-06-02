using Facturas.Models;
using System;
using System.Collections.Generic;

namespace Facturas.Data
{
    public static class ListadoFacturas
    {
        public static List<FacturaModel> ListFacturas()
        {
            return new List<FacturaModel>
            {
                new FacturaModel
                {
                    Id = 1,
                    Nit = 123456789,
                    Descripcion = "Factura Uno",
                    ValorTotal = new Random().Next(1000000, 9000000),
                    Porcentaje = new Random().Next(0, 100)
                },
                new FacturaModel
                {
                    Id = 2,
                    Nit = 234567891,
                    Descripcion = "Factura Dos",
                    ValorTotal = new Random().Next(1000000, 9000000),
                    Porcentaje = new Random().Next(0, 100)
                },
                new FacturaModel
                {
                    Id = 3,
                    Nit = 345678912,
                    Descripcion = "Factura Tres",
                    ValorTotal = new Random().Next(1000000, 9000000),
                    Porcentaje = new Random().Next(0, 100)
                },
                new FacturaModel
                {
                    Id = 4,
                    Nit = 456789123,
                    Descripcion = "Factura Cuatro",
                    ValorTotal = new Random().Next(1000000, 9000000),
                    Porcentaje = new Random().Next(0, 100)
                },
                new FacturaModel
                {
                    Id = 5,
                    Nit = 567891234,
                    Descripcion = "Factura Cinco",
                    ValorTotal = new Random().Next(1000000, 9000000),
                    Porcentaje = new Random().Next(0, 100)
                },
                new FacturaModel
                {
                    Id = 1,
                    Nit = 678912345,
                    Descripcion = "Factura Seis",
                    ValorTotal = new Random().Next(1000000, 9000000),
                    Porcentaje = new Random().Next(0, 100)
                },
                new FacturaModel
                {
                    Id = 7,
                    Nit = 789123456,
                    Descripcion = "Factura Siete",
                    ValorTotal = new Random().Next(1000000, 9000000),
                    Porcentaje = new Random().Next(0, 100)
                },
                new FacturaModel
                {
                    Id = 8,
                    Nit = 891234567,
                    Descripcion = "Factura Ocho",
                    ValorTotal = new Random().Next(1000000, 9000000),
                    Porcentaje = new Random().Next(0, 100)
                },
                new FacturaModel
                {
                    Id = 9,
                    Nit = 912345678,
                    Descripcion = "Factura Nueve",
                    ValorTotal = new Random().Next(1000000, 9000000),
                    Porcentaje = new Random().Next(0, 100)
                },
                new FacturaModel
                {
                    Id = 10,
                    Nit = 101234567,
                    Descripcion = "Factura Uno",
                    ValorTotal = new Random().Next(1000000, 9000000),
                    Porcentaje = new Random().Next(0, 100)
                },
                new FacturaModel
                {
                    Id = 11,
                    Nit = 101234589,
                    Descripcion = "Factura Diez",
                    ValorTotal = new Random().Next(1000000, 9000000),
                    Porcentaje = new Random().Next(0, 100)
                },
                new FacturaModel
                {
                    Id = 12,
                    Nit = 101456789,
                    Descripcion = "Factura Once",
                    ValorTotal = new Random().Next(1000000, 9000000),
                    Porcentaje = new Random().Next(0, 100)
                }
            };
        }
    }
}
