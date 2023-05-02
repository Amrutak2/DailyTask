using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using DotNetCoreWebApiFrontEnd.Data;
using DotNetCoreWebApiFrontEnd.Models;

namespace DotNetCoreWebApiFrontEnd.Repository
{
    public class UserDetailsRepository: IUserDetails
    {
        
        private UserManagementDbContext _userManagementDb;
        public UserDetailsRepository(UserManagementDbContext userManagementDb)
        {
            _userManagementDb = userManagementDb;
            
        }
        #region GetAllUserDetails
        public List<UserDetails> GetAllUserDetails()
        {
            try {
                List<UserDetails> user = _userManagementDb.UserDetails.ToList();
                return user;
                }
            catch(Exception)
            {
                throw;
            }
        }
        #endregion
        public UserDetails AddUsers(UserDetails user)
        {
            _userManagementDb.Add(user);
            _userManagementDb.SaveChanges();
            return (user);
        }
        public UserDetails DeleteUsers(double id, UserDetails user)
        {
            _userManagementDb.Remove(user);
            _userManagementDb.SaveChanges();
            return (user);
        }
        public UserDetails UpdateUsers(double id, UserDetails user)
        {
            _userManagementDb.Update(user);
            _userManagementDb.SaveChanges();
            return (user);
        }

    }
}
