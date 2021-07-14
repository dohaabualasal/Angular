using KeepAPets.Core.DTOs;
using KeepAPets.Core.Entity;
using KeepAPets.Core.Repository;
using KeepAPets.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace KeepAPets.Infra.Services
{
    public class LocationServices:ILocationServices
    {
        private readonly ILocationRepository LocationRepository;
        public LocationServices(ILocationRepository locationRepository)
        {
            LocationRepository = locationRepository;
        }
        public Location Create(Location Location)
        {
            LocationRepository.Create(Location);
            return Location;
        }
        public List<Location> GetAll()
        {
            return LocationRepository.GetAll();

        }
        public Location Update(Location Location)
        {
            LocationRepository.Update(Location);
            return Location;
        }
        //public Location Delete(int id)
        //{
        //    LocationRepository.Delete(id);
        //    return new Location();
        //}
        public List<Location> Search(ClinicLocationDTO locationDTO)
        {
            return LocationRepository.Search(locationDTO);
        }
        //public async Task<List<Location>> GetAllLocation()
        //{
        //    return await LocationRepository.GetAllLocation();
        //}
    }
}
