using KeepAPets.Core.Entity;
using KeepAPets.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KeepAPets.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : Controller
    {
        private readonly IReviewServices ReviewServices;
        public ReviewController(IReviewServices reviewServices)
        {
            ReviewServices = reviewServices;
        }

        [HttpPost]
        [ProducesResponseType(typeof(Review), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Review), StatusCodes.Status400BadRequest)]
        public Review Create([FromBody] Review review)
        {
            return ReviewServices.Create(review);
        }
        [HttpGet]
        [ProducesResponseType(typeof(List<Review>), StatusCodes.Status200OK)]
        public List<Review> GetAll()
        {
            return ReviewServices.GetAll();
        }
        [HttpPut]
        [ProducesResponseType(typeof(Review), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Review), StatusCodes.Status400BadRequest)]
        public Review Update([FromBody] Review review)
        {
            return ReviewServices.Update(review);
        }
        //[AllowAnonymous]
        //[HttpDelete("{id}")]
        //public Reviews Delete(int id)
        //{
        //    return ReviewServices.Delete(id);
        //}
        //[HttpPost]
        //[Authorize("Teacher")]
        //[Route("ReviewSearch")]
        //[ProducesResponseType(typeof(List<Review>), StatusCodes.Status200OK)]
        //[ProducesResponseType(typeof(List<Review>), StatusCodes.Status400BadRequest)]
        //public List<Review> Search([FromBody] ReviewDTO ReviewDTO)
        //{
        //    return ReviewServices.Search(ReviewDTO);
        //}
        //[HttpGet]
        //[Route("GetAllReview")]
        //[ProducesResponseType(typeof(List<Review>), StatusCodes.Status200OK)]
        //public async Task<List<Review>> GetAllReview()
        //{
        //    return await ReviewServices.GetAllReview();
        //}
    }
}
