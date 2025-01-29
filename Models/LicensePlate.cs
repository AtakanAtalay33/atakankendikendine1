using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atakankendikendine1.Models
{
    public  class LicensePlate
    {

        //Primary key
        public int Id { get; set; }

        public string Name { get; set; }

        public Car Car { get; set; }
    }
}
