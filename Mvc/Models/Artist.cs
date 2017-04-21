using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Mvc.Models
{
    public class Artist
    {
        public int ArtistID { get; set; }

        public string Name { get; set; }

        public virtual List<Album> Albums { get; set; }
    }
}