using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models
{
    public partial class TagMaster
    {
        [Key]
        public int TagMasterId { get; set; }
        public int? FpostMasterId { get; set; }
        [Column("FBloggerMasterId")]
        public int? FbloggerMasterId { get; set; }

        [ForeignKey(nameof(FbloggerMasterId))]
        [InverseProperty(nameof(BloggerMaster.TagMaster))]
        public virtual BloggerMaster FbloggerMaster { get; set; }
        [ForeignKey(nameof(FpostMasterId))]
        [InverseProperty(nameof(PostMaster.TagMaster))]
        public virtual PostMaster FpostMaster { get; set; }
    }
}
