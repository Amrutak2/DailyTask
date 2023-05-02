using DotNetCoreWebApiFrontEnd.Models;
using DotNetCoreWebApiFrontEnd.Repository;
using System;
using System.Collections.Generic;

namespace DotNetCoreWebApiFrontEnd.Services
{
    public class UserDetailsService
    {
        private IUserDetails _userDetailsRepository;
        public UserDetailsService(IUserDetails userDetailsRepository)
        {
            _userDetailsRepository = userDetailsRepository;

        }
        public List<UserDetails> GetAllUserDetails()
        {
            return _userDetailsRepository.GetAllUserDetails();
        }
        public UserDetails AddUsers(UserDetails user)
        {
            return _userDetailsRepository.AddUsers(user);
        }
        public UserDetails UpdateUsers(double id, UserDetails user)
        {
            return _userDetailsRepository.UpdateUsers(id, user);
        }
        public UserDetails DeleteUsers(double id, UserDetails user)
        {
            return _userDetailsRepository.DeleteUsers(id, user);
        }


    }
}
