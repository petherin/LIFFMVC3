using AutoMapper;
using LIFF.Model;
using LIFF.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LIFF.Web.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        // public DomainToViewModelMappingProfile() : base()
        // {
        //     var config = new MapperConfiguration(cfg =>
        //     {
        //         cfg.CreateMap<Country, CountryViewModel>();
        //         //cfg.CreateMap<Director, DirectorViewModel>();
        //         //cfg.CreateMap<Film, FilmViewModel>();
        //         //cfg.CreateMap<ImagePath, ImagePathViewModel>();
        //         //cfg.CreateMap<TimeSlot, TimeSlotViewModel>();
        //         //cfg.CreateMap<Venue, VenueViewModel>();
        //     });

        //     //IMapper mapper = config.CreateMapper();
        //     //var source = new Country();
        //     //var dest = mapper.Map<Country, CountryViewModel>(source);
        //}

        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            //var config = new MapperConfiguration(cfg =>
            //{
            //    cfg.CreateMap<Country, CountryViewModel>();
            //cfg.CreateMap<Director, DirectorViewModel>();
            //cfg.CreateMap<Film, FilmViewModel>();
            //cfg.CreateMap<ImagePath, ImagePathViewModel>();
            //cfg.CreateMap<TimeSlot, TimeSlotViewModel>();
            //cfg.CreateMap<Venue, VenueViewModel>();
            //});

            CreateMap<Country, CountryViewModel>();
            CreateMap<Director, DirectorViewModel>();
            CreateMap<Film, FilmViewModel>();
            CreateMap<ImagePath, ImagePathViewModel>();
            CreateMap<TimeSlot, TimeSlotViewModel>();
            CreateMap<Venue, VenueViewModel>();
            //IMapper mapper = config.CreateMapper();
            //var source = new Country();
            //var dest = mapper.Map<Country, CountryViewModel>(source);

        }
    }
}