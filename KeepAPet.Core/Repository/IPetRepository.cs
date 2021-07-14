using KeepAPets.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace KeepAPets.Core.Repository
{
    public interface IPetRepository
    {
        int Create(Pets Data);
        List<Pets> GetAll();
        int Book( BookPet BookPet);

        int Update(Pets Data);
        //int Delete(int id);
        // List<Pets> Search(PetsDTO PetsDTO);
        //Task<List<Pets>> GetAllPets();
    }
}
