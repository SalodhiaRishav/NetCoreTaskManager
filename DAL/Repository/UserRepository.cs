using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using DAL.Database;
using Shared.DTO;
using DAL.Interfaces;
using DAL.Domain;

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
            Domain.User user = DatabaseAutomapperConfiguration.UserDTOToUser(userDTO);
            user.CreatedOn = DateTime.Now;
            user.ModifiedOn = DateTime.Now;

            DatabaseContext.Users.Add(user);
            DatabaseContext.SaveChanges();
            return;

        }

        public void delete(int id)
        {

            Domain.User user = this.DatabaseContext.Users.Find(id);
            
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
            Domain.User user = this.DatabaseContext.Users.Find(id);
            //Domain.User User =  this.DatabaseContext.Users
            //.Include(t => t.User)
            //.AsNoTracking()
            //.FirstOrDefault(m => m.ID == id);
            UserDTO userDTO = DatabaseAutomapperConfiguration.UserToUserDTO(user);
            return userDTO;
        }

        public async void Update(UserDTO userDTO)
        {
            Domain.User user = DatabaseAutomapperConfiguration.UserDTOToUser(userDTO);
            DatabaseContext.Users.Update(user);
            await DatabaseContext.SaveChangesAsync();
            return;
        }
    }
}
