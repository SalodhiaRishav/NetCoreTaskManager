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

        List<TaskDTO> GetAll();

        void Delete(int id);

        void Update(TaskDTO taskDTO);

    }
}
