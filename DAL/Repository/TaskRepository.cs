using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Text;
using DAL.Database;
using Shared.DTO;
using DAL.Domain;
using System.Threading.Tasks;
using DAL.Interfaces;

namespace DAL.Repository
{
    public class TaskRepository:ITaskRepository
    {
        public DatabaseContext DatabaseContext { get; set; }
        public IDatabaseAutomapperConfiguration DatabaseAutomapperConfiguration { get; set; }
        public TaskRepository(DatabaseContext databaseContext,IDatabaseAutomapperConfiguration databaseAutomapperConfiguration)
        {
            DatabaseContext = databaseContext;
            //DatabaseAutomapperConfiguration = new DatabaseAutomapperConfiguration();
            DatabaseAutomapperConfiguration = databaseAutomapperConfiguration;
        }

        public void Add(TaskDTO taskDTO)
        {
            Domain.Task task = DatabaseAutomapperConfiguration.TaskDTOToTask(taskDTO);
            task.CreatedOn = DateTime.Now;
            task.ModifiedOn = DateTime.Now;

            DatabaseContext.Tasks.Add(task);
            DatabaseContext.SaveChanges();
            return;
            
        }

        public void delete(TaskDTO taskDTO)
        {
            Domain.Task task = DatabaseAutomapperConfiguration.TaskDTOToTask(taskDTO);
            DatabaseContext.Tasks.Remove(task);
            DatabaseContext.SaveChanges();
            return;
        }

        //public List<TaskDTO> List()
        //{

        //}

        public TaskDTO GetById(int id)
        {
            Domain.Task task = this.DatabaseContext.Tasks.Find(id);
            TaskDTO taskDTO = DatabaseAutomapperConfiguration.TaskToTaskDTO(task);
            return taskDTO;
        }

        public void Update(TaskDTO taskDTO)
        {
            Domain.Task task = DatabaseAutomapperConfiguration.TaskDTOToTask(taskDTO);
            DatabaseContext.Tasks.Update(task);
            DatabaseContext.SaveChanges();
            return;
        }

        public List<TaskDTO> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
