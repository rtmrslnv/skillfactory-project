﻿using AwesomeNetwork.Models.Users;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System;

namespace AwesomeNetwork.Data.Repository
{
    public class FriendsRepository : Repository<Friend>
    {
        public FriendsRepository(ApplicationDbContext db)
      : base(db)
        {}
        

        public void AddFriend (User target, User Friend)
        {
            var friends = Set.AsEnumerable().FirstOrDefault(x => x.CurrentFriendId == Friend.Id && x.UserId == target.Id);
            if (friends == null)
            {

                var item = new Friend()
                {
                    UserId = target.Id,
                    User = target,
                    CurrentFriend = Friend,
                    CurrentFriendId = Friend.Id,
                };
                Create(item);
            }
        }

        public List<User> GetFriendsByUser(User target)
        {
            var friends = Set.Include(x => x.CurrentFriend).AsEnumerable().Where(x => x.User.Id == target.Id).Select(x => x.CurrentFriend);
            return friends.ToList();
        }


        public void DeleteFriend(User target, User Friend)
        {
            var friends = Set.AsEnumerable().FirstOrDefault(x => x.CurrentFriendId == Friend.Id && x.UserId == target.Id);

            if (friends != null)
            {

		Delete(friends);
            }
        }

    }
}
