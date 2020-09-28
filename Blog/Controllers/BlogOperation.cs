using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Blog.DTO;
using Blog.Models;
using Blog.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Blog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogOperation : ControllerBase
    {
        private readonly IBlog blog;
        private readonly IMapper mapper;

        public BlogOperation(IBlog blog, IMapper mapper ) {
            this.blog = blog;
            this.mapper = mapper;
        }

        [HttpGet]
        [Route("Getwelcome")]
        public string Getwelcome(int postMasterId)
        {
            return "Greetings Intellore Systems";
        }

        [HttpGet]
        [Route("getpost")]
        public PostMasterDTO Get(int postMasterId)
        {
            return mapper.Map<PostMasterDTO>(blog.GetPost(postMasterId));
        }

        
        [HttpDelete]
        [Route("deletetag")]
        public TagMaster Delete(int TagMasterId)
        {
            return blog.Delete(TagMasterId);

        }
    }
}
