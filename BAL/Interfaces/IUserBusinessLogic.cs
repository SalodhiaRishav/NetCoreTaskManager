using System;
using System.Collections.Generic;
using System.Text;
using Shared.DTO;

namespace BAL.Interfaces
{
   public interface IUserBusinessLogic 
    {
        void Add(UserDTO userDTO);

        UserDTO GetById(int id);

        List<UserDTO> GetAll();

        void Delete(int id);

        void Update(UserDTO userDTO);
    }
}
