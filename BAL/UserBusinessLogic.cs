using System;
using System.Collections.Generic;
using System.Text;
using DAL.Interfaces;
using Shared.DTO;
using BAL.Interfaces;

namespace BAL
{
   public class UserBusinessLogic : IUserBusinessLogic
    {
        IUserRepository UserRepository;
        public UserBusinessLogic(IUserRepository userRepository)
        {
            UserRepository = userRepository;
        }

        public void Add(UserDTO userDTO)
        {
            this.UserRepository.Add(userDTO);
            return;
        }

        public List<UserDTO> GetAll()
        {
           return this.UserRepository.GetAll();
        }

        public UserDTO GetById(int id)
        {
            return this.UserRepository.GetById(id);
        }

        public void Delete(int id)
        {
            this.UserRepository.Delete(id);
        }

        public void Update(UserDTO userDTO)
        {

            this.UserRepository.Update(userDTO);
        }
    }
}
