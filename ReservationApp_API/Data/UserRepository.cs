using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ReservationApp_API.Models;

namespace ReservationApp_API.Data
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext context;
        public UserRepository(DataContext context)
        {
            this.context = context;

        }
        public async void AddBallance(string username, int ballance)
        {
            User user = await (this.context.Users.Where(x => x.Username == username).FirstOrDefaultAsync<User>());
            if (user != null)
            {
                user.AccountBallance += ballance;
                this.context.SaveChanges();
            }

        }

        public void AssignRole(string user, string role)
        {
            throw new NotImplementedException();
        }

        public async void DeactivateUser(string username)
        {
            User user = await (this.context.Users.Where(x => x.Username == username).FirstOrDefaultAsync<User>());
            if (user != null)
            {
                user.IsEnabled = false;
                this.context.SaveChanges();
            }
        }
    }
}