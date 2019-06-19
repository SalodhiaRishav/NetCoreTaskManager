using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using DAL.Domain;
using Shared.DTO;
using DAL.Interfaces;

namespace DAL
{
   public class DatabaseAutomapperConfiguration:IDatabaseAutomapperConfiguration
    {
        IMapper Mapper;

        public DatabaseAutomapperConfiguration()
        {
            MapperConfiguration config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<User, UserDTO>().ReverseMap();
              
                cfg.CreateMap<Task, TaskDTO>().ReverseMap();
               
            });
            Mapper = config.CreateMapper();

        }

        public UserDTO UserToUserDTO(User user)
        {
            return Mapper.Map<UserDTO>(user);
        }

        public User UserDTOToUser(UserDTO userDTO)
        {
            return Mapper.Map<User>(userDTO);
        }

        public TaskDTO TaskToTaskDTO(Task task)
        {
            return Mapper.Map<TaskDTO>(task);
        }

        public Task TaskDTOToTask(TaskDTO taskDTO)
        {
            return Mapper.Map<Task>(taskDTO);
        }

        public List<User> UserDTOListToUserList(List<UserDTO> usersDTO)
        {
            return Mapper.Map<List<User>>(usersDTO);
        }

        public List<UserDTO> UserListToUserDTOList(List<User> users)
        {
            return Mapper.Map<List<UserDTO>>(users);
        }

        public List<Task> TaskDTOListToTaskList(List<TaskDTO> tasksDTO)
        {
            return Mapper.Map<List<Task>>(tasksDTO);
        }

        public List<TaskDTO> TaskListToTaskDTOList(List<Task> tasks)
        {
            return Mapper.Map<List<TaskDTO>>(tasks);
        }
    }
}
