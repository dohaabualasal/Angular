using KeepAPets.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace KeepAPets.Core.Repository
{
   public  interface IReviewRepository
    {
        int Create(Review Data);
        List<Review> GetAll();
        int Update(Review Data);
        //int Delete(int id);
        // List<Review> Search(ReviewDTO ReviewDTO);
        //Task<List<Review>> GetAllReview();
    }
}
