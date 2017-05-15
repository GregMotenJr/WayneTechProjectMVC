using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WayneTechProjectMVC.Models
{
    public class Reviews
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Rating { get; set; }
        public string Content { get; set; }
        public string Img { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; } 
        public virtual Category Category { get; set; }
    }
}