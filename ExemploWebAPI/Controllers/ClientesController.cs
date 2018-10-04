using ExemploWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ExemploWebAPI.Controllers
{
    public class ClientesController : ApiController
    {
        private static List<Cliente> clientes = new List<Cliente>();

        //[HttpGet] - Nesse caso nao é necessario, pois o nome do método é o mesmo do 'verbo'.
        public List<Cliente> Get()
        {
            return clientes;
        }

        public void Post(string nome)
        {
            if (!String.IsNullOrEmpty(nome))
            {
                clientes.Add(new Cliente(nome));
            }
        }

        public void Delete(string nome)
        {
            clientes.RemoveAt(clientes.IndexOf(clientes.First(x => x.Nome.Equals(nome))));
        }
    }
}
