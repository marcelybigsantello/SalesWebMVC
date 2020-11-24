using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SalesWebMVC.Models
{
    public class Department
    {
        public int Id { get; set; }
        [Required]
        [StringLength(40, MinimumLength = 5, ErrorMessage = "Department Name size must be between {2} and {1}")]
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department()
        {
        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }

        public float TotalSales(DateTime initial, DateTime final)
        {
            return Sellers.Sum(sellers => sellers.TotalSales(initial, final));
        }
    }
}
