using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ReservationApp_API.Models;

namespace ReservationApp_API.Data
{
    public interface IReservationRepository
    {
        void CreateNewReservation(string user, string lesson, DateTime date);
        void CancelExistingReservation(string user, string lesson, DateTime date);
        Task<bool> CheckReservationStatus(string user, string lesson, DateTime date);
        Task<bool> CheckReservationStatus(int ReservationId);
        Task<IEnumerable<Reservation>> GetUserReservations();
    }
}