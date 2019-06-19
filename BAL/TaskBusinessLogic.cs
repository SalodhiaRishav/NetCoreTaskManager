using System;
using DAL.Repository;
using Shared.DTO;
using BAL.Interfaces;
using DAL.Interfaces;
using System.Collections.Generic;

namespace BAL
{
    public class TaskBusinessLogic :ITaskBusinessLogic
    {
        ITaskRepository TaskRepository;
        public TaskBusinessLogic(ITaskRepository taskRepository)
        {
            TaskRepository = taskRepository;
        }

        public void Add(TaskDTO taskDTO)
        {
            this.TaskRepository.Add(taskDTO);
            return;
        }

        public List<TaskDTO> GetAll()
        {
            return this.TaskRepository.GetAll();
        }

        public TaskDTO GetById(int id)
        {
            return this.TaskRepository.GetById(id);
        }

        public void Delete(int id)
        {
            this.TaskRepository.Delete(id);
        }

        public void Update(TaskDTO taskDTO)
        {

            this.TaskRepository.Update(taskDTO);
        }
    }
}
