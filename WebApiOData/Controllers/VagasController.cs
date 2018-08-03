using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.OData;
using System.Web.Http.OData.Query;
using WebApiOData.Models;

namespace WebApiOData.Controllers
{
    public class VagasController : ApiController
    {
        //Install Microsoft.AspNet.WebApi.OData
        private VagaContext db = new VagaContext();

        // GET: api/Vagas
        // O método que receber esse atributo deve retornar uma coleção do tipo IQueryable.
        //IQueryble, retorna uma coleção de vagas

        //[EnableQuery]  suportar todas as operações do OData.
        
        // limitar as operações suportadas.
        [EnableQuery(AllowedQueryOptions = AllowedQueryOptions.Filter |
                                           AllowedQueryOptions.OrderBy |
                                           AllowedQueryOptions.Select)]
        public IQueryable<Vaga> GetVagas()
        {
            return db.Vagas;
        }

        // GET: api/Vagas/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Vagas
        public void Post(Vaga vaga)
        {
            db.Vagas.Add(vaga);
            db.SaveChanges();
        }

        // PUT: api/Vagas/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Vagas/5
        public void Delete(int id)
        {
        }
    }
}
