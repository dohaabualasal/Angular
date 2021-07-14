using KeepAPets.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace KeepAPets.Core.Services
{
    public interface IReviewServices
    {
        Review Create(Review review);
        List<Review> GetAll();
        Review Update(Review review);
        //Review Delete(int id);
        //List<Review> Search(ReviewDTO ReviewDTO);
        //Task<List<Review>> GetAllReview();
    }
}
