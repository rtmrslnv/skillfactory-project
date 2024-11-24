using AwesomeNetwork.Models.Users;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System;

namespace AwesomeNetwork.ViewModels.Account
{
    public class UserViewModel
    {
        public User User { get; set; }
        public List<User> Friends { get; set; }
        public UserViewModel(User user)
        {
            User = user;
        }
    }
}
