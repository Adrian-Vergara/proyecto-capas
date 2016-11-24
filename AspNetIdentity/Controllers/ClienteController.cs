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
    [RoutePrefix("api/clientes")]
    public class ClienteController : ApiController
    {
        [Route("")]
        public Respuesta PostCliente(ClienteDTO cliente)
        {
            ClienteBLL clienteBLL = new ClienteBLL();
            return clienteBLL.Insertar(cliente);
        }

        [Route("")]
        public List<ClienteDTO> GetClientes()
        {
            ClienteBLL cliente = new ClienteBLL();
            return cliente.GetRecords();
        }

        [Route("delete")]
        [HttpDelete]
        public async System.Threading.Tasks.Task<Respuesta> Delete(int id)
        {
            ClienteBLL clienteBLL = new ClienteBLL();
            return await clienteBLL.Delete(id);
        }

        [Route("update")]
        public async System.Threading.Tasks.Task<Respuesta> Put(ClienteDTO cliente)
        {
            ClienteBLL clienteBLL = new ClienteBLL();
            return await clienteBLL.Update(cliente);
        }
    }
}
