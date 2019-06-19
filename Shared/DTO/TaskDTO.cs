using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.DTO
{
   public class TaskDTO
    {
        public int ID { get; set; }


        public string TaskDomain { get; set; }


        public DateTime TimeSpent { get; set; }


        public DateTime TaskDate { get; set; }


        public DateTime ExpectedTime { get; set; }


        public string UserStory { get; set; }


        public DateTime ModifiedOn { get; set; }


        public DateTime CreatedOn { get; set; }

        public int UserID { get; set; }
    }
}
