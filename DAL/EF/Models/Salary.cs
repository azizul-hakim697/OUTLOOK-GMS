using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Salary
    {
        public int Id { get; set; }

        //[Required]
        //public int EmployeeId { get; set; }
        //public Employee Employee { get; set; }

        
        [Required(ErrorMessage = "Amount is required")]
        public decimal Amount { get; set; }
      
        public decimal Bonus { get; set; }

        
        public decimal Allowance { get; set; }


        [Required] 
        public decimal Tax { get; set; }


        [Required(ErrorMessage = "Date is required")]
        public DateTime PaymentDate { get; set; }


        [Required(ErrorMessage = "Status is required")]
        public string Status { get; set; }

        public decimal Net { get; set; }


    }
}
