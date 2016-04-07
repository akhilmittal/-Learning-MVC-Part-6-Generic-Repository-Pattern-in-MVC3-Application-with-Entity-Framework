using System;
using System.Collections.Generic;

namespace LearningMVC.Repository
{
    public interface IUserRepository:IDisposable
    {
        IEnumerable<User> GetUsers();
        User GetUserByID(int userId);
        void InsertUser(User user);
        void DeleteUser(int userId);
        void UpdateUser(User user);
        void Save();
    }
}
