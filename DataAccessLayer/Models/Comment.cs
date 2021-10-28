using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccessLayer.Models
{
    public class Comment
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Body { get; set; }
        [Required]
        public virtual Game Game { get; set; }
    }
}
