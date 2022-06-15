using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

using Microsoft.EntityFrameworkCore;
using ProjectAlta.Data;
using ProjectAlta.DBContext;
using ProjectAlta.Entity;
using ProjectAlta.Respository;
namespace ProjectAlta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentController : ControllerBase
    {
        private IEDocumentRespository _DocRespo;
        public DocumentController(Context context)
        {
            _DocRespo = new DocumentRespository(context);
        }
        [HttpGet]
        public async Task<ActionResult<List<Document>>> getallDoc()
        {
            var model = _DocRespo.GetAll();
            if (model == null)
            {
                return new List<Document>();
            }
            return model.ToList();
        }
        [HttpPost]
        public async void AddDoc(Document model)
        {
            if (ModelState.IsValid)
            {
                _DocRespo.Insert(model);
                _DocRespo.Save();

            }

        }
    }
}
