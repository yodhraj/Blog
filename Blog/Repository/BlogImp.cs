using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Repository
{
    public class BlogImp : IBlog
    {


        IntelloreDBContext context = new IntelloreDBContext();

        public PostMaster GetPost(int postMasterId)
        {
            PostMaster pm= context.PostMaster.Find(postMasterId);
            return pm;
        }
        public TagMaster Delete(int TagMasterId)
        {
            TagMaster tm = context.TagMaster.Find(TagMasterId);
            if (tm != null)
            {

                context.TagMaster.Remove(tm);
                context.SaveChanges();
            }
            return tm;

        }
    }
}
