using PJBookRental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PJBookRental.ViewModel
{
    public class ThumbnailBoxViewModel
    {
        public IEnumerable<ThumbnailModel> Thumbnails { get; set; }
    }
}