using ESite.Model;
using Microsoft.AspNetCore.Mvc;

namespace ESite.Controllers
{
    public class EsiteController : Controller
    {

        private readonly DBConTextProd _dpprod;

        public EsiteController(DBConTextProd dpprod)
        {
            _dpprod = dpprod;
        }

       
        [HttpPut("EsiteAdd")]
        public IActionResult Index(EsiteHome esiteHome)
        {

            _dpprod.esiteHomes.Add(esiteHome);
            _dpprod.SaveChanges();
  
            return Ok(esiteHome);
        }

        [HttpGet("EsiteShow")]
        public IEnumerable<EsiteHome> GetAll()
        {
            return _dpprod.esiteHomes;
        }
    }
}
