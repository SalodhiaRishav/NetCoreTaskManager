using System;
using System.Collections.Generic;
using System.Text;
using Shared.DTO;

namespace DAL.Interfaces
{
    public interface IUserRepository
    {
        void Add(UserDTO userDTO);


        void Delete(int id);

        List<UserDTO> GetAll();

        UserDTO GetById(int id);


        void Update(UserDTO userDTO);
    }
}
