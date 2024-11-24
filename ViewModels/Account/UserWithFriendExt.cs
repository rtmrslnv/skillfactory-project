using AwesomeNetwork.Models.Users;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace AwesomeNetwork.ViewModels.Account
{
    public class UserWithFriendExt: User
    {
        public bool IsFriendWithCurrent { get; set; }

    }
}
