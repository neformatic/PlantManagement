using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlantManagment.BusinessLogic.Mapper
{
    public class MapperConfig
    {
        public IMapper Mapper { get; set; }
        public MapperConfig()
        {
            var config = new MapperConfiguration(cfg =>
                cfg.AddProfile(new MapperProfile()));
            Mapper = config.CreateMapper();
        }
        
    }
}
