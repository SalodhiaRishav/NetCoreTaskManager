using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using DAL.Database;
using Shared.DTO;
using DAL.Interfaces;
using DAL.Domain;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository
{
    public class UserRepository:IUserRepository
    {
        public DatabaseContext DatabaseContext { get; set; }
        public IDatabaseAutomapperConfiguration DatabaseAutomapperConfiguration { get; set; }

        public UserRepository(DatabaseContext databaseContext,IDatabaseAutomapperConfiguration databaseAutomapperConfiguration)
        {
            DatabaseContext = databaseContext;
             DatabaseAutomapperConfiguration = databaseAutomapperConfiguration;
        }

        public void Add(UserDTO userDTO)
        {
            User user = DatabaseAutomapperConfiguration.UserDTOToUser(userDTO);
            user.CreatedOn = DateTime.Now;
            user.ModifiedOn = DateTime.Now;

            DatabaseContext.Users.Add(user);
            DatabaseContext.SaveChanges();
            return;

        }

        public void Delete(int id)
        {

            User user = this.DatabaseContext.Users.Find(id);
            if(user==null)
            {
                return;
            }
            DatabaseContext.Users.Remove(user);
            DatabaseContext.SaveChanges();
            return;
        }

        public List<UserDTO> GetAll()
        {
            List<User> userList= this.DatabaseContext.Users.ToList();
            return this.DatabaseAutomapperConfiguration.UserListToUserDTOList(userList);
        }

        public UserDTO GetById(int id)
        {
            Domain.User user = this.DatabaseContext.Users
                .Include(u=>u.Tasks)
                .Where(uu=>uu.ID==id).ToList().First();

            if (user==null)
            {
                return null;
            }
            UserDTO userDTO = DatabaseAutomapperConfiguration.UserToUserDTO(user);
            return userDTO;
        }

        public void Update(UserDTO userDTO)
        {
            User tempUser = DatabaseContext.Users.Single(u => u.Email == userDTO.Email);
            userDTO.ID = tempUser.ID;
            userDTO.CreatedOn = tempUser.CreatedOn;
            userDTO.ModifiedOn = DateTime.Now;

            Domain.User user = DatabaseAutomapperConfiguration.UserDTOToUser(userDTO);
            DatabaseContext.Entry(user).State = EntityState.Detached;

             //DatabaseContext.Entry(user).State = EntityState.Modified;
             DatabaseContext.Users.Update(user);
            DatabaseContext.SaveChanges();
            return;
        }
    }
}
