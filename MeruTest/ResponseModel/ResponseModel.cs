using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeruTest.ResponseModels
{
    public class ResponseModel
    {
        public ResponseModel(string subAreaName, string areaName, string cityName, string customerName, string address)
        {
            SubAreaName = subAreaName;
            AreaName = areaName;
            CityName = cityName;
            CustomerName = customerName;
            Address = address;
        }

        //SubAreaName, AreaName, CityName, CustomerName, Address
        public string SubAreaName { get; set; }
        public string AreaName { get; set; }
        public string CityName { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
    }
}
