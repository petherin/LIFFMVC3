using AutoMapper;
using LIFF.Model;
using LIFF.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LIFF.Web.Mappings
{
    public class ViewModelToDomainMappingProfile : Profile
    {

        //public ViewModelToDomainMappingProfile() : base()
        //{
        //    var config = new MapperConfiguration(cfg =>
        //    {
        //        cfg.CreateMap<CountryViewModel, Country>();
        //        //cfg.CreateMap<DirectorViewModel, Director>();
        //        //cfg.CreateMap<FilmViewModel, Film>();
        //        //cfg.CreateMap<ImagePathViewModel, ImagePath>();
        //        //cfg.CreateMap<TimeSlotViewModel, TimeSlot>();
        //        //cfg.CreateMap<VenueViewModel, Venue>();
        //    });

        //    //IMapper mapper = config.CreateMapper();
        //    //var source = new CountryViewModel();
        //    //var dest = mapper.Map<CountryViewModel, Country>(source);
        //}

        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            //var config = new MapperConfiguration(cfg =>
            //{
            //    cfg.CreateMap<CountryViewModel, Country>();
            //    cfg.CreateMap<DirectorViewModel, Director>();
            //    cfg.CreateMap<FilmViewModel, Film>();
            //    cfg.CreateMap<ImagePathViewModel, ImagePath>();
            //    cfg.CreateMap<TimeSlotViewModel, TimeSlot>();
            //    cfg.CreateMap<VenueViewModel, Venue>();
            //});
            CreateMap<CountryViewModel, Country>();
            CreateMap<DirectorViewModel, Director>();
            CreateMap<FilmViewModel, Film>();
           CreateMap<ImagePathViewModel, ImagePath>();
           CreateMap<TimeSlotViewModel, TimeSlot>();
            CreateMap<VenueViewModel, Venue>();
            CreateMap<NewsItemViewModel, NewsItem>();
        }
    }
}