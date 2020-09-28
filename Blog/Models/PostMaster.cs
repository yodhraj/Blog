using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models
{
    [Table("postMaster")]
    public partial class PostMaster
    {
        public PostMaster()
        {
            TagMaster = new HashSet<TagMaster>();
        }

        [Key]
        [Column("postMasterId")]
        public int PostMasterId { get; set; }
        [Column("post")]
        [StringLength(50)]
        public string Post { get; set; }

        [InverseProperty("FpostMaster")]
        public virtual ICollection<TagMaster> TagMaster { get; set; }
    }
}
