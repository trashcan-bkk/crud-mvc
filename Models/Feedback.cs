using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace crud_mvc.Models
{
   [Table("Feedbacks")]
    public class Feedback
    {
        [Key]
        public int FeedbackId { get; set; }
        public string Message { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public DateTime Date { get; set; }
    }
}