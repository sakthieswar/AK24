using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AES.ApiTemplate.Models.Models
{
    [Table("product")]
    public class Product : BaseEntity
    {     
        public string name { get; set; }
        public string description { get; set; }
        //public Category? Category { get; set; }
        public int categoryId { get; set; }
        public int subcategoryId { get; set; }
        //public SubCategory SubCategory { get; set; }
        public int inStock { get; set; }
        public Boolean IsActive { get; set; }
        public int id {
            get;   // get method
            set;  // set method
        }
        //public double SellingPrice { get; set; }
        //public double CostPrice { get; set; }
        //public string Specification { get; set; }
        //public string Warrenty { get; set; }
        //public int IsOfferProduct { get; set; }
        //public DateTime OfferFrom { get; set; }
        //public DateTime OfferTo { get; set; }
        //public double OfferPrice { get; set; }
        //public int OfferQuantity { get; set; }
    }

    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
