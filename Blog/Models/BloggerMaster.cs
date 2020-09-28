using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models
{
    public partial class BloggerMaster
    {
        public BloggerMaster()
        {
            TagMaster = new HashSet<TagMaster>();
        }

        [Key]
        public int BloggerMasterId { get; set; }

        [InverseProperty("FbloggerMaster")]
        public virtual ICollection<TagMaster> TagMaster { get; set; }
    }
}
