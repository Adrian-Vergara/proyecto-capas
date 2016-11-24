using Entities;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPTConsola
{
    public class Program
    {
        static void Main(string[] args)
        {
             //7cliente para guardar
            ClienteDTO cliente1 = new ClienteDTO
            {
                Nombre = "Miguel",
                Direccion = "Alamos 1",
                Telefono = "3113298374"
            };

            // guardar el cliente
            ClienteBLL clienteBLL = new ClienteBLL();
            Respuesta respuesta = clienteBLL.Insertar(cliente1);
            Console.WriteLine(respuesta.Mensaje + ", Filas afactadas: " + respuesta.FilasAfectadas);
            Console.ReadKey();

            // ahora una consulta de los datos
            Console.WriteLine("Consulta de datos");
            foreach (var cliente in clienteBLL.GetRecords())
            {
                Console.WriteLine(cliente.Nombre + " " + cliente.Telefono);
            }
            Console.ReadKey();

            //ProyectoDTO proyecto1 = new ProyectoDTO
            //{
            //    Nombre = "Miguel",
            //    Valor = 10000,
            //    FechaInicio = ,
            //    Plazo = "Miguel",
            //    Estado = "Alamos 1",
            //    ClienteId = "3113298374",
            //};
        }
    }
}
