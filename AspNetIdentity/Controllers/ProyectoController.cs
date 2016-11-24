using BLL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AspNetIdentity.Controllers
{
    [RoutePrefix("api/proyectos")]
    public class ProyectoController : ApiController
    {
        [Authorize]
        [Route("")]
        public Respuesta PostProyecto(ProyectoDTO proyectoDTO)
        {
            ProyectoBLL proyecto = new ProyectoBLL();
            return proyecto.Insertar(proyectoDTO);
        }
        [Authorize]
        [Route("")]
        public List<ProyectoDTO> GetProyectos()
        {
            ProyectoBLL proyecto = new ProyectoBLL();
            return proyecto.GetRecords();
        }
        [Authorize]
        [Route("")]
        public Respuesta PutProyecto(ProyectoDTO proyectoDTO)
        {
            ProyectoBLL proyecto = new ProyectoBLL();
            return proyecto.PutProyecto(proyectoDTO);
        }
        [Authorize]
        [Route("")]
        public Respuesta DeleteProyecto(ProyectoDTO proyectoDTO)
        {
            ProyectoBLL proyecto = new ProyectoBLL();
            return proyecto.DeleteProyecto(proyectoDTO);
        }
    }
}
