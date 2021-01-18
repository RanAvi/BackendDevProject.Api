using AutoMapper;
using BackendDevProject.Domain;
using BackendDevProject.Respository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BackendDevProject.Api
{
    //[ApiController]
    public class PostsController : ControllerBase
    {

        private ILogger<PostsController> _logger;
        private readonly IUnitOfWork _db;
        private readonly IMapper _mapper;

        public PostsController(ILogger<PostsController> logger, IUnitOfWork db, IMapper mapper)
        {
            _logger = logger;
            _db = db;
            _mapper = mapper;
        }


        [HttpGet(), FormatFilter, Route(ApiRouts.Posts.GetAll)]
        public async Task<IEnumerable<PostViewModel>> GetAll()
        {
            var posts = await _db._postRepository.GetAll();

            var postViewModel = _mapper.Map<IEnumerable<PostViewModel>>(posts);

            return postViewModel;

        }


        [HttpPost(), Route(ApiRouts.Posts.Create)]
        public async Task<bool> Create([FromBody]PostViewModel postView)
        {
            var post = _mapper.Map<Post>(postView);

            var posts = await _db._postRepository.Create(post);

            return posts;

        }


        [HttpGet, Route(ApiRouts.Posts.Get)]
        public async Task<PostViewModel> Get(int id)
        {
            var posts = await _db._postRepository.Get(id);

            var postViewModel = _mapper.Map<PostViewModel>(posts);

            return postViewModel;

        }




        [HttpDelete, Route(ApiRouts.Posts.Delete)]
        public async Task<bool> Delete(int id)
        {
            var posts = await _db._postRepository.Delete(id);

            return posts;

        }






    }
}
