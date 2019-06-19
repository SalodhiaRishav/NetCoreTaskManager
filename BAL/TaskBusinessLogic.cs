using System;
using DAL.Repository;
using Shared.DTO;
using BAL.Interfaces;
using DAL.Interfaces;
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

        public TaskDTO GetById(int id)
        {
            return this.TaskRepository.GetById(id);
        }
    }
}
