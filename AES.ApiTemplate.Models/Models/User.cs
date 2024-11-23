using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AES.ApiTemplate.Models.Models
{
    [Table("user")]
    public class User : BaseEntity
    {
        public int id {get;set;}
        public string name { get; set; }
        public string email { get; set; }
        public string contactno { get; set; }
        public string pasword { get; set; }
        public string address { get; set; }
        public string occupation { get; set; }
        public bool isactive { get; set; }
    }
}
