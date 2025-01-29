using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atakankendikendine1.Models
{
    public class Employee
    {

        public int Id { get; set; }

        public string FullName { get; set; }

        public List<EmployeeCar> EmployeeCars { get; set; } // navigation bir çalışan birden fazla araç üzerinde çalışabilir 

    }
}
