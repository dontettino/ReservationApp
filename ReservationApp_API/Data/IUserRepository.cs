using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ReservationApp_API.Models;

namespace ReservationApp_API.Data
{
    public interface IUserRepository
    {
        void DeactivateUser(string user);
        void AssignRole(string user, string role);
        void AddBallance(string user, int ballance);
    }
}