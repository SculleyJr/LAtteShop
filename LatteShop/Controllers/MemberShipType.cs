using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LatteShop.Controllers
{
    public class MemberShipType
    {
        public byte Id { get; set; }    
        public int SingUpFee  { get; set; }
        public byte DurationInMonths { get; set; } 
        public byte DiscountRate { get; set; }

    }
}