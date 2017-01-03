using LIFF.Data.Infrastructure;
using LIFF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIFF.Data.Repositories
{
    public class TimeSlotRepository : RepositoryBase<TimeSlot>, ITimeSlotRepository
    {
        public TimeSlotRepository(IDbFactory dbFactory) : base(dbFactory) { }

        public IEnumerable<TimeSlot> GetTimeSlotsByDirector(int directorId)
        {
            var director = this.DbContext.Directors.Where(d => d.DirectorId == directorId).FirstOrDefault();
            var timeSlot = this.DbContext.Slots.Where(s => s.Film.Director.Contains(director)).ToList();

            return timeSlot;
        }

        public IEnumerable<TimeSlot> GetTimeSlotsByCountry(int countryId)
        {
            var country = this.DbContext.Countries.Where(c => c.CountryId == countryId).FirstOrDefault();
            var timeSlot = this.DbContext.Slots.Where(s => s.Film.Country.Contains(country)).ToList();

            return timeSlot;
        }
    }

    public interface ITimeSlotRepository : IRepository<TimeSlot>
    {
        IEnumerable<TimeSlot> GetTimeSlotsByDirector(int directorId);
        IEnumerable<TimeSlot> GetTimeSlotsByCountry(int countryId);
    }
}