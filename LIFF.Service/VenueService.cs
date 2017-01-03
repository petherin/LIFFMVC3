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
    public interface IVenueService
    {
        IEnumerable<Venue> GetVenues();
        IEnumerable<Venue> GetVenuesByFilm(int filmId);
        Venue GetVenue(int id);
        void CreateVenue(Venue venue);
        void SaveVenue();
    }

    public class VenueService : IVenueService
    {
        private readonly IVenueRepository venueRepository;
        private readonly IUnitOfWork unitOfWork;

        public VenueService(IVenueRepository venueRepository, IUnitOfWork unitOfWork)
        {
            this.venueRepository = venueRepository;
            this.unitOfWork = unitOfWork;
        }

        #region ITimeSlotService Members
        public void CreateVenue(Venue venue)
        {
            venueRepository.Add(venue);
        }

        public IEnumerable<Venue> GetVenues()
        {
            var venues = venueRepository.GetAll();
            return venues;
        }

        public Venue GetVenue(int id)
        {
            var venue = venueRepository.GetById(id);
            return venue;
        }

        public IEnumerable<Venue> GetVenuesByFilm(int filmId)
        {
            var venues = venueRepository.GetVenuesByFilm(filmId);
            return venues;
        }

        public void SaveVenue()
        {
            unitOfWork.Commit();
        }
        #endregion
    }
}
