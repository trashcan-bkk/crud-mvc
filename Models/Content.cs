using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace crud_mvc.Models
{
    [Table("Contents")]
    public class Content
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; } 
        public string CoverImg { get; set; }
        public string Genre { get; set; }
        public string Author { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

    }
}
