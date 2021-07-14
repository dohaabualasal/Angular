using KeepAPets.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace KeepAPets.Core.Services
{
    public interface IExtraServices
    {
        Extra Create(Extra extra);
        List<Extra> GetAll();
        Extra Update(Extra extra);
        //xtra Delete(int id);
        //List<Extra> Search(ExtraDTO ExtraDTO);
        //Task<List<Extra>> GetAllExtra();
    }
}
