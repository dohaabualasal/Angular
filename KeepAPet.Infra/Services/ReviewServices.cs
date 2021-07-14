using KeepAPets.Core.Entity;
using KeepAPets.Core.Repository;
using KeepAPets.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace KeepAPets.Infra.Services
{
    public class ReviewServices:IReviewServices
    {
        private readonly IReviewRepository ReviewRepository;
        public ReviewServices(IReviewRepository reviewRepository)
        {
            ReviewRepository = reviewRepository;
        }
        public Review Create(Review Review)
        {
            ReviewRepository.Create(Review);
            return Review;
        }
        public List<Review> GetAll()
        {
            return ReviewRepository.GetAll();

        }
        public Review Update(Review Review)
        {
            ReviewRepository.Update(Review);
            return Review;
        }
        //public Review Delete(int id)
        //{
        //    ReviewRepository.Delete(id);
        //    return new Review();
        //}
        //public List<Review> Search(ReviewDTO ReviewDTO)
        //{
        //    return ReviewRepository.Search(ReviewDTO);
        //}
        //public async Task<List<Review>> GetAllReview()
        //{
        //    return await ReviewRepository.GetAllReview();
        //}
    }
}
