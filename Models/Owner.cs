using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atakankendikendine1.Models
{
    public class Owner
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public List<Car> Cars { get; set; } // navigation peki neden list türünde çünkü bir kişinin birden fazla arabası olabilir
    }
}
