using System;
using System.Collections.Generic;
using System.Text;
using Shared.DTO;

namespace DAL.Interfaces
{
    public interface ITaskRepository
    {
      void Add(TaskDTO taskDTO);


      void Delete(TaskDTO taskDTO);


       List<TaskDTO> GetAll();

        TaskDTO GetById(int id);


        void Update(TaskDTO taskDTO);
       
    }
}
