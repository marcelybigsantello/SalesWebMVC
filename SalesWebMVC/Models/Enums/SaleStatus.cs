using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Models.Enums
{
    public enum SaleStatus : int
    {
        pending = 0,
        billed = 1, 
        canceled = 2
    }
}
