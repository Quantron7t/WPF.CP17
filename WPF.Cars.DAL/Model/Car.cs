using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF.Cars.DAL.Model
{
    public class Car
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public int Price { get; set; }
        public Country Country { get; set; }
        public string Type { get; set; }
    }
}
