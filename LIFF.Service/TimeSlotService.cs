using LIFF.Data.Infrastructure;
using LIFF.Data.Repositories;
using LIFF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIFF.Service
{
    public interface ITimeSlotService
    {
        IEnumerable<TimeSlot> GetTimeSlots();
        IEnumerable<TimeSlot> GetTimeSlotsByDirector(int directorId);
        IEnumerable<TimeSlot> GetTimeSlotsByCountry(int countryId);
        TimeSlot GetTimeSlot(int id);
        void CreateTimeSlot(TimeSlot timeSlot);
        void SaveTimeSlot();
    }

    public class TimeSlotService : ITimeSlotService
    {
        private readonly ITimeSlotRepository timeSlotRepository;
        private readonly IUnitOfWork unitOfWork;

        public TimeSlotService(ITimeSlotRepository timeSlotRepository, IUnitOfWork unitOfWork)
        {
            this.timeSlotRepository = timeSlotRepository;
            this.unitOfWork = unitOfWork;
        }

        #region ITimeSlotService Members
        public void CreateTimeSlot(TimeSlot timeSlot)
        {
            timeSlotRepository.Add(timeSlot);
        }

        public IEnumerable<TimeSlot> GetTimeSlots()
        {
            var timeSlots = timeSlotRepository.GetAll();
            return timeSlots;
        }

        public TimeSlot GetTimeSlot(int id)
        {
            var timeSlot = timeSlotRepository.GetById(id);
            return timeSlot;
        }

        public IEnumerable<TimeSlot> GetTimeSlotsByDirector(int directorId)
        {
            var timeSlots = timeSlotRepository.GetTimeSlotsByDirector(directorId);
            return timeSlots;
        }

        public IEnumerable<TimeSlot> GetTimeSlotsByCountry(int countryId)
        {
            var timeSlots = timeSlotRepository.GetTimeSlotsByCountry(countryId);
            return timeSlots;
        }

        public void SaveTimeSlot()
        {
            unitOfWork.Commit();
        }
        #endregion
    }
}
