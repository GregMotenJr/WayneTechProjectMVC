using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WayneTechProjectMVC.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "Category Name")]
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Reviews> Reviews { get; set; }
    }
}