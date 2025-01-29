using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atakankendikendine1.Models
{
    public class Car
    {
        public int Id { get; set; }

        public string Color { get; set; }

        public string Brand { get; set; }

        public int? LicensePlateId { get; set; } // foreign key 

        public LicensePlate LicensePlate { get; set; } // navigation 


        public int? OwnerId { get; set; } // foreign key // sahibi olmayan araba olabilir

        public Owner Owner { get; set; } // navigation  bir arabanın birden fazla sahibi olamaz o yüzden tekil 


        public List<EmployeeCar> EmployeeCars { get; set; } // navigation bir araç üzerinde birden fazla çalışan olabilir 
    }
}
