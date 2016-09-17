using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Web_Site.Models
{
    public class Comment
    {
        public Comment()
        {
            this.Date = DateTime.Now;
        }
        [Key]
        public int CommentId { get; set; }
        public int ListingId { get; set; }
        [Required]

        [DataType(DataType.MultilineText)]
        public string Text { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public string AuthorId { get; set; }
        public virtual ApplicationUser Author { get; set; }
        public virtual Listings Listing { get; set; }
    }
}