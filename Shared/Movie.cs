using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject.Shared
{
    public class Movie
    {
        [Key]
        public string movie_name{ get; set; }
        public String movie_rating { get; set; }
        public String movie_Description { get;set ; }
        
    }
}
