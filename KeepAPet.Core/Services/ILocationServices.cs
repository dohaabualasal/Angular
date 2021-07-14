using KeepAPets.Core.DTOs;
using KeepAPets.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace KeepAPets.Core.Services
{
   public interface ILocationServices
    {
        Location Create(Location location);
        List<Location> GetAll();
        Location Update(Location location);
        //Location Delete(int id);
        List<Location> Search(ClinicLocationDTO LocationDTO);
        //Task<List<Location>> GetAllLocation();
    }
}
