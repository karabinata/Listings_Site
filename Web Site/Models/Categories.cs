using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web_Site.Models
{
    public class Categories
    {
        public int Id { get; set; }

        [StringLength(70)]
        public string Category { get; set; }

        public virtual ICollection<Listings> Listing { get; set; }
    }
}