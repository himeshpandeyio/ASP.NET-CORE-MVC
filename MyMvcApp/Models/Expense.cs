using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace MyMvcApp.Models
{
    public class Expense
    {
        public int ID {get; set;}
        [Required]
        public string Description {get; set;} = null!;
        [Required]
        [Range (0.01, double.MaxValue, ErrorMessage = "Amount needs to be higher than zero")]
        public double Amount {get; set;}
        [Required]
        public string Category {get; set;} = null!;
        public DateTime Date {get; set;} = DateTime.Now;
    }
}