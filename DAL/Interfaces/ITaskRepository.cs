using System;
using System.Collections.Generic;
using System.Text;
using Shared.DTO;

namespace DAL.Interfaces
{
    public interface ITaskRepository
    {
      void Add(TaskDTO taskDTO);


      void Delete(int id);


       List<TaskDTO> GetAll();

        TaskDTO GetById(int id);


        void Update(TaskDTO taskDTO);
       
    }
}
