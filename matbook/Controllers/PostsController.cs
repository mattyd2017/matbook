using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using matbook.Models;

namespace matbook.Controllers
{
    public class PostsController : ApiController
    {
        private MessageBoardContext _ctx;
        public PostsController()
        {
            this._ctx = new MessageBoardContext();
        }

        // GET api/
        public System.Collections.IEnumerable Get()
        {
            return this._ctx.Posts.OrderByDescending(x => x.DatePosted).ToList();
        }
    }
}
