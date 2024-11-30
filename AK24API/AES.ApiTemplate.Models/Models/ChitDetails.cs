using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AES.ApiTemplate.Models.Models
{
    public class ChitDetails : BaseEntity
    {
        public string Name { get; set; }
        public int Members { get; set; }
        public double Fixed_discount { get; set; }
        public int Months { get; set; }
        public double EMI { get; set; }
        public double Commission { get; set; }
        public Boolean IsActive { get; set; }
        public int Agent { get; set; }
        public double Amount { get; set; }
        public int Totalchits { get; set; }
        public int id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
