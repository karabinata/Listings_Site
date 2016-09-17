using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web_Site.Models
{
    public class Towns
    {
        public int Id { get; set; }

        [StringLength(90)]
        public string Town { get; set; }

        public virtual ICollection<Listings> Listing { get; set; }
    }
}