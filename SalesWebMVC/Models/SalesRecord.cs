using System;
using SalesWebMVC.Models.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public float Amount { get; set; }
        public SaleStatus Status { get; set; }

        public SalesRecord()
        {
        }

        public SalesRecord(int id, DateTime date, float amount, SaleStatus status)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
        }
    }
}
