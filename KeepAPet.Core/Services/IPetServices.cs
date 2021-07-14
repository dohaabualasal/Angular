using KeepAPets.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace KeepAPets.Core.Services
{
   public  interface IPetServices
    {
        Pets Create(Pets Pets);
        List<Pets> GetAll();
        Pets Update(Pets Pets);
          BookPet Book( BookPet BookPet);
        //Pets Delete(int id);
        //List<Pets> Search(PetsDTO PetsDTO);
        //Task<List<Pets>> GetAllPets();
    }
}
