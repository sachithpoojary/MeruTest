using MeruTest.Models;
using MeruTest.ResponseModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeruTest.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly DBContext _dBContext;

        public CustomerController(DBContext dBContext)
        {
            this._dBContext = dBContext;
        }

        [HttpGet]
        public ActionResult<ResponseModel> Get(string custMob)
        {
            try
            {
                //SubAreaName, AreaName, CityName, CustomerName, Address
                var response = (from cus in _dBContext.Customers
                               join s in _dBContext.SubAreas on cus.SubAreaId equals s.SubAreaId
                               join a in _dBContext.Areas on s.AreaId equals a.AreaId
                               join c in _dBContext.Cities on a.CityId equals c.CityId
                               where cus.CustMobNo == custMob
                               select new ResponseModel(s.SubAreaName, a.AreaName, c.CityName, cus.CustName, cus.Address))
                               .FirstOrDefault();

                return response;
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Database failure");
            }
        }
    }
}
