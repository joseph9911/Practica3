using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace salesdb.Model
{
    
    public partial class Employees
    {
        public Employees()
        {
            Sales = new HashSet<Sales>();
        }

        [Key]
        public int EmployeeID { get; set; }

        [Required]
        [StringLength(40)]
        public string FirstName { get; set; }

        [StringLength(40)]
        public string MiddleInitial { get; set; }

        [Required]
        [StringLength(40)]
        public string LastName { get; set; }

        public virtual ICollection<Sales> Sales { get; set; }
    }
}
