using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.DTO
{
    public class UserDTO
    {

        
        public int ID { get; set; }

        
        public string FirstName { get; set; }

        
        public string LastName { get; set; }

        
        public string Email { get; set; }

        
        public string Password { get; set; }

        
        public DateTime ModifiedOn { get; set; }

        
        public DateTime CreatedOn { get; set; }

        public ICollection<TaskDTO> Tasks { get; set; }


    }
}
