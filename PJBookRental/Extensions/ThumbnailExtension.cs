using PJBookRental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PJBookRental.Extensions
{
    public static class ThumbnailExtension
    {
        public static IEnumerable<ThumbnailModel> GetBookThumbnail(this List<ThumbnailModel> thumbnails, ApplicationDbContext db=null, string search = null)
        {
            try
            {

            if(db==null)
            {
                db = ApplicationDbContext.Create();
            }

            thumbnails = (from b in db.Books
                          select new ThumbnailModel
                          {
                              BookId = b.Id,
                              Title = b.Title,
                              Description = b.Description,
                              ImageUrl = b.ImageUrl,
                              Link = "/BookDetail/Index/" + b.Id
                          }).ToList();
                if (search != null)
                    return thumbnails.Where(t => t.Title.ToLower().Contains(search.ToLower())).OrderBy(t => t.Title);
            }
            catch(Exception ex) { }
            return thumbnails.OrderBy(b => b.Title);
        }
    }
}