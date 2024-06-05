using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lesson06___Entity_framework.Models
{
    public class PchBook
    {
        [Key]
        public int PchId { get; set; }
        public string PchBookId { get; set; }
        public string PchTitle { get; set;}
        public string PchAuthor { get;set; }
        public int PchYear { get;set; }
        public string PchPulisher { get; set; }  
        public string PchPicture { get; set; }
        public int PchCategoryId { get; set; }
        public virtual PchCategory PchCategory { get; set; }



    }
}