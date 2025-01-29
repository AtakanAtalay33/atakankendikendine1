using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atakankendikendine1.Models
{
    public class EmployeeCar // çoka çok ilişki için
    {
        public int Id { get; set; } // Kendi primary key i

        public int EmployeeId { get; set; } // Dbset<employee>  den gelen foreign key
        public Employee Employee { get; set; } // navigation 

        public int CarId { get; set; } // Dbset<cars> dan gelen foreign key 
        public Car Car { get; set; } // navigation 

        public double WorkingTime { get; set; } // kendi özelliği

    }
}
