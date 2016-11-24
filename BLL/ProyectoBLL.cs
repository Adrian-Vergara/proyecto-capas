using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;

namespace BLL
{
    public class ProyectoBLL
    {
        Respuesta respuesta = new Respuesta();
        Contexto db;

        public Respuesta Insertar(ProyectoDTO proyecto)
        {
            using (db = new Contexto())
            {
                try
                {
                    // preparar el proyecto para guardar
                    Proyecto p = new Proyecto();
                    // p.ProyectoId = proyecto.ProyectoId;
                    p.Nombre = proyecto.Nombre;
                    p.Valor = proyecto.Valor;
                    p.FechaInicio = proyecto.FechaInicio;
                    p.Plazo = proyecto.Plazo;
                    p.Estado = proyecto.Estado;
                    p.ClienteId = proyecto.ClienteId;

                    db.Proyectos.Add(p);

                    // preparar la respuesta
                    respuesta.FilasAfectadas = db.SaveChanges();
                    respuesta.Mensaje = "Se realizó la operación satisfactoriamente";
                    respuesta.Error = false;
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException ex)
                {
                    respuesta.Mensaje = ex.Message;
                    respuesta.FilasAfectadas = 0;
                    respuesta.Error = true;
                }
                catch (Exception ex)
                {
                    respuesta.Mensaje = ex.Message;
                    respuesta.FilasAfectadas = 0;
                    respuesta.Error = true;
                }

                return respuesta;
            }
        }

        public List<ProyectoDTO> GetRecords()
        {
            using (Contexto db = new Contexto())
            {
                return db.Proyectos
                    .Select(t =>
                        new ProyectoDTO
                        {
                            ProyectoId = t.ProyectoId,
                            Nombre = t.Nombre,
                            Valor = t.Valor,
                            FechaInicio = t.FechaInicio,
                            Plazo = t.Plazo,
                            Estado = t.Estado,
                            ClienteId = t.ClienteId
                        }
                    ).ToList();
            }
        }

        public Respuesta PutProyecto(ProyectoDTO proyecto)
        {
            using (Contexto db = new Contexto())
            {
                #region Ejemplo4
                //ejemplo de delete
                //1. Consultamos el registro 2..
                var blogUpdate = db.Proyectos.Find(proyecto.ProyectoId); // Busca por llave primaria
                if (blogUpdate != null)
                {
                    blogUpdate.Nombre = proyecto.Nombre;
                    blogUpdate.Valor = proyecto.Valor;
                    blogUpdate.FechaInicio = proyecto.FechaInicio;
                    blogUpdate.Plazo = proyecto.Plazo;
                    blogUpdate.Estado = proyecto.Estado;
                    blogUpdate.ClienteId = proyecto.ClienteId;

                    Respuesta resp = new Respuesta();
                    resp.Mensaje = "Modificado correctamente";
                    resp.Error = false;
                    resp.FilasAfectadas = db.SaveChanges();
                    return resp;
                }
                else
                {
                    Respuesta resp = new Respuesta();
                    resp.Mensaje = "No se encontro";
                    resp.Error = false;
                    resp.FilasAfectadas = db.SaveChanges();
                    return resp;
                }
                #endregion 
            }
        }


        public Respuesta DeleteProyecto(ProyectoDTO proyecto)
        {
            using (Contexto db = new Contexto())
            {
                #region Ejemplo3
                //ejemplo de delete
                //1. Consultamos el registro 2..
                var blogDelete = db.Proyectos.Find(proyecto.ProyectoId); // Busca por llave primaria
                if (blogDelete != null)
                {
                    Proyecto proyectoDAL = new Proyecto();

                    proyectoDAL.ClienteId = proyecto.ClienteId;
                    proyectoDAL.Nombre = proyecto.Nombre;
                    proyectoDAL.Valor = proyecto.Valor;
                    proyectoDAL.FechaInicio = proyecto.FechaInicio;
                    proyectoDAL.Plazo = proyecto.Plazo;
                    proyectoDAL.Estado = proyecto.Estado;
                    proyectoDAL.ProyectoId = proyecto.ProyectoId;

                    db.Proyectos.Remove(blogDelete);
                    db.SaveChanges();

                    Respuesta resp = new Respuesta();
                    resp.Mensaje = "Eliminado";
                    resp.Error = false;
                    resp.FilasAfectadas = db.SaveChanges();
                    return resp;
                }
                else {
                    Respuesta resp = new Respuesta();
                    resp.Mensaje = "No encontro el registro";
                    resp.Error = false;
                    resp.FilasAfectadas = db.SaveChanges();
                    return resp;
                }
                #endregion 
            }
        }



        

    }
}
