using System;
using System.Collections.Generic;
using System.Text;
using Shared.DTO;

namespace BAL.Interfaces
{
   public interface ITaskBusinessLogic
    {
       
        void Add(TaskDTO taskDTO);


        TaskDTO GetById(int id);
       
    }
}
