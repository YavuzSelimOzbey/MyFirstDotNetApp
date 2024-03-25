using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstDotNetApp
{
    public class Product
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public DateTime OlusturulmaZamani { get; set; }
        public DateTime? SilinmeZamani { get; set; }
        public bool SilindiMi { get; set; }
    }
}
