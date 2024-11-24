using AwesomeNetwork.Models.Users;
using System.Collections.Generic;
using System.Threading.Tasks;
using AwesomeNetwork.ViewModels.Account;
using System.Linq;
using System;

namespace AwesomeNetwork.Extentions
{
    public static class UserFromModel
    {
        public static User Convert(this User user, UserEditViewModel usereditvm)
        {
            user.Image = usereditvm.Image;
            user.LastName = usereditvm.LastName;
            user.MiddleName = usereditvm.MiddleName;
            user.FirstName = usereditvm.FirstName;
            user.Status = usereditvm.Status;
            user.About = usereditvm.About;
            user.BirthDate = usereditvm.BirthDate;
            user.UserName = usereditvm.UserName;
            user.Email = usereditvm.Email;
            return user;
        }
    }
}
