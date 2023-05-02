using DotNetCoreWebApiFrontEnd.Models;
using System.Collections.Generic;
namespace DotNetCoreWebApiFrontEnd.Repository
{
    public interface IUserDetails
    {
        List<UserDetails> GetAllUserDetails();
        UserDetails AddUsers(UserDetails user);
        UserDetails UpdateUsers(double id, UserDetails user);
        UserDetails DeleteUsers(double id, UserDetails user);
    }
}
