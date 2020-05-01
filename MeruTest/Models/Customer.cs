using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MeruTest.Models
{
    public class Customer
    {
        //CustId,CustName,CustMobNo,Address,SubAreaId
        [Key]
        public int CustId { get; set; }
        public string CustName { get; set; }
        public string CustMobNo { get; set; }
        public string Address { get; set; }
        public int SubAreaId { get; set; }
    }
}
