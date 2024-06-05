using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lesson06___Entity_framework.Models
{
    public class PchCategory
    {
        [Key]
        public int PchId { get; set; }
        public string PchCategoryName { get; set;}
        public virtual ICollection<PchBook> PchBooks { get; set; }
    }
}