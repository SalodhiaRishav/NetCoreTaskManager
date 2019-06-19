using System;
using System.Collections.Generic;
using System.Text;
using DAL.Domain;
using Shared.DTO;

namespace DAL.Interfaces
{
    public interface IDatabaseAutomapperConfiguration
    {

        UserDTO UserToUserDTO(User user);


        User UserDTOToUser(UserDTO userDTO);


        TaskDTO TaskToTaskDTO(Task task);


        Task TaskDTOToTask(TaskDTO taskDTO);

        List<User> UserDTOListToUserList(List<UserDTO> usersDTO);

        List<UserDTO> UserListToUserDTOList(List<User> users);

        List<Task> TaskDTOListToTaskList(List<TaskDTO> tasksDTO);

        List<TaskDTO> TaskListToTaskDTOList(List<Task> tasks);





    }
}
