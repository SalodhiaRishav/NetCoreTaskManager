using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Domain
{
    public class Task
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public string TaskDomain { get; set; }

        [Required]
        public int TimeSpent { get; set; }

        [Required]
        public DateTime TaskDate { get; set; }

        [Required]
        public int ExpectedTime { get; set; }

        [Required]
        public string UserStory { get; set; }

        [Required]
        public DateTime ModifiedOn { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        public int UserID { get; set; }

        public User User { get; set; }

    }
}
