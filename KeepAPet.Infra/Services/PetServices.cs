using KeepAPets.Core.Entity;
using KeepAPets.Core.Repository;
using KeepAPets.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace KeepAPets.Infra.Services
{
    public class PetServices:IPetServices
    {
         private readonly IPetRepository PetsRepository;
        public PetServices(IPetRepository petsRepository)
        {
           PetsRepository = petsRepository;
        }
        public Pets Create(Pets Pets)
        {
            PetsRepository.Create(Pets);
            return Pets;
        }
        public List<Pets> GetAll()
        {
            return PetsRepository.GetAll();

        }
        public Pets Update(Pets Pets)
        {
            PetsRepository.Update(Pets);
            return Pets;
        }
       public BookPet Book( BookPet BookPet)
         {
             
            PetsRepository.Book(BookPet);
            return BookPet;
         }
        //public Pets Delete(int id)
        //{
        //    PetsRepository.Delete(id);
        //    return new Pets();
        //}
        //public List<Pets> Search(PetsDTO PetsDTO)
        //{
        //    return PetsRepository.Search(PetsDTO);
        //}
        //public async Task<List<Pets>> GetAllPets()
        //{
        //    return await PetsRepository.GetAllPets();
        //}
    }
}
