using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Domain
{
    public class User
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public DateTime ModifiedOn { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        public ICollection<Task> Tasks { get; set; }



    }
}
