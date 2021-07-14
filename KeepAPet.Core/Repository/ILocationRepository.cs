using KeepAPets.Core.DTOs;
using KeepAPets.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace KeepAPets.Core.Repository
{
    public interface ILocationRepository
    {
        int Create(Location Data);
        List<Location> GetAll();
        int Update(Location Data);
        //int Delete(int id);
        List<Location> Search(ClinicLocationDTO locationDTO);
        //Task<List<Location>> GetAllCLocation();
    }
}
