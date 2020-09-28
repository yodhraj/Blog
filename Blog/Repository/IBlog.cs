﻿using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Repository
{
    public interface IBlog
    {
      
        PostMaster GetPost(int postMasterId);
        TagMaster Delete(int TagMasterId);
    }
}
